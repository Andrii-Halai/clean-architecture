using Application.Physicians;
using Microsoft.AspNetCore.Mvc;

namespace Endpoints.Physicians;

/// <summary>
/// Physician API endpoints
/// </summary>
public static class PhysicianEndpoints
{
    public static void MapPhysicianEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/api/physicians")
            .WithTags("Physicians")
            .WithOpenApi();

        group.MapGet("/{id:int}", GetPhysicianById)
            .WithName("GetPhysicianById")
            .WithSummary("Get a physician by ID")
            .Produces<PhysicianDto>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound);

        group.MapPost("/CreatePhysician", CreatePhysician)
            .WithName("CreatePhysician")
            .WithTags("Physicians")
            .Produces<PhysicianDto>(StatusCodes.Status201Created);
    }

    private static async Task<IResult> GetPhysicianById(
        [FromServices] IPhysicianService physicianService,
        [FromRoute] int id)
    {
        var physician = await physicianService.GetByIdAsync(id);

        if (physician == null)
            return Results.NotFound(new { Message = $"Physician with ID {id} not found" });

        return Results.Ok(physician);
    }
    
    private static async Task<IResult> CreatePhysician(
        [FromServices] IPhysicianService physicianService,
        [FromBody] CreatePhysicianDto physicianDto)
    {
        var createdPhysician = await physicianService.CreatePhysicianAsync(physicianDto);
        return Results.Created($"/api/physicians/{createdPhysician.Id}", createdPhysician);
    }
}

