using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class HoaDon_BUS
    {
        public static void InsertHD(string idkh, string idnv)
        {
            Hoadon_DAL.InsertHD(idkh,idnv);
        }
        public static string GetIdHD()
        {
            return Hoadon_DAL.GetIdHD();
        }
        public static void UpdateHD(string idhd)
        {
            Hoadon_DAL.UpdateHD(idhd);
        }


    }
}
