using CleanArchitecture.Domain.Common;
using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Domain.PhysicianAggregate;

public interface IPhysicianRepository: IRepository<Physician>
{
    Task<Physician> Test(Physician entity);
}