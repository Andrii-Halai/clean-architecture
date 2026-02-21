using CleanArchitecture.Application.Abstractions;
using CleanArchitecture.Domain.PhysicianAggregate;

namespace CleanArchitecture.Application.Physicians;

// Todo: Зробити приклад із FastEndpoints
// Repository pattern (generic)

/// <summary>
/// Service implementation for Physician operations
/// </summary>
public class PhysicianService : IPhysicianService
{
    private readonly IPhysicianRepository _physicianRepository;

    public PhysicianService(IPhysicianRepository physicianRepository)
    {
        _physicianRepository = physicianRepository;
    }

    public async Task<PhysicianDto?> GetByIdAsync(int id)
    {
        var physician = await _physicianRepository.GetByIdAsync(id);
        await _physicianRepository.SaveChangesAsync();
        
        return physician == null ? null : ToDto(physician);
    }
    
    public async Task<PhysicianDto> CreatePhysicianAsync(CreatePhysicianDto physicianDto)
    {
        var entity = new Physician(
            id: 0, // Will be assigned by the database
            name: physicianDto.Name,
            lastName: physicianDto.LastName,
            mi: physicianDto.MI,
            email: physicianDto.Email,
            phone: physicianDto.Phone,
            phone2: physicianDto.Phone2,
            description: physicianDto.Description,
            comment: physicianDto.Comment,
            idCenter: physicianDto.IDCenter,
            notificationTemplate: physicianDto.NotificationTemplate,
            notificationCriteria: physicianDto.NotificationCriteria,
            npi: physicianDto.Npi
        );

        var createdPhysician = await _physicianRepository.CreateAsync(entity);
        await _physicianRepository.SaveChangesAsync();

        return ToDto(createdPhysician);
    }

    public async Task<List<PhysicianDto>> GetAllPhysiciansAsync()
    {
        var physicians = await _physicianRepository.GetAllAsync();
        return physicians.Select(ToDto).ToList();
    }

    public async Task<List<PhysicianDto>> GetAllAsync()
    {
        var physicians = await _physicianRepository.GetAllAsync();
        await _physicianRepository.SaveChangesAsync();
        return physicians.Select(ToDto).ToList();
    }

    private static PhysicianDto ToDto(Physician physician)
    {
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

