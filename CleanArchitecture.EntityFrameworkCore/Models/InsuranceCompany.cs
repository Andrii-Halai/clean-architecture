using System;
using System.Collections.Generic;

namespace CleanArchitecture.EntityFrameworkCore.Models;

public partial class InsuranceCompany
{
    public int Id { get; set; }

    public string? CompanyName { get; set; }

    public int? Usability { get; set; }

    public DateTime? LastUsabilityDate { get; set; }
}
