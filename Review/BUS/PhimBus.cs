using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

using DAL;
using DTO;

namespace BUS
{
    public class PhimBus //class BUS được gọi
    {
        public List<PhimDTO> GetPhimBUS(string sql)// trả ngược về DAL có List đã có dữ liệu
        {
            try
            {
                return new PhimDAL().GetPhimDAL(sql);//  return-> gọi DAL -> class DAL thực thi.
            }
            catch (SqlException  ex)
            {
                throw ex;
            }
        }
    }
}
