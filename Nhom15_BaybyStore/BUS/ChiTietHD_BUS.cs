using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class ChiTietHD_BUS
    {
        //public static ChiTietHD_DTO GetChiTietHD(string idhd, string idsp)
        //{
        //    return ChiTietHD_DAL.GetChiTietHD(idhd, idsp);
        //}
        //public static List<ChiTietHD_DTO> GetListChiTietHD(string idhd)
        //{
        //    return ChiTietHD_DAL.GetListChiTietHD(idhd);
        //}
        //public static void DeleteHD(string idhd, string idsp)
        //{
        //    ChiTietHD_DAL.DeleteHD(idhd, idsp);
        //}
        public static void InsertCTHD(ChiTietHD_DTO chiTietHD)
        {
            ChiTietHD_DAL.InsertCTHD(chiTietHD);
        }
        public static void DeleteCTHD(string idhd, string idsp)
        {
            ChiTietHD_DAL.DeleteCTHD(idhd, idsp);
        }
    }
}
