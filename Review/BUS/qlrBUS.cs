using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

using DTO;
using DAL;

namespace BUS
{
    public class qlrBUS
    {
        public List<KhachHang> GetKhachHang(string sql)
        {
            try
            {
                KhachHangDAL khachhangDAL = new KhachHangDAL();
                return khachhangDAL.GetKhachHang(sql);
            }
            catch (SqlException ex)
            {
                
                throw ex;
            }
        }

        public List<NhanVien> GetNhanVien(string sql)
        {
            try
            {
                NhanVienDAL nhanvienDAL = new NhanVienDAL();
                return nhanvienDAL.GetNhanVien(sql);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public List<ThucAn> GetThucAn(string sql)
        {
            try
            {
                ThucAnDAL thucanDAL = new ThucAnDAL();
                return thucanDAL.GetThucAn(sql);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public int add(KhachHang khachhang)
        {
            try
            {
                KhachHangDAL khachhangDAL = new KhachHangDAL();
                return khachhangDAL.add(khachhang);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public int addNhanVien(NhanVien nhanvien)
        {
            try
            {
                NhanVienDAL nhanvienDAL = new NhanVienDAL();
                return nhanvienDAL.addNhanVien(nhanvien);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public int addThucAn(ThucAn thucan)
        {
            try
            {
                ThucAnDAL thucanDAL = new ThucAnDAL();
                return thucanDAL.addThucAn(thucan);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public int delNhanVien(NhanVien nhanvien)
        {
            try
            {
                NhanVienDAL nhanvienDAL = new NhanVienDAL();
                return nhanvienDAL.deleteNhanVien(nhanvien);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public int del(KhachHang khachhang)
        {
            try
            {
                KhachHangDAL khachhangDAL= new KhachHangDAL();
                return khachhangDAL.delete(khachhang);
            }
            catch (SqlException ex)
            {
                
                throw ex;
            }
        }

        public int delThucAn(ThucAn thucan)
        {
            try
            {
                ThucAnDAL thucanDAL = new ThucAnDAL();
                return thucanDAL.deleteThucAn(thucan);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public int upDate(KhachHang khachhang)
        {
            try
            {
                KhachHangDAL khachhangDAL = new KhachHangDAL();
                return khachhangDAL.upDate(khachhang);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public int upDateThucAn(ThucAn thucan)
        {
            try
            {
                ThucAnDAL thucanDAL = new ThucAnDAL();
                return thucanDAL.upDateThucAn(thucan);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public int upDateNhanVien(NhanVien nhanvien)
        {
            try
            {
                NhanVienDAL nhanvienDAL = new NhanVienDAL();
                return nhanvienDAL.upDateNhanVien(nhanvien);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
