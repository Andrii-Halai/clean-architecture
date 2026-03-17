using CleanArchitecture.Application.PortalUsers;
using Microsoft.AspNetCore.Mvc;
using CleanArchitecture.WebAPI.Controllers.LicenceRequests.Dtos;

namespace CleanArchitecture.WebAPI.Controllers.LicenceRequests;

[ApiController]
[Route("api/license-requests")]
public class LicenseRequestsController(IPortalUserService portalUserService) : ControllerBase
{
    private readonly IPortalUserService _portalUserService = portalUserService;

    [HttpPost("{id:int}/change-password")]
    public async Task<IActionResult> UpdatePasswordAsync(
        int id, 
        [FromBody] ChangePasswordRequest changePasswordRequest
        )
    {
        await _portalUserService.UpdatePasswordAsync(
            id, changePasswordRequest.newPassword
        );
        
        return Ok();
    }
}
