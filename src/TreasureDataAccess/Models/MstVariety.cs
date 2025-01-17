using System;
using System.Collections.Generic;

namespace TreasureDataAccess.Models;

public partial class MstVariety
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? CategoryId { get; set; }

    public string? Status { get; set; }

    public string? Deleted { get; set; }

    public virtual MstCategory? Category { get; set; }

    public virtual ICollection<MstBrandType> MstBrandTypes { get; set; } = new List<MstBrandType>();

    public virtual ICollection<MstModel> MstModels { get; set; } = new List<MstModel>();
}
