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
    public partial class NhaCungCap : Form
    {
        public NhaCungCap()
        {
            InitializeComponent();
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            dgvNhaCungCap.DataSource = QLNhaCungCap_BUS.GetNCC();
            txtIDNhaCungCap.Text = QLNhaCungCap_BUS.GetNewNCC();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NhaCungCap_DTO nc = new NhaCungCap_DTO();
            nc.TenNCC = txtTenNhaCungCap.Text;
            nc.Diachi = txtDiaChi.Text;
            QLNhaCungCap_BUS.Insert(nc);
            NhaCungCap_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            NhaCungCap_DTO nc = new NhaCungCap_DTO();
            nc.IdNCC = txtIDNhaCungCap.Text;

            QLNhaCungCap_BUS.Delete(nc);
            NhaCungCap_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NhaCungCap_DTO nc = new NhaCungCap_DTO();
            nc.IdNCC = txtIDNhaCungCap.Text;
            nc.TenNCC = txtTenNhaCungCap.Text;
            nc.Diachi = txtDiaChi.Text;
            QLNhaCungCap_BUS.Update(nc);
            NhaCungCap_Load(sender, e);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtIDNhaCungCap.Text = QLNhaCungCap_BUS.GetNewNCC();
            txtTenNhaCungCap.Text = "";
            txtDiaChi.Text = "";
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string value = txtTimKiem.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = QLNhaCungCap_BUS.Find(value);
                dgvNhaCungCap.DataSource = dt;
            }
            else
                NhaCungCap_Load(sender, e);
        }

        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvNhaCungCap.CurrentRow.Index;
            txtIDNhaCungCap.Text = dgvNhaCungCap.Rows[i].Cells[0].Value.ToString();
            txtTenNhaCungCap.Text = dgvNhaCungCap.Rows[i].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvNhaCungCap.Rows[i].Cells[2].Value.ToString();
        }
    }
}
