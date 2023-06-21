using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Nhom15_BaybyStore
{
    public partial class SanPham : Form
    {
        public SanPham()
        {
            InitializeComponent();
        }

        private void btnDoanhMuc_Click(object sender, EventArgs e)
        {
            DoanhMucSanPham doanhMucSanPham = new DoanhMucSanPham();
            doanhMucSanPham.Show();
        }
        private void btnDoanhMuc_MouseLeave(object sender, EventArgs e)
        {
            btnDoanhMuc.IconColor = Color.FromArgb(237, 61, 127);
            btnDoanhMuc.BackColor = Color.White;
        }

        private void btnDoanhMuc_MouseEnter(object sender, EventArgs e)
        {
            btnDoanhMuc.IconColor = Color.White;
            btnDoanhMuc.BackColor = Color.FromArgb(237, 61, 127);
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            NhaCungCap nhaCungCap = new NhaCungCap();
            nhaCungCap.Show();
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            sphethan_CheckedChanged(sender, e);
            dgvSanPham.DataSource = QLSanPham_BUS.GetSP();

            cmbDoanhMuc.DataSource = QLDoanhMucSanPham_BUS.GetDMSP();
            cmbDoanhMuc.DisplayMember = "IdDM";

            cmbNhaCungCap.DataSource = QLNhaCungCap_BUS.GetNCC();
            cmbNhaCungCap.DisplayMember = "IdNCC";

            txtIDSanPham.Text = QLSanPham_BUS.GetNewSP();
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            SanPham_DTO sp = new SanPham_DTO();
            sp.IdDM = cmbDoanhMuc.Text;
            sp.IdNCC = cmbNhaCungCap.Text;
            sp.TenSP = txtTenSanPham.Text;
            sp.NSX = dtpNSX.Value;
            sp.HSD = dtpHSD.Value;
            sp.Gia = int.Parse(txtGiaSanPham.Text);
            QLSanPham_BUS.Insert(sp);
            SanPham_Load(sender, e);
        }

        private void btnSuaSanPham_Click(object sender, EventArgs e)
        {
            SanPham_DTO sp = new SanPham_DTO();
            sp.IdSP = txtIDSanPham.Text;
            sp.IdDM = cmbDoanhMuc.Text;
            sp.IdNCC = cmbNhaCungCap.Text;
            sp.TenSP = txtTenSanPham.Text;
            sp.NSX = dtpNSX.Value;
            sp.HSD = dtpHSD.Value;
            sp.Gia = int.Parse(txtGiaSanPham.Text);
            QLSanPham_BUS.Update(sp);
            SanPham_Load(sender, e);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            string value = chuoitimkiem.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = QLSanPham_BUS.Find(value);
                dgvSanPham.DataSource = dt;
            }
            else
                btnLoc_Click(sender, e);
        }

        private void sphethan_CheckedChanged(object sender, EventArgs e)
        {
            if (sphethan.Checked == true)
            {
                chuoitimkiem.Visible = true;
                btnLoc.Visible = true;
                panel4.Visible = true;
                iconPictureBox1.Visible = true;
            }
            else
            {
                chuoitimkiem.Visible = false;
                btnLoc.Visible = false;
                panel4.Visible = false;
                iconPictureBox1.Visible = false;
            }
        }

        private void dgvSanPham_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvSanPham.CurrentRow.Index;
            txtIDSanPham.Text = dgvSanPham.Rows[i].Cells["IdSP"].Value.ToString();
            cmbDoanhMuc.Text = dgvSanPham.Rows[i].Cells["IdDM"].Value.ToString();
            cmbNhaCungCap.Text = dgvSanPham.Rows[i].Cells["IdNCC"].Value.ToString();
            txtTenSanPham.Text = dgvSanPham.Rows[i].Cells["TenSP"].Value.ToString();
            dtpNSX.Text = dgvSanPham.Rows[i].Cells["NSX"].Value.ToString();
            dtpHSD.Text = dgvSanPham.Rows[i].Cells["HSD"].Value.ToString();
            txtGiaSanPham.Text = dgvSanPham.Rows[i].Cells["Gia"].Value.ToString();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtIDSanPham.Text = QLSanPham_BUS.GetNewSP();
            txtTenSanPham.Text = "";
            txtGiaSanPham.Text = "";
            cmbDoanhMuc.SelectedItem = 1;
            cmbNhaCungCap.SelectedItem = 1;
        }

        private void txtTimKiemSanPham_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoaSanPham_Click(object sender, EventArgs e)
        {
            SanPham_DTO sp = new SanPham_DTO();
            sp.IdSP = txtIDSanPham.Text;

            QLSanPham_BUS.Delete(sp);
            SanPham_Load(sender, e);
        }
    }
}
