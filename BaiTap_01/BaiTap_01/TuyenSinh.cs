using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_01
{
    class TuyenSinh : ThiSinh
    {
        int kv;

        public TuyenSinh()
        {

        }

        public TuyenSinh(string ht, string sbd, double m1, double m2, double m3, int kv) : base(ht, sbd, m1, m2, m3)
        {
            this.kv = kv;
        }

        public int Kv { get => kv; set => kv = value; }

        public void nhap()
        {
            base.nhap();
            Console.WriteLine("Nhap khu vuc: "); kv = int.Parse(Console.ReadLine());
        }

        public void xuat()
        {
            Console.WriteLine($"{base.Ht,20} {base.Sbd,5} {base.M1,5} {base.M2,5} {base.M3,5} {kv,5} {tinhTongDiem(), 5}");
        }

        public double tinhTongDiem()
        {
            double ttd = 0.0;
            if (kv == 1) ttd =  base.tinhTongDiem();
            if (kv == 2) ttd = base.tinhTongDiem() + 1;
            if (kv == 3) ttd = base.tinhTongDiem() + 2;
            return ttd;
        }
    }
}
