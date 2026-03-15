using System;
using System.Collections.Generic;

namespace CleanArchitecture.EntityFrameworkCore.Models;

public partial class DeviceStatistic
{
    public int Id { get; set; }

    public int? Iddevice { get; set; }

    public string? RecordingId { get; set; }

    public int? CellStr { get; set; }

    public int? NumCommFail { get; set; }

    public int? BattV { get; set; }

    public int? AudAlarm { get; set; }

    public int? Ch1LeadOff { get; set; }

    public int? Ch2LeadOff { get; set; }

    public int? BattStat { get; set; }

    public int? NumFaults { get; set; }

    public int? State { get; set; }

    public int? EventDet { get; set; }

    public int? RecInProgress { get; set; }

    public int? RecDone { get; set; }

    public int? SdreFormatted { get; set; }

    public int? NewDevConf { get; set; }

    public byte? IsBatteryVoltageLow { get; set; }

    public byte? IsCh1LeadIsPoor { get; set; }

    public byte? IsCh2LeadIsPoor { get; set; }

    public byte? IsFaulted { get; set; }

    public byte? IsDeviceOfflineForaLongTime { get; set; }

    public DateTime? LastTransmission { get; set; }

    public byte? HealthIndicator { get; set; }

    public DateTime? DeviceRecordingStartDate { get; set; }

    public string? Qcsq { get; set; }

    public DateTime? DeviceRecordingEndDate { get; set; }

    public byte? IndicatorNoData { get; set; }

    public byte? ComMode { get; set; }

    public virtual Device? IddeviceNavigation { get; set; }
}
