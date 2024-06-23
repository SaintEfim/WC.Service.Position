using Grpc.Core;

namespace WC.Service.Positions.gRPC.Server.Services;

public class GreeterPositionsService : GreeterPositions.GreeterPositionsBase
{
    private readonly ILogger<GreeterPositionsService> _logger;

    public GreeterPositionsService(ILogger<GreeterPositionsService> logger)
    {
        _logger = logger;
    }

    public override async Task<CheckPositionResponse> CheckPositionExists(CheckPositionRequest request,
        ServerCallContext context)
    {
        return new CheckPositionResponse
        {
            IsPositionExists = true
        };
    }
}