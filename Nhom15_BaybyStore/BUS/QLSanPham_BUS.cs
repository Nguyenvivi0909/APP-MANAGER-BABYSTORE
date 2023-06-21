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
    public class QLSanPham_BUS
    {
        public static DataTable GetSP()
        {
            return QLSanPHam_DAL.GetSP();
        }
        public static void Insert(SanPham_DTO sp)
        {
            QLSanPHam_DAL.Insert(sp);
        }
        public static void Update(SanPham_DTO sp)
        {
            QLSanPHam_DAL.Update(sp);
        }
        public static void Delete(SanPham_DTO sp)
        {
            QLSanPHam_DAL.Delete(sp);
        }
        public static DataTable Find(string chuoiekt)
        {
            return QLSanPHam_DAL.Find(chuoiekt);
        }
        public static string GetNewSP()
        {
            return QLSanPHam_DAL.GetNewSP();
        }
    }
}
