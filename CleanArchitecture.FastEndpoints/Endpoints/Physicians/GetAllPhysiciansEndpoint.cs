using CleanArchitecture.Application.Physicians;
using CleanArchitecture.FastEndpoints.Endpoints.Physician.Dtos;
using FastEndpoints;

namespace CleanArchitecture.FastEndpoints.Endpoints.Physicians;

public class GetAllPhysiciansEndpoint : EndpointWithoutRequest<GetAllPhysiciansResponse>
{
    protected IPhysicianService PhysicianService { get; set; } = null!;
    
    public override void Configure()
    {
        Get("/api/physicians");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        var physicians = await PhysicianService.GetAllPhysiciansAsync();
        
        Response = new GetAllPhysiciansResponse
        {
            Physicians = physicians
        };
    }
}