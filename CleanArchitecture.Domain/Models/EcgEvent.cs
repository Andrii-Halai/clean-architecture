using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.Models;

public partial class EcgEvent
{
    public int IdecgEvent { get; set; }

    public int? IdreceivedData { get; set; }

    public int? EcgEventSource { get; set; }

    public int? EventType { get; set; }

    public byte? EventStatus { get; set; }

    public DateTime? EventStartDate { get; set; }

    public double? Length { get; set; }

    public int? AvgHr { get; set; }

    public string? EcgStripCaption { get; set; }

    public string? Action { get; set; }

    public byte? PartEcg { get; set; }

    public int? Start { get; set; }

    public int? Size { get; set; }

    public int? StartFromBeginReceivedData { get; set; }

    public byte? IncludedToReport { get; set; }

    public int? Idoperator { get; set; }

    public int? AdjTimeInterval { get; set; }

    public virtual ReceivedDatum? IdreceivedDataNavigation { get; set; }
}
