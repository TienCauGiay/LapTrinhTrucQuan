using System.Text.RegularExpressions;

namespace TinhSoNgayCuaThang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BackColor = Color.Yellow;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtThang_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            if(txtNam.Text == "" || txtThang.Text == "")
            {
                txtMess.Text = "";
            } else
            {
                int thang = int.Parse(txtThang.Text);
                int nam = int.Parse(txtNam.Text);
                int songay = 0;

                switch (thang)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12: songay = 31; break;
                    case 4:
                    case 6:
                    case 9:
                    case 11: songay = 30; break;
                    case 2:
                        if (nam % 400 == 0 || (nam % 4 == 0 && nam % 100 != 0))
                            songay = 29;
                        else
                            songay = 28;
                        break;
                }
                txtMess.Text = "Thang " + thang + " nam " + nam + " co " + songay + " ngay";
            }
        }

        private void txtNam_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtMess.Text = "";
            txtNam.Text = "";
            txtThang.Text = "";
        }

        private void txtThang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}