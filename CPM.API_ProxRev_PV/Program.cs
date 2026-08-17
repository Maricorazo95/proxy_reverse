var builder = WebApplication.CreateBuilder(args);

// Registrar YARP
builder.Services
    .AddReverseProxy()
    .LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"));

var app = builder.Build();

// Mapear proxy
app.MapReverseProxy();

app.Run();
