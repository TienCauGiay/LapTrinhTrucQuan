using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra_De02_BuiNgocTien
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("So hop dong can nhap n = ");
            int n = int.Parse(Console.ReadLine());
            HD[] h = new HD[n];

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhan vien thu " + (i + 1));
                h[i] = new HD();
                h[i].nhap();
            }

            int maxTuoi = h[0].tuoi();
            for(int i = 1; i < n; i++)
            {
                if (h[i].tuoi() > maxTuoi)
                {
                    maxTuoi = h[i].tuoi();
                }
            }
            Console.WriteLine("Nguoi co tuoi cao nhat: " + maxTuoi);
            for(int i = 0; i < n; i++)
            {
                if (h[i].tuoi() == maxTuoi)
                {
                    h[i].xuat();
                }
             }

            double minLuong = h[0].tienLuong();
            for(int i = 1; i < n; i++)
            {
                if (h[i].tienLuong() < minLuong)
                {
                    minLuong = h[i].tienLuong();
                }
            }
            Console.WriteLine("Nguoi co tien luong thap nhat la: ");
            for(int i = 0; i < n; i++)
            {
                if (h[i].tienLuong() == minLuong)
                {
                    h[i].xuat();
                }
            }
            double s = 0;
            for(int i = 0; i < n; i++)
            {
                s += h[i].tienLuong();
            }
            double tbcLuong = s / n;
            Console.WriteLine("Luong trung binh cua nhung hop dong la: " + tbcLuong);
            Console.ReadKey();
        }
    }
}
