using System;
using System.Collections.Generic;

namespace CleanArchitecture.EntityFrameworkCore.Models;

public partial class Physician
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? Phone2 { get; set; }

    public string? Description { get; set; }

    public string? LastName { get; set; }

    public string? Mi { get; set; }

    public string? Comment { get; set; }

    public int? Idcenter { get; set; }

    public string? NotificationTemplate { get; set; }

    public string? NotificationCriteria { get; set; }

    public string? Npi { get; set; }

    public virtual MonitoringCenter? IdcenterNavigation { get; set; }

    public virtual ICollection<Patient> PatientIdphysicianOrderingNavigations { get; set; } = new List<Patient>();

    public virtual ICollection<Patient> PatientIdphysicianReadingNavigations { get; set; } = new List<Patient>();

    public virtual ICollection<Patient> PatientIdphysicianReferringNavigations { get; set; } = new List<Patient>();

    public virtual ICollection<PhysicanClinicsGroup> PhysicanClinicsGroups { get; set; } = new List<PhysicanClinicsGroup>();
}
