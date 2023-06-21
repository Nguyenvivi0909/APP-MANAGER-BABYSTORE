using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class QLTaiKhoan_BUS
    {
        public static DataTable Show_List_Account()
        {
            return QLTaiKhoan_DAL.Show_List_Account();
        }
        public static DataTable Search_Account(String account)
        {
            return QLTaiKhoan_DAL.Search_Account(account);
        }
        public static void Insert_Account(TaiKhoan_DTO account)
        {
            QLTaiKhoan_DAL.Insert_Account(account);
        }
        public static void Delete_Account(TaiKhoan_DTO account)
        {
            QLTaiKhoan_DAL.Delete_Accout(account);
        }
        public static void Update_Account(TaiKhoan_DTO account)
        {
            QLTaiKhoan_DAL.Update_Account(account);
        }
    }
}
