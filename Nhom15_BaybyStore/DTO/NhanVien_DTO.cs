using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien_DTO
    {
        public string IdNV { get; set; }
        public string Hovaten { get; set; }
        public DateTime Ngaysinh { get; set; }
        public string Diachi { get; set; }
        public bool Gioitinh { get; set; }
        public string Sdt { get; set; }
        public int Luong { get; set; }
        public string IdCH { get; set; }
        public string IdCa { get; set; }
    }
}
