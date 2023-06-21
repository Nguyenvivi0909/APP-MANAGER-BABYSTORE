using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    public class QLCuaHang_BUS
    {
        public static DataTable Show_List_Store()
        {
            return QLCuaHang_DAL.Show_List_Store();
        }
        public static void Insert_Store(CuaHang_DTO store)
        {
            QLCuaHang_DAL.Insert_Store(store);
        }
        public static void Update_Store(CuaHang_DTO store)
        {
            QLCuaHang_DAL.Update_Store(store);
        }
        public static DataTable Search_Store(String str)
        {
            return QLCuaHang_DAL.Search_Store(str);
        }
        public static string GetNewCH()
        {
            return QLCuaHang_DAL.GetNewCH();
        }
    }
}
