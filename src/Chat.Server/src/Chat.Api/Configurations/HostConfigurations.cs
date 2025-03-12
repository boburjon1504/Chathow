namespace Chat.Api.Configurations;

public static partial class HostConfigurations
{
    public static ValueTask ConfiguraAsync(this WebApplicationBuilder builder)
    {
        builder
            .AddExposers()
            .AddDevTools();

        return ValueTask.CompletedTask;
    }

    public static ValueTask ConfigureAsync(this WebApplication app)
    {
        app
            .UseExposers()
            .UseDevTools();

        return ValueTask.CompletedTask;
    }
}
