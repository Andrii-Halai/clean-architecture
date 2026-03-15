using System;
using System.Collections.Generic;

namespace CleanArchitecture.EntityFrameworkCore.Models;

public partial class ClientApp
{
    public int Id { get; set; }

    public int? Idcenter { get; set; }

    public string? AppKey { get; set; }

    public int? IdlicenseRequest { get; set; }

    public byte? IsActive { get; set; }

    public int? Idclinic { get; set; }

    public string? AdditionalClinics { get; set; }

    public int? IdappRelated { get; set; }

    public virtual MonitoringCenter? IdcenterNavigation { get; set; }

    public virtual Clinic? IdclinicNavigation { get; set; }

    public virtual LicenseRequest? IdlicenseRequestNavigation { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
