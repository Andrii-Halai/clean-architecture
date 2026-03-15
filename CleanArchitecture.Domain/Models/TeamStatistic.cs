using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.Models;

public partial class TeamStatistic
{
    public int Id { get; set; }

    public int? Idcenter { get; set; }

    public DateTime? Day { get; set; }

    public int? StudiesMct { get; set; }

    public int? StudiesEr { get; set; }

    public int? StudiesHolter { get; set; }

    public int? AvglengthMct { get; set; }

    public int? AvglengthEr { get; set; }

    public int? AvglengthHolter { get; set; }

    public string? CenterName { get; set; }

    public int? ReportsMct { get; set; }

    public int? ReportsEr { get; set; }

    public int? ReportsHolter { get; set; }

    public int? ReportsHolterPlus { get; set; }

    public int? StudiesHolterPlus { get; set; }

    public int? AvglengthHolterPlus { get; set; }

    public int? ReportsSummaryM { get; set; }
}
