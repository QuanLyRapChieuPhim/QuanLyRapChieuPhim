using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

using DTO;

namespace DAL
{
    public class PhimDAL
    {
        private DataProvider dp;

        public PhimDAL()
        {
            dp = new DataProvider();
        }

        public List<PhimDTO> GetPhimDAL(string sql)
        {
            List<PhimDTO> list = new List<PhimDTO>();

            string maPhim, tenPhim, daoDien, quocGia, theLoai;
            int nam, thoiLuong;
            //byte[] hinhAnh;

            dp.Connect();
            try
            {
                SqlDataReader dr = dp.executeReader(sql);
                while (dr.Read())
                {
                    maPhim = dr.GetString(0);
                    tenPhim = dr.GetString(1);
                    daoDien = dr.GetString(2);
                    quocGia = dr.GetString(3);
                    nam = dr.GetInt32(4);
                    thoiLuong = dr.GetInt32(5);
                    theLoai = dr.GetString(6);
                    //hinhAnh = (byte[])dr["hinhAnh"];
                    PhimDTO film = new PhimDTO(maPhim, tenPhim, daoDien, quocGia, nam, thoiLuong, theLoai/*, hinhAnh*/);//-> gọi DTO, DTO lấy dữ liệu từ Data
                    list.Add(film);
                }
                return list;// trả về List đã có dữ liệu
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
    }
}
