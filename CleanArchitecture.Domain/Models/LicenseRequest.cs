using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.Models;

public partial class LicenseRequest
{
    public int Id { get; set; }

    public string? Organization { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? SoftwareVersion { get; set; }

    public string? HardwareInfo { get; set; }

    public string? Comment { get; set; }

    public byte? IsApproved { get; set; }

    public byte? Is64Bit { get; set; }

    public string? Osversion { get; set; }

    public string? MachineName { get; set; }

    public string? Netversion { get; set; }

    public string? UserLoggedName { get; set; }

    public string? SoftwareType { get; set; }

    public string? Password { get; set; }

    public DateTime? LastLoginDate { get; set; }

    public byte? DisablePasscode { get; set; }

    public DateTime? ResetPwdDate { get; set; }

    public DateTime? LastPwdChanged { get; set; }

    public string? RegistrationInfo { get; set; }

    public int? Idphysician { get; set; }

    public string? PortalUrl { get; set; }

    public string? Login { get; set; }

    public string? LastName { get; set; }

    public byte? OptOut2Fa { get; set; }

    public byte? AllClinicLoad { get; set; }

    public byte? Waiver2Fa { get; set; }

    public virtual ICollection<ClientApp> ClientApps { get; set; } = new List<ClientApp>();

    public virtual ICollection<PassCode> PassCodes { get; set; } = new List<PassCode>();

    public void UpdatePassword(string newPassword)
    {
        Password = newPassword;
    }
}
