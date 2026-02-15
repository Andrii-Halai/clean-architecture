using Domain.PhysicianAggregate;

namespace Application.Abstractions;

/// <summary>
/// Database manager abstraction for data access operations
/// </summary>
public interface IDbManager
{
    Task<T?> GetByIdAsync<T>(int id) where T : class;
    Task<T> CreateAsync<T>(T entity) where T : class;
    Task<List<Physician>> GetAllPhysiciansAsync();
}
