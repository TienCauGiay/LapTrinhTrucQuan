using System.Text.RegularExpressions;

namespace BaiTapThem_Bai12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo))
            {
                Close();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtNhap.Text = "";
            listBox1.Items.Clear();
            lbKQ.Text = "";
            txtNhap.Focus();
        }

        public bool isNumber(string pText)
        {
            Regex regex = new Regex(@"^[0-9]*$");
            return regex.IsMatch(pText);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtNhap.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số vào");
            }
            else
            {
                if(isNumber(txtNhap.Text) == true)
                {
                    listBox1.Items.Add(txtNhap.Text);
                    txtNhap.Text = "";
                    txtNhap.Focus();
                }
                else
                {
                    MessageBox.Show("Dữ liệu nhập vào k đúng");
                    txtNhap.Text = "";
                    txtNhap.Focus();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Count == 0)
            {
                MessageBox.Show("Dãy số chưa có phần tử");
            }
            else
            {
                if(listBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Bạn chưa chọn phần tử để xóa");
                }
                else
                {
                    while(listBox1.SelectedItems.Count > 0)
                    {
                        listBox1.Items.Remove((string)listBox1.SelectedItems[0]);
                    }
                }
            }
        }

        public bool checkSNT(int n)
        {
            if(n < 2)return false;
            int dem = 0;
            for(int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    dem++;
            }
            if (dem == 0)
                return true;
            return false;
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex < 0)
            {
                return;
            }
            else
            {
                int i = listBox1.SelectedIndex;
                int so = Convert.ToInt32(listBox1.Items[i]);
                if(checkSNT(so) == true)
                {
                    lbKQ.Text = so + " là số nguyên tố";
                }
                else
                {
                    lbKQ.Text = so + " không là số nguyên tố";
                }
                listBox1.SelectedIndex = -1;
            }
        }
    }
}