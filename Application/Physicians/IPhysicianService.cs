namespace Application.Physicians;

/// <summary>
/// Service interface for Physician operations
/// </summary>
public interface IPhysicianService
{
    Task<PhysicianDto?> GetByIdAsync(int id);
}

