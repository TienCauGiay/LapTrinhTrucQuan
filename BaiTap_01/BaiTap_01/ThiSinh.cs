using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_01
{
    class ThiSinh
    {
        string ht, sbd;
        double m1, m2, m3;

        public ThiSinh()
        {

        }

        public ThiSinh(string ht, string sbd, double m1, double m2, double m3)
        {
            this.ht = ht;
            this.sbd = sbd;
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
        }

        public string Ht { get => ht; set => ht = value; }
        public string Sbd { get => sbd; set => sbd = value; }
        public double M1 { get => m1; set => m1 = value; }
        public double M2 { get => m2; set => m2 = value; }
        public double M3 { get => m3; set => m3 = value; }

        public void nhap()
        {
            Console.WriteLine("Nhap so bao danh: "); sbd = Console.ReadLine();
            Console.WriteLine("Nhap ho ten: "); ht = Console.ReadLine();
            Console.WriteLine("Nhap diem 3 mon: ");
            m1 = double.Parse(Console.ReadLine());
            m2 = double.Parse(Console.ReadLine());
            m3 = double.Parse(Console.ReadLine());
        }

        public double tinhTongDiem()
        {
            return m1 + m2 + m3;
        }
    }
}
