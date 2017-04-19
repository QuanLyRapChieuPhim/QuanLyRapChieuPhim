using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

using DTO;

namespace DAL
{
    public class KhachHangDAL
    {
        DataProvider dp;
        public KhachHangDAL()
        {
            dp = new DataProvider();
        }

        public List<KhachHang> GetKhachHang(string sql)
        {
            try
            {
                dp.Connect();
                List<KhachHang> listKhachHang = new List<KhachHang>();
                SqlDataReader dr = dp.executeReader(sql);
                while (dr.Read())
                {
                    KhachHang khachhang = new KhachHang(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6), dr.GetString(7), dr.GetString(8));
                    listKhachHang.Add(khachhang);
                }

                return listKhachHang;
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally { dp.DisConnect(); };
        }

        public int add(KhachHang khachhang)
        {
            List<SqlParameter> listpar = new List<SqlParameter>();
            listpar.Add(new SqlParameter("@MaKhachHang", khachhang.MaKhachHang));
            listpar.Add(new SqlParameter("@Ho", khachhang.Ho));
            listpar.Add(new SqlParameter("@Ten", khachhang.Ten));
            listpar.Add(new SqlParameter("@GioiTinh", khachhang.GioiTinh));
            listpar.Add(new SqlParameter("@NgaySinh", khachhang.NgaySinh));
            listpar.Add(new SqlParameter("@DiaChi", khachhang.DiaChi));
            listpar.Add(new SqlParameter("@Email", khachhang.Email));
            listpar.Add(new SqlParameter("@SDT", khachhang.SDT));
            listpar.Add(new SqlParameter("@DiemTichLuy", khachhang.DiemTichLuy));
            try
            {
                return (dp.executeNonQuery("ThemKhachHang", System.Data.CommandType.StoredProcedure, listpar));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public int delete(KhachHang khachhang)
        {
            List<SqlParameter> listpar = new List<SqlParameter>();
            listpar.Add(new SqlParameter("@MaKhachHang", khachhang.MaKhachHang));
            try
            {
                return (dp.executeNonQuery("XoaKhachHang", System.Data.CommandType.StoredProcedure, listpar));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public int upDate(KhachHang khachhang)
        {
            List<SqlParameter> listpar = new List<SqlParameter>();
            listpar.Add(new SqlParameter("@MaKhachHang", khachhang.MaKhachHang));
            listpar.Add(new SqlParameter("@Ho", khachhang.Ho));
            listpar.Add(new SqlParameter("@Ten", khachhang.Ten));
            listpar.Add(new SqlParameter("@GioiTinh", khachhang.GioiTinh));
            listpar.Add(new SqlParameter("@NgaySinh", khachhang.NgaySinh));
            listpar.Add(new SqlParameter("@DiaChi", khachhang.DiaChi));
            listpar.Add(new SqlParameter("@Email", khachhang.Email));
            listpar.Add(new SqlParameter("@SDT", khachhang.SDT));
            listpar.Add(new SqlParameter("@DiemTichLuy", khachhang.DiemTichLuy));
            try
            {
                return (dp.executeNonQuery("SuaKhachHang", System.Data.CommandType.StoredProcedure, listpar));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
