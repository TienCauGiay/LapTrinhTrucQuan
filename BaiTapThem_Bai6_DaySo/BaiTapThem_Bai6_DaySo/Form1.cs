using System.Text.RegularExpressions;

namespace BaiTapThem_Bai6_DaySo
{
    public partial class Form1 : Form
    {
        List<double> listDaySo;
        public Form1()
        {
            InitializeComponent();
            listDaySo = new List<double>();
            btnXoa.Enabled = false;
            listBox1.Items.Add(4);
            listBox1.Items.Add(46.8);
            listBox1.Items.Add(95);
            listDaySo.Add(4);
            listDaySo.Add(46.8);
            listDaySo.Add(95);
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtNhapSo.Text = "";
            lbMax.Text = "";
            btnXoa.Enabled = false;
            listBox1.Items.Clear();
            listDaySo.Clear();
            listBox1.Items.Add(4);
            listBox1.Items.Add(46.8);
            listBox1.Items.Add(95);
            listDaySo.Add(4);
            listDaySo.Add(46.8);
            listDaySo.Add(95);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo))
            {
                this.Close();
            }
        }

        public bool Isnumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*.?[0-9]+$");
            return regex.IsMatch(pText);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(!Isnumber(txtNhapSo.Text))
            {
                MessageBox.Show("Bạn phải nhạp số");
            }
            else
            {
                listBox1.Items.Add(txtNhapSo.Text);
                listDaySo.Add(double.Parse(txtNhapSo.Text));
                txtNhapSo.Text = "";
                txtNhapSo.Focus();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedItems.Count > 0)
            {
                btnXoa.Enabled = true;
            } 
            else
            {
                btnXoa.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo))
            {
                int i = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(i);
                listDaySo.RemoveAt(i);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            double max = listDaySo[0];
            foreach(double i in listDaySo)
            {
                if(i > max)
                {
                    max = i;
                }
            }
            lbMax.Text = "Giá trị lớn nhất của dãy số là: " + max.ToString();
        }
    }
}