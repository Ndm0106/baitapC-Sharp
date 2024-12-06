using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeMauGuiSV
{
    public class DataInfor
    {
        public string ProductId { get; set; } = null!;

        public string? ProductName { get; set; }

        public int? UnitPrice { get; set; }

        public int? Quantity { get; set; }
        public int? Amount { get; set; }

        public string? CatId { get; set; }
    }
}
