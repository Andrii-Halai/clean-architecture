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
}

