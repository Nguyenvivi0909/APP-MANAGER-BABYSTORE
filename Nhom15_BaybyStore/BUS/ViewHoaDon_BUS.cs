using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class ViewHoaDon_BUS
    {
        public static ViewHoaDon ViewHD(string idhd)
        {
            return ViewHoaDon_DAL.ViewHD(idhd);
        }
        public static List<ViewHoaDon> ListViewHD()
        {
            return ViewHoaDon_DAL.ListViewHD();
        }
        public static List<ViewHoaDon> ListViewHDTheoTG(string tungay, string denngay)
        {
            return ViewHoaDon_DAL.ListViewHDTheoTG(tungay, denngay);
        }
        public static List<ViewHoaDon> ListViewHDTheoCH(string idch)
        {
            return ViewHoaDon_DAL.ListViewHDTheoCH(idch);

        }
        public static List<ViewHoaDon> ListViewHDTheoTGCH(string idch, string tungay, string denngay)
        {
            return ViewHoaDon_DAL.ListViewHDTheoTGCH(idch, tungay, denngay);
        }
    }
}
