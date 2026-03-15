using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.Models;

public partial class IndicationsGroup
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Indications { get; set; }
}
