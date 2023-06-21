using BUS;
using System;
using System.Windows.Forms;

namespace Nhom15_BaybyStore
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtSDT.Text == "" && txtMatKhau.Text == "")
            {
                txtSDT.Focus();
                MessageBox.Show("Vui lòng nhập tên tài khoản và mật khẩu");
            }
            else if (txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại");
                txtSDT.Focus();
            }
            else if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                txtMatKhau.Focus();
            }
            else if (txtMatKhau.Text != txtXacNhanMatKhau.Text)
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu lại");
                txtXacNhanMatKhau.Focus();
            }
            else
            {
                try
                {
                    DangKy_BUS.DangKy(txtSDT.Text, txtMatKhau.Text, txtHovaTen.Text);
                    MessageBox.Show("Đăng ký thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
