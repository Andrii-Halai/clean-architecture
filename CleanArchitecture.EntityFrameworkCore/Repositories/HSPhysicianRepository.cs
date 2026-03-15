using CleanArchitecture.Domain.PhysicianAggregate;
using CleanArchitecture.EntityFrameworkCore.Data;
using CleanArchitecture.Infrastructure.EntityFrameworkCoreSqlite.Repositories;

namespace CleanArchitecture.EntityFrameworkCore.Repositories;

public class HSPhysicianRepository(HsContext dbContext) : BaseRepository<Physician>(dbContext), IPhysicianRepository;
