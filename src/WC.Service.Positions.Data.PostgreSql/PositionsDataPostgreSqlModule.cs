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

        builder.RegisterType<PositionDnContextFactory>()
            .AsSelf()
            .SingleInstance();

        builder.Register(c => c.Resolve<PositionDnContextFactory>().CreateDbContext())
            .As<PositionDbContext>()
            .As<DbContext>()
            .InstancePerLifetimeScope();
    }
}