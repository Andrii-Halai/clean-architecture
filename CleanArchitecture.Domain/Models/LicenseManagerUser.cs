using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.Models;

public partial class LicenseManagerUser
{
    public int Id { get; set; }

    public string? UserName { get; set; }

    public DateTime? LastAccessDate { get; set; }

    public string? MotherboardInfo { get; set; }

    public byte? Activated { get; set; }

    public byte? SuperUser { get; set; }

    public string? MachineName { get; set; }

    public string? Version { get; set; }

    public string? Type { get; set; }
}
