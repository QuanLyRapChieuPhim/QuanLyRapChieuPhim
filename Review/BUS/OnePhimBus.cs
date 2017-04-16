using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DTO;
using DAL;

namespace BUS
{
    public class OnePhimBus
    {
        public PhimDTO GetOnePhimBUS(string maphim)
        {
            return (new OnePhimDAL().GetOnePhimDAL(maphim));
        }
    }
}
