using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.Models;

public partial class Clinic
{
    public int Id { get; set; }

    public string? ClinicName { get; set; }

    public int? Idlocation { get; set; }

    public int? Idcenter { get; set; }

    public string? ClinicPhone { get; set; }

    public string? Email { get; set; }

    public string? SettingsTemplate { get; set; }

    public byte? IsSendNotification { get; set; }

    public byte? IsFullMct { get; set; }

    public string? Logo { get; set; }

    public string? Code { get; set; }

    public int? Iddistributor { get; set; }

    public string? CellPhone { get; set; }

    public int? IdindicationsGroup { get; set; }

    public byte? Status { get; set; }

    public int? IdlinkedClinic { get; set; }

    public byte? IsInvitingPatient { get; set; }

    public string? Apikey { get; set; }

    public byte? IsUseWiFi { get; set; }

    public string? WiFiSsid { get; set; }

    public string? WiFiPwd { get; set; }

    public string? ItcontactInfo { get; set; }

    public byte? IsUseSh { get; set; }

    public string? BusinessName { get; set; }

    public string? ExternalId { get; set; }

    public string? DestinationId { get; set; }

    public virtual ICollection<ClientApp> ClientApps { get; set; } = new List<ClientApp>();

    public virtual ICollection<DeviceUtilization> DeviceUtilizations { get; set; } = new List<DeviceUtilization>();

    public virtual ICollection<Device> Devices { get; set; } = new List<Device>();

    public virtual MonitoringCenter? IdcenterNavigation { get; set; }

    public virtual Location? IdlocationNavigation { get; set; }

    public virtual ICollection<Patient> PatientIdclinicPhysicianOrderingNavigations { get; set; } = new List<Patient>();

    public virtual ICollection<Patient> PatientIdclinicPhysicianReadingNavigations { get; set; } = new List<Patient>();

    public virtual ICollection<Patient> PatientIdclinicPhysicianReferringNavigations { get; set; } = new List<Patient>();

    public virtual ICollection<PhysicanClinicsGroup> PhysicanClinicsGroups { get; set; } = new List<PhysicanClinicsGroup>();

    public virtual ICollection<ReceivedDatum> ReceivedData { get; set; } = new List<ReceivedDatum>();
}
