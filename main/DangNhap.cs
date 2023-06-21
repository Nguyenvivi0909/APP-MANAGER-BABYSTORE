using BUS;
using System;
using System.Drawing;
using System.Windows.Forms;
using DTO;

namespace Nhom15_BaybyStore
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        private void txtTenTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtTenTaiKhoan.Text == "")
                {
                    txtTenTaiKhoan.Text = "Nhập tên tài khoản";
                    return;
                }
                txtTenTaiKhoan.ForeColor = Color.Black;
                panel5.Visible = false;
            }
            catch { }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtMatKhau.Text == "")
                {
                    txtMatKhau.Text = "Nhập mật khẩu";
                    return;
                }
                txtMatKhau.ForeColor = Color.Black;
                txtMatKhau.PasswordChar = '*';
                panel7.Visible = false;
            }
            catch { }
        }

        private void txtTenTaiKhoan_Click(object sender, EventArgs e)
        {
            txtTenTaiKhoan.SelectAll();
        }

        private void txtMatKhau_Click(object sender, EventArgs e)
        {
            txtMatKhau.SelectAll();
        }

        private void btnDangNhap_MouseEnter(object sender, EventArgs e)
        {
            btnDangNhap.ForeColor = Color.Black;
        }

        private void btnDangNhap_MouseLeave(object sender, EventArgs e)
        {
            btnDangNhap.ForeColor = Color.White;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string IdTK, Matkhau;
            IdTK = txtTenTaiKhoan.Text;
            Matkhau = txtMatKhau.Text;

            if (rdbKhachHang.Checked == true)
            {    
                string Message = DangNhap_BUS.CheckTaiKhoan(IdTK, Matkhau, "LTK1");
                if (Message == "Chào mừng bạn")
                {
                    MessageBox.Show(Message);
                    KhachHang khachHang = new KhachHang(txtTenTaiKhoan.Text);
                    khachHang.ShowDialog();
                }
                else
                    MessageBox.Show(Message);

            }
            if (rdbNhanVien.Checked == true)
            {
                string Message = DangNhap_BUS.CheckTaiKhoan(IdTK, Matkhau, "LTK2");
                if (Message == "Chào mừng bạn")
                {
                    MessageBox.Show(Message);
                    QuayBan quayBan = new QuayBan(IdTK);
                    quayBan.ShowDialog();
                }
                else
                    MessageBox.Show(Message);
            }
            if (rdbQuanLy.Checked == true)
            {
                string Message = DangNhap_BUS.CheckTaiKhoan(IdTK, Matkhau, "LTK3");
                if (Message == "Chào mừng bạn")
                {
                    MessageBox.Show(Message);
                    Home home = new Home();
                    home.ShowDialog();
                }
                else
                    MessageBox.Show(Message); ;
            }

            // Form
            if (txtTenTaiKhoan.Text == "Nhập tên tài khoản")
            {
                panel5.Visible = true;
                txtTenTaiKhoan.Focus();
                return;
            }
            if (txtMatKhau.Text == "Nhập mật khẩu")
            {
                panel7.Visible = true;
                txtMatKhau.Focus();
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dangKy = new DangKy();
            dangKy.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
