using Microsoft.Extensions.Configuration;
using WC.Library.Data.PostgreSql.Context;

namespace WC.Service.Positions.Data.PostgreSql.Context;

public sealed class PositionDnContextFactory : PostgreSqlDbContextFactoryBase<PositionDbContext>
{
    protected override string ConnectionString => "ServiceDB";

    public PositionDnContextFactory(IConfiguration configuration) : base(configuration)
    {
    }
}