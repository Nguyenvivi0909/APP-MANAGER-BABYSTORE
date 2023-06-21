using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    public class ViewChiTietHoaDon_BUS
    {
        public static ViewChiTietHoaDon_DTO GetChiTietHD(string idhd, string idsp)
        {
            return ViewChiTietHoaDon_DAL.GetChiTietHD(idhd, idsp);
        }
        public static List<ViewChiTietHoaDon_DTO> GetListChiTietHD(string idhd)
        {
            return ViewChiTietHoaDon_DAL.GetListChiTietHD(idhd);
        }
    }
}
