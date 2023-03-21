using EulynxLive.Messages;
using Google.Protobuf;
using Grpc.Core;
using Grpc.Net.Client;
using Sci;
using static Sci.Rasta;

namespace EulynxBridge.Services;

public class RastaService : RastaBase
{
    private readonly ILogger<RastaService> _logger;
    private IServerStreamWriter<SciPacket>? _requests;
    private IAsyncStreamReader<SciPacket>? _responses;

    public string LocalId = "INTERLOCKING";
    public string RemoteId = "99W1";

    public RastaService(ILogger<RastaService> logger)
    {
        _logger = logger;
    }

    public override async Task Stream(IAsyncStreamReader<SciPacket> requestStream, IServerStreamWriter<SciPacket> responseStream, ServerCallContext context)
    {
        _requests = responseStream;
        _responses = requestStream;

        var versionCheck = new PointVersionCheckCommand(LocalId, RemoteId, 0x01);
        await WriteMessage(versionCheck);

        await ReadMessage<PointVersionCheckMessage>();

        var setupRequest = new PointInitializationRequestMessage(LocalId, RemoteId);
        await WriteMessage(setupRequest);

        await ReadMessage<PointStartInitializationMessage>();
        await ReadMessage<PointPositionMessage>();
        await ReadMessage<PointInitializationCompletedMessage>();

        var tcs = new TaskCompletionSource();
        await tcs.Task;
    }

    public async Task WriteMessage(EulynxMessage message)
    {
        if (_requests != null) {
            await _requests.WriteAsync(new SciPacket
            {
                Message = ByteString.CopyFrom(message.ToByteArray()),
            });
        }
    }

    public async Task<EulynxMessage> ReadEulynxMessage()
    {
        if (!await _responses.MoveNext())
        {
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

    public async Task<T> ReadMessage<T>()
    {
        var eulynxMessage = await ReadEulynxMessage();

        if (eulynxMessage is T expectedMessage)
        {
            return expectedMessage;
        }

        throw new Exception("Unexpected message.");
    }
}
