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
    public partial class GopY : Form
    {
        private string tenTaiKhoan;
        public GopY(string tenTaiKhoan)
        {
            this.tenTaiKhoan = tenTaiKhoan;
            InitializeComponent();
        }

        private void GopY_Load(object sender, EventArgs e)
        {
            KhachHang_DTO khachHang = new KhachHang_DTO();

            khachHang = KhachHang_BUS.ThongTinCaNhan(tenTaiKhoan);
            txtHovaTen.Text = khachHang.Hovaten;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGopY_Click(object sender, EventArgs e)
        {
            KhachHang_BUS.ThemDanhGia(tenTaiKhoan,txtNoiDung.Text);
            MessageBox.Show("Cảm ơn bạn đã đánh giá !");
        }
    }
}
