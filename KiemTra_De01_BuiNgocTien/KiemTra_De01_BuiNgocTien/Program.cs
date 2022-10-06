using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra_De01_BuiNgocTien
{
    public class Program
    {
        static void Main(string[] args)
        {
            UD app = new UD();
            app.nhap();
            app.xuat();
            app.searchMaxAge();
            app.sortByTGTG();
            app.findMinSLTT();
            Console.ReadKey();
        }
    }
}
