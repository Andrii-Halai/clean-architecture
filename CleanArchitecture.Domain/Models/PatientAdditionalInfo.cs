using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.Models;

public partial class PatientAdditionalInfo
{
    public int Id { get; set; }

    public int? Idpatient { get; set; }

    public string? Cpt { get; set; }

    public string? PrimInsCompany { get; set; }

    public string? PrimInsPhone { get; set; }

    public string? PrimInsIdnumber { get; set; }

    public string? PrimInsGroupNumber { get; set; }

    public string? SecInsCompany { get; set; }

    public string? SecInsPhoneNumber { get; set; }

    public string? SecInsIdnumber { get; set; }

    public string? SecInsGroupNumber { get; set; }

    public string? SubscFirstName { get; set; }

    public string? SubscLastName { get; set; }

    public string? SubscRelationship { get; set; }

    public DateTime? SubscDob { get; set; }

    public byte? InsuranceChoiceInfo { get; set; }

    public string? CardFiles { get; set; }

    public string? PrimPolicyName { get; set; }

    public string? SecPolicyName { get; set; }

    public DateTime? AddedDate { get; set; }

    public string? SpecifyRelationship { get; set; }

    public int? Idlocation { get; set; }

    public string? Entity { get; set; }
}
