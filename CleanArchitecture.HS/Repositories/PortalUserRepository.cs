using CleanArchitecture.Domain.Models;
using CleanArchitecture.Domain.Interfaces;

namespace CleanArchitecture.HS.Repositories;

public class PortalUserRepository(HsContext dbContext) : Repository<LicenseRequest>(dbContext), IPortalUserRepository
{    private readonly HsContext _dbContext = dbContext;

    public async Task<bool> UpdatePasswordAsync(int userId, string newPassword)
    {
        var user = await _dbContext.LicenseRequests.FindAsync(userId);
        
        if (user == null)
        { 
            return true;
        }
        user.Password = newPassword;
            
        await _dbContext.SaveChangesAsync();

        return true;
    }
}
