namespace CleanArchitecture.Application.PortalUsers;

public record ChangePasswordDto(
    int userId,
    string newPassword
);
