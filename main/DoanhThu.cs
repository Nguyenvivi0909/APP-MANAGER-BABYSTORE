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
    public partial class DoanhThu : Form
    {
        public DoanhThu()
        {
            InitializeComponent();
        }

        public void All()
        {
            dgvListHD.DataSource = ViewHoaDon_BUS.ListViewHD();
            lbdoanhso.Text = DoanhSo_BUS.DoanhSo().ToString();
        }
        public void ClearAll()
        {
            dgvListHD.DataSource = null;
            lbdoanhso.Text = "0";
        }

        private void DoanhThu_Load(object sender, EventArgs e)
        {
            cbbCuahang.DataSource = CuaHang_BUS.GetListIdCH();
            All();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            string tungay = dttungay.Value.ToString("yyyyMMdd");
            string denngay = dtdenngay.Value.ToString("yyyyMMdd");
            if (checkAll.Checked == true)
            {
                dgvListHD.DataSource = ViewHoaDon_BUS.ListViewHDTheoTG(tungay, denngay);
                lbdoanhso.Text = DoanhSo_BUS.DoanhSoTheoTG(tungay, denngay).ToString();
            }
            else
            {
                string idch = cbbCuahang.Text;
                dgvListHD.DataSource = ViewHoaDon_BUS.ListViewHDTheoTGCH(idch, tungay, denngay);
                lbdoanhso.Text = DoanhSo_BUS.DoanhSoTheoCHTG(idch, tungay, denngay).ToString();

            }
        }

        private void cbbCuahang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idch = cbbCuahang.Text;
            dgvListHD.DataSource = ViewHoaDon_BUS.ListViewHDTheoCH(idch);
            lbdoanhso.Text = DoanhSo_BUS.DoanhSoTheoCH(idch).ToString();
        }

        private void checkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAll.Checked == true)
            {
                cbbCuahang.Enabled = false;
                All();
            }
            else
            {
                cbbCuahang.Enabled = true;
                ClearAll();
            }
        }
    }
}
