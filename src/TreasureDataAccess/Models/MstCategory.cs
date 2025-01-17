using System;
using System.Collections.Generic;

namespace TreasureDataAccess.Models;

public partial class MstCategory
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public bool? Status { get; set; }

    public bool? Deleted { get; set; }

    public virtual ICollection<DataLead> DataLeads { get; set; } = new List<DataLead>();

    public virtual ICollection<MstBrandType> MstBrandTypes { get; set; } = new List<MstBrandType>();

    public virtual ICollection<MstBrand> MstBrands { get; set; } = new List<MstBrand>();

    public virtual ICollection<MstModel> MstModels { get; set; } = new List<MstModel>();

    public virtual ICollection<MstVariety> MstVarieties { get; set; } = new List<MstVariety>();
}
