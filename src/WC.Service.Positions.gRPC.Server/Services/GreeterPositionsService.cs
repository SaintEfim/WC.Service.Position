using Grpc.Core;
using WC.Service.Positions.Domain.Abstractions.Models;
using WC.Service.Positions.Domain.Abstractions.Services;

namespace WC.Service.Positions.gRPC.Server.Services;

public class GreeterPositionsService : GreeterPositions.GreeterPositionsBase
{
    private readonly IPositionProvider _provider;

    public GreeterPositionsService(IPositionProvider provider)
    {
        _provider = provider;
    }

    public override async Task<CheckPositionResponse> CheckPositionExists(CheckPositionRequest request,
        ServerCallContext context)
    {
        var result = await _provider.CheckPosition(new PositionModel
        {
            Name = request.Position.Name
        });

        return new CheckPositionResponse
        {
            IsPositionExists = result
        };
    }
}