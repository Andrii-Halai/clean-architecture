using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.Models;

public partial class EcgEventMobile
{
    public int Id { get; set; }

    public int? IdecgEvent { get; set; }

    public string? RecordingId { get; set; }

    public int? Idpatient { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? StartDate { get; set; }

    public string? Symptoms { get; set; }

    public string? Activity { get; set; }

    public string? Location { get; set; }
}
