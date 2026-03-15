using System;
using System.Collections.Generic;

namespace CleanArchitecture.EntityFrameworkCore.Models;

public partial class DeviceSetting
{
    public int Id { get; set; }

    public int? Iddevice { get; set; }

    public string RecordingId { get; set; } = null!;

    public string? TimeZone { get; set; }

    public int? SamplingRate { get; set; }

    public int? BitResolution { get; set; }

    public int? OperatingMode { get; set; }

    public int? ServerConnectInterval { get; set; }

    public int? ButtonPressTime { get; set; }

    public int? Duration { get; set; }

    public int? NumChannels { get; set; }

    public int? LevelDrl { get; set; }

    public int? LevelLod { get; set; }

    public int? HookupEnbl { get; set; }

    public int? SaveDenEcg { get; set; }

    public int? CompressDenEcg { get; set; }

    public string? ChannelLabelCh1 { get; set; }

    public string? ChannelLabelCh2 { get; set; }

    public int? TachyRateUrgent { get; set; }

    public int? TachyRateRoutine { get; set; }

    public int? TachySensitivity { get; set; }

    public int? BradyRateUrgent { get; set; }

    public int? BradyRateRoutine { get; set; }

    public int? BradySensitivity { get; set; }

    public int? PauseTimeUrgent { get; set; }

    public int? PauseTimeRoutine { get; set; }

    public int? AfdurationUrgent { get; set; }

    public byte? SettingsStatus { get; set; }

    public byte? Dst { get; set; }

    public byte? Drl { get; set; }

    public int? Idpatient { get; set; }

    public string? Crc { get; set; }

    public byte? IsArchived { get; set; }

    public byte? IsAf { get; set; }

    public byte? IsSveRun { get; set; }

    public byte? IsVeRun { get; set; }

    public byte? IsVeCouplet { get; set; }

    public byte? IsVeBigeminy { get; set; }

    public byte? AutoRequested { get; set; }

    public string? CriticalSave { get; set; }

    public int? Idclinic { get; set; }

    public byte? Hpdays { get; set; }

    public byte? S3bucket { get; set; }

    public byte? ReasonsWr { get; set; }

    public string? ReasonText { get; set; }

    public byte? Bsmstatus { get; set; }

    public string? BsmerrorMessage { get; set; }

    public byte? HomeHookupStatus { get; set; }

    public DateTime? HomeHookupStart { get; set; }

    public DateTime? HomeHookupEnd { get; set; }

    public byte? ServiceCall { get; set; }

    public string? TrackingNumber { get; set; }

    public string? AlternativeMode { get; set; }

    public int? Vtrate { get; set; }

    public int? Vtsensitivity { get; set; }

    public int? Svtrate { get; set; }

    public int? Svtsensitivity { get; set; }

    public byte? Billed { get; set; }

    public string? Cpt { get; set; }

    public int? StudyType { get; set; }

    public virtual Device? IddeviceNavigation { get; set; }

    public virtual ICollection<Patient> Patients { get; set; } = new List<Patient>();

    public virtual ICollection<ReceivedDatum> ReceivedData { get; set; } = new List<ReceivedDatum>();

    public virtual ICollection<Report> Reports { get; set; } = new List<Report>();
}
