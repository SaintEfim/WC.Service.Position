using Autofac;
using Autofac.Extensions.DependencyInjection;
using WC.Service.Positions.gRPC.Server.Services;

namespace WC.Service.Positions.gRPC.Server;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddGrpc();
        services.AddAutoMapper(typeof(AutoMapperProfile));
        services.AddAutoMapper(typeof(WC.Service.Positions.Domain.AutoMapperProfile));

        var containerBuilder = new ContainerBuilder();
        containerBuilder.Populate(services);
        containerBuilder.RegisterModule<EmployeesServerModule>();

        var container = containerBuilder.Build();
        var serviceProvider = new AutofacServiceProvider(container);

        services.AddSingleton<IServiceProvider>(serviceProvider);
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapGrpcService<GreeterPositionsService>();
            endpoints.MapGet("/",
                async context =>
                {
                    await context.Response.WriteAsync(
                        "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");
                });
        });
    }
}