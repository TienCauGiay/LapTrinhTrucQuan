using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra_De02_BuiNgocTien
{
    public class HD : NhanVien
    {
        private double tienCong;
        private int ngayCong;

        public HD()
        {
        }

        public HD(string maNV, string hoTen, int namSinh, double tienCong, int ngayCong) : base(maNV, hoTen, namSinh)
        {
            this.tienCong = tienCong;
            this.ngayCong = ngayCong;
        }

        public double TienCong { get => tienCong; set => tienCong = value; }
        public int NgayCong { get => ngayCong; set => ngayCong = value; }

        public void nhap()
        {
            base.nhap();
            Console.WriteLine("Nhap tien cong: "); this.tienCong = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ngay cong: "); this.ngayCong = int.Parse(Console.ReadLine());
        }

        public void xuat()
        {
            base.xuat();
            Console.WriteLine("Tien cong: " + this.tienCong);
            Console.WriteLine("Ngay cong: " + this.ngayCong);
            Console.WriteLine("Tien luong: " + tienLuong());
        }

        public double tienLuong()
        {
            return tienCong * ngayCong;
        }
    }
}
