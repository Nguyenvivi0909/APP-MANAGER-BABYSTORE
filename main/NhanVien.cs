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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        private void btnCaLam_Click(object sender, EventArgs e)
        {
            CaLam caLam = new CaLam();
            caLam.Show();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            DataTable dt = QLNhanVien_BUS.GetSV();
            dgvNhanVien.DataSource = dt;

            cmbCaLam.DataSource = QLCaLam_BUS.GetCL();
            cmbCaLam.DisplayMember = "IdCa";

            cmbCuaHang.DataSource = QLCuaHang_BUS.Show_List_Store();
            cmbCuaHang.DisplayMember = "IdCH";

            txtIDNhanVien.Text = QLNhanVien_BUS.GetNewNV();
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.Hovaten = txtTenNhanVien.Text;
            nv.Ngaysinh = (dtpNgaySinh.Value);
            nv.Diachi = txtDiaChi.Text;
            if (rdbNu.Checked)
            {
                nv.Gioitinh = true;
            }
            else
            {
                nv.Gioitinh = false;
            }
            nv.Sdt = txtSDTNhanVien.Text;
            nv.Luong = int.Parse(txtLuong.Text);
            nv.IdCH = cmbCuaHang.Text;
            nv.IdCa = cmbCaLam.Text;
            QLNhanVien_BUS.Insert(nv);
            NhanVien_Load(sender, e);
        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.IdNV = txtIDNhanVien.Text;

            QLNhanVien_BUS.Delete(nv);
            NhanVien_Load(sender, e);
        }

        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.IdNV = txtIDNhanVien.Text;
            nv.Hovaten = txtTenNhanVien.Text;
            nv.Ngaysinh = (dtpNgaySinh.Value);
            nv.Diachi = txtDiaChi.Text;
            nv.Sdt = txtSDTNhanVien.Text;
            nv.Luong = int.Parse(txtLuong.Text);
            nv.IdCH = cmbCuaHang.Text;
            nv.IdCa = cmbCaLam.Text;
            QLNhanVien_BUS.Update(nv);
            NhanVien_Load(sender, e);
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int i = dgvNhanVien.CurrentRow.Index;
            txtIDNhanVien.Text = dgvNhanVien.Rows[i].Cells[0].Value.ToString();
            txtTenNhanVien.Text = dgvNhanVien.Rows[i].Cells[1].Value.ToString();
            dtpNgaySinh.Text = dgvNhanVien.Rows[i].Cells[2].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.Rows[i].Cells[3].Value.ToString();
            if (dgvNhanVien.Rows[i].Cells[4].Value.ToString() == "Nam")
            {
                rdbNam.Checked = true;
            }
            else
                rdbNu.Checked = true;
            txtSDTNhanVien.Text = dgvNhanVien.Rows[i].Cells[5].Value.ToString();
            txtLuong.Text = dgvNhanVien.Rows[i].Cells[6].Value.ToString();
            cmbCuaHang.Text = dgvNhanVien.Rows[i].Cells[7].Value.ToString();
            cmbCaLam.Text = dgvNhanVien.Rows[i].Cells[8].Value.ToString();
        }

        private void txtTimKiemNhanVien_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTimKiemNhanVien.Text))
            {
                DataTable dt = QLNhanVien_BUS.Find(txtTimKiemNhanVien.Text);
                dgvNhanVien.DataSource = dt;
            }
            else
                NhanVien_Load(sender, e);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtIDNhanVien.Text = QLNhanVien_BUS.GetNewNV();
            txtTenNhanVien.Text = "";
            txtDiaChi.Text = "";
            txtSDTNhanVien.Text = "";
            txtLuong.Text = "";
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
