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
    public partial class CuaHang : Form
    {
        public CuaHang()
        {
            InitializeComponent();
        }

        private void CuaHang_Load(object sender, EventArgs e)
        {
            DataTable dt = QLCuaHang_BUS.Show_List_Store();
            dgvCuaHang.DataSource = dt;

            txtIDCH.Text = QLCuaHang_BUS.GetNewCH();
        }

        private void btnThemCuaHang_Click(object sender, EventArgs e)
        {
            CuaHang_DTO store = new CuaHang_DTO();
            store.Diachi = txtDiaChi.Text;
            store.IdQL = txtIDQuanLy.Text;

            QLCuaHang_BUS.Insert_Store(store);
            CuaHang_Load(sender, e);
        }

        private void btnXoaCuaHang_Click(object sender, EventArgs e)
        {
            CuaHang_DTO store = new CuaHang_DTO();
            store.IdCH = txtIDCH.Text;
            store.Diachi = txtDiaChi.Text;
            store.IdQL = txtIDQuanLy.Text;
            QLCuaHang_BUS.Update_Store(store);
            CuaHang_Load(sender, e);
        }

        private void btnSuaCuaHang_Click(object sender, EventArgs e)
        {
            CuaHang_DTO store = new CuaHang_DTO();
            store.IdCH = txtIDCH.Text;
            store.Diachi = txtDiaChi.Text;
            store.IdQL = txtIDQuanLy.Text;

            QLCuaHang_BUS.Update_Store(store);
            CuaHang_Load(sender, e);
        }

        private void dgvCuaHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvCuaHang.CurrentRow.Index;
            txtIDCH.Text = dgvCuaHang.Rows[i].Cells[0].Value.ToString();
            txtDiaChi.Text = dgvCuaHang.Rows[i].Cells[1].Value.ToString();
            txtIDQuanLy.Text = dgvCuaHang.Rows[i].Cells[2].Value.ToString();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtIDCH.Text = QLCuaHang_BUS.GetNewCH();
            txtIDQuanLy.Text = "";
            txtDiaChi.Text = "";
        }

        private void txtTmKiemCuaHang_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTmKiemCuaHang.Text))
            {
                DataTable dt = QLCuaHang_BUS.Search_Store(txtTmKiemCuaHang.Text);
                dgvCuaHang.DataSource = dt;
            }
            else
                CuaHang_Load(sender, e);
        }
    }
}
