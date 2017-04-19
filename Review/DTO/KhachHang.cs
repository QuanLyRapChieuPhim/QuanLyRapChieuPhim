using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class KhachHang
    {
        public string MaKhachHang { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public string GioiTinh { get; set; }
        public string NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public string DiemTichLuy { get; set; }

        public KhachHang(string makhachhang, string ho, string ten, string gioitinh, string ngaysinh, string diachi, string email, string sdt, string diemtichluy)
        {
            MaKhachHang = makhachhang;
            Ho = ho;
            Ten = ten;
            GioiTinh = gioitinh;
            NgaySinh = ngaysinh;
            DiaChi = diachi;
            Email = email;
            SDT = sdt;
            DiemTichLuy = diemtichluy;
        }
    }
}
