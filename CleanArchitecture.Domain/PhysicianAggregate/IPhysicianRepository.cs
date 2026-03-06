using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Domain.PhysicianAggregate;

public interface IPhysicianRepository: IRepository<Physician>
{
    Task<Physician> Test(Physician entity);
}