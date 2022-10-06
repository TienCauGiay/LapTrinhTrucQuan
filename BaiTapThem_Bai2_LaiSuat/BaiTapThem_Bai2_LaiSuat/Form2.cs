using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapThem_Bai2_LaiSuat
{
    public partial class Form2 : Form
    {
        List<Nguoi> listKhachHang = new List<Nguoi>();
        public Form2()
        {
            InitializeComponent();
            listKhachHang = BasicData._Nguoi;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            int dem = 0;
            Nguoi nguoi = new Nguoi();
            foreach(Nguoi n in listKhachHang)
            {
                if(txtNhapMaKHCanTim.Text == n.getMaKH())
                {
                    dem++;
                    nguoi = n;
                }
            }
            if(dem == 0)
            {
                lbKetQua.Text = "Khách hàng có mã " + txtNhapMaKHCanTim.Text + " hiện chưa có trong danh sách";
            }
            else
            {
                lbKetQua.Text = "Tìm thấy khách hàng có mã " + txtNhapMaKHCanTim.Text + " trong danh sách, số tiền phải trả: " + nguoi.getSoTienPhaiTra();
            }
        }
    }
}
