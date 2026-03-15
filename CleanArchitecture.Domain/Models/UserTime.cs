using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.Models;

public partial class UserTime
{
    public int Id { get; set; }

    public int? Iduser { get; set; }

    public DateTime? Date { get; set; }

    public int? ActiveTime { get; set; }

    public int? InActiveTime { get; set; }

    public string? FullUserName { get; set; }

    public int? Idcenter { get; set; }

    public string? Email { get; set; }

    public virtual User? IduserNavigation { get; set; }
}
