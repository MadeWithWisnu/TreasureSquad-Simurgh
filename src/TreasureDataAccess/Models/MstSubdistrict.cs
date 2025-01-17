using System;
using System.Collections.Generic;

namespace TreasureDataAccess.Models;

public partial class MstSubdistrict
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? ProvinceId { get; set; }

    public int? DistrictId { get; set; }

    public byte? Status { get; set; }

    public byte? Deleted { get; set; }

    public virtual MstDistrict? District { get; set; }

    public virtual ICollection<MstVillage> MstVillages { get; set; } = new List<MstVillage>();

    public virtual MstProvince? Province { get; set; }
}
