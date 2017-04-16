using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class NgayChieuDTO
    {
        public string MaPhimNgayChieu { get; set; }
        public string NgayChieu { get; set; }

        public NgayChieuDTO(string maPhimNgayCHieu, string ngayChieu)
        {
            MaPhimNgayChieu = maPhimNgayCHieu;
            NgayChieu = ngayChieu;
        }
    }
}
