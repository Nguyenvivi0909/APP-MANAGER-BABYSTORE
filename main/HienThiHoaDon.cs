using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace Nhom15_BaybyStore
{
    public partial class HienThiHoaDon : Form
    {
        public string idhd;
        public HienThiHoaDon(string id)
        {
            InitializeComponent();
            this.idhd = id;
        }

        private void HienThiHoaDon_Load(object sender, EventArgs e)
        {
            ViewHoaDon viewhd = ViewHoaDon_BUS.ViewHD(idhd);
            if (viewhd!= null)
            {
                dgvCTHoaDon.DataSource = ViewChiTietHoaDon_BUS.GetListChiTietHD(idhd);
                lbTenNhanVien.Text = viewhd.TenNV;
                lbTenKhachHang.Text = viewhd.TenKH;
                lbSdtKh.Text = (viewhd.Sdt).ToString();
                lbTongTien.Text = (viewhd.Tongtien).ToString();
                lbThanhToan.Text = (viewhd.Thanhtien).ToString();
                lbKhuyenMai.Text = (viewhd.Giamgia).ToString();
                lbNgaymua.Text = (viewhd.Ngaymua).ToString("dd/MM/yyyy");
                lbCuuhang.Text = (viewhd.DiaChi).ToString();
            }
        }
    }
}
