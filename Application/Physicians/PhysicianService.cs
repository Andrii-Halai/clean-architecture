using Application.Abstractions;
using Domain.PhysicianAggregate;

namespace Application.Physicians;

/// <summary>
/// Service implementation for Physician operations
/// </summary>
public class PhysicianService : IPhysicianService
{
    private readonly IDbManager _dbManager;

    public PhysicianService(IDbManager dbManager)
    {
        _dbManager = dbManager;
    }

    public async Task<PhysicianDto?> GetByIdAsync(int id)
    {
        var physician = await _dbManager.GetByIdAsync<Physician>(id);
        
        if (physician == null)
            return null;

        return new PhysicianDto(
            physician.Id,
            physician.Name,
            physician.LastName,
            physician.MI,
            physician.Email,
            physician.Phone,
            physician.Phone2,
            physician.Description,
            physician.Comment,
            physician.IDCenter,
            physician.NotificationTemplate,
            physician.NotificationCriteria,
            physician.Npi
        );
    }
    
    public async Task<PhysicianDto> CreatePhysicianAsync(CreatePhysicianDto physicianDto)
    {
        var createdPhysician = await _dbManager.CreatePhysicianAsync(physicianDto);
        
        return new PhysicianDto(
            createdPhysician.Id,
            createdPhysician.Name,
            createdPhysician.LastName,
            createdPhysician.MI,
            createdPhysician.Email,
            createdPhysician.Phone,
            createdPhysician.Phone2,
            createdPhysician.Description,
            createdPhysician.Comment,
            createdPhysician.IDCenter,
            createdPhysician.NotificationTemplate,
            createdPhysician.NotificationCriteria,
            createdPhysician.Npi
        );
    }
}

