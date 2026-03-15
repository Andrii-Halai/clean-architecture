using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.Models;

public partial class Location
{
    public int Id { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public int? Idstate { get; set; }

    public string? Address2 { get; set; }

    public string? Zip { get; set; }

    public virtual ICollection<Clinic> Clinics { get; set; } = new List<Clinic>();

    public virtual State? IdstateNavigation { get; set; }

    public virtual ICollection<LocationsGroup> LocationsGroups { get; set; } = new List<LocationsGroup>();

    public virtual ICollection<Patient> Patients { get; set; } = new List<Patient>();
}
