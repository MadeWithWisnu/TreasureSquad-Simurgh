﻿using System;
using System.Collections.Generic;

namespace TreasureDataAccess.Models;

public partial class MstIdentity
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Status { get; set; }

    public string? Deleted { get; set; }

    public virtual ICollection<DataLead> DataLeads { get; set; } = new List<DataLead>();

    public virtual ICollection<Partner> Partners { get; set; } = new List<Partner>();
}
