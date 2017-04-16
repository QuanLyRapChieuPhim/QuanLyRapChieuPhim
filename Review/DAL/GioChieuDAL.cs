using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using DTO;

namespace DAL
{
	public class GioChieuDAL
	{
        private DataProvider dp;

        public GioChieuDAL()
        {
            dp = new DataProvider();
        }

        public DataSet GetGioChieuDAL(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, dp.cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
	}
}
