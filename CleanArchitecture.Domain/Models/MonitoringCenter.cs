using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.Models;

public partial class MonitoringCenter
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? IdlocationsGroup { get; set; }

    public byte? IsRemoved { get; set; }

    public byte? IsCollectData { get; set; }

    public string? PackageFile { get; set; }

    public string? PackageFileArchived { get; set; }

    public int? CountArchived { get; set; }

    public string? BusinessName { get; set; }

    public string? Logo { get; set; }

    public byte? IsFullMct { get; set; }

    public byte? Status { get; set; }

    public byte? IsInvitingPatient { get; set; }

    public string? Apikey { get; set; }

    public virtual ICollection<ClientApp> ClientApps { get; set; } = new List<ClientApp>();

    public virtual ICollection<Clinic> Clinics { get; set; } = new List<Clinic>();

    public virtual ICollection<Device> Devices { get; set; } = new List<Device>();

    public virtual LocationsGroup? IdlocationsGroupNavigation { get; set; }

    public virtual ICollection<Patient> Patients { get; set; } = new List<Patient>();

    public virtual ICollection<Physician> Physicians { get; set; } = new List<Physician>();
}
