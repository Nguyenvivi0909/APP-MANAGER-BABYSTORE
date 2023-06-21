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
    public class QLNhaCungCap_BUS
    {
        public static DataTable GetNCC()
        {
            return QLNhaCungCap_DAL.GetNCC();
        }
        public static void Insert(NhaCungCap_DTO ncc)
        {
            QLNhaCungCap_DAL.Insert(ncc);
        }
        public static void Update(NhaCungCap_DTO ncc)
        {
            QLNhaCungCap_DAL.Update(ncc);
        }
        public static void Delete(NhaCungCap_DTO ncc)
        {
            QLNhaCungCap_DAL.Delete(ncc);
        }
        public static DataTable Find(string value)
        {
            return QLNhaCungCap_DAL.Find(value);
        }
        public static string GetNewNCC()
        {
            return QLNhaCungCap_DAL.GetNewNCC();
        }
    }
}
