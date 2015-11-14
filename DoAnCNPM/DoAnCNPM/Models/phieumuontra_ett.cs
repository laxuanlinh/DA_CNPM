using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCNPM.Models
{
    public class phieumuontra_ett
    {
        public int sophieumuon { get; set; }
        public int madg { get; set; }
        public int masach { get; set; }
        public string ngaymuon { get; set; }
        public string ngaytra { get; set; }
        public bool xacnhantra { get; set; }

        public phieumuontra_ett() { }
        public phieumuontra_ett(tbl_phieumuon_tra phieu)
        {
            sophieumuon = phieu.sophieumuon;
            madg = (int)phieu.madg;
            masach = (int)phieu.masach;
            ngaymuon = phieu.ngaymuon.ToString();
            ngaytra = phieu.ngaytra.ToString();
            xacnhantra = (bool)phieu.xacnhantra;
        }
        public phieumuontra_ett(int sopm, int madg, int masach, string ngaymuon, string ngaytra, bool xacnhantra)
        {
            sophieumuon = sopm;
            this.madg = madg;
            this.masach = masach;
            this.ngaymuon = ngaymuon;
            this.ngaytra = ngaytra;
            this.xacnhantra = xacnhantra;
        }
    }
}
