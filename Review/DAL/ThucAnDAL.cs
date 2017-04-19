using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

using DTO;

namespace DAL
{
    public class ThucAnDAL
    {
        DataProvider dp;
        public ThucAnDAL()
        {
            dp = new DataProvider();
        }
        public List<ThucAn> GetThucAn(string sql)
        {
            try
            {
                dp.Connect();
                List<ThucAn> listThucAn = new List<ThucAn>();
                SqlDataReader dr = dp.executeReader(sql);
                while (dr.Read())
                {
                    ThucAn khachhang = new ThucAn(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetInt32(3), dr.GetInt32(4));
                    listThucAn.Add(khachhang);
                }

                return listThucAn;
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally { dp.DisConnect(); };
        }

        public int addThucAn(ThucAn thucan)
        {
            List<SqlParameter> listpar = new List<SqlParameter>();
            listpar.Add(new SqlParameter("@MaThucAn", thucan.MaThucAn));
            listpar.Add(new SqlParameter("@TenThucAn", thucan.TenThucAn));
            listpar.Add(new SqlParameter("@DonVi", thucan.DonVi));
            listpar.Add(new SqlParameter("@DonGia", thucan.DonGia));
            listpar.Add(new SqlParameter("@Combo", thucan.Combo));
            try
            {
                return (dp.executeNonQuery("ThemThucAn", System.Data.CommandType.StoredProcedure, listpar));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public int deleteThucAn(ThucAn thucan)
        {
            List<SqlParameter> listpar = new List<SqlParameter>();
            listpar.Add(new SqlParameter("@MaThucAn", thucan.MaThucAn));
            try
            {
                return (dp.executeNonQuery("XoaThucAn", System.Data.CommandType.StoredProcedure, listpar));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public int upDateThucAn(ThucAn thucan)
        {
            List<SqlParameter> listpar = new List<SqlParameter>();
            listpar.Add(new SqlParameter("@TenThucAn", thucan.TenThucAn));
            listpar.Add(new SqlParameter("@TenThucAn", thucan.TenThucAn));
            listpar.Add(new SqlParameter("@DonVi", thucan.DonVi));
            listpar.Add(new SqlParameter("@DonGia", thucan.DonGia));
            listpar.Add(new SqlParameter("@Combo", thucan.Combo));
            try
            {
                return (dp.executeNonQuery("SuaThucAn", System.Data.CommandType.StoredProcedure, listpar));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
