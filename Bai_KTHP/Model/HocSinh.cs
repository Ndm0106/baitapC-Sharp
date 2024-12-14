using System;
using System.Collections.Generic;

namespace Bai_KTHP.Model;

public partial class HocSinh
{
    public string MaHs { get; set; } = null!;

    public string HoTen { get; set; } = null!;

    public DateTime NgaySinh { get; set; }

    public string GioiTinh { get; set; } = null!;

    public string ConTbls { get; set; } = null!;

    public string MaLop { get; set; } = null!;

    public virtual Lop MaLopNavigation { get; set; } = null!;
}
