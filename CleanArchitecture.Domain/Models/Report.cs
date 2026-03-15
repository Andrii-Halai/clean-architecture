using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.Models;

public partial class Report
{
    public int Id { get; set; }

    public int? Iduser { get; set; }

    public int? IddeviceSettings { get; set; }

    public DateTime? ReportDate { get; set; }

    public byte? ReportType { get; set; }

    public string? ReportDownloadPath { get; set; }

    public int? Idclinic { get; set; }

    public int? IdreceivedData { get; set; }

    public int? SignedByLicenseRequest { get; set; }

    public string? PhysicianInterpretation { get; set; }

    public string? TechnicianFindings { get; set; }

    public string? SummaryData { get; set; }

    public DateTime? DailyReportDay { get; set; }

    public byte? Printed { get; set; }

    public string? MergedInfo { get; set; }

    public DateTime? SignedDate { get; set; }

    public byte? ReportTypeS3 { get; set; }

    public virtual DeviceSetting? IddeviceSettingsNavigation { get; set; }

    public virtual User? IduserNavigation { get; set; }
}
