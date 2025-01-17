using System;
using System.Collections.Generic;

namespace TreasureDataAccess.Models;

public partial class MstDistrict
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? ProvinceId { get; set; }

    public string? Status { get; set; }

    public string? Deleted { get; set; }

    public virtual ICollection<MstSubdistrict> MstSubdistricts { get; set; } = new List<MstSubdistrict>();

    public virtual ICollection<MstVillage> MstVillages { get; set; } = new List<MstVillage>();

    public virtual MstProvince? Province { get; set; }
}
