using AiDemo.WebApi.Services.Implementations;
using AiDemo.WebApi.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IWeatherForecastService, WeatherForecastService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/", () => Results.Ok(new { Message = "Hello from AiDemo Web API" }));

app.MapGet("/weatherforecast", (IWeatherForecastService weatherForecastService) =>
{
    var forecast = weatherForecastService.GetForecast();
    return Results.Ok(forecast);
});

app.Run();
