using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

using DTO;
using DAL;

namespace BUS
{
    public class NgayChieuBUS
    {
        //public List<NgayChieuDTO> GetNgayChieuBUS(string sql)
        //{
        //    try
        //    {
        //        return (new NgayChieuDAL().GetNgayChieuDAL(sql));
        //    }
        //    catch (SqlException ex)
        //    {                
        //        throw ex;
        //    }
        //}
        public DataSet GetNgayChieuBUS(string sql)
        {
            try
            {
                return (new NgayChieuDAL().GetNgayChieuDAL(sql));
            }
            catch (SqlException ex)
            {                
                throw ex;
            }
        }
    }
}
