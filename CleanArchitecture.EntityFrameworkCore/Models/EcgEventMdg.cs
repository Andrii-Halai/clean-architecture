using System;
using System.Collections.Generic;

namespace CleanArchitecture.EntityFrameworkCore.Models;

public partial class EcgEventMdg
{
    public int Id { get; set; }

    public string? RecordingId { get; set; }

    public DateTime? StartDate { get; set; }

    public int? AvgHr { get; set; }

    public string? EventType { get; set; }
}
