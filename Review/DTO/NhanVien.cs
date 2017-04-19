using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string  Ho { get; set; }
        public string Ten { get; set; }
        public string NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        public int SoCMND { get; set; }
        public string DiaChi { get; set; }
        public int SDT { get; set; }
        public string Email { get; set; }
        public string ChucVu { get; set; }
        public string NgayVaoLam { get; set; }

        public NhanVien(string manv, string ho, string ten, string ngaysinh, bool gioitinh, int socmnd, string diachi, int sdt, string mail, string chucvu, string ngayvaolam)
        {
            MaNV = manv;
            Ho = ho;
            Ten = ten;
            NgaySinh = ngaysinh;
            GioiTinh = gioitinh;
            SoCMND = socmnd;
            DiaChi = diachi;
            SDT = sdt;
            Email = mail;
            ChucVu = chucvu;
            NgayVaoLam = ngayvaolam;
        }
    }
}
