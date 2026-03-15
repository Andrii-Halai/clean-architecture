using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.Models;

public partial class Patient
{
    public int Id { get; set; }

    public int? Iddevice { get; set; }

    public string? Name { get; set; }

    public string? Gender { get; set; }

    public DateTime? Dob { get; set; }

    public string? IndForMonitor { get; set; }

    public int? IdphysicianReading { get; set; }

    public int? IdphysicianOrdering { get; set; }

    public int? IddeviceSettings { get; set; }

    public string? Comment { get; set; }

    public string? LastName { get; set; }

    public string? Mi { get; set; }

    public string? Ssn { get; set; }

    public string? PatientIdclinic { get; set; }

    public string? Contact1 { get; set; }

    public string? Contact2 { get; set; }

    public string? Contact3 { get; set; }

    public int? Idlocation { get; set; }

    public int? IdphysicianReferring { get; set; }

    public int? IdclinicPhysicianReading { get; set; }

    public int? IdclinicPhysicianOrdering { get; set; }

    public int? IdclinicPhysicianReferring { get; set; }

    public byte? IsRemoved { get; set; }

    public string? TimeZoneStandardName { get; set; }

    public byte? Dst { get; set; }

    public int? Idcenter { get; set; }

    public string? Medications { get; set; }

    public string? CardiacDevice { get; set; }

    public string? PhysicianComment { get; set; }

    public DateTime? AddedDate { get; set; }

    public string? ExternalId { get; set; }

    public byte? Emrtype { get; set; }

    public string? OrderId { get; set; }

    public byte? OrderType { get; set; }

    public virtual MonitoringCenter? IdcenterNavigation { get; set; }

    public virtual Clinic? IdclinicPhysicianOrderingNavigation { get; set; }

    public virtual Clinic? IdclinicPhysicianReadingNavigation { get; set; }

    public virtual Clinic? IdclinicPhysicianReferringNavigation { get; set; }

    public virtual Device? IddeviceNavigation { get; set; }

    public virtual DeviceSetting? IddeviceSettingsNavigation { get; set; }

    public virtual Location? IdlocationNavigation { get; set; }

    public virtual Physician? IdphysicianOrderingNavigation { get; set; }

    public virtual Physician? IdphysicianReadingNavigation { get; set; }

    public virtual Physician? IdphysicianReferringNavigation { get; set; }

    public virtual ICollection<PatientMobileApp> PatientMobileApps { get; set; } = new List<PatientMobileApp>();
}
