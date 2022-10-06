namespace TinhToanTrenDaySo
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

        private void txtNhapn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            if(txtNhapn.Text != "")
            {
                int n = int.Parse(txtNhapn.Text);
                for(int i = 1; i <= n; i++)
                {
                    lbHienDaySo.Text += Convert.ToString(random.Next(1000)) + " ";
                }
            }
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtNhapn.Text);
            int[] a = new int[n];
            string[] s = lbHienDaySo.Text.Split(" ");
            for(int i = 0; i < n; i++)
            {
                a[i] = int.Parse(s[i]);
            }
            int sum = 0;
            for(int i = 0; i < n; i++)
            {
                sum += a[i];
            }
            lbHienTongDaySo.Text = sum.ToString();
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtNhapn.Text);
            int[] a = new int[n];
            string[] s = lbHienDaySo.Text.Split(" ");
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(s[i]);
            }
            for(int i = 0; i < n - 1; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    if (a[i] <= a[j])
                    {
                        int tg = a[i]; a[i] = a[j]; a[j] = tg;
                    }
                }
            }
            for(int i = 0; i < n; i++)
            {
                lbHienDaySoSapXepGiam.Text += Convert.ToString(a[i]) + " ";
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            lbHienDaySoSapXepGiam.Text = "";
            lbHienTongDaySo.Text = "";
            lbHienDaySo.Text = "";
            txtNhapn.Text = "";
            txtNhapn.Select();
        }
    }
}