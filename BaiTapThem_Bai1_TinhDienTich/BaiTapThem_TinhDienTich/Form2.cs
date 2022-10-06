using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapThem_TinhDienTich
{
    public partial class Form2 : Form
    {
        List<KhachHang> listKhachHangs = new List<KhachHang>();
        public Form2()
        {
            InitializeComponent();
            listKhachHangs = StaticData._KhachHang;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int dem = 0;
            KhachHang k = new KhachHang("", "", "", "", 0, 0, 0.0);
            foreach (KhachHang hang in listKhachHangs)
            {
                if(txtNhap.Text.Equals(hang.getNameKH()))
                {
                    dem++;
                    k = hang;
                }
            }
            if(dem > 0)
            {
                lbThongTinTimKiem.Text = "Khách hàng " + txtNhap.Text + " phải trả " + k.getTien();
            } 
            else
            {
                lbThongTinTimKiem.Text = "Khách hàng " + txtNhap.Text + " không có trong danh sách";
            }
        }
    }
}
