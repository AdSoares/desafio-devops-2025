using DevOps2025.Middlewares;
using DevOps2025.Services;
using Prometheus;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddMemoryCache();
builder.Services.AddSingleton<CacheService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpMetrics(); // coleta padr�o de HTTP
app.UseMiddleware<CacheMiddleware>();
app.MapControllers();
app.MapMetrics(); // exp�e /metrics
app.UseRouting();

app.Run();