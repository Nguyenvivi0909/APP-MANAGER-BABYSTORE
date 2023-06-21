using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class QLNhanVien_BUS
    {
        public static DataTable GetSV()
        {
            return QLNhanVien_DAL.GetSV();
        }
        public static void Insert(NhanVien_DTO nv)
        {
            QLNhanVien_DAL.Insert(nv);
        }
        public static void Update(NhanVien_DTO nv)
        {
            QLNhanVien_DAL.Update(nv);
        }
        public static void Delete(NhanVien_DTO nv)
        {
            QLNhanVien_DAL.Delete(nv);
        }
        public static DataTable Find(string chuoitimkiem)
        {
            return QLNhanVien_DAL.Find(chuoitimkiem);
        }
        public static string GetNewNV()
        {
            return QLNhanVien_DAL.GetNewNV();
        }
        public static string GetIdNV(string sdt)
        {
            return QLNhanVien_DAL.GetIdNV(sdt);
        }

    }
}
