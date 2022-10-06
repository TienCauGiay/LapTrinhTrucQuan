using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("So thi sinh can nhap n = ");
            int n = int.Parse(Console.ReadLine());
            TuyenSinh[] ts = new TuyenSinh[n];
            for(int i = 0; i < n; i++)
            {
                ts[i] = new TuyenSinh();
                ts[i].nhap();
            }
            Console.WriteLine("DANH SACH THI SINH DU THI");
            Console.WriteLine($"{"Ho ten",20} {"SBD",5} {"Mon1",5} {"Mon2",5} {"Mon3",5} {"KV",5} {"Tong", 5}");
            for (int i = 0; i < n; i++)
            {
                ts[i].xuat();
            }
            Console.WriteLine("Nhap diem chuan: ");
            double dc = double.Parse(Console.ReadLine());
            Console.WriteLine(" DANH SACH THI SINH TRUNG TUYEN LA: ");
            Console.WriteLine($"{"Ho ten",20} {"SBD",5} {"Mon1",5} {"Mon2",5} {"Mon3",5} {"KV",5} {"Tong",5}");
            for (int i = 0; i < n; i++)
            {
                if (ts[i].tinhTongDiem() >= dc)
                {
                    ts[i].xuat();
                }
            }
            Console.ReadKey();
        }
    }
}
