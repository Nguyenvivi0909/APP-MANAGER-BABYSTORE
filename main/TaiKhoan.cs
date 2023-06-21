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
    public partial class TaiKhoan : Form
    {
        public TaiKhoan()
        {
            InitializeComponent();
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            DataTable dt = QLTaiKhoan_BUS.Show_List_Account();
            dgvTaiKhoan.DataSource = dt;
        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            TaiKhoan_DTO account = new TaiKhoan_DTO();
            account.IdTK = txtTenTaiKhoan.Text;
            account.Matkhau = txtMatKhau.Text;
            account.IdLTK = cmbLoaiTaiKhoan.Text;

            QLTaiKhoan_BUS.Insert_Account(account);
            TaiKhoan_Load(sender, e);
        }

        private void btnXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            TaiKhoan_DTO account = new TaiKhoan_DTO();
            account.IdTK = txtTenTaiKhoan.Text;

            QLTaiKhoan_BUS.Delete_Account(account);
            TaiKhoan_Load(sender, e);
        }

        private void btnSuaTaiKhoan_Click(object sender, EventArgs e)
        {
            TaiKhoan_DTO account = new TaiKhoan_DTO();
            account.IdTK = txtTenTaiKhoan.Text;
            account.Matkhau = txtMatKhau.Text;
            account.IdLTK = cmbLoaiTaiKhoan.Text;

            QLTaiKhoan_BUS.Update_Account(account);
            TaiKhoan_Load(sender, e);
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvTaiKhoan.CurrentRow.Index;
            txtTenTaiKhoan.Text = dgvTaiKhoan.Rows[i].Cells[0].Value.ToString();
            txtMatKhau.Text = dgvTaiKhoan.Rows[i].Cells[1].Value.ToString();
            cmbLoaiTaiKhoan.Text = dgvTaiKhoan.Rows[i].Cells[2].Value.ToString();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cmbLoaiTaiKhoan.SelectedItem = 1;
            txtTenTaiKhoan.Text = "";
            txtMatKhau.Text = "";
        }

        private void txtTimKiemTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTimKiemTaiKhoan.Text))
            {
                DataTable dt = QLTaiKhoan_BUS.Search_Account(txtTimKiemTaiKhoan.Text);
                dgvTaiKhoan.DataSource = dt;
            }
            else
                TaiKhoan_Load(sender, e);
        }
    }
}
