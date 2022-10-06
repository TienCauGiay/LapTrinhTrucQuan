using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_07_OOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            CuaHang c = new CuaHang();
            c.nhapDanhSach();
            c.xuatDanhSach();
            c.kiemTraSach();
            Console.ReadKey();
        }
    }
}
