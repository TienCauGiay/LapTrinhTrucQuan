using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra_De02_BuiNgocTien
{
    public class NhanVien
    {
        private string maNV;
        private string hoTen;
        private int namSinh;

        protected string MaNV { get => maNV; set => maNV = value; }
        protected string HoTen { get => hoTen; set => hoTen = value; }
        protected int NamSinh { get => namSinh; set => namSinh = value; }

        public NhanVien()
        {
        }

        public NhanVien(string maNV, string hoTen, int namSinh)
        {
            this.maNV = maNV;
            this.hoTen = hoTen;
            this.namSinh = namSinh;
        }

        public void nhap()
        {
            Console.WriteLine("Nhap ma nhan vien: "); this.maNV = Console.ReadLine();
            Console.WriteLine("Nhap ho ten: "); this.hoTen = Console.ReadLine();
            Console.WriteLine("Nhap nam sinh: "); this.namSinh = int.Parse(Console.ReadLine());
        }

        public void xuat()
        {
            Console.WriteLine("Ma nhan vien: " + this.maNV);
            Console.WriteLine("Ten nhan vien: " + this.HoTen);
            Console.WriteLine("Nam sinh: " + this.NamSinh);
        }

        public int tuoi()
        {
            return 2022 - this.namSinh;
        }
    }
}
