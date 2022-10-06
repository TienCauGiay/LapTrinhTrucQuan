namespace ThucHanhTuan_02_Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addData();
        }

        private void addData()
        {
            listBoxDanhSachMH.Items.Add("Kĩ thuật lập trình C#");
            listBoxDanhSachMH.Items.Add("Tự học Visual C# trong 21 ngày");
            listBoxDanhSachMH.Items.Add("Bài tập C#");
            listBoxDanhSachMH.Items.Add(".NET toàn tập - Tập 1");
            listBoxDanhSachMH.Items.Add(".NET toàn tập - Tập 2");
            listBoxDanhSachMH.Items.Add(".NET toàn tập - Tập 3");
            listBoxDanhSachMH.Items.Add(".NET toàn tập - Tập 4");
            listBoxDanhSachMH.Items.Add("Tin học cơ bản");
            listBoxDanhSachMH.Items.Add("SQL server");
            listBoxDanhSachMH.Items.Add("Cơ bản về XML");
            listBoxDanhSachMH.Items.Add("Phân tích thiết kế hệ thống");
            listBoxDanhSachMH.Items.Add("Sử dụng Word");
            listBoxDanhSachMH.Items.Add("Đến với Word 2003");
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void listBoxDanhSachMH_DoubleClick(object sender, EventArgs e)
        {
            string curItem = listBoxDanhSachMH.SelectedItem.ToString();

            int index = listBoxHangDatMua.FindString(curItem);

            if (index == -1)
            {
                listBoxHangDatMua.Items.Add(curItem);
            }
            else
            {
                MessageBox.Show( curItem + " đã có rồi");
            }
        }

        private void listBoxHangDatMua_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listBoxHangDatMua.SelectedIndex;
            if(index != -1)
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) 
                listBoxHangDatMua.Items.RemoveAt(index);
        }

        private string HinhThucLL()
        {
            string a = "Hình thức liên lạc: ";
            if(checkBoxDienThoai.Checked == true)
            {
                a += " " + checkBoxDienThoai.Text;
            }
            if(checkBoxEmail.Checked == true)
            {
                a += " " + checkBoxEmail.Text;
            }
            if(checkBoxFax.Checked == true)
            {
                a += " " + checkBoxFax.Text;
            }
            return a;
        }

        private string ThanhToan()
        {
            string s = "Hình thức thanh toán: ";
            if(radTienMat.Checked == true)
            {
                s += radTienMat.Text;
            }
            if (radSec.Checked == true)
            {
                s += radSec.Text;
            }
            if (radTheTinDung.Checked == true)
            {
                s += radTheTinDung.Text;
            }
            return s;
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            string s ="Họ tên: " + txtHoTen.Text + "\n"
                + "Điện thoại: " + txtDienThoai.Text + "\n" +
                HinhThucLL()+ "\n" + ThanhToan() + "\n"
                + "Danh sách mặt hàng: \n";
            if(txtHoTen.Text.Equals("") || txtDienThoai.Text.Equals(""))
            {
                MessageBox.Show("Bạn cần nhập đủ thông tin", "Thông báo");
                txtHoTen.Focus();
            }    
            else
            {
                foreach(object item in listBoxHangDatMua.Items)
                {
                    s += (item.ToString()) + "\n";
                }
            }

            MessageBox.Show(s.ToString(), "Thông tin khách hàng đã chọn");
        }
    }
    }  