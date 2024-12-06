using System;
using System.Collections.Generic;

namespace DeMauGuiSV.Models;

public partial class Product
{
    public string ProductId { get; set; } = null!;

    public string? ProductName { get; set; }

    public int? UnitPrice { get; set; }

    public int? Quantity { get; set; }

    public string? CatId { get; set; }

    public virtual Category? Cat { get; set; }
}
