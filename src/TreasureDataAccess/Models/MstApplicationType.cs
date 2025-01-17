using System;
using System.Collections.Generic;

namespace TreasureDataAccess.Models;

public partial class MstApplicationType
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public byte? Status { get; set; }

    public byte? Deleted { get; set; }

    public virtual ICollection<DataLead> DataLeads { get; set; } = new List<DataLead>();
}
