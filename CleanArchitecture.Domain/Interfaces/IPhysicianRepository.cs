using CleanArchitecture.Domain.Common;
using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Domain.Interfaces;

public interface IPhysicianRepository: IRepository<Physician>
{
    Task<Physician> Test(Physician entity);
}
