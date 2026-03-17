using CleanArchitecture.Domain.Models;
using CleanArchitecture.Domain.Interfaces;

namespace CleanArchitecture.HS.Repositories;

public class HSPhysicianRepository : Repository<Physician>, IPhysicianRepository
{
    private readonly HsContext _dbContext;
    
    public HSPhysicianRepository(HsContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<Physician> Test(Physician entity)
    {
        return entity;
    }
}