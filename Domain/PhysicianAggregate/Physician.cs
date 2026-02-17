using Domain.Common;

namespace Domain.PhysicianAggregate;

public class Physician : IEntity, IAggregateRoot
{
    public int Id { get; set; }
    
    public string? Name { get; set; }
    
    public string? Email { get; set; }
    
    public string? Phone { get; set; }
    
    public string? Phone2 { get; set; }
    
    public string? Description { get; set; }
    
    public string? LastName { get; set; }
    
    public string? MI { get; set; }
    
    public string? Comment { get; set; }
    
    public int? IDCenter { get; set; }
    
    public string? NotificationTemplate { get; set; }
    
    public string? NotificationCriteria { get; set; }
    
    public string? Npi { get; set; }
    
    public Physician() {}

    public Physician(
        int id,
        string? name,
        string? lastName,
        string? mi,
        string? email,
        string? phone,
        string? phone2,
        string? description,
        string? comment,
        int? idCenter,
        string? notificationTemplate,
        string? notificationCriteria,
        string? npi
    )
    {
        Id = id;
        Name = name;
        LastName = lastName;
        MI = mi;
        Email = email;
        Phone = phone;
        Phone2 = phone2;
        Description = description;
        Comment = comment;
        IDCenter = idCenter;
        NotificationTemplate = notificationTemplate;
        NotificationCriteria = notificationCriteria;
        Npi = npi;
    }
}