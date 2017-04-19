using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

using DTO;

namespace DAL
{
    public class NhanVienDAL
    {
        DataProvider dp;
        public NhanVienDAL()
        {
            dp = new DataProvider();
        }

        public List<NhanVien> GetNhanVien(string sql)
        {
            try
            {
                dp.Connect();
                List<NhanVien> listNhanVien = new List<NhanVien>();
                SqlDataReader dr = dp.executeReader(sql);
                string manv, ho, ten, ngaysinh, diachi, mail, chucvu, ngayvaolam;
                int socmnd, sdt;
                bool gioitinh;
                while (dr.Read())
                {
                    manv = dr.GetString(0);
                    ho = dr.GetString(1);
                    ten = dr.GetString(2);
                    ngaysinh = dr.GetString(3);
                    gioitinh = dr.GetBoolean(4);
                    socmnd = dr.GetInt32(5);
                    diachi = dr.GetString(6);
                    sdt = dr.GetInt32(7);
                    mail = dr.GetString(8);
                    chucvu = dr.GetString(9);
                    ngayvaolam = dr.GetString(10);
                    NhanVien nhanvien = new NhanVien(manv, ho, ten, ngaysinh, gioitinh, socmnd, diachi, sdt, mail, chucvu, ngayvaolam);
                    listNhanVien.Add(nhanvien);
                }

                return listNhanVien;
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally { dp.DisConnect(); };
        }

        public int addNhanVien(NhanVien nhanvien)
        {
            List<SqlParameter> listpar = new List<SqlParameter>();
            listpar.Add(new SqlParameter("@MaNV", nhanvien.MaNV));
            listpar.Add(new SqlParameter("@Ho", nhanvien.Ho));
            listpar.Add(new SqlParameter("@Ten", nhanvien.Ten));
            listpar.Add(new SqlParameter("@GioiTinh", nhanvien.GioiTinh));
            listpar.Add(new SqlParameter("@NgaySinh", nhanvien.NgaySinh));
            listpar.Add(new SqlParameter("@DiaChi", nhanvien.DiaChi));
            listpar.Add(new SqlParameter("@Email", nhanvien.Email));
            listpar.Add(new SqlParameter("@SDT", nhanvien.SDT));
            listpar.Add(new SqlParameter("@ChucVu", nhanvien.ChucVu));
            listpar.Add(new SqlParameter("@NgayVaoLam", nhanvien.NgayVaoLam));
            listpar.Add(new SqlParameter("@CMND", nhanvien.SoCMND));
            try
            {
                return (dp.executeNonQuery("ThemNhanVien", System.Data.CommandType.StoredProcedure, listpar));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public int deleteNhanVien(NhanVien nhanvien)
        {
            List<SqlParameter> listpar = new List<SqlParameter>();
            listpar.Add(new SqlParameter("@MaNV", nhanvien.MaNV));
            try
            {
                return (dp.executeNonQuery("XoaNhanVien", System.Data.CommandType.StoredProcedure, listpar));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public int upDateNhanVien(NhanVien nhanvien)
        {
            List<SqlParameter> listpar = new List<SqlParameter>();
            listpar.Add(new SqlParameter("@MaNV", nhanvien.MaNV));
            listpar.Add(new SqlParameter("@Ho", nhanvien.Ho));
            listpar.Add(new SqlParameter("@Ten", nhanvien.Ten));
            listpar.Add(new SqlParameter("@GioiTinh", nhanvien.GioiTinh));
            listpar.Add(new SqlParameter("@NgaySinh", nhanvien.NgaySinh));
            listpar.Add(new SqlParameter("@DiaChi", nhanvien.DiaChi));
            listpar.Add(new SqlParameter("@Email", nhanvien.Email));
            listpar.Add(new SqlParameter("@SDT", nhanvien.SDT));
            listpar.Add(new SqlParameter("@ChucVu", nhanvien.ChucVu));
            listpar.Add(new SqlParameter("@NgayVaoLam", nhanvien.NgayVaoLam));
            listpar.Add(new SqlParameter("@CMND", nhanvien.SoCMND));
            try
            {
                return (dp.executeNonQuery("SuaNhanVien", System.Data.CommandType.StoredProcedure, listpar));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
