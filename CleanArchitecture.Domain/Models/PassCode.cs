using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.Models;

public partial class PassCode
{
    public int Id { get; set; }

    public int? Idrequest { get; set; }

    public string? PassCode1 { get; set; }

    public byte? IsApplied { get; set; }

    public DateTime? GeneratedDate { get; set; }

    public DateTime? AppliedDate { get; set; }

    public virtual LicenseRequest? IdrequestNavigation { get; set; }
}
