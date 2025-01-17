using System;
using System.Collections.Generic;

namespace TreasureDataAccess.Models;

public partial class MstProduct
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public byte? Status { get; set; }

    public byte? Deleted { get; set; }

    public virtual ICollection<DataLead> DataLeads { get; set; } = new List<DataLead>();

    public virtual ICollection<MstBranch> MstBranches { get; set; } = new List<MstBranch>();

    public virtual ICollection<MstPaymentOfTerm> MstPaymentOfTerms { get; set; } = new List<MstPaymentOfTerm>();

    public virtual ICollection<MstSurveyor> MstSurveyors { get; set; } = new List<MstSurveyor>();

    public virtual ICollection<Partner> Partners { get; set; } = new List<Partner>();
}
