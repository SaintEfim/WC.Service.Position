using Microsoft.Extensions.Logging;
using WC.Service.Positions.Data.Repositories;
using WC.Service.Positions.Data.PostgreSql.Context;

namespace WC.Service.Positions.Data.PostgreSql.Repositories;

public class PositionRepository : PositionRepository<PositionDbContext>
{
    public PositionRepository(PositionDbContext context, ILogger<PositionRepository> logger) :
        base(
            context, logger)
    {
    }
}