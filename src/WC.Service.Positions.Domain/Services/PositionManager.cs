using AutoMapper;
using FluentValidation;
using Microsoft.Extensions.Logging;
using WC.Library.Domain.Services;
using WC.Service.Positions.Data.Models;
using WC.Service.Positions.Data.Repositories;
using WC.Service.Positions.Domain.Abstractions.Models;
using WC.Service.Positions.Domain.Abstractions.Services;

namespace WC.Service.Positions.Domain.Services;

public class PositionManager : DataManagerBase<PositionManager, IPositionRepository, PositionModel, PositionEntity>,
    IPositionManager
{
    public PositionManager(IMapper mapper, ILogger<PositionManager> logger, IPositionRepository repository,
        IEnumerable<IValidator> validators) : base(mapper, logger, repository, validators)
    {
    }
}