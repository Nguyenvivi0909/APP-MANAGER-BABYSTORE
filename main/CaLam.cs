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
    public partial class CaLam : Form
    {
        public CaLam()
        {
            InitializeComponent();
        }

        private void CaLam_Load(object sender, EventArgs e)
        {
            dgvCaLam.DataSource = QLCaLam_BUS.GetCL();
            txtIDCaLam.Text = QLCaLam_BUS.GetNewCL();
        }

        private void btnThemCaLam_Click(object sender, EventArgs e)
        {
            Ca_DTO cl = new Ca_DTO();
            cl.Thoigian = txtThoiGianCaLam.Text;
            QLCaLam_BUS.Insert(cl);
            CaLam_Load(sender, e);
        }

        private void btnSuaCaLam_Click(object sender, EventArgs e)
        {
            Ca_DTO cl = new Ca_DTO();
            cl.IdCa = txtIDCaLam.Text;
            cl.Thoigian = txtThoiGianCaLam.Text;
            QLCaLam_BUS.Update(cl);
            CaLam_Load(sender, e);
        }

        private void btnXoaCaLam_Click(object sender, EventArgs e)
        {
            Ca_DTO cl = new Ca_DTO();
            cl.IdCa = txtIDCaLam.Text;
            QLCaLam_BUS.Delete(cl);
            CaLam_Load(sender, e);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtIDCaLam.Text = QLCaLam_BUS.GetNewCL();
            txtThoiGianCaLam.Text = "";
        }

        private void dgvCaLam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvCaLam.CurrentRow.Index;
            txtIDCaLam.Text = dgvCaLam.Rows[i].Cells[0].Value.ToString();
            txtThoiGianCaLam.Text = dgvCaLam.Rows[i].Cells[1].Value.ToString();
        }
    }
}
