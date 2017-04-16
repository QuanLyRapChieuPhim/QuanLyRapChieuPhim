using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class PhimDTO
    {
        public string MaPhim { get; set; }
        public string TenPhim { get; set; }
        public string DaoDien { get; set; }
        public string QuocGia { get; set; }
        public int Nam { get; set; }
        public int ThoiLuong { get; set; }
        public string TheLoai { get; set; }
        public byte[] HinhAnh { get; set; }

        public PhimDTO(string maPhim, string tenPhim, string daoDien, string quocGia, int nam, int thoiLuong, string theLoai, byte[] hinhAnh)
        {
            MaPhim = maPhim;
            TenPhim = tenPhim;
            DaoDien = daoDien;
            QuocGia = quocGia;
            Nam = nam;
            ThoiLuong = thoiLuong;
            TheLoai = theLoai;
            HinhAnh = hinhAnh;
        }

        public PhimDTO(string maPhim, string tenPhim, string daoDien, string quocGia, int nam, int thoiLuong, string theLoai)
        {
            MaPhim = maPhim;
            TenPhim = tenPhim;
            DaoDien = daoDien;
            QuocGia = quocGia;
            Nam = nam;
            ThoiLuong = thoiLuong;
            TheLoai = theLoai;
        }

        public PhimDTO()
        {

        }
    }
}
