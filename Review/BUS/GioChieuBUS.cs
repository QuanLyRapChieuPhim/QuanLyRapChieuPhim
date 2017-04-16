using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using DTO;
using DAL;

namespace BUS
{
    public class GioChieuBUS
    {
        public DataSet GetGioChieuBus(string sql)
        {
            try 
	        {	           	
                return (new GioChieuDAL().GetGioChieuDAL(sql));
	        }
	        catch (SqlException ex)
	        {		
		        throw ex;
	        }

        }
    }
}
