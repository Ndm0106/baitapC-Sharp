using System;
using System.Collections.Generic;

namespace NguyenDinhManh_690.Model;

public partial class Hang
{
    public string MaHang { get; set; } = null!;

    public string? TenHang { get; set; }

    public int? DonGiaBan { get; set; }

    public int? SoLuongCon { get; set; }

    public string? MaDm { get; set; }

    public virtual DanhMucHang? MaDmNavigation { get; set; }
}
