using Application.Abstractions;
using Application.Physicians;
using Domain.PhysicianAggregate;

namespace Infrastructure.Data;

/// <summary>
/// Mock implementation of IDbManager for learning purposes
/// </summary>
public class MockDbManager : IDbManager
{
    private readonly List<Physician> _physicians;

    public MockDbManager()
    {
        _physicians = new List<Physician>
        {
            new Physician
            {
                Id = 1,
                Name = "John",
                LastName = "Smith",
                MI = "A",
                Email = "john.smith@example.com",
                Phone = "555-0100",
                Phone2 = "555-0101",
                Description = "Cardiologist",
                Comment = "Senior physician",
                IDCenter = 1,
                NotificationTemplate = "Standard",
                NotificationCriteria = "All alerts",
                Npi = "1234567890"
            },
            new Physician
            {
                Id = 2,
                Name = "Jane",
                LastName = "Doe",
                MI = "B",
                Email = "jane.doe@example.com",
                Phone = "555-0200",
                Phone2 = "555-0201",
                Description = "Neurologist",
                Comment = "Specialist in neurology",
                IDCenter = 2,
                NotificationTemplate = "Urgent",
                NotificationCriteria = "Critical only",
                Npi = "0987654321"
            }
        };
    }

    public Task<T?> GetByIdAsync<T>(int id) where T : class
    {
        if (typeof(T) == typeof(Physician))
        {
            var physician = _physicians.FirstOrDefault(p => p.Id == id);
            return Task.FromResult(physician as T);
        }

        return Task.FromResult<T?>(null);
    }

    public Task<PhysicianDto> CreatePhysicianAsync(CreatePhysicianDto physicianDto)
    {
        var id = _physicians.Max(p => p.Id) + 1;
        var physician = new Physician
        {
            Id = id,
            Name = physicianDto.Name,
            LastName = physicianDto.LastName,
            MI = physicianDto.MI,
            Email = physicianDto.Email,
            Phone = physicianDto.Phone,
            Phone2 = physicianDto.Phone2,
            Description = physicianDto.Description,
            Comment = physicianDto.Comment,
            IDCenter = physicianDto.IDCenter,
            NotificationTemplate = physicianDto.NotificationTemplate,
            NotificationCriteria = physicianDto.NotificationCriteria,
            Npi = physicianDto.Npi
        };
        
        _physicians.Add(physician);
        
        var physicianDtoResult = new PhysicianDto(
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
        
        return Task.FromResult(physicianDtoResult);
    }
}

