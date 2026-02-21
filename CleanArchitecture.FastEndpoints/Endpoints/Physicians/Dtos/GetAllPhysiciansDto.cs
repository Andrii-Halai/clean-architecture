using CleanArchitecture.Application.Physicians;

namespace CleanArchitecture.FastEndpoints.Endpoints.Physician.Dtos;

public class GetAllPhysiciansResponse
{
    public List<PhysicianDto> Physicians { get; set; }
}