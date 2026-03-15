using CleanArchitecture.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.EntityFrameworkCoreSqlite.Repositories;

public class Repository<T> : IRepository<T> where T : Entity
{
    protected readonly CPContext _dbContext;
    protected readonly DbSet<T> _dbSet;
    
    public Repository(CPContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task SaveChangesAsync()
    {
        await _dbContext.SaveChangesAsync();
    }

    public async Task<T?> GetByIdAsync(int id)
    {
        var model = await _dbContext.Set<T>().FindAsync(id);
        return model;
    }
    
    public async Task<T> CreateAsync(T entity)
    {
        await _dbContext.Set<T>().AddAsync(entity);
        return entity;
    }
    
    public async Task<List<T>> GetAllAsync()
    {
        var models = await _dbContext.Set<T>().ToListAsync();
        return models;
    }
}