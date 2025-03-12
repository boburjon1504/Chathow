namespace Chat.Api.Configurations;

public static partial class HostConfigurations
{

    private static WebApplicationBuilder AddExposers(this WebApplicationBuilder builder)
    {
        builder
            .Services
            .AddRouting(r =>
            {
                r.LowercaseUrls = true;
                r.LowercaseQueryStrings = true;
            })
            .AddControllers();

        return builder;
    }
    private static WebApplicationBuilder AddDevTools(this WebApplicationBuilder builder)
    {
        builder
            .Services
            .AddEndpointsApiExplorer()
            .AddSwaggerGen();


        return builder;
    }
       
    private static WebApplication UseExposers(this WebApplication app)
    {
        app
            .MapControllers();

        app.UseCors(x =>
        {
            x.AllowAnyHeader();
            x.AllowAnyOrigin();
            x.AllowAnyMethod();
        });

        return app;
    }
    private static WebApplication UseDevTools(this WebApplication app)
    {
        app
            .UseSwagger()
            .UseSwaggerUI();

        return app;
    }
}
