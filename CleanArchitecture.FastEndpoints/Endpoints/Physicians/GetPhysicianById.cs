using CleanArchitecture.Application.Physicians;
using FastEndpoints;

namespace CleanArchitecture.FastEndpoints.Endpoints.Physicians;

public class GetPhysicianById : EndpointWithoutRequest<PhysicianDto>
{
    private readonly IPhysicianService _physicianService;

    public GetPhysicianById(IPhysicianService physicianService)
    {
        _physicianService = physicianService;
    }
    
    public override void Configure()
    {
        Get("/api/physicians/{id:int}");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        var id = Route<int>("id");
        
        var physician = await _physicianService.GetByIdAsync(id);
        
        if (physician is null)
        {
            await Send.NotFoundAsync(ct);
            return;
        }
        
        Response = physician;
    }
}