using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapThem_Bai2_LaiSuat
{
    internal class Nguoi
    {
        private int maKH;
        private string hotenKH;
        private string diaChiKH;
        private int soTienGui;
        private string ngayGui;
        private string thoiGianGui;
        private double tien;

        public string getMaKH()
        {
            return maKH.ToString();
        }

        public string getSoTienPhaiTra()
        {
            return tien.ToString();
        }

        public Nguoi()
        {
            this.maKH = 0;
            this.hotenKH = "";
            this.diaChiKH = "";
            this.soTienGui = 0;
            this.ngayGui = "";
            this.thoiGianGui = "";
            this.tien = 0;
        }

        public Nguoi(int maKH, string tenKH, string diaChi, int soTienGui, string ngayGui, string thoiGianGui, double tien)
        {
            this.maKH = maKH;
            this.hotenKH = tenKH;
            this.diaChiKH = diaChi;
            this.soTienGui = soTienGui;
            this.ngayGui = ngayGui;
            this.thoiGianGui = thoiGianGui;
            this.tien = tien;
        }
    }
}
