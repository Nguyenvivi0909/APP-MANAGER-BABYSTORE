using BUS;
using DTO;
using FontAwesome.Sharp;
using System.Linq;
using System.Windows.Forms;

namespace Nhom15_BaybyStore
{
    public partial class KhachHang : Form
    {
        private string tenTaiKhoan;
        public KhachHang(string tenTaiKhoan)
        {
            this.tenTaiKhoan = tenTaiKhoan;
            InitializeComponent();
            HideSubMenu();
            HideChucNang();
            LoadSanPham();
        }
        #region Xử lý giao diện
        void HideSubMenu()
        {
            foreach (var pnl in pnlMenu.Controls.OfType<Panel>())
                pnl.Height = 50;
        }

        void HideChucNang()
        {
            foreach (var pnl in pnlChucNang.Controls.OfType<Panel>())
                pnl.Height = 50;
        }

        void ShowSubMenu(Panel pnl)
        {
            pnl.Height = pnl.Controls.OfType<IconButton>().Count() * 50 + 15;
        }

        private void btnDanhMuc_Click(object sender, System.EventArgs e)
        {
            HideSubMenu();
            LoadSanPham();
        }

        private void btnSuaNguCoc_Click(object sender, System.EventArgs e)
        {
            HideSubMenu();
            ShowSubMenu(pnlSua);
        }

        private void btnThoiTrang_Click(object sender, System.EventArgs e)
        {
            HideSubMenu();
            ShowSubMenu(pnlThoiTrang);
        }

        private void btnHocTap_Click(object sender, System.EventArgs e)
        {
            HideSubMenu();
            ShowSubMenu(pnlHocTap);
        }
        private void btnDangXuat_Click_1(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnQuanLyTaiKhoan_Click(object sender, System.EventArgs e)
        {
            HideChucNang();
            ShowSubMenu(pnlCacChucNang);
        }

        private void panel3_Click(object sender, System.EventArgs e)
        {
            HideChucNang();
        }
        #endregion

        void LoadSanPham()
        {
            dgvSanPham.DataSource = KhachHang_BUS.LoadSanPhamTrangKhachHang();
        }

        private void btnSua_Click(object sender, System.EventArgs e)
        {
            dgvSanPham.DataSource = KhachHang_BUS.LoadSanPhamTheoDanhMuc("DMSP001");
        }

        private void btnNguCoc_Click(object sender, System.EventArgs e)
        {
            dgvSanPham.DataSource = KhachHang_BUS.LoadSanPhamTheoDanhMuc("DMSP002");
        }

        private void btnBanhKeo_Click(object sender, System.EventArgs e)
        {
            dgvSanPham.DataSource = KhachHang_BUS.LoadSanPhamTheoDanhMuc("DMSP003");
        }

        private void btnThoiTrangSoSinh_Click(object sender, System.EventArgs e)
        {
            dgvSanPham.DataSource = KhachHang_BUS.LoadSanPhamTheoDanhMuc("DMSP004");
        }

        private void btnThoiTrangBeTrai_Click(object sender, System.EventArgs e)
        {
            dgvSanPham.DataSource = KhachHang_BUS.LoadSanPhamTheoDanhMuc("DMSP005");
        }

        private void btnThoiTrangBeGai_Click(object sender, System.EventArgs e)
        {
            dgvSanPham.DataSource = KhachHang_BUS.LoadSanPhamTheoDanhMuc("DMSP006");
        }

        private void btnSach_Click(object sender, System.EventArgs e)
        {
            dgvSanPham.DataSource = KhachHang_BUS.LoadSanPhamTheoDanhMuc("DMSP007");
        }

        private void btnDoChoiBeGai_Click(object sender, System.EventArgs e)
        {
            dgvSanPham.DataSource = KhachHang_BUS.LoadSanPhamTheoDanhMuc("DMSP008");
        }

        private void btnDoChoiBeTrai_Click(object sender, System.EventArgs e)
        {
            dgvSanPham.DataSource = KhachHang_BUS.LoadSanPhamTheoDanhMuc("DMSP009");
        }

        private void txtTimKiemSanPham_TextChanged(object sender, System.EventArgs e)
        {
            dgvSanPham.DataSource = KhachHang_BUS.TimKiemSanPham(txtTimKiemSanPham.Text);
        }

        private void btnThongTin_Click(object sender, System.EventArgs e)
        {
            ThongTinCaNhan thongTinCaNhan = new ThongTinCaNhan(tenTaiKhoan);
            thongTinCaNhan.ShowDialog();
        }

        private void btnGopY_Click(object sender, System.EventArgs e)
        {
            GopY gopY = new GopY(tenTaiKhoan);
            gopY.ShowDialog();
        }
        private void btnLichSu_Click(object sender, System.EventArgs e)
        {
            LichSuMuaHang lichSuMuaHang = new LichSuMuaHang(tenTaiKhoan);  
            lichSuMuaHang.ShowDialog();
        }
    }
}
