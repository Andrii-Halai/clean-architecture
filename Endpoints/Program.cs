using Application.Abstractions;
using Application.Physicians;
using Endpoints.Physicians;
using Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IDbManager, MockDbManager>();
builder.Services.AddScoped<IPhysicianService, PhysicianService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapPhysicianEndpoints();

app.Run();
