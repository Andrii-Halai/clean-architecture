using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.Models;

public partial class ReportBacklog
{
    public int Id { get; set; }

    public DateTime? Day { get; set; }

    public int? Idcenter { get; set; }

    public int? CountDevices { get; set; }

    public int? HolterDueCount { get; set; }

    public int? HolterDueCountArc { get; set; }

    public int? SummaryDueCount { get; set; }

    public int? SummaryDueCountArc { get; set; }
}
