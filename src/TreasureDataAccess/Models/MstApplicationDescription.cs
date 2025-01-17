using System;
using System.Collections.Generic;

namespace TreasureDataAccess.Models;

public partial class MstApplicationDescription
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Status { get; set; }

    public string? Deleted { get; set; }

    public virtual ICollection<DataLead> DataLeads { get; set; } = new List<DataLead>();
}
