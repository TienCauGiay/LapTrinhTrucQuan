using System.Text.RegularExpressions;

namespace BaiTapThem_Bai5_DaySo
{
    public partial class Form1 : Form
    {
        List<double> lDaySo;
        public Form1()
        {
            InitializeComponent();
            lDaySo = new List<double>();
            btnXoa.Enabled = false;
            btnTong.Enabled = false;
            btnMax.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo))
            {
                this.Close();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtNhapSo.Text = "";
            listBox1.Items.Clear();
            lbTinhTong.Text = "";
            lbMax.Text = "";
            btnXoa.Enabled = false;
            btnTong.Enabled = false;
            btnMax.Enabled = false;
        }

        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*.?[0-9]+$");
            return regex.IsMatch(pText);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtNhapSo.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số!");
            } 
            else
            {
                string s = txtNhapSo.Text;
                if(IsNumber(s))
                {
                    listBox1.Items.Add(s);
                    lDaySo.Add(double.Parse(s));
                    txtNhapSo.Text = "";
                    txtNhapSo.Focus();
                    btnXoa.Enabled = true;
                    btnTong.Enabled = true;
                    btnMax.Enabled = true;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chọn một mục để xóa");
            }
            if(listBox1.SelectedItems.Count > 0)
            {
                int index = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(index);
                if(listBox1.Items.Count == 0)
                {
                    btnXoa.Enabled = false;
                    btnTong.Enabled = false;
                    btnMax.Enabled = false;
                }
            }
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            double sum = 0;
            foreach(double cur in lDaySo)
            {
                sum += cur;
            }
            lbTinhTong.Text = "Tổng = " + Math.Round(sum,2).ToString();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            double max = lDaySo[0];
            foreach (double cur in lDaySo)
            {
                if(cur > max)
                {
                    max = cur;
                }
            }
            lbMax.Text = "Max = " + Math.Round(max,2).ToString();
        }
    }
}