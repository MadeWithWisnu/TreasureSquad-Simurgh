using System;
using System.Collections.Generic;

namespace TreasureDataAccess.Models;

public partial class MstProvince
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public byte? Status { get; set; }

    public byte? Deleted { get; set; }

    public virtual ICollection<MstDistrict> MstDistricts { get; set; } = new List<MstDistrict>();

    public virtual ICollection<MstSubdistrict> MstSubdistricts { get; set; } = new List<MstSubdistrict>();

    public virtual ICollection<MstVillage> MstVillages { get; set; } = new List<MstVillage>();
}
