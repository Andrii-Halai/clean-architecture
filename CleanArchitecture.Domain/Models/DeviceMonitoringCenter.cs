using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.Models;

public partial class DeviceMonitoringCenter
{
    public int Id { get; set; }

    public int? Iddevice { get; set; }

    public int? Idcenter { get; set; }

    public int? Idclinic { get; set; }

    public int? IddeviceSettings { get; set; }

    public DateTime? AttachDate { get; set; }

    public virtual Device? IddeviceNavigation { get; set; }
}
