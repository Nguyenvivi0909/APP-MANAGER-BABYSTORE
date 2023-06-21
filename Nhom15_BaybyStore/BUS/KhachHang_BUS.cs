using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class KhachHang_BUS
    {
        public static List<SanPhanTrangKhachHang_DTO> LoadSanPhamTrangKhachHang()
        {
            return KhachHang_DAL.LoadSanPhamTrangKhachHang();
        }

        public static List<SanPhanTrangKhachHang_DTO> LoadSanPhamTheoDanhMuc(string IdDM)
        {
            return KhachHang_DAL.LoadSanPhamTheoDanhMuc(IdDM);
        }

        public static List<SanPhanTrangKhachHang_DTO> TimKiemSanPham(string TenSP)
        {
            return KhachHang_DAL.TimKiemSanPham(TenSP);
        }

        public static KhachHang_DTO FindKH(string str)
        {
            return KhachHang_DAL.FindKH(str);
        }

        public static string GetIdKH(string str)
        {
            return KhachHang_DAL.GetIdKH(str);
        }

        public static void AddDiem(string idhd)
        {
            KhachHang_DAL.AddDiem(idhd);
        }
        public static KhachHang_DTO ThongTinCaNhan(String SDT)
        {
            return KhachHang_DAL.ThongTinCaNhan(SDT);
        }
        public static void Update(string HoTen, string SDT)
        {
            KhachHang_DAL.Update(HoTen, SDT);
        }
        public static List<ViewLichSu> LoadLichSuMuaHang(string tenTaiKhoan)
        {
            return KhachHang_DAL.LoadLichSuMuaHang(tenTaiKhoan);
        }
        public static void ThemDanhGia(string SDT, string noiDung)
        {
            KhachHang_DAL.ThemDanhGia(SDT, noiDung);
        }
    }
}
