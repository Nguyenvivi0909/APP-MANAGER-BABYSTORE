using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class QLKhachHang_BUS
    {
        public static void Insert_Cus(KhachHang_DTO customer)
        {
            QLKhachHang_DAL.Insert_Cus(customer);
        }
        public static void Delete_Cus(KhachHang_DTO customer)
        {
            QLKhachHang_DAL.Delete_Cus(customer);
        }
        public static void Update_Cus(KhachHang_DTO customer)
        {
            QLKhachHang_DAL.Update_Cus(customer);
        }
        public static DataTable Show_List_Cus()
        {
            return QLKhachHang_DAL.Show_List_Cus();
        }
        public static DataTable Show_List_Cus_Str(String str_cus)
        {
            return QLKhachHang_DAL.Show_List_Cus_String(str_cus);
        }
        public static string GetNewKH()
        {
            return QLKhachHang_DAL.GetNewKH();
        }
    }
}
