using System;
using System.Collections.Generic;
using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Domain.Models;

public partial class Physician : Entity
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
    
    public Physician() {}

    public Physician(
        string? Name,
        string? LastName,
        string? MI,
        string? Email,
        string? Phone,
        string? Phone2,
        string? Description,
        string? Comment,
        int? IDCenter,
        string? NotificationTemplate,
        string? NotificationCriteria,
        string? Npi)
    {
        this.Name = Name;
        this.LastName = LastName;
        this.Mi = MI;
        this.Email = Email;
        this.Phone = Phone;
        this.Phone2 = Phone2;
        this.Description = Description;
        this.Comment = Comment;
        this.Idcenter = IDCenter;
        this.NotificationTemplate = NotificationTemplate;
        this.NotificationCriteria = NotificationCriteria;
        Npi = ValidateNpi(Npi);
    }

    public string ValidateNpi(string? npi)
    {
        if (string.IsNullOrWhiteSpace(npi))
            throw new DomainValidationException("NPI is required.");

        var value = npi.Trim();

        // Business rule: NPI must be exactly 10 digits
        if (value.Length != 10 || !value.All(char.IsDigit))
            throw new DomainValidationException("NPI must contain exactly 10 digits.");

        return value;
    }
    
    public void ChangeNpi(string npi)
    {
        Npi = ValidateNpi(npi);
    }
}
