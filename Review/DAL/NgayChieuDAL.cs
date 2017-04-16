using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

using DTO;

namespace DAL
{
    public class NgayChieuDAL
    {
        private DataProvider dp;

        public NgayChieuDAL()
        {
            dp = new DataProvider();
        }

        public DataSet GetNgayChieuDAL(string sql)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, dp.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                dp.DisConnect();
            }
        }

        //public List<NgayChieuDTO> GetNgayChieuDAL(string sql)
        //{
        //    List<NgayChieuDTO> list = new List<NgayChieuDTO>();

        //    string ngayChieu, maPhimNgayChieu;

        //    dp.Connect();
        //    try
        //    {
        //        SqlDataReader dr = dp.executeReader(sql);
        //        while (dr.Read())
        //        {
        //            maPhimNgayChieu = dr.GetString(0);
        //            ngayChieu = dr.GetString(1);
        //            NgayChieuDTO ngaychieu = new NgayChieuDTO(maPhimNgayChieu, ngayChieu);
        //            list.Add(ngaychieu);
        //        }
        //        return list;
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        dp.DisConnect();
        //    }
        //}
    }
}
