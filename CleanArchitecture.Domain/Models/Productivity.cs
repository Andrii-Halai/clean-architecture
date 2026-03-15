using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.Models;

public partial class Productivity
{
    public int Id { get; set; }

    public int? Idcenter { get; set; }

    public int? UserId { get; set; }

    public string? OperatorName { get; set; }

    public string? Email { get; set; }

    public DateTime? Day { get; set; }

    public int? HolterCount { get; set; }

    public int? SummaryMct { get; set; }

    public int? SummaryEr { get; set; }

    public int? Statcount { get; set; }

    public int? BaselineCount { get; set; }

    public int? Evcount { get; set; }

    public int? ConfirmedCount { get; set; }

    public int? AvgAdjConfirmed { get; set; }

    public int? RejectedCount { get; set; }

    public int? AvgAdjRejected { get; set; }

    public int? ActiveTime { get; set; }

    public int? InActiveTime { get; set; }

    public string? GroupName { get; set; }

    public int? SummaryM { get; set; }
}
