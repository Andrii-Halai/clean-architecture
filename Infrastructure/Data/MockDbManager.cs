using Application.Abstractions;
using Domain.PhysicianAggregate;

namespace Infrastructure.Data;

/// <summary>
/// Mock implementation of IDbManager for development/testing purposes
/// </summary>
public class MockDbManager : IDbManager
{
    private readonly List<Physician> _physicians;

    public MockDbManager()
    {
        // Initialize with sample data
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
}

