namespace CleanArchitecture.Domain.Common;

public interface IRepository<T>
{
    Task SaveChangesAsync();
    Task<T?> GetByIdAsync(int id);
    Task<T> CreateAsync(T entity);
    Task<List<T>> GetAllAsync();
}