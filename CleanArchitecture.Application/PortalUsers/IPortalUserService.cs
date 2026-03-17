namespace CleanArchitecture.Application.PortalUsers;

public interface IPortalUserService
{
    public Task<bool> UpdatePasswordAsync(int userId, string newPassword);
}