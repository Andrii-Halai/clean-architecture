namespace CleanArchitecture.Application.PortalUsers;

public interface IPortalUserService
{
    public Task UpdatePasswordAsync(int userId, string newPassword);
}