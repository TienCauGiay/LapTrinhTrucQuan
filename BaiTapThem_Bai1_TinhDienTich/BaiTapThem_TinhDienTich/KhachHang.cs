using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapThem_TinhDienTich
{
    class KhachHang
    {
        private string idKH;
        private string nameKH;
        private string addressKH;
        private string dateChotSo;
        private int number1;
        private int number2;
        private double tien;

        public KhachHang(string idKH, string nameKH, string addressKH, string dateChotSo, int number1, int number2, double tien)
        {
            this.idKH = idKH;
            this.nameKH = nameKH;
            this.addressKH = addressKH;
            this.dateChotSo = dateChotSo;
            this.number1 = number1;
            this.number2 = number2;
            this.tien = tien;
        }

        public string getTien()
        {
            return tien.ToString();
        }

        public string getNameKH()
        {
            return nameKH;
        }
    }
}
