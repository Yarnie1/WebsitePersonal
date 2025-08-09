using System;
using System.Collections.Generic;

namespace WebsitePersonal.Models
{
    public class GioHangDb
    {
        public int Id { get; set; }

        public string MaNguoiDung { get; set; }

        public DateTime NgayTao { get; set; }

        public string TenDangNhap { get; set; }
        public ICollection<GioHangChiTietDb> ChiTietGioHang { get; set; } = new List<GioHangChiTietDb>();
    }
}