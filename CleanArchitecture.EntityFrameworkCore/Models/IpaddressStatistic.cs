using System;
using System.Collections.Generic;

namespace CleanArchitecture.EntityFrameworkCore.Models;

public partial class IpaddressStatistic
{
    public int Id { get; set; }

    public int? Idapp { get; set; }

    public int? Idlicense { get; set; }

    public string? UserName { get; set; }

    public string? Ip { get; set; }

    public string? Organization { get; set; }

    public string? Email { get; set; }

    public DateTime? AddedDate { get; set; }

    public byte? Rdp { get; set; }

    public byte? Vpn { get; set; }

    public string? Raa { get; set; }

    public byte? IpinfoVpn { get; set; }

    public byte? Hosting { get; set; }
}
