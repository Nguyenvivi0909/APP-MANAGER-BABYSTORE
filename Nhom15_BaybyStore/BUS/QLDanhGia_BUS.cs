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
    public class QLDanhGia_BUS
    {
        public static DataTable LoadDanhGia()
        {
            return QLDanhGia_DAL.LoadDanhGia();
        }
    }
}
