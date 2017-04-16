using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

using DTO;
using DAL;

namespace BUS
{
    public class ThemPhimBus
    {
        public int Them_PhimBus(PhimDTO film)
        {
            try
            {
                return (new ThemPhimDAL().Them_PhimDAL(film));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
