using CleanArchitecture.Domain.PhysicianAggregate;
using CleanArchitecture.Infrastructure.EntityFrameworkCoreSqlite.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.EntityFrameworkCoreSqlite.Repositories;

public class PhysicianRepository : Repository<Physician>, IPhysicianRepository
{
    private readonly CPContext _dbContext;
    
    public PhysicianRepository(CPContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<Physician> Test(Physician entity)
    {
        return entity;
    }
}