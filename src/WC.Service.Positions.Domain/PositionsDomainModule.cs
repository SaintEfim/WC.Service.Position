using Autofac;
using FluentValidation;
using WC.Library.Domain.Services;
using WC.Service.Positions.Data.PostgreSql;

namespace WC.Service.Positions.Domain;

public class PositionsDomainModule : Module
{
    protected override void Load(
        ContainerBuilder builder)
    {
        builder.RegisterModule<PositionsDataPostgreSqlModule>();

        builder.RegisterAssemblyTypes(ThisAssembly)
            .AsClosedTypesOf(typeof(IDataProvider<>))
            .AsImplementedInterfaces();

        builder.RegisterAssemblyTypes(ThisAssembly)
            .AsClosedTypesOf(typeof(IDataManager<>))
            .AsImplementedInterfaces();

        builder.RegisterAssemblyTypes(ThisAssembly)
            .AsClosedTypesOf(typeof(IValidator<>))
            .AsImplementedInterfaces();
    }
}