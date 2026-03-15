using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.Models;

public partial class User
{
    public int Id { get; set; }

    public int? IdusersGroup { get; set; }

    public int? Idapp { get; set; }

    public string? Name { get; set; }

    public byte? Activated { get; set; }

    public DateTime? LastAccessDate { get; set; }

    public string? Initials { get; set; }

    public virtual ClientApp? IdappNavigation { get; set; }

    public virtual UsersGroup? IdusersGroupNavigation { get; set; }

    public virtual ICollection<Report> Reports { get; set; } = new List<Report>();

    public virtual ICollection<UserTime> UserTimes { get; set; } = new List<UserTime>();
}
