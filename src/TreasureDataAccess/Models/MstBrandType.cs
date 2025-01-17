using System;
using System.Collections.Generic;

namespace TreasureDataAccess.Models;

public partial class MstBrandType
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? ManufacturerCountry { get; set; }

    public int? CategoryId { get; set; }

    public int? BrandId { get; set; }

    public int? VarietyId { get; set; }

    public byte? Status { get; set; }

    public byte? Deleted { get; set; }

    public virtual MstBrand? Brand { get; set; }

    public virtual MstCategory? Category { get; set; }

    public virtual ICollection<MstModel> MstModels { get; set; } = new List<MstModel>();

    public virtual MstVariety? Variety { get; set; }
}
