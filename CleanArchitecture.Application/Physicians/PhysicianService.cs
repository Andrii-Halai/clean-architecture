using CleanArchitecture.Application.Abstractions;
using CleanArchitecture.Domain.PhysicianAggregate;
using CleanArchitecture.Domain.Models;

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
            physicianDto.Name,
            physicianDto.LastName,
            physicianDto.MI,
            physicianDto.Email,
            physicianDto.Phone,
            physicianDto.Phone2,
            physicianDto.Description,
            physicianDto.Comment,
            physicianDto.IDCenter,
            physicianDto.NotificationTemplate,
            physicianDto.NotificationCriteria,
            physicianDto.Npi
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
            physician.Mi,
            physician.Email,
            physician.Phone,
            physician.Phone2,
            physician.Description,
            physician.Comment,
            physician.Idcenter,
            physician.NotificationTemplate,
            physician.NotificationCriteria,
            physician.Npi
        );
    }
}

