using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_07_OOP
{
    public class Sach
    {
        private String maSach;
        private String tenSach;
        private String tenTacGia;
        private int soLuong;

        protected string MaSach { get => maSach; set => maSach = value; }
        protected string TenSach { get => tenSach; set => tenSach = value; }
        protected string TenTacGia { get => tenTacGia; set => tenTacGia = value; }
        protected int SoLuong { get => soLuong; set => soLuong = value; }

        public Sach()
        {

        }

        public Sach(string maSach, string tenSach, string tenTacGia, int soLuong)
        {
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.tenTacGia = tenTacGia;
            this.soLuong = soLuong;
        }

        public void nhap()
        {
            Console.WriteLine("Nhap ma sach: "); this.maSach = Console.ReadLine();
            Console.WriteLine("Nhap ten sach: "); this.tenSach = Console.ReadLine();
            Console.WriteLine("Nhap ten tac gia: "); this.tenTacGia = Console.ReadLine();
            Console.WriteLine("Nhap so luong: "); this.soLuong = int.Parse(Console.ReadLine());
        }
    }
}