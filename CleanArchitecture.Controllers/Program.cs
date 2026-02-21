using CleanArchitecture.Application.Abstractions;
using CleanArchitecture.Application.Physicians;
using CleanArchitecture.Domain.PhysicianAggregate;
using CleanArchitecture.Infrastructure.Data;
using CleanArchitecture.Infrastructure.EntityFrameworkCoreSqlite;
using CleanArchitecture.Infrastructure.EntityFrameworkCoreSqlite.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IDbManager, MockDbManager>(); // for testing purposes, change to AddScoped
builder.Services.AddScoped<IPhysicianService, PhysicianService>();
builder.Services.AddScoped<IPhysicianRepository, PhysicianRepository>();
builder.Services.AddScoped<CPContext, CPContext>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
