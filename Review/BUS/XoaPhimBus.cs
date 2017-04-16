using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

using DTO;
using DAL;

namespace BUS
{
    public class XoaPhimBus
    {
        public int Xoa_PhimBus(PhimDTO film)
        {
            try
            {
                return (new XoaPhimDAL().Xoa_PhimDAL(film));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
