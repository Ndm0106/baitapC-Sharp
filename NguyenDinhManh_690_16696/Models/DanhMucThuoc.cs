﻿using System;
using System.Collections.Generic;

namespace NguyenDinhManh_690_16696.Models;

public partial class DanhMucThuoc
{
    public string MaDm { get; set; } = null!;

    public string? TenDm { get; set; }

    public virtual ICollection<Thuoc> Thuocs { get; set; } = new List<Thuoc>();
}
