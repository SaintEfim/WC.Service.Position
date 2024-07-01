using Autofac;
using Microsoft.EntityFrameworkCore;
using WC.Library.Data.Repository;
using WC.Service.Positions.Data.PostgreSql.Context;

namespace WC.Service.Positions.Data.PostgreSql;

public class PositionsDataPostgreSqlModule : Module
{
    protected override void Load(
        ContainerBuilder builder)
    {
        builder.RegisterAssemblyTypes(ThisAssembly)
            .AsClosedTypesOf(typeof(IRepository<>))
            .AsImplementedInterfaces();

        builder.RegisterType<PositionDbContextFactory>()
            .AsSelf()
            .SingleInstance();

        builder.Register(c => c.Resolve<PositionDbContextFactory>().CreateDbContext())
            .As<PositionDbContext>()
            .As<DbContext>()
            .InstancePerLifetimeScope();
    }
}