using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class DoanhSo_BUS
    {
        public static int DoanhSo()
        {
            return DoanhSo_DAL.DoanhSo();
        }
        public static int DoanhSoTheoTG(string tungay, string denngay)
        {
            return DoanhSo_DAL.DoanhSoTheoTG(tungay, denngay);
        }
        public static int DoanhSoTheoCH(string idch)
        {
            return DoanhSo_DAL.DoanhSoTheoCH(idch);
        }
        public static int DoanhSoTheoCHTG(string idch, string tungay, string denngay)
        {
            return DoanhSo_DAL.DoanhSoTheoCHTG(idch, tungay, denngay);
        }
    }
}
