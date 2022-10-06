using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanhTuan_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("So can ho can nhap la: ");
            int n = int.Parse(Console.ReadLine());

            CH[] ch = new CH[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap can ho thu " + (i + 1));
                ch[i] = new CH();
                ch[i].nhapch();
            }
            Console.WriteLine("DANH SACH CAC CAN HO VUA NHAP LA: ");
            for(int i = 0; i < n; i++)
            {
                ch[i].xuatch();
            }

            double max = ch[0].KichThuoc.area();
            CH maxch = ch[0];
            for(int i = 1; i < n; i++)
            {
                if(max < ch[i].KichThuoc.area())
                {
                    max = ch[i].KichThuoc.area();
                    maxch = ch[i];
                }
            }

            Console.WriteLine("Can ho co dien tich lon nhat la: ");
            maxch.xuatch();
            */

            Console.WriteLine("So can ho can nhap la: ");
            int n = int.Parse(Console.ReadLine());

            CHNEW[] chn = new CHNEW[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap can ho thu " + (i + 1));
                chn[i] = new CHNEW();
                chn[i].nhapCHNEW();
            }
            Console.WriteLine("DANH SACH CAC CAN HO VUA NHAP LA: ");
            for (int i = 0; i < n; i++)
            {
                chn[i].xuatCHNEW();
            }
            Console.WriteLine("Nhap huong can ho can tim kiem: ");string hch = Console.ReadLine();
            int dem = 0;
            for(int i = 0; i < n; i++)
            {
                if (chn[i].HuongBanCong == hch)
                {
                    dem++;
                }
            }
            if(dem == 0)
            {
                Console.WriteLine("K co can ho co huong ban cong " + hch);
            } else
            {
                Console.WriteLine("Thong tin can ho: ");
                for(int i = 0; i < n; i++)
                {
                    if (chn[i].HuongBanCong == hch)
                    {
                        chn[i].xuatCHNEW();
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
