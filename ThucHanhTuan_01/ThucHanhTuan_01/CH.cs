using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanhTuan_01
{
    class CH
    {
        int maPhong;
        HCN kichThuoc;

        public int MaPhong { get => maPhong; set => maPhong = value; }
        internal HCN KichThuoc { get => kichThuoc; set => kichThuoc = value; }

        public void nhapch()
        {
            Console.WriteLine("Nhap ma phong: "); maPhong = int.Parse(Console.ReadLine());
            kichThuoc = new HCN();
            kichThuoc.nhap();
        }

        public void xuatch()
        {
            Console.WriteLine("Ma phong: " + maPhong.ToString());
            kichThuoc.xuat();
            Console.WriteLine("Dien tich: " + kichThuoc.area());
        }
    }
}
