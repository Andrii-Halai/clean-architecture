using CleanArchitecture.Application.Physicians;
using CleanArchitecture.FastEndpoints.Endpoints.Physician.Dtos;
using FastEndpoints;

namespace CleanArchitecture.FastEndpoints.Endpoints.Physicians;

public class GetAllPhysiciansEndpoint : EndpointWithoutRequest<GetAllPhysiciansResponse>
{
    private IPhysicianService _physicianService;
    
    public GetAllPhysiciansEndpoint(IPhysicianService physicianService)
    {
        _physicianService = physicianService;
    }
    
    public override void Configure()
    {
        Get("/api/physicians");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        var physicians = await _physicianService.GetAllPhysiciansAsync();
        
        Response = new GetAllPhysiciansResponse
        {
            Physicians = physicians
        };
    }
}