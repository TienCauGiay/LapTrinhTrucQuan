using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace BaiTapThem_Bai13
{
    public partial class Form1 : Form
    {
        List<int> listDaySo = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnTim.Enabled = false;
            btnTimSoDuong.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo))
            {
                Close();
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtNhapK.Text = "";
            txtNhapSPT.Text = "";
            lbDaySo.Text = "";
            lbTimSoDuong.Text = "";
            btnTim.Enabled = false;
            btnTimSoDuong.Enabled = false;
        }

        public bool isNumber(string ptext)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*$");
            return regex.IsMatch(ptext);
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            listDaySo.Clear();
            if(txtNhapSPT.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số phần tử");
            }
            else
            {
                if(isNumber(txtNhapSPT.Text) == true)
                {
                    int n = int.Parse(txtNhapSPT.Text);
                    Object[] a = new object[n];
                    for(int i = 0; i < n; i++)
                    {
                        do
                        {
                            a[i] = Interaction.InputBox("Nhập số thứ " + (i + 1), "Input", "");
                        } while (isNumber((string)a[i]) == false);
                    }
                    foreach(Object o in a)
                    {
                        listDaySo.Add(Convert.ToInt32(o.ToString()));
                    }
                    string s = "Dãy số vừa nhập là: ";
                    foreach(int so in listDaySo)
                    {
                        s += so.ToString() + " ";
                    }
                    lbDaySo.Text = s;
                    btnTim.Enabled = true;
                    btnTimSoDuong.Enabled = true;
                }
            }
        }

        private void btnTimSoDuong_Click(object sender, EventArgs e)
        {
            List<int> soDuong = new List<int>();
            foreach(int so in listDaySo)
            {
                if(so > 0)
                {
                    soDuong.Add(so);
                }
            }
            soDuong.Sort(
                (p1,p2) =>
                {
                    if(p1 < p2)
                    {
                        return -1;
                    }
                    if (p1 > p2)
                        return 1;
                    return 0;
                }
            );
            lbTimSoDuong.Text = "Số dương bé nhất là: " + soDuong[0].ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if(txtNhapK.Text != "")
            {
                if (isNumber(txtNhapK.Text) == true)
                {
                    int sct = int.Parse(txtNhapK.Text);
                    int dem = 0;
                    List<int> chiSo = new List<int>();
                    for (int i = 0; i < listDaySo.Count; i++)
                    {
                        if (listDaySo[i] == sct)
                        {
                            chiSo.Add(i);
                            dem++;
                        }
                    }
                    string vitri = "";
                    foreach (int i in chiSo)
                    {
                        vitri += (i + 1).ToString() + ", ";
                    }
                    if(vitri == "")
                    {
                        vitri = "-1 (không có trong dãy)";
                    }
                    else
                    {
                        vitri = vitri.Remove(vitri.Length - 2, 2);
                    }
                    MessageBox.Show("Số phần tử có giá trị bằng " + sct + " là " + dem + " phần tử nằm ở vị trí thứ " + vitri,"Thông báo");
                }
            }
        }
    }
}