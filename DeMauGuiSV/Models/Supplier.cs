using System;
using System.Collections.Generic;

namespace DeMauGuiSV.Models;

public partial class Supplier
{
    public string SupplierId { get; set; } = null!;

    public string? SupplierName { get; set; }

    public string? SupplierTelephone { get; set; }
}
