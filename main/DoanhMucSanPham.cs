using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom15_BaybyStore
{
    public partial class DoanhMucSanPham : Form
    {
        public DoanhMucSanPham()
        {
            InitializeComponent();
        }

        private void btnThemDoanhMuc_Click(object sender, EventArgs e)
        {
            DanhMucSanPham_DTO dm = new DanhMucSanPham_DTO();
            dm.TenDM = txtTenDoanhMuc.Text;
            QLDoanhMucSanPham_BUS.Insert(dm);
            DoanhMucSanPham_Load(sender, e);
        }

        private void btnSuaDoanhMuc_Click(object sender, EventArgs e)
        {
            DanhMucSanPham_DTO dm = new DanhMucSanPham_DTO();
            dm.IdDM = txtIDDoanhMuc.Text;
            dm.TenDM = txtTenDoanhMuc.Text;

            QLDoanhMucSanPham_BUS.Update(dm);
            DoanhMucSanPham_Load(sender, e);
        }

        private void btnXoaDoanhMuc_Click(object sender, EventArgs e)
        {
            DanhMucSanPham_DTO dm = new DanhMucSanPham_DTO();
            dm.IdDM = txtIDDoanhMuc.Text;

            QLDoanhMucSanPham_BUS.Delete(dm);
            DoanhMucSanPham_Load(sender, e);
        }

        private void txtTimKiemDoanhMuc_TextChanged(object sender, EventArgs e)
        {
            string value = txtTimKiemDoanhMuc.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = QLDoanhMucSanPham_BUS.Find(value);
                dgvDoanhMuc.DataSource = dt;
            }
            else
                DoanhMucSanPham_Load(sender, e);
        }

        private void dgvDoanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvDoanhMuc.CurrentRow.Index;
            txtIDDoanhMuc.Text = dgvDoanhMuc.Rows[i].Cells[0].Value.ToString();
            txtTenDoanhMuc.Text = dgvDoanhMuc.Rows[i].Cells[1].Value.ToString();
        }

        private void DoanhMucSanPham_Load(object sender, EventArgs e)
        {
            dgvDoanhMuc.DataSource = QLDoanhMucSanPham_BUS.GetDMSP();
            txtIDDoanhMuc.Text = QLDoanhMucSanPham_BUS.GetNewDMSP();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtIDDoanhMuc.Text = QLDoanhMucSanPham_BUS.GetNewDMSP();
            txtTenDoanhMuc.Text = "";
        }
    }
}
