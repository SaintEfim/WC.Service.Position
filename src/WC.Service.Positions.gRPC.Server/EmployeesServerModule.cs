using Autofac;
using WC.Service.Positions.Domain;

namespace WC.Service.Positions.gRPC.Server;

public class EmployeesServerModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterModule<PositionsDomainModule>();
    }
}