using CleanArchitecture.Application.Physicians;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.HS;
using CleanArchitecture.HS.Repositories;
using FastEndpoints;
using FastEndpoints.Swagger;

var bld = WebApplication.CreateBuilder();
bld.Services
    .AddFastEndpoints()
    .SwaggerDocument();

bld.Services.AddScoped<IPhysicianService, PhysicianService>();
bld.Services.AddScoped<IPhysicianRepository, HSPhysicianRepository>();
bld.Services.AddScoped<HsContext, HsContext>();

var app = bld.Build();
app.UseFastEndpoints()
    .UseSwaggerGen();
app.Run();
