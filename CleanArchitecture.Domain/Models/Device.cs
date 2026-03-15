using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.Models;

public partial class Device
{
    public int Id { get; set; }

    public int? Idcenter { get; set; }

    public string? ModelNumber { get; set; }

    public DateTime? BuildDate { get; set; }

    public string? UniqueId { get; set; }

    public byte? Model { get; set; }

    public byte? Status { get; set; }

    public int? Idclinic { get; set; }

    public byte? IsRemoved { get; set; }

    public string? McfirmwareVer { get; set; }

    public string? DspfirmwareVer { get; set; }

    public string? MdmfirmwareVer { get; set; }

    public string? Udi { get; set; }

    public byte? DeviceLocation { get; set; }

    public byte? Class { get; set; }

    public string? Imei { get; set; }

    public string? Iccid { get; set; }

    public DateTime? FirmwareDate { get; set; }

    public virtual ICollection<DeviceMonitoringCenter> DeviceMonitoringCenters { get; set; } = new List<DeviceMonitoringCenter>();

    public virtual ICollection<DeviceSetting> DeviceSettings { get; set; } = new List<DeviceSetting>();

    public virtual ICollection<DeviceStatistic> DeviceStatistics { get; set; } = new List<DeviceStatistic>();

    public virtual MonitoringCenter? IdcenterNavigation { get; set; }

    public virtual Clinic? IdclinicNavigation { get; set; }

    public virtual ICollection<Patient> Patients { get; set; } = new List<Patient>();

    public virtual ICollection<ReceivedDatum> ReceivedData { get; set; } = new List<ReceivedDatum>();
}
