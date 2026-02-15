namespace Application.Physicians;

/// <summary>
/// Data Transfer Object for Physician
/// </summary>
public record PhysicianDto(
    int Id,
    string? Name,
    string? LastName,
    string? MI,
    string? Email,
    string? Phone,
    string? Phone2,
    string? Description,
    string? Comment,
    int? IDCenter,
    string? NotificationTemplate,
    string? NotificationCriteria,
    string? Npi
);

public record CreatePhysicianDto(
    string? Name,
    string? LastName,
    string? MI,
    string? Email,
    string? Phone,
    string? Phone2,
    string? Description,
    string? Comment,
    int? IDCenter,
    string? NotificationTemplate,
    string? NotificationCriteria,
    string? Npi
);

