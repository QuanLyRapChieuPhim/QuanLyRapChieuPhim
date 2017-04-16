using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

using DTO;

namespace DAL
{
    public class ThemPhimDAL
    {
        private DataProvider dp;

        public ThemPhimDAL()
        {
            dp = new DataProvider();
        }

        public int Them_PhimDAL(PhimDTO film)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@MaPhim", film.MaPhim));
            paras.Add(new SqlParameter("@TenPhim", film.TenPhim));
            paras.Add(new SqlParameter("@DaoDien", film.DaoDien));
            paras.Add(new SqlParameter("@QuocGia", film.QuocGia));
            paras.Add(new SqlParameter("@Nam", film.Nam));
            paras.Add(new SqlParameter("@ThoiLuong", film.ThoiLuong));
            paras.Add(new SqlParameter("@TheLoai", film.TheLoai));
            paras.Add(new SqlParameter("@HinhAnh", film.HinhAnh));

            try
            {
                return (dp.executeNonQuery("ThemPhim", System.Data.CommandType.StoredProcedure, paras));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
