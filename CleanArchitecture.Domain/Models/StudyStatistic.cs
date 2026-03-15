using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.Models;

public partial class StudyStatistic
{
    public int Id { get; set; }

    public string? RecordingId { get; set; }

    public string? DeviceSn { get; set; }

    public int? Idcenter { get; set; }

    public int? Idclinic { get; set; }

    public string? ClinicName { get; set; }

    public string? PatientMrn { get; set; }

    public DateTime? PatientDob { get; set; }

    public string? IndForMonitor { get; set; }

    public string? Cpt { get; set; }

    public string? OperatingMode { get; set; }

    public string? AlternativeMode { get; set; }

    public DateTime? DeviceRecordingStartDate { get; set; }

    public DateTime? DeviceRecordingEndDate { get; set; }

    public int? Duration { get; set; }

    public byte? Hpdays { get; set; }

    public int? OffMonitor { get; set; }

    public int? AnalyzedTime { get; set; }

    public DateTime? FirstStat { get; set; }

    public DateTime? FirstConfirmedArrhythmia { get; set; }

    public string? TechDiagnoses { get; set; }

    public string? DowngradedMode { get; set; }

    public byte? HomeHookup { get; set; }
}
