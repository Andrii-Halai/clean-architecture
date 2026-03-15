using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.Models;

public partial class ClientAppsAction
{
    public int Id { get; set; }

    public DateTime? AddedDate { get; set; }

    public byte? UserActionType { get; set; }

    public int? ClientAppId { get; set; }

    public int? UserId { get; set; }

    public string? UserName { get; set; }

    public int? Idclinic { get; set; }

    public int? Idcenter { get; set; }

    public string? RecordingId { get; set; }

    public string? DeviceSn { get; set; }

    public int? PatientId { get; set; }

    public string? ClinicName { get; set; }

    public string? ActionData { get; set; }
}
