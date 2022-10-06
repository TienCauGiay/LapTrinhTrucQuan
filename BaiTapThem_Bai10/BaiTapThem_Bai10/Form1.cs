using System.Text.RegularExpressions;

namespace BaiTapThem_Bai10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radgptbn.Checked = true;
            txtNhapC.Enabled = false;
        }

        private void btnToat_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo))
            {
                Close();
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtNhapA.Text = "";
            txtNhapB.Text = "";
            txtNhapC.Text = "";
            txtKetQua.Text = "";
        }

        private void radgptbn_CheckedChanged(object sender, EventArgs e)
        {
            if(radgptbn.Checked == true)
                txtNhapC.Enabled = false;
        }

        private void radgptbh_CheckedChanged(object sender, EventArgs e)
        {
            if (radgptbh.Checked == true)
                txtNhapC.Enabled = true;
        }

        public bool isNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*.?[0-9]+$");
            return regex.IsMatch(pText);
        }

        private void btnGPT_Click(object sender, EventArgs e)
        {
            if(radgptbn.Checked == true)
            {
                if(txtNhapA.Text == "" || txtNhapB.Text == "" || isNumber(txtNhapA.Text) == false || isNumber(txtNhapB.Text) == false)
                {
                    MessageBox.Show("Dữ liệu nhập chưa đúng");
                }
                else
                {
                    double a = double.Parse(txtNhapA.Text);
                    double b = double.Parse(txtNhapB.Text);
                    if(a == 0)
                    {
                        if(b == 0)
                        {
                            txtKetQua.Text = "PT có vô số nghiệm";
                        }
                        else
                        {
                            txtKetQua.Text = "PT vô nghiệm";
                        }
                    }
                    else
                    {
                        double kq = Math.Round(-b /a, 2);
                        txtKetQua.Text = kq.ToString();
                    }
                }
            }
            if(radgptbh.Checked == true)
            {
                if (txtNhapA.Text == "" || txtNhapB.Text == "" || isNumber(txtNhapA.Text) == false || isNumber(txtNhapB.Text) == false
                    || txtNhapC.Text == "" || isNumber(txtNhapC.Text) == false)
                {
                    MessageBox.Show("Dữ liệu nhập chưa đúng");
                }
                else
                {
                    double a = double.Parse(txtNhapA.Text);
                    double b = double.Parse(txtNhapB.Text);
                    double c = double.Parse(txtNhapC.Text);
                    if(a == 0)
                    {
                        if(b == 0)
                        {
                            if(c == 0)
                            {
                                txtKetQua.Text = "PT có vô số nghiệm";
                            }else
                            {
                                txtKetQua.Text = "PT vô nghiệm";
                            }
                        }else
                        {
                            double kq = Math.Round(-c / b, 2);
                            txtKetQua.Text = kq.ToString();
                        }
                    } else
                    {
                        double delta = b * b - a * c * 4;
                        if(delta < 0)
                        {
                            txtKetQua.Text = "PT vô nghiệm";
                        } else if(delta == 0) {
                            txtKetQua.Text = "PT có nghiệm kép x = " + (-b / (2 * a)).ToString();
                        }else
                        {
                            double x1 = Math.Round((-b - Math.Sqrt(delta)) / (2 * a), 2);
                            double x2 = Math.Round((-b + Math.Sqrt(delta)) / (2 * a), 2);
                            txtKetQua.Text = "x1 = " + x1.ToString() + " x2 = " + x2.ToString();
                        }
                    }
                }
            }
        }
    }
}