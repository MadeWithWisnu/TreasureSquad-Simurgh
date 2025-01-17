using System;
using System.Collections.Generic;

namespace TreasureDataAccess.Models;

public partial class MstVillage
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? PostalCode { get; set; }

    public int? ProvinceId { get; set; }

    public int? DistrictId { get; set; }

    public int? SubdistrictId { get; set; }

    public bool? Status { get; set; }

    public bool? Deleted { get; set; }

    public virtual ICollection<DataLead> DataLeadDomicilleVillages { get; set; } = new List<DataLead>();

    public virtual ICollection<DataLead> DataLeadVillages { get; set; } = new List<DataLead>();

    public virtual MstDistrict? District { get; set; }

    public virtual ICollection<MstBranch> MstBranches { get; set; } = new List<MstBranch>();

    public virtual ICollection<Partner> PartnerDomicilleVillages { get; set; } = new List<Partner>();

    public virtual ICollection<Partner> PartnerVillages { get; set; } = new List<Partner>();

    public virtual MstProvince? Province { get; set; }

    public virtual MstSubdistrict? Subdistrict { get; set; }
}
