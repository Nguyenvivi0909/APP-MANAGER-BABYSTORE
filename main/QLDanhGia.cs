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
    public partial class QLDanhGia : Form
    {
        public QLDanhGia()
        {
            InitializeComponent();
        }

        private void QLDanhGia_Load(object sender, EventArgs e)
        {
            dgvDanhGia.DataSource = QLDanhGia_BUS.LoadDanhGia();
        }
    }
}
