using System;
using System.Collections.Generic;

namespace CleanArchitecture.EntityFrameworkCore.Models;

public partial class PatientMobileApp
{
    public int Id { get; set; }

    public int? Idpatient { get; set; }

    public string? PatientPhone { get; set; }

    public DateTime? RegisterDate { get; set; }

    public byte? IsRemoved { get; set; }

    public DateTime? RemovedDate { get; set; }

    public virtual Patient? IdpatientNavigation { get; set; }
}
