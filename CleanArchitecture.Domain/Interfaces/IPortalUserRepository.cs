using CleanArchitecture.Domain.Common;
using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Domain.Interfaces;

public interface IPortalUserRepository : IRepository<LicenseRequest>
{
    Task<LicenseRequest?> GetByIdAsync(string id);
    Task<LicenseRequest?> UpdatePasswordAsync(int userId, string newPassword);
}