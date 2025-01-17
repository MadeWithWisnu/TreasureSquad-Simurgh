using System;
using System.Collections.Generic;

namespace TreasureDataAccess.Models;

public partial class MstModel
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? CategoryId { get; set; }

    public int? BrandId { get; set; }

    public int? BrandTypeId { get; set; }

    public int? VarietyId { get; set; }

    public string? Status { get; set; }

    public string? Deleted { get; set; }

    public virtual MstBrand? Brand { get; set; }

    public virtual MstBrandType? BrandType { get; set; }

    public virtual MstCategory? Category { get; set; }

    public virtual MstVariety? Variety { get; set; }
}
