using System;
using System.Collections.Generic;

namespace CleanArchitecture.EntityFrameworkCore.Models;

public partial class Indication
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Description { get; set; }
}
