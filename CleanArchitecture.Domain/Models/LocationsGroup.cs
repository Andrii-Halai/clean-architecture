using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.Models;

public partial class LocationsGroup
{
    public int Id { get; set; }

    public string? GroupName { get; set; }

    public int? Idlocation { get; set; }

    public virtual Location? IdlocationNavigation { get; set; }

    public virtual ICollection<MonitoringCenter> MonitoringCenters { get; set; } = new List<MonitoringCenter>();
}
