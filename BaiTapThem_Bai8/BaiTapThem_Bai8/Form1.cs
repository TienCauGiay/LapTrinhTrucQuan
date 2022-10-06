using System.Text.RegularExpressions;

namespace BaiTapThem_Bai8
{
    public partial class Form1 : Form
    {
        List<int> lDS;
        public Form1()
        {
            InitializeComponent();
            lDS = new List<int>();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Close();
            } 
        }

        public bool isNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*$");
            return regex.IsMatch(pText);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtNhap.Text != "")
            {
                if (!isNumber(txtNhap.Text))
                {
                    MessageBox.Show("Phải nhập số");
                    txtNhap.Text = "";
                    txtNhap.Focus();
                }
                else
                {
                    listBox1.Items.Add(txtNhap.Text);
                    lDS.Add(int.Parse(txtNhap.Text));
                    txtNhap.Text = "";
                    txtNhap.Focus();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn phần tử để xóa");
            }
            if(listBox1.SelectedItems.Count > 0)
            {
                int i = listBox1.SelectedIndex;
                if(DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo))
                {
                    listBox1.Items.RemoveAt(i);
                    lDS.RemoveAt(i);
                }
            }
        }

        private void btnTang3_Click(object sender, EventArgs e)
        {
            int n = listBox1.Items.Count;
            for(int i = 0; i < n; i++)
            {
                listBox1.Items[i] = Convert.ToInt32(listBox1.Items[i]) + 3;
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int n = listBox1.Items.Count;
            for(int i = 0; i < n; i++)
            {
                if(Convert.ToInt32(listBox1.Items[i]) % 2 == 0)
                {
                    listBox1.SelectedIndex = i;
                    return;
                }
            }
        }

        private void btnChonLe_Click(object sender, EventArgs e)
        {
            int n = listBox1.Items.Count;
            for(int i = n - 1; i >= 0; i--)
            {
                if (Convert.ToInt32(listBox1.Items[i]) % 2 != 0)
                {
                    listBox1.SelectedIndex = i;
                    return;
                }
            }
        }
    }
}