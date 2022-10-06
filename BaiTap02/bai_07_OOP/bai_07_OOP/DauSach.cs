using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_07_OOP
{
    public class DauSach : Sach
    {
        private String qrCode;

        public DauSach():base()
        {

        }

        public DauSach(string maSach, string tenSach, string tenTacGia, int soLuong, string qrCode)
        : base(maSach, tenSach, tenTacGia, soLuong)
        {
            this.qrCode = qrCode;
        }

        public string QrCode { get => qrCode; set => qrCode = value; }

        public void nhap()
        {
            base.nhap();
            Console.WriteLine("Nhap qrCode: "); this.qrCode = Console.ReadLine();
        }

        public void xuat()
        {
            Console.WriteLine($"{base.MaSach, 5} {base.TenSach, 20} {base.TenTacGia, 20} {base.SoLuong, 5} {qrCode, 10}");
        }

        public int checkqrCode(String s)
        {
            int kq = 0;
            if(this.qrCode == s && this.SoLuong > 0)
            {
                kq = this.SoLuong;
            }
            return kq;
        }
    }

    public class CuaHang
    {
        LinkedList<DauSach> dauSachList;

        public CuaHang()
        {
            dauSachList = new LinkedList<DauSach>();
        }

        public void nhapDanhSach()
        {
            char kt = 'c';
            do
            {
                Console.WriteLine("Nhap thong tin dau sach: ");
                DauSach s = new DauSach();
                s.nhap();
                dauSachList.AddFirst(s);
                Console.WriteLine("Ban co muon nhap tiep k? ");
                kt = char.Parse(Console.ReadLine());
            } while (kt != 'k');
        }

        public void xuatDanhSach()
        {
            Console.WriteLine($"{"Mã sách", 5} {"Tên sách", 20} {"Tên tác gia", 20} {"SL", 5} {"qrCode", 10}");
            foreach (DauSach s in dauSachList)
            {
                s.xuat();
            }
        }

        public void kiemTraSach()
        {
            Console.WriteLine("Nhap qrcode sach can kiem tra: "); String s = Console.ReadLine();
            int dem = 0;
            int sl = 0;
            foreach (DauSach dauSach in dauSachList)
            {
                if(dauSach.checkqrCode(s) > 0)
                {
                    dem++;
                    sl = dauSach.checkqrCode(s);
                }
            }
            if(dem > 0)
            {
                Console.WriteLine("Sach co qrcode " + s + " con trong cua hang, so luong la: " + sl);
            } else
            {
                Console.WriteLine("Sach co qrcode " + s + " khong con trong cua hang");
            }
        }
    }
}
