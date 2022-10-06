namespace BaiTap03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiaiPT_Click(object sender, EventArgs e)
        {
            if(txtNhapa.Text == "")
            {
                MessageBox.Show("Nhap a", "Thong bao");
            }
            if (txtNhapb.Text == "")
            {
                MessageBox.Show("Nhap b", "Thong bao");
            }
            if (txtNhapc.Text == "")
            {
                MessageBox.Show("Nhap c", "Thong bao");
            }
            double a, b, c;
            bool a1, b1, c1;
            a1 = double.TryParse(txtNhapa.Text, out a);
            b1 = double.TryParse(txtNhapb.Text, out b);
            c1 = double.TryParse(txtNhapc.Text, out c);
            if(a1 && b1&& c1)
            {
                if (a == 0)
                {
                    if (b == 0)
                    {
                        if (c == 0)
                        {
                            txtKetQua.Text = "Phuong trinh co vo so nghiem";
                        }
                        else
                        {
                            txtKetQua.Text = "Phuong trinh vo nghiem";
                        }
                    }
                    else
                    {
                        txtKetQua.Text = "Phuong trinh co nghiem duy nhat x = " + (-c / b).ToString();
                    }
                }
                else
                {
                    double delta = b * b - 4 * a * c;
                    if (delta < 0)
                    {
                        txtKetQua.Text = "Phuong trinh vo nghiem";
                    }
                    else if (delta == 0)
                    {
                        txtKetQua.Text = "Phuong trinh co nghiem kep x = " + (-b / (2 * a)).ToString();
                    }
                    else
                    {
                        double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                        double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                        txtKetQua.Text = "Phuong trinh co hai nghiem phan biet: x1 = " + x1.ToString() + "; x2 = " + x2.ToString();
                    }
                }
            } else
            {
                if(!a1)
                {
                    MessageBox.Show("a khong phai la so", "Thong bao");
                }
                if (!b1)
                {
                    MessageBox.Show("b khong phai la so", "Thong bao");
                }
                if (!c1)
                {
                    MessageBox.Show("c khong phai la so", "Thong bao");
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt == true && e.KeyCode == Keys.G)
            {
                btnLamLai_Click(sender, e);
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtNhapa.Text = "";
            txtNhapb.Text = "";
            txtNhapc.Text = "";
            txtKetQua.Text = "";
            txtNhapa.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban muon thoat ?", "Thông báo..", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}