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
    public partial class LichSuMuaHang : Form
    {
        private string tenTaiKhoan;
        public LichSuMuaHang(string tenTaiKhoan)
        {
            this.tenTaiKhoan = tenTaiKhoan;
            InitializeComponent();
        }

        private void LichSuMuaHang_Load(object sender, EventArgs e)
        {
            KhachHang_DTO khachHang = new KhachHang_DTO();

            khachHang = KhachHang_BUS.ThongTinCaNhan(tenTaiKhoan);
            lblTenKhachHang.Text = khachHang.Hovaten;

            dgvLichSu.DataSource = KhachHang_BUS.LoadLichSuMuaHang(tenTaiKhoan);
        }

        private void dgvLichSu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvLichSu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = dgvLichSu.CurrentRow.Index;
            HienThiHoaDon hienThiHoaDon = new HienThiHoaDon(dgvLichSu.Rows[i].Cells[0].Value.ToString());
            hienThiHoaDon.ShowDialog();
        }
    }
}
