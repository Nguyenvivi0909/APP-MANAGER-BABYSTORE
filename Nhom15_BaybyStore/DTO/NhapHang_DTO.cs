using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhapHang_DTO
    {
        public string IdNCC { get; set; }
        public string IdCH { get; set; }
        public string IdSP { get; set; }
        public string TenSP { get; set; }
        public DateTime NgayCC { get; set; }
        public DateTime NSX { get; set; }
        public DateTime HSD { get; set; }
        public int Soluong { get; set; }
        public int Gia { get; set; }
    }
}
