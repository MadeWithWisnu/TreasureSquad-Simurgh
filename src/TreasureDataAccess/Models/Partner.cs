using System;
using System.Collections.Generic;

namespace TreasureDataAccess.Models;

public partial class Partner
{
    public string Id { get; set; } = null!;

    public string? FullName { get; set; }

    public string? Gender { get; set; }

    public string? NpwpNumber { get; set; }

    public string? Address { get; set; }

    public string? DomicileAddress { get; set; }

    public string? BirthPlace { get; set; }

    public DateOnly? BirthDate { get; set; }

    public string? PhoneNumber { get; set; }

    public string? TelephoneNumber { get; set; }

    public string? BankAccountNumber { get; set; }

    public string? BankAccountName { get; set; }

    public int? TypeId { get; set; }

    public int? ProductId { get; set; }

    public int? BranchId { get; set; }

    public int? IdentityId { get; set; }

    public int? VillageId { get; set; }

    public int? DomicilleVillageId { get; set; }

    public int? BankId { get; set; }

    public byte? Status { get; set; }

    public byte? Deleted { get; set; }

    public virtual MstBank? Bank { get; set; }

    public virtual MstBranch? Branch { get; set; }

    public virtual ICollection<DataLead> DataLeads { get; set; } = new List<DataLead>();

    public virtual MstVillage? DomicilleVillage { get; set; }

    public virtual MstIdentity? Identity { get; set; }

    public virtual ICollection<MstSurveyor> MstSurveyors { get; set; } = new List<MstSurveyor>();

    public virtual MstProduct? Product { get; set; }

    public virtual MstType? Type { get; set; }

    public virtual MstVillage? Village { get; set; }
}
