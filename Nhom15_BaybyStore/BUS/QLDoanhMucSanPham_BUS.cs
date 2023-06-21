using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class QLDoanhMucSanPham_BUS
    {
        public static DataTable GetDMSP()
        {
            return QLDoanhMucSanPham_DAL.GetDMSP();
        }
        public static void Insert(DanhMucSanPham_DTO dmsp)
        {
            QLDoanhMucSanPham_DAL.Insert(dmsp);
        }
        public static void Update(DanhMucSanPham_DTO dmsp)
        {
            QLDoanhMucSanPham_DAL.Update(dmsp);
        }
        public static void Delete(DanhMucSanPham_DTO dmsp)
        {
            QLDoanhMucSanPham_DAL.Delete(dmsp);
        }
        public static DataTable Find(string value)
        {
            return QLDoanhMucSanPham_DAL.Find(value);
        }
        public static string GetNewDMSP()
        {
            return QLDoanhMucSanPham_DAL.GetNewDMSP();
        }
    }
}
