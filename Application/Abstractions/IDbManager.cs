namespace Application.Abstractions;

/// <summary>
/// Database manager abstraction for data access operations
/// </summary>
public interface IDbManager
{
    Task<T?> GetByIdAsync<T>(int id) where T : class;
}

