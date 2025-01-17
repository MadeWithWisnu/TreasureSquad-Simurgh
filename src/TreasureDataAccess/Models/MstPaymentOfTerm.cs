using System;
using System.Collections.Generic;

namespace TreasureDataAccess.Models;

public partial class MstPaymentOfTerm
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public decimal? InitialPrincipalPayment { get; set; }

    public decimal? FinalPrincipalPayment { get; set; }

    public int? Tenure { get; set; }

    public double? EffectiveRate { get; set; }

    public int? ProductId { get; set; }

    public bool? Status { get; set; }

    public bool? Deleted { get; set; }

    public virtual ICollection<DataLead> DataLeads { get; set; } = new List<DataLead>();

    public virtual MstProduct? Product { get; set; }
}
