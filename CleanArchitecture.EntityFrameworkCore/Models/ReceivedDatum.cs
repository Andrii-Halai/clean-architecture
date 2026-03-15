using System;
using System.Collections.Generic;

namespace CleanArchitecture.EntityFrameworkCore.Models;

public partial class ReceivedDatum
{
    public int Id { get; set; }

    public string? FolderName { get; set; }

    public byte? IsResolved { get; set; }

    public int? Iddevice { get; set; }

    public DateTime? StartDate { get; set; }

    public int? Idclinic { get; set; }

    public string? RecordingId { get; set; }

    public byte? EventSource { get; set; }

    public byte? AnalyzedByEcgProcess { get; set; }

    public byte? IsRemovedGeneral { get; set; }

    public DateTime? TimeStamp { get; set; }

    public virtual ICollection<EcgEvent> EcgEvents { get; set; } = new List<EcgEvent>();

    public virtual Clinic? IdclinicNavigation { get; set; }

    public virtual Device? IddeviceNavigation { get; set; }

    public virtual DeviceSetting? Recording { get; set; }
}
