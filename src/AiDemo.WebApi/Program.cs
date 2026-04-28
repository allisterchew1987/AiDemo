using AiDemo.WebApi.Services.Implementations;
using AiDemo.WebApi.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IHelloService, HelloService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/hello", (IHelloService helloService) => Results.Ok(helloService.GetHelloWorld()));

app.Run();
