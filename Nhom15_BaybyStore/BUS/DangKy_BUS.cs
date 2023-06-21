using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    public class DangKy_BUS
    {
        public static void DangKy(string tenTaiKhoan, string matKhau, string hoTen)
        {
            try
            {
                DangKy_DAL.DangKy(tenTaiKhoan, matKhau, hoTen);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
