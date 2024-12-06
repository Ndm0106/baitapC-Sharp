using System;
using System.Collections.Generic;

namespace DeMauGuiSV.Models;

public partial class Category
{
    public string CatId { get; set; } = null!;

    public string? CatName { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
