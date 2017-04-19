using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class ThucAn
    {
        public string MaThucAn { get; set; }
        public string TenThucAn { get; set; }
        public string  DonVi { get; set; }
        public int DonGia { get; set; }
        public int Combo { get; set; }

        public ThucAn(string mathucan, string tenthucan, string donvi, int dongia, int combo)
        {
            MaThucAn = mathucan;
            TenThucAn = tenthucan;
            DonVi = donvi;
            DonGia = dongia;
            Combo = combo;
        }
    }
}
