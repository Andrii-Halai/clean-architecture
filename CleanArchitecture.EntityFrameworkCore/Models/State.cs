using System;
using System.Collections.Generic;

namespace CleanArchitecture.EntityFrameworkCore.Models;

public partial class State
{
    public int Id { get; set; }

    public string? State1 { get; set; }

    public string? Abbreviation { get; set; }

    public virtual ICollection<Location> Locations { get; set; } = new List<Location>();
}
