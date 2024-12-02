using System;
using System.Collections.Generic;

namespace NguyenDinhManh_690.Model;

public partial class DanhMucHang
{
    public string MaDm { get; set; } = null!;

    public string? TenDm { get; set; }

    public virtual ICollection<Hang> Hangs { get; set; } = new List<Hang>();
}
