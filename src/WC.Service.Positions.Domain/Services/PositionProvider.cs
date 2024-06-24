using AutoMapper;
using Microsoft.Extensions.Logging;
using WC.Library.Domain.Services;
using WC.Service.Positions.Data.Models;
using WC.Service.Positions.Data.Repositories;
using WC.Service.Positions.Domain.Abstractions.Models;
using WC.Service.Positions.Domain.Abstractions.Services;

namespace WC.Service.Positions.Domain.Services;

public class PositionProvider : DataProviderBase<PositionProvider, IPositionRepository, PositionModel, PositionEntity>,
    IPositionProvider
{
    public PositionProvider(IMapper mapper, ILogger<PositionProvider> logger, IPositionRepository repository) : base(
        mapper, logger, repository)
    {
    }

    public async Task<bool> CheckPosition(PositionModel position, CancellationToken cancellationToken = default)
    {
        var positions = await Repository.Get(cancellationToken);
        return positions.Any(x => x.Name == position.Name);
    }
}