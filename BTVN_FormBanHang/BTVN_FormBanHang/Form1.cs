namespace BTVN_FormBanHang
{
    public partial class Form1 : Form
    {
        List<string> listHangDaMua;
        public Form1()
        {
            InitializeComponent();
            addProduct();
            listHangDaMua = new List<string>();
        }

        public void addProduct()
        {
            listBoxMatHang.Items.Add("Lập trình Java");
            listBoxMatHang.Items.Add("Tin học đại cương");
            listBoxMatHang.Items.Add("Thiết kế web");
            listBoxMatHang.Items.Add(".NET cơ bản");
            listBoxMatHang.Items.Add("Cấu trúc dữ liệu và giải thuật");
            listBoxMatHang.Items.Add("Phân tích thiết kế hệ thống");
            listBoxMatHang.Items.Add("Cơ sở dữ liệu");
            listBoxMatHang.Items.Add("Tiếng anh chuyên ngành");
            listBoxMatHang.Items.Add("Lập trình trực quan");
            listBoxMatHang.Items.Add("Triết học Mac-Lenin");
        }

        private void listBoxMatHang_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int check = 0;
            foreach(string s in listHangDaMua)
            {
                if(listBoxMatHang.SelectedItem.ToString() == s)
                {
                    check = 1;
                }
            }
            if(check == 1)
            {
                MessageBox.Show("Mặt hàng này đã được mua, k được mua lại");
            }
            else
            {
                listBoxHangDatMua.Items.Add(listBoxMatHang.SelectedItem.ToString());
                listHangDaMua.Add(listBoxMatHang.SelectedItem.ToString());
            }
        }

        private void listBoxHangDatMua_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int i = listBoxHangDatMua.SelectedIndex;
            if(DialogResult.OK == MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel))
            {
                listBoxHangDatMua.Items.RemoveAt(i);
                listHangDaMua.RemoveAt(i);
            }
        }

        public string pttt()
        {
            string s = "";
            if (checkBoxTienMat.Checked == true)
                s += checkBoxTienMat.Text + " | ";
            if (checkBoxSec.Checked == true)
                s += checkBoxSec.Text + " | ";
            if (checkBoxThe.Checked == true)
                s += checkBoxThe.Text + " | ";
            return s;
        }

        public string htll()
        {
            string s = "";
            if (checkBoxPhone.Checked == true)
                s += checkBoxPhone.Text + " | ";
            if (checkBoxFax.Checked == true)
                s += checkBoxFax.Text + " | ";
            if (checkBoxEmail.Checked == true)
                s += checkBoxEmail.Text + " | ";
            return s;
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            string lmh = "";
            foreach(string item in listHangDaMua)
            {
                lmh += item + " | ";
            }
            string s = txtName.Text + "\n"
                        + txtAddress.Text + "\n"
                        + lmh + "\n"
                        + "Phương thức thanh toán: " + pttt() + "\n"
                        + "Hình thức liên lạc: " + htll() + "\n";
            MessageBox.Show(s, "Thông tin khách hàng đã chọn");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Bạn có muốn thoát k?", "thông báo", MessageBoxButtons.YesNo))
            {
                this.Close();
            }
        }
    }
}