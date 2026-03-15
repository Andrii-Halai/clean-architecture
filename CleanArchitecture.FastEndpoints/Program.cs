using CleanArchitecture.Application.Physicians;
using CleanArchitecture.Domain.PhysicianAggregate;
using CleanArchitecture.HS;
using CleanArchitecture.HS.Repositories;
using CleanArchitecture.Infrastructure.EntityFrameworkCoreSqlite.Repositories;
using CleanArchitecture.Infrastructure.EntityFrameworkCoreSqlite;
using FastEndpoints;
using FastEndpoints.Swagger;

var bld = WebApplication.CreateBuilder();
bld.Services
    .AddFastEndpoints()
    .SwaggerDocument();

bld.Services.AddScoped<IPhysicianService, PhysicianService>();
// bld.Services.AddScoped<IPhysicianRepository, PhysicianRepository>();
// bld.Services.AddScoped<CPContext, CPContext>();
bld.Services.AddScoped<IPhysicianRepository, HSPhysicianRepository>();
bld.Services.AddScoped<HsContext, HsContext>();

var app = bld.Build();
app.UseFastEndpoints()
    .UseSwaggerGen();
app.Run();
