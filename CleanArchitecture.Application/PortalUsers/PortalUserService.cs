using CleanArchitecture.Application.Abstractions;
using CleanArchitecture.Domain.Interfaces;

namespace CleanArchitecture.Application.PortalUsers;

public class PortalUserService : IPortalUserService
{
    private IPortalUserRepository _portalUserRepository;
    private ICryptographyManager _cryptographyManager;
    private IEDSae _edSae;
    
    public PortalUserService(
        IPortalUserRepository portalUserRepository, 
        ICryptographyManager cryptographyManager,
        IEDSae edsae
        )
    {
        _portalUserRepository = portalUserRepository;
        _cryptographyManager = cryptographyManager;
        _edSae = edsae;
    }
    
    public async Task<bool> UpdatePasswordAsync(int userId, string newPassword)
    {
        var portalUser = await _portalUserRepository.GetByIdAsync(userId);
        
        if (portalUser == null)
        {
            return false;
        }
        
        var passwordHash = _edSae.EStringAE(newPassword,"AEFTRPGEXX");
        
        var isOk = await _portalUserRepository.UpdatePasswordAsync(portalUser.Id, passwordHash);
        
        return isOk;
    }
}