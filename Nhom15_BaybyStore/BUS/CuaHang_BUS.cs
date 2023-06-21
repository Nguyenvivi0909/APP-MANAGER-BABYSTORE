using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class CuaHang_BUS
    {
        public static List<string> GetListIdCH()
        {
            return CuaHang_DAL.GetListIdCH();
        }
    }
}
