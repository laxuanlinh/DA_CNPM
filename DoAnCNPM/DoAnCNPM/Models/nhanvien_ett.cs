using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCNPM.Models
{
    public class nhanvien_ett
    {
        public int manhanvien { get; set; }
        public string tennhanvien { get; set; }
        public string diachi { get; set; }
        public string sdt { get; set; }
        public string email { get; set; }
        public string chucvu { get; set; }
        public int tuoi { get; set; }

        public nhanvien_ett() { }
        public nhanvien_ett(tbl_nhanvien nv)
        {
            manhanvien = nv.manv;
            tennhanvien = nv.tennv;
            diachi = nv.diachi;
            sdt = nv.dienthoai;
            email = nv.email;
            chucvu = nv.chucvu;
            tuoi = (int)nv.tuoi;
        }
        public nhanvien_ett(int ma, string ten, string dc, string sdt, string email, string chucvu, int tuoi)
        {
            manhanvien = ma;
            tennhanvien = ten;
            diachi = dc;
            this.sdt = sdt;
            this.email = email;
            this.chucvu = chucvu;
            this.tuoi = tuoi;
        }
    }
}
