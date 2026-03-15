using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.Models;

public partial class UsersGroup
{
    public int Id { get; set; }

    public string? GroupName { get; set; }

    public int? IdsoftwareType { get; set; }

    public virtual Software? IdsoftwareTypeNavigation { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
