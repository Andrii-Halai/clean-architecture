using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.Models;

public partial class DeviceUtilization
{
    public int Id { get; set; }

    public int? Idclinic { get; set; }

    public int? CountActive { get; set; }

    public int? CountRma { get; set; }

    public int? CountSuspended { get; set; }

    public DateTime? Day { get; set; }

    public int? Idcenter { get; set; }

    public virtual Clinic? IdclinicNavigation { get; set; }
}
