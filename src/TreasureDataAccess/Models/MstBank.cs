using System;
using System.Collections.Generic;

namespace TreasureDataAccess.Models;

public partial class MstBank
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public bool? Status { get; set; }

    public bool? Deleted { get; set; }

    public virtual ICollection<Partner> Partners { get; set; } = new List<Partner>();
}
