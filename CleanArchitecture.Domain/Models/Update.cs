using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.Models;

public partial class Update
{
    public int Id { get; set; }

    public string? SoftwareType { get; set; }

    public string? SoftwareVersion { get; set; }

    public byte? UpdateStatus { get; set; }

    public string? UpdateFileWebPath { get; set; }

    public string? Details { get; set; }
}
