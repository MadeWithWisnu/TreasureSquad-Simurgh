using System;
using System.Collections.Generic;

namespace TreasureDataAccess.Models;

public partial class DataLead
{
    public string Id { get; set; } = null!;

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Gender { get; set; }

    public string? Address { get; set; }

    public string? DomicileAddress { get; set; }

    public string? PhoneNumber { get; set; }

    public string? PhoneNumber2 { get; set; }

    public string? Telephone { get; set; }

    public string? ApplicationSource { get; set; }

    public string? Reference { get; set; }

    public string? TypeOfBusiness { get; set; }

    public int? Year { get; set; }

    public int? TaxYear { get; set; }

    public string? BpkbNumber { get; set; }

    public string? PoliceNumber { get; set; }

    public int? ProductId { get; set; }

    public string? DebtorsType { get; set; }

    public int? ApplicationTypeId { get; set; }

    public int? IdentityId { get; set; }

    public int? VillageId { get; set; }

    public int? DomicilleVillageId { get; set; }

    public int? BranchId { get; set; }

    public string? PartnerId { get; set; }

    public int? ApplicationDescriptionId { get; set; }

    public int? SurveyorId { get; set; }

    public int? PaymentOfTermId { get; set; }

    public int? CategoryId { get; set; }

    public bool? Status { get; set; }

    public bool? Deleted { get; set; }

    public virtual MstApplicationDescription? ApplicationDescription { get; set; }

    public virtual MstApplicationType? ApplicationType { get; set; }

    public virtual MstBranch? Branch { get; set; }

    public virtual MstCategory? Category { get; set; }

    public virtual MstVillage? DomicilleVillage { get; set; }

    public virtual MstIdentity? Identity { get; set; }

    public virtual Partner? Partner { get; set; }

    public virtual MstPaymentOfTerm? PaymentOfTerm { get; set; }

    public virtual MstProduct? Product { get; set; }

    public virtual MstSurveyor? Surveyor { get; set; }

    public virtual MstVillage? Village { get; set; }
}
