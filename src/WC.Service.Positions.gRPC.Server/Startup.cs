using Autofac;
using WC.Library.Web.Startup;
using WC.Service.Positions.Domain;
using WC.Service.Positions.gRPC.Server.Services;

namespace WC.Service.Positions.gRPC.Server;

internal sealed class Startup : StartupGrpcBase
{
    public Startup(WebApplicationBuilder builder) : base(builder)
    {
    }

    public override void ConfigureContainer(ContainerBuilder containerBuilder)
    {
        base.ConfigureContainer(containerBuilder);

        containerBuilder.RegisterModule<PositionsDomainModule>();
    }

    public override void Configure(WebApplication app)
    {
        base.Configure(app);
        app.MapGrpcService<GreeterPositionsService>();
    }
}