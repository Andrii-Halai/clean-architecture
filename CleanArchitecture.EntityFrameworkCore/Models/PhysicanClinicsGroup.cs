using System;
using System.Collections.Generic;

namespace CleanArchitecture.EntityFrameworkCore.Models;

public partial class PhysicanClinicsGroup
{
    public int Id { get; set; }

    public int? Idphysician { get; set; }

    public int? Idclinic { get; set; }

    public virtual Clinic? IdclinicNavigation { get; set; }

    public virtual Physician? IdphysicianNavigation { get; set; }
}
