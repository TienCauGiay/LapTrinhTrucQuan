namespace BaiTap_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNhapa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNhapb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void checkRong()
        {
            if (txtNhapa.Text == "" || txtNhapb.Text == "")
            {
                txtKetQua.Text = "Nhập chưa đủ dữ liệu";
                txtNhapa.Focus();
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtNhapa.Text = "";
            txtNhapb.Text = "";
            txtKetQua.Text = "";
            radCong.Checked = false;
            radTru.Checked = false;
            radNhan.Checked = false;
            radChia.Checked = false;
            checkMax.Checked = false;
            checkMin.Checked = false;
            checkMax.Text = "Max = ";
            checkMin.Text = "Min = ";
            txtNhapa.Focus();
        }

        private void radCong_CheckedChanged(object sender, EventArgs e)
        {
            checkRong();
            double a = double.Parse(txtNhapa.Text);
            double b = double.Parse(txtNhapb.Text);
            if (radCong.Checked == true)
                txtKetQua.Text = (a + b).ToString();
        }

        private void radTru_CheckedChanged(object sender, EventArgs e)
        {
            checkRong();
            double a = double.Parse(txtNhapa.Text);
            double b = double.Parse(txtNhapb.Text);
            if (radTru.Checked == true)
                txtKetQua.Text = (a - b).ToString();
        }

        private void radNhan_CheckedChanged(object sender, EventArgs e)
        {
            checkRong();
            double a = double.Parse(txtNhapa.Text);
            double b = double.Parse(txtNhapb.Text);
            if (radNhan.Checked == true)
                txtKetQua.Text = (a * b).ToString();
        }

        private void radChia_CheckedChanged(object sender, EventArgs e)
        {
            checkRong();
            double a = double.Parse(txtNhapa.Text);
            double b = double.Parse(txtNhapb.Text);
            if(radChia.Checked == true)
            {
                if(b == 0)
                {
                    txtKetQua.Text = "Mẫu = 0";
                } else
                {
                    txtKetQua.Text = (a / b).ToString();
                }
            }
        }

        private void checkMax_CheckedChanged(object sender, EventArgs e)
        {
            checkRong();
            double a = double.Parse(txtNhapa.Text);
            double b = double.Parse(txtNhapb.Text);
            if (checkMax.Checked == true)
            {
                if (a > b)
                    checkMax.Text += a.ToString();
                else
                    checkMax.Text += b.ToString();
            }
            else
            {
                checkMax.Text = "Max = ";
            }
        }

        private void checkMin_CheckedChanged(object sender, EventArgs e)
        {
            checkRong();
            double a = double.Parse(txtNhapa.Text);
            double b = double.Parse(txtNhapb.Text);
            if (checkMin.Checked == true)
            {
                if (a < b)
                    checkMin.Text += a.ToString();
                else
                    checkMin.Text += b.ToString();
            }
            else
            {
                checkMin.Text = "Min = ";
            }
        }
    }
}