using System;
using System.Collections.Generic;

namespace CleanArchitecture.EntityFrameworkCore.Models;

public partial class Distributor
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Idlocation { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public byte? Insurance { get; set; }

    public string? ExternalId { get; set; }

    public string? DestinationId { get; set; }
}
