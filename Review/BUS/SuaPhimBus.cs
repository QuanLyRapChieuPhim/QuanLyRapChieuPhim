using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

using DTO;
using DAL;

namespace BUS
{
    public class SuaPhimBus
    {
        public int Sua_PhimBus(PhimDTO film)
        {
            try
            {
                return (new SuaPhimDAL().Sua_PhimDAL(film));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
