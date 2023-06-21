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
    public partial class ThongTinCaNhan : Form
    {
        private string tenTaiKhoan;
        public ThongTinCaNhan(string tenTaiKhoan)
        {
            this.tenTaiKhoan = tenTaiKhoan;
            InitializeComponent();
            txtSDT.Text = tenTaiKhoan;
        }

        private void ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            KhachHang_DTO khachHang = new KhachHang_DTO();

            khachHang = KhachHang_BUS.ThongTinCaNhan(txtSDT.Text);
            txtHovaTen.Text = khachHang.Hovaten;
            txtĐiểm.Text = Convert.ToString(khachHang.Diem);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            KhachHang_BUS.Update(txtHovaTen.Text, txtSDT.Text);
            MessageBox.Show("Cập nhật thành công");
            ThongTinCaNhan_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
