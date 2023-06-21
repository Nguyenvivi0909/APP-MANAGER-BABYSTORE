using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;

namespace BUS
{
    public class QLCaLam_BUS
    {
        public static DataTable GetCL()
        {
            return QLCaLam_DAL.GetCL();
        }
        public static void Insert(Ca_DTO cl)
        {
            QLCaLam_DAL.Insert(cl);
        }
        public static void Update(Ca_DTO cl)
        {
            QLCaLam_DAL.Update(cl);
        }
        public static void Delete(Ca_DTO cl)
        {
            QLCaLam_DAL.Delete(cl);
        }
        public static string GetNewCL()
        {
            return QLCaLam_DAL.GetNewCL();
        }
    }
}
