using CleanArchitecture.Domain.PhysicianAggregate;
using CleanArchitecture.Infrastructure.EntityFrameworkCoreSqlite.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.EntityFrameworkCoreSqlite.Repositories;

public class PhysicianRepository : IPhysicianRepository
{
    private readonly CPContext _dbContext;
    
    public PhysicianRepository(CPContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task SaveChangesAsync()
    {
        await _dbContext.SaveChangesAsync();
    }

    public async Task<Physician?> GetByIdAsync(int id)
    {
        var model = await _dbContext.Physicians.FindAsync(id);
        return model is null ? null : MapToDomain(model);
    }
    
    public async Task<Physician> CreateAsync(Physician entity)
    {
        var model = MapToModel(entity);
        await _dbContext.Physicians.AddAsync(model);
        return entity;
    }
    
    public async Task<List<Physician>> GetAllAsync()
    {
        var models = await _dbContext.Physicians.ToListAsync();
        return models.Select(MapToDomain).ToList();
    }
    
    private static Physician MapToDomain(PhysicianModel model)
    {
        return new Physician(
            model.Id,
            model.Name,
            model.LastName,
            model.MI,
            model.Email,
            model.Phone,
            model.Phone2,
            model.Description,
            model.Comment,
            model.IDCenter,
            model.NotificationTemplate,
            model.NotificationCriteria,
            model.Npi
        );
    }
    
    private static PhysicianModel MapToModel(Physician entity)
    {
        return new PhysicianModel
        {
            Id = entity.Id,
            Name = entity.Name,
            LastName = entity.LastName,
            MI = entity.MI,
            Email = entity.Email,
            Phone = entity.Phone,
            Phone2 = entity.Phone2,
            Description = entity.Description,
            Comment = entity.Comment,
            IDCenter = entity.IDCenter,
            NotificationTemplate = entity.NotificationTemplate,
            NotificationCriteria = entity.NotificationCriteria,
            Npi = entity.Npi
        };
    }
}