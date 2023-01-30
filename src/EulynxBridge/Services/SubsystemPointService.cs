using EulynxLive.Messages;
using Google.Protobuf;
using Grpc.Core;
using Grpc.Net.Client;
using Sci;
using static Sci.Rasta;

namespace EulynxBridge.Services;

public class SubsystemPointService : SubsystemPoint.SubsystemPointBase
{
    private readonly ILogger<SubsystemPointService> _logger;
    private readonly IClientStreamWriter<SciPacket> _requests;
    private readonly IAsyncStreamReader<SciPacket> _responses;

    public SubsystemPointService(ILogger<SubsystemPointService> logger)
    {
        _logger = logger;
        var channel = GrpcChannel.ForAddress("");
        var client = new RastaClient(channel);
        var stream = client.Stream();
        _requests = stream.RequestStream;
        _responses = stream.ResponseStream;
    }

    public override async Task<PdiVersionCheckMessage> PdiVersionCheck(PdiVersionCheckCommand request, Grpc.Core.ServerCallContext context)
    {
        var versionCheckCommand = new PointVersionCheckCommand(request.SenderId, request.ReceiverId, (byte)request.SenderPdiVersion);
        await WriteMessage(versionCheckCommand);
        var response = await ReadMessage<PointVersionCheckMessage>();
        return new PdiVersionCheckMessage {
            SenderId = response.SenderId,
            ReceiverId = response.ReceiverId,
            ResultPdiVersionCheck = MapPdiVersionCheckResult(response.ResultPdiVersionCheck),
            SenderPdiVersion = response.SenderPdiVersion
        };
    }

    private PdiVersionCheckResult MapPdiVersionCheckResult(EulynxLive.Messages.PdiVersionCheckResult resultPdiVersionCheck)
        => resultPdiVersionCheck switch {
            EulynxLive.Messages.PdiVersionCheckResult.Match => PdiVersionCheckResult.Match,
            EulynxLive.Messages.PdiVersionCheckResult.NoMatch => PdiVersionCheckResult.NoMatch,
            _ => throw new Exception("Unknown enum value received.")
    };

    public override async Task Initialization(InitializationRequestCommand request, IServerStreamWriter<InitializationMessage> responseStream, ServerCallContext context)
    {
        var initializationRequest = new PointInitializationRequestMessage(request.SenderId, request.ReceiverId);
        await WriteMessage(initializationRequest);
        while (true) {
            var message = await ReadEulynxMessage();
            switch (message) {
                case PointStartInitializationMessage: {
                    await responseStream.WriteAsync(new InitializationMessage {
                        SenderId = message.SenderId,
                        ReceiverId = message.ReceiverId,
                        Type = InitializationMessageType.StartInitialization
                    });
                    break;
                }
                case EulynxLive.Messages.PointPositionMessage pointPosition: {
                    await responseStream.WriteAsync(new InitializationMessage {
                        SenderId = message.SenderId,
                        ReceiverId = message.ReceiverId,
                        Type = InitializationMessageType.ReportStatus,
                        ReportedPointPosition = MapReportedPointPosition(pointPosition.ReportedPointPosition),
                        // ReportedDegradedPointPosition = MapDegradedPointPosition(pointPosition.ReportedDegradedPointPosition)
                    });
                    break;
                }
                case PointInitializationCompletedMessage: {
                    await responseStream.WriteAsync(new InitializationMessage {
                        SenderId = message.SenderId,
                        ReceiverId = message.ReceiverId,
                        Type = InitializationMessageType.EndInitialization
                    });
                    break;
                }
                default: throw new Exception("Unexpected message received.");
            }
        }
    }
    private ReportedPointPosition MapReportedPointPosition(EulynxLive.Messages.ReportedPointPosition reportedPointPosition)
        => reportedPointPosition switch {
                EulynxLive.Messages.ReportedPointPosition.Right => ReportedPointPosition.ReportedRight,
                EulynxLive.Messages.ReportedPointPosition.Left => ReportedPointPosition.ReportedLeft,
                EulynxLive.Messages.ReportedPointPosition.NoEndPosition => ReportedPointPosition.ReportedNoEndPosition,
                EulynxLive.Messages.ReportedPointPosition.Trailed => ReportedPointPosition.ReportedTrailed,
                _ => throw new Exception("Unknown enum value received.")
        };

    public override async Task<PointPositionMessage> MovePoint(MovePointCommand request, ServerCallContext context)
    {
        var versionCheckCommand = new PointMovePointCommand(request.SenderId, request.ReceiverId, MapCommandedPointPosition(request.CommandedPointPosition));
        await WriteMessage(versionCheckCommand);
        var response = await ReadMessage<EulynxLive.Messages.PointPositionMessage>();
        return new PointPositionMessage {
            SenderId = response.SenderId,
            ReceiverId = response.ReceiverId,
            ReportedPointPosition = MapReportedPointPosition(response.ReportedPointPosition),
            // ReportedDegradedPointPosition = MapDegradedPointPosition(response.DegradedPointPosition)
        };
    }

    private EulynxLive.Messages.CommandedPointPosition MapCommandedPointPosition(CommandedPointPosition commandedPointPosition)
        => commandedPointPosition switch {
                CommandedPointPosition.CommandedRight => EulynxLive.Messages.CommandedPointPosition.Right,
                CommandedPointPosition.CommandedLeft => EulynxLive.Messages.CommandedPointPosition.Left,
                _ => throw new Exception("Unknown enum value received.")
        };

    private async Task WriteMessage(EulynxMessage message) {
        await _requests.WriteAsync(new SciPacket {
            Message = ByteString.CopyFrom(message.ToByteArray()),
        });
    }

    private async Task<EulynxMessage> ReadEulynxMessage() {
        if (!await _responses.MoveNext()) {
            throw new Exception("No response received for command.");
        }

        EulynxMessage eulynxMessage;
        try
        {
            eulynxMessage = EulynxMessage.FromBytes(_responses.Current.Message.ToByteArray());
        }
        catch (Exception ex)
        {
            _logger.LogWarning(ex, "Couldn't parse EULYNX message");
            throw;
        }

        return eulynxMessage;
    }

    private async Task<T> ReadMessage<T>() {
        var eulynxMessage = await ReadEulynxMessage();

        if (eulynxMessage is T expectedMessage) {
            return expectedMessage;
        }

        throw new Exception("Unexpected message.");
    }
}
