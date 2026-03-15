using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.Models;

public partial class Software
{
    public int Id { get; set; }

    public string? SoftwareType { get; set; }

    public virtual ICollection<UsersGroup> UsersGroups { get; set; } = new List<UsersGroup>();
}
