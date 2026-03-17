using CleanArchitecture.Application.Abstractions;
using CleanArchitecture.Domain.Common;
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
    
    public async Task UpdatePasswordAsync(int userId, string newPassword)
    {
        var passwordHash = _edSae.EStringAE(newPassword,"AEFTRPGEXX");

        var updated = await _portalUserRepository.UpdatePasswordAsync(userId, passwordHash);

        if (updated is null)
        {
            throw new NotFoundException("User not found");
        }
    }
}