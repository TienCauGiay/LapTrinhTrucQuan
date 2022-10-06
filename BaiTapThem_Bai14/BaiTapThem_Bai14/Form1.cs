namespace BaiTapThem_Bai14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Bạn có muốn thoát k?", "Thông báo", MessageBoxButtons.YesNo))
            {
                Close();
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
            cbbKhoa.SelectedIndex = -1;
            cbbKhoas.SelectedIndex = -1;
            listBoxDSGT.SelectedIndex = -1;
        }

        public bool checkDK()
        {
            if (txtHoTen.Text == "")
                return false;
            if (cbbKhoa.SelectedIndex == -1)
                return false;
            if (cbbKhoas.SelectedIndex == -1)
                return false;
            if (listBoxDSGT.SelectedIndex == -1)
                return false;
            return true;
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            if(checkDK() == false)
            {
                MessageBox.Show("Hãy nhập đủ thông tin");
            }
            else
            {
                int stt = listBoxDSSVM.Items.Count;
                string dssvm = "";
                foreach(string s in listBoxDSGT.SelectedItems)
                {
                    dssvm += s + ", ";
                }
                if(dssvm != "")
                {
                    dssvm = dssvm.Remove(dssvm.Length - 2, 2);
                }
                listBoxDSSVM.Items.Add((stt + 1).ToString()+ "." + txtHoTen.Text + " " + cbbKhoa.SelectedItem.ToString() + " K" + cbbKhoas.SelectedItem.ToString() + "ĐK:" + dssvm);
                listBoxDSGT.SelectedIndex = -1;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(listBoxDSSVM.SelectedIndex <= -1)
            {
                MessageBox.Show("Chọn phần tử để xóa");
            }
            else
            {
                if(DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo))
                {
                    while(listBoxDSSVM.SelectedItems.Count > 0)
                    {
                        listBoxDSSVM.Items.Remove((string)listBoxDSSVM.SelectedItems[0]);
                    }
                    int n = listBoxDSSVM.Items.Count;
                    int dem = 1;
                    for(int i = 0; i < n; i++)
                    {
                        string s = listBoxDSSVM.Items[i].ToString();
                        s = s.Remove(0, 1);
                        listBoxDSSVM.Items[i] = dem.ToString() + s;
                        dem++;
                    }
                }
                else
                {
                    listBoxDSSVM.SelectedIndex = -1;
                }
            }
        }
    }
}