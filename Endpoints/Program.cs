using Application.Abstractions;
using Application.Physicians;
using Endpoints.Physicians;
using Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register application services
builder.Services.AddScoped<IDbManager, MockDbManager>();
builder.Services.AddScoped<IPhysicianService, PhysicianService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Map endpoints
app.MapPhysicianEndpoints();

app.Run();
