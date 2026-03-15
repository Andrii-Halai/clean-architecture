using System;
using System.Collections.Generic;

namespace CleanArchitecture.EntityFrameworkCore.Models;

public partial class BillingInfoIdtf
{
    public int Id { get; set; }

    public string? RecordingId { get; set; }

    public DateTime? ClaimSubmDate { get; set; }

    public byte? ClaimSubm { get; set; }

    public byte? ClaimPaid { get; set; }

    public int? Idpatient { get; set; }

    public string? PatientName { get; set; }

    public string? PatientLastName { get; set; }

    public string? PatientMi { get; set; }

    public DateTime? PatientDob { get; set; }

    public string? Gender { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? Contact1 { get; set; }

    public string? Contact2 { get; set; }

    public string? Contact3 { get; set; }

    public string? ClinicBusinessName { get; set; }

    public string? IndForMonitor { get; set; }

    public string? PhysicianName { get; set; }

    public string? PhysicianLastName { get; set; }

    public string? Npi { get; set; }

    public string? StudyType { get; set; }

    public byte? Duration { get; set; }

    public string? Cpt { get; set; }

    public DateTime? DeviceRecordingStartDate { get; set; }

    public string? PrimInsCompany { get; set; }

    public string? PrimPolicyName { get; set; }

    public string? PrimInsIdnumber { get; set; }

    public string? PrimInsGroupNumber { get; set; }

    public string? PrimInsPhone { get; set; }

    public string? SecInsCompany { get; set; }

    public string? SecPolicyName { get; set; }

    public string? SecInsIdnumber { get; set; }

    public string? SecInsGroupNumber { get; set; }

    public string? SecInsPhoneNumber { get; set; }

    public string? SubscRelationship { get; set; }

    public DateTime? SubscDob { get; set; }

    public DateTime? AddedDate { get; set; }
}
