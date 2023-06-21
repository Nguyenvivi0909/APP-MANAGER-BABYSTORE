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
    public partial class QLKhachHang : Form
    {
        public QLKhachHang()
        {
            InitializeComponent();
        }

        private void QLKhachHang_Load(object sender, EventArgs e)
        {
            DataTable dt = QLKhachHang_BUS.Show_List_Cus();
            dgvKhachHang.DataSource = dt;

            txtIDKhachHang.Text = QLKhachHang_BUS.GetNewKH();
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang_DTO customer = new KhachHang_DTO();
            customer.Hovaten = txtTenKhachHang.Text;
            customer.Diem = Convert.ToInt32(txtDiem.Text);
            customer.Sdt = txtSDTKhachHang.Text;
            QLKhachHang_BUS.Insert_Cus(customer);
            QLKhachHang_Load(sender, e);
        }

        private void btnXoaKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang_DTO customer = new KhachHang_DTO();
            customer.IdKH = txtIDKhachHang.Text;
            customer.Hovaten = txtTenKhachHang.Text;
            customer.Diem = Convert.ToInt32(txtDiem.Text);
            customer.Sdt = txtSDTKhachHang.Text;
            QLKhachHang_BUS.Delete_Cus(customer);
            QLKhachHang_Load(sender, e);
        }

        private void btnSuaKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang_DTO customer = new KhachHang_DTO();
            customer.IdKH = txtIDKhachHang.Text;
            customer.Hovaten = txtTenKhachHang.Text;
            customer.Diem = Convert.ToInt32(txtDiem.Text);
            customer.Sdt = txtSDTKhachHang.Text;
            QLKhachHang_BUS.Update_Cus(customer);
            QLKhachHang_Load(sender, e);
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvKhachHang.CurrentRow.Index;
            txtIDKhachHang.Text = dgvKhachHang.Rows[i].Cells[0].Value.ToString();
            txtTenKhachHang.Text = dgvKhachHang.Rows[i].Cells[1].Value.ToString();
            txtDiem.Text = dgvKhachHang.Rows[i].Cells[2].Value.ToString();
            txtSDTKhachHang.Text = dgvKhachHang.Rows[i].Cells[3].Value.ToString();
        }

        private void txtTimKiemKhachHang_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTimKiemKhachHang.Text))
            {
                DataTable dt = QLKhachHang_BUS.Show_List_Cus_Str(txtTimKiemKhachHang.Text);
                dgvKhachHang.DataSource = dt;
            }
            else
                QLKhachHang_Load(sender, e);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtIDKhachHang.Text = QLKhachHang_BUS.GetNewKH();
            txtSDTKhachHang.Text = "";
            txtTenKhachHang.Text = "";
            txtDiem.Text = "";
        }
    }
}
