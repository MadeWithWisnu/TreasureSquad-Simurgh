using System;
using System.Collections.Generic;

namespace TreasureDataAccess.Models;

public partial class MstSurveyor
{
    public int Id { get; set; }

    public DateOnly? StartDate { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public DateOnly? SurveyorDate { get; set; }

    public string? PartnerId { get; set; }

    public int? ProductId { get; set; }

    public byte? Status { get; set; }

    public byte? Deleted { get; set; }

    public virtual ICollection<DataLead> DataLeads { get; set; } = new List<DataLead>();

    public virtual Partner? Partner { get; set; }

    public virtual MstProduct? Product { get; set; }
}
