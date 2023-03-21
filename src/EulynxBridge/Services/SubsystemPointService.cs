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
    private readonly RastaService rasta;

    public SubsystemPointService(ILogger<SubsystemPointService> logger, RastaService rasta)
    {
        _logger = logger;
        this.rasta = rasta;
        var channel = GrpcChannel.ForAddress("http://localhost:50051");
    }

    public override async Task Connect(IAsyncStreamReader<Input> requestStream, IServerStreamWriter<State> responseStream, ServerCallContext context)
    {
        await foreach (var command in requestStream.ReadAllAsync())
        {
            if (command.HasMovePoint)
            {
                var signalAspect = new PointMovePointCommand(rasta.LocalId, rasta.RemoteId, command.MovePoint switch
                {
                    MovePointPosition.Left => CommandedPointPosition.Left,
                    MovePointPosition.Right => CommandedPointPosition.Right,
                    _ => throw new ArgumentOutOfRangeException(nameof(command.MovePoint), $"Unexpected move point value: {command.MovePoint}"),
                });
                await rasta.WriteMessage(signalAspect);

                await rasta.ReadMessage<PointPositionMessage>();
            }
        }
    }
}
