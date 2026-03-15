using System;
using System.Collections.Generic;

namespace CleanArchitecture.EntityFrameworkCore.Models;

public partial class ClinicRequest
{
    public int Id { get; set; }

    public DateTime? AddedDate { get; set; }

    public int? Idclinic { get; set; }

    public string? RecordingId { get; set; }

    public string? RequestInfo { get; set; }

    public int? Idlrequest { get; set; }

    public string? ClinicName { get; set; }

    public string? UserName { get; set; }

    public byte? Status { get; set; }

    public string? StatusInfo { get; set; }
}
