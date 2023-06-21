using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace Nhom15_BaybyStore
{
    public partial class QuayBan : Form
    {
        private HoaDon_DTO hdDTO = new HoaDon_DTO();
        private KhachHang_DTO khDTO = new KhachHang_DTO();
        private SanPham_DTO sp_DTO = new SanPham_DTO();
        private ChiTietHD_DTO ctHD = new ChiTietHD_DTO();
        private String sdtNV;
        int tongtien = 0;
        int indexhd;

        public QuayBan(string sdtnv)
        {
            InitializeComponent();
            this.sdtNV = sdtnv;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                txtTongTien.Text = "";
                txtTenKH.Text = "";
                txtGiamGia.Text = "";
                txtSDTKhachHang.Text = "";
                txtTenSanPham.Text = "";
                txtThanhTien.Text = "";
                txtTimKiemSP.Text = "";
                txtSoLuong.Text = "";
                txtTenKH.Text = "";
                //mt
                btnThemHD.Enabled = true;
                int i=0;
                while (dgvHoaDon.Rows.Count>1)
                {
                    dgvHoaDon.Rows.RemoveAt(i);
                }

                HoaDon_BUS.UpdateHD(hdDTO.IdHD);
                if (txtDiemSD.Text =="")
                    KhachHang_BUS.AddDiem(hdDTO.IdHD);
                HienThiHoaDon hienThiHoaDon = new HienThiHoaDon(hdDTO.IdHD);
                hienThiHoaDon.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: {0}" + ex);
            }
        }

        private void QuayBan_Load(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = SanPham_BUS.LoadSanPham();
            hdDTO.IdNV = QLNhanVien_BUS.GetIdNV(sdtNV);
            //mt
            txtTongTien.Enabled = false;
            txtThanhTien.Enabled = false;
        }

        private void txtTimKiemSP_TextChanged(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = SanPham_BUS.FindSP(txtTimKiemSP.Text);
        }

        private void txtSDTKhachHang_TextChanged(object sender, EventArgs e)
        {
            khDTO = KhachHang_BUS.FindKH(txtSDTKhachHang.Text);
            if (khDTO != null)
            {
                txtTenKH.Text = khDTO.Hovaten;
                hdDTO.IdKH = khDTO.IdKH;
            }
            else txtTenKH.Text = "Không tìm thấy!!";
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvSanPham.CurrentCell.RowIndex;
            txtTenSanPham.Text = dgvSanPham.Rows[index].Cells[1].Value.ToString();
            ctHD.IdSP = dgvSanPham.Rows[index].Cells[0].Value.ToString();
        }

        private void btnThemGiohang_Click(object sender, EventArgs e)
        {
            try
            {
                ctHD.IdHD = hdDTO.IdHD;
                ctHD.Soluong = Convert.ToInt32(txtSoLuong.Text);
                ChiTietHD_BUS.InsertCTHD(ctHD);

                ViewChiTietHoaDon_DTO chiTietHD_DTO = ViewChiTietHoaDon_BUS.GetChiTietHD(ctHD.IdHD, ctHD.IdSP);
                dgvHoaDon.Rows.Add(chiTietHD_DTO.IdSP, chiTietHD_DTO.TenSP, chiTietHD_DTO.Soluong, chiTietHD_DTO.Gia, chiTietHD_DTO.Thanhtien);

                txtTenSanPham.Text = "";
                txtSoLuong.Text = "";

                tongtien += chiTietHD_DTO.Thanhtien;
                txtTongTien.Text = tongtien.ToString();

                chiTietHD_DTO = new ViewChiTietHoaDon_DTO();
                ctHD = new ChiTietHD_DTO();
                txtThanhTien.Text = txtTongTien.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thiếu thông tin, Vui lòng kiểm tra lại!","Thông báo");
            }
            
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            try
            {
                HoaDon_BUS.InsertHD(hdDTO.IdKH, hdDTO.IdNV);
                hdDTO.IdHD = HoaDon_BUS.GetIdHD();
                txtIdHD.Text = hdDTO.IdHD;
                dgvSanPham.Enabled = true;
                txtSoLuong.Enabled = true;
                txtTenSanPham.Enabled = true;
                btnThemGiohang.Enabled = true;
             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: {0}" + ex);
                
            }

        }
      
        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexhd = dgvHoaDon.CurrentCell.RowIndex;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string idsp = dgvHoaDon.Rows[indexhd].Cells[0].Value.ToString();
                ChiTietHD_BUS.DeleteCTHD(hdDTO.IdHD, idsp);
                dgvHoaDon.Rows.RemoveAt(indexhd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thiếu thông tin, Vui lòng kiểm tra lại!", "Thông báo");
            }
        }
       
        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int giamgia = 0;
            if (txtGiamGia.Text != "")
            {
                giamgia = Convert.ToInt32(txtGiamGia.Text);
                GiamGia_BUS.AddGiamGia(hdDTO.IdHD, giamgia);
                int thanhtien = Convert.ToInt32(tongtien * (1 - giamgia * 0.01));
                txtThanhTien.Text = thanhtien.ToString();
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thiếu thông tin, Vui lòng kiểm tra lại!", "Thông báo");
            }
        }

        private void btnSDDiem_Click(object sender, EventArgs e)
        {
            try
            {
                int diem = Convert.ToInt32(txtDiemSD.Text);
                if (GiamGia_BUS.CheckSDDiem(hdDTO.IdHD, diem) == 0)
                    MessageBox.Show("Điểm của bạn không đủ để thực hiện thao tác này", "Thông báo");
                else
                    GiamGia_BUS.AddSDDiem(hdDTO.IdHD, diem);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thiếu thông tin, Vui lòng kiểm tra lại!", "Thông báo");
            }

        }
    }
}
