using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class DangNhap_BUS
    {
        public static string CheckTaiKhoan(string tenTaiKhoan, string matKhau, string IdLTK)
        {
            return DangNhap_DAL.CheckTaiKhoan(tenTaiKhoan, matKhau, IdLTK);
        }
    }
}
