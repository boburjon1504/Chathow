using Chat.Api.Configurations;

var builder = WebApplication.CreateBuilder(args);

await builder.ConfiguraAsync();

var app = builder.Build();

await app.ConfigureAsync();

await app.RunAsync();
