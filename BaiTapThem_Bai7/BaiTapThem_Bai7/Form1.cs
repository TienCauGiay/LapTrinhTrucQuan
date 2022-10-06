using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace BaiTapThem_Bai7
{
    public partial class Form1 : Form
    {
        List<int> listDaySo;
        public Form1()
        {
            InitializeComponent();
            listDaySo = new List<int>();    
        }

        private void btnTHoat_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo))
            {
                this.Close();
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtNhap.Text = "";
            lbKQDaySoVuaNhap.Text = "";
            lbKetQuaChucNang.Text = "";cbbChonChucNang.SelectedIndex = -1;
        }

        public bool Isnumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*.?[0-9]+$");
            return regex.IsMatch(pText);
        }

        private void btnNhapDay_Click(object sender, EventArgs e)
        {
            if(!Isnumber(txtNhap.Text))
            {
                MessageBox.Show("Bạn phải nhập số");
            }
            else
            {
                int n = int.Parse(txtNhap.Text);
                object[] a = new object[n];
                for(int i = 0; i < n; i++)
                {
                    a[i] = Interaction.InputBox("Nhập số thứ " + (i + 1), "Nhập số", "");
                }
                for(int i = 0; i < n; i++)
                {
                    listDaySo.Add(int.Parse(a[i].ToString()));
                    lbKQDaySoVuaNhap.Text += a[i].ToString() + " ";
                }
            }
        }

        private void cbbChonChucNang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbChonChucNang.SelectedIndex > -1)
            {
                if (cbbChonChucNang.SelectedItem.ToString() == "Trung bình cộng của dãy")
                {
                    double sum = 0;
                    foreach (int i in listDaySo)
                    {
                        sum += i;
                    }
                    lbKetQuaChucNang.Text = "TBC dãy số là: " + (sum / listDaySo.Count).ToString();
                }
                if (cbbChonChucNang.SelectedItem.ToString() == "Đếm số phần tử âm")
                {
                    int dem = 0;
                    foreach (int i in listDaySo)
                    {
                        if (i < 0)
                        {
                            dem++;
                        }
                    }
                    lbKetQuaChucNang.Text = "Có " + dem + " phần tử âm";
                }
            }
        }
    }
}