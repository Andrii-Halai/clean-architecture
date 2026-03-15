using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.Models;

public partial class EcgEventOp
{
    public int Id { get; set; }

    public int? Idcenter { get; set; }

    public int? IdreceivedData { get; set; }

    public int? IdecgEvent { get; set; }
}
