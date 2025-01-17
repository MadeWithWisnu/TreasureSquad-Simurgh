using System;
using System.Collections.Generic;

namespace TreasureDataAccess.Models;

public partial class MstBranch
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Structure { get; set; }

    public string? Address { get; set; }

    public string? PhoneNumber { get; set; }

    public string? NpwpNumber { get; set; }

    public DateOnly? StartDate { get; set; }

    public decimal? PlafonCashAdvance { get; set; }

    public decimal? PlafonFunding { get; set; }

    public decimal? PlafonPettyCash { get; set; }

    public string? CoaRakNumber { get; set; }

    public string? CustodianCode { get; set; }

    public string? PicTitle { get; set; }

    public string? LocalTime { get; set; }

    public int? VillageId { get; set; }

    public int? ProductId { get; set; }

    public string? Status { get; set; }

    public string? Deleted { get; set; }

    public virtual ICollection<DataLead> DataLeads { get; set; } = new List<DataLead>();

    public virtual ICollection<Partner> Partners { get; set; } = new List<Partner>();

    public virtual MstProduct? Product { get; set; }

    public virtual MstVillage? Village { get; set; }
}
