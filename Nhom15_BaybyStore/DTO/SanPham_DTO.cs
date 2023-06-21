using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPham_DTO
    {
        public string IdSP { get; set; }
        public string IdDM { get; set; }
        public string IdNCC { get; set; }
        public string TenSP { get; set; }
        public DateTime NSX { get; set; }
        public DateTime HSD { get; set; }
        public int Gia { get; set; }
    }
}
