//Minimal API's don't have a Controller Folder
//Os Models (WeatherForecast, Users) estão acoplados diretamente no Program.cs 
//Em vez de um Router para cada chamada rest, temos um app.MaPGet/Post, passando o caminho
//Ideal to develop microservices


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapPost("/Testing", () => "Hello World");
app.MapGet("/Testing", () => "Hello World");

app.Run();