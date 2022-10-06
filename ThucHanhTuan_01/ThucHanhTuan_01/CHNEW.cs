using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanhTuan_01
{
    class CHNEW : CH
    {
        string huongBanCong;

        public CHNEW() : base()
        {
            huongBanCong = "Huong vao tim em";
        }

        public string HuongBanCong { get => huongBanCong; set => huongBanCong = value; }

        public void nhapCHNEW()
        {
            base.nhapch();
            Console.WriteLine("Nhap huong ban cong: "); huongBanCong = Console.ReadLine();
        }

        public void xuatCHNEW()
        {
            base.xuatch();
            Console.WriteLine("Huong ban cong: " + huongBanCong);
        }
    }
}
