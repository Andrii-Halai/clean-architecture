using CleanArchitecture.Application.Abstractions;
using CleanArchitecture.Application.Physicians;
using CleanArchitecture.Application.PortalUsers;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.HS;
using CleanArchitecture.HS.Repositories;
using CleanArchitecture.WebAPI.Middleware;
using CleanArchitecture.Infrastructure.CryptographyManager;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IPhysicianService, PhysicianService>();
builder.Services.AddScoped<HsContext, HsContext>();
builder.Services.AddScoped<IPhysicianRepository, HSPhysicianRepository>();
builder.Services.AddScoped<ICryptographyManager, CryptographyManager>();
builder.Services.AddScoped<IPortalUserRepository, PortalUserRepository>();
builder.Services.AddScoped<IPortalUserService, PortalUserService>();
builder.Services.AddScoped<IEDSae, EDSae>();

var app = builder.Build();

app.UseMiddleware<ExceptionHandlingMiddleware>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
