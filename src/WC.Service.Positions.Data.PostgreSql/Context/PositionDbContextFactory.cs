using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using WC.Library.Data.PostgreSql.Context;

namespace WC.Service.Positions.Data.PostgreSql.Context;

public sealed class PositionDbContextFactory : PostgreSqlDbContextFactoryBase<PositionDbContext>
{
    protected override string ConnectionString => "ServiceDB";

    public PositionDbContextFactory(IConfiguration configuration, IHostEnvironment environment) : base(configuration,
        environment)
    {
    }
}