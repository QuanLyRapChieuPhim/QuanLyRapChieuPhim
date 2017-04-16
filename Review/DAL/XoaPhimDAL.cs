using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

using DTO;

namespace DAL
{
    public class XoaPhimDAL
    {
        private DataProvider dp;

        public XoaPhimDAL()
        {
            dp = new DataProvider();
        }

        public int Xoa_PhimDAL(PhimDTO film)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@MaPhim", film.MaPhim));

            try
            {
                return (dp.executeNonQuery("XoaPhim", System.Data.CommandType.StoredProcedure, paras));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
