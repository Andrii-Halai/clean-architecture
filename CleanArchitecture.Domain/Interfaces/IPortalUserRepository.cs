using CleanArchitecture.Domain.Common;
using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Domain.Interfaces;

public interface IPortalUserRepository : IRepository<LicenseRequest>
{
    Task<LicenseRequest?> GetByIdAsync(string id);
    Task<bool> UpdatePasswordAsync(int userId, string newPassword);
}