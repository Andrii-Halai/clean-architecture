using System;
using System.Collections.Generic;

namespace CleanArchitecture.EntityFrameworkCore.Models;

public partial class ZipCode
{
    public int Id { get; set; }

    public string? Zip { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Timezone { get; set; }

    public byte? Dst { get; set; }
}
