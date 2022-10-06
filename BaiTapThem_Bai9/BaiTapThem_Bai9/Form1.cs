namespace BaiTapThem_Bai9
{
    public partial class Form1 : Form
    {
        List<Sach> lSach = new List<Sach>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KhoiTaoSach();
        }

        private void KhoiTaoSach()
        {
            Sach s1 = new Sach()
            {
                tenSach = "Tin đại cương",
                gia = 22000,
                soLuong = 0
            };
            Sach s2 = new Sach()
            {
                tenSach = "Tiếng Anh F2",
                gia = 27000,
                soLuong = 0
            };
            Sach s3 = new Sach()
            {
                tenSach = "Giải tích F1",
                gia = 25000,
                soLuong = 0
            };
            Sach s4 = new Sach()
            {
                tenSach = "Đại số tuyến tính",
                gia = 26000,
                soLuong = 0
            };

            lSach.Add(s1);
            lSach.Add(s2);
            lSach.Add(s3);
            lSach.Add(s4);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo))
            {
                Close();
            }
        }

        private void cbbTenSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbTenSach.SelectedIndex > -1)
            {
                foreach (Sach s in lSach)
                {
                    if (cbbTenSach.SelectedItem.ToString() == s.tenSach.ToString())
                    {
                        txtGia.Text = Convert.ToString(s.gia);
                    }
                }
            }
        }

        private void radTienMat_CheckedChanged(object sender, EventArgs e)
        {
            if(radTienMat.Checked == true)
            {
                txtGiamGia.Text = Convert.ToString(5);
            }
        }

        private void radThe_CheckedChanged(object sender, EventArgs e)
        {
            if (radThe.Checked == true)
            {
                txtGiamGia.Text = Convert.ToString(10);
            }
        }

        public bool checkNhapDuLieu()
        {
            if(cbbTenSach.SelectedIndex == -1 || txtSoLuong.Text == "" || (radThe.Checked == false && radTienMat.Checked == false))
                return false;
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(checkNhapDuLieu() == false)
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu");
            }
            else
            {
                double thanhTien = 0;
                thanhTien = int.Parse(txtSoLuong.Text) * int.Parse(txtGia.Text) * (1 - double.Parse(txtGiamGia.Text) / 100);
                listBox1.Items.Add(cbbTenSach.SelectedItem.ToString() + ", " + txtSoLuong.Text + " - " + Convert.ToString(thanhTien));
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn phần tử để xóa");
            }
            else
            {
                int i = listBox1.SelectedIndex;
                if(DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo))
                {
                    listBox1.Items.RemoveAt(i);
                }
            }
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            int n = listBox1.Items.Count;
            List<double> l = new List<double>();
            for(int i = 0; i < n; i++)
            {
                int j = listBox1.Items[i].ToString().IndexOf("-") + 2;
                int size = listBox1.Items[i].ToString().Length;
                string s = listBox1.Items[i].ToString();
                double tt = Convert.ToDouble(s.Substring(j,size - j));
                l.Add(tt);
            }
            double tongTien = 0;
            foreach(double d in l)
            {
                tongTien = d;
            }
            txtTongTien.Text = (double.Parse(txtTongTien.Text) + tongTien).ToString();
        }
    }
}