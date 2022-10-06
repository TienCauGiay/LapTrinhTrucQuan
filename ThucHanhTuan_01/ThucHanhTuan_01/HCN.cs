using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanhTuan_01
{
    class HCN
    {
        double cd, cr;

        public double Cd { get => cd; set => cd = value; }
        public double Cr { get => cr; set => cr = value; }

        public void nhap()
        {
            Console.WriteLine("Nhap chieu dai: "); cd = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chieu rong: "); cr = double.Parse(Console.ReadLine());
        }

        public void xuat()
        {
            Console.WriteLine("Chieu dai " + cd + " chieu rong " + cr);
        }

        public double area()
        {
            return cd * cr;
        }
    }
}
