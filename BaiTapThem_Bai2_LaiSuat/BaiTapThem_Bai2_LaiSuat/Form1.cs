namespace BaiTapThem_Bai2_LaiSuat
{
    public partial class Form1 : Form
    {
        List<Nguoi> lNguoi;
        public Form1()
        {
            lNguoi = new List<Nguoi>();
            InitializeComponent();
        }

        private void txtMaKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoTienGui_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtHotenKH.Text = "";
            txtDiaChi.Text = "";
            txtSoTienGui.Text = "";
            txtNgayGui.Text = "";
            radThuong.Checked = false;
            radPhatLoc.Checked = false;
            cbbThoiGianGui.SelectedIndex = -1;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo))
            {
                this.Close();
            }
        }

        private void btnThemVaoDS_Click(object sender, EventArgs e)
        {
            int check = 1;
            double tienlai = 0;
            if(txtMaKH.Text.Length < 6 || txtHotenKH.Text == "" || txtDiaChi.Text == "" || DateTime.TryParse(txtNgayGui.Text, out DateTime dt))
            {
                check = 0;
            }
            if(check == 0)
            {
                MessageBox.Show("Nhập lại");
            }
            else
            {
                if (radThuong.Checked == true)
                {
                    if (cbbThoiGianGui.SelectedItem == "1")
                    {
                        tienlai = Convert.ToInt32(txtSoTienGui.Text) * 0.06;
                    }
                    if (cbbThoiGianGui.SelectedItem == "3")
                    {
                        tienlai = Convert.ToInt32(txtSoTienGui.Text) * 0.07;
                    }
                    if (cbbThoiGianGui.SelectedItem == "6")
                    {
                        tienlai = Convert.ToInt32(txtSoTienGui.Text) * 0.08;
                    }
                    if (cbbThoiGianGui.SelectedItem == "12")
                    {
                        tienlai = Convert.ToDouble(txtSoTienGui.Text) * 0.09;
                    }
                }
                else if (radPhatLoc.Checked == true)
                {
                    if (cbbThoiGianGui.SelectedItem == "1")
                    {
                        tienlai = Convert.ToInt32(txtSoTienGui.Text) * 0.07;
                    }
                    if (cbbThoiGianGui.SelectedItem == "3")
                    {
                        tienlai = Convert.ToInt32(txtSoTienGui.Text) * 0.08;
                    }
                    if (cbbThoiGianGui.SelectedItem == "6")
                    {
                        tienlai = Convert.ToInt32(txtSoTienGui.Text) * 0.09;
                    }
                    if (cbbThoiGianGui.SelectedItem == "12")
                    {
                        tienlai = Convert.ToInt32(txtSoTienGui.Text) * 0.1;
                    }
                }
                listBox1.Items.Add(txtMaKH.Text + " | " + txtHotenKH.Text + " | " +
                    txtDiaChi.Text + " | " + txtNgayGui.Text + " | " + txtSoTienGui.Text + " | "
                    + cbbThoiGianGui.Text + " tháng | " + "Tiền lãi" + tienlai);
                Nguoi n = new Nguoi(int.Parse(txtMaKH.Text), txtHotenKH.Text, txtDiaChi.Text, int.Parse(txtSoTienGui.Text), txtNgayGui.Text, cbbThoiGianGui.Text, (tienlai + int.Parse(txtSoTienGui.Text)));
                lNguoi.Add(n);
                BasicData._Nguoi = lNguoi;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}