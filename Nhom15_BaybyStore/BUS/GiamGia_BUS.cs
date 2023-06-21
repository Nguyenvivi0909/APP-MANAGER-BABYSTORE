using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUS
{
    public class GiamGia_BUS
    {
        public static void AddGiamGia(string idhd, int giamgia)
        {
            GiamGia_DAL.AddGiamGia(idhd, giamgia);
        }
        public static void AddSDDiem(string idhd, int diem)
        {
            GiamGia_DAL.AddSDDiem(idhd, diem);
        }
        public static int CheckSDDiem(string idhd, int diem)
        {
            return GiamGia_DAL.CheckSDDiem(idhd, diem);
        }

    }
}
