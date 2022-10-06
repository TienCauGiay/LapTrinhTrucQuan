namespace Tuan2_BTTuongTu_Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo))
            {
                this.Close();
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
            txtGiaDuThuyen.Text = "";
            txtTien.Text = "";
            radNuaNgay.Checked = false;
            radCaNgay.Checked = false;
            comboBoxChonDoUong.SelectedIndex = -1;
            comboBoxSoLuong.SelectedIndex = -1;
            txtHoTen.Focus();
        }

        private void radCaNgay_CheckedChanged(object sender, EventArgs e)
        {
            if(radCaNgay.Checked == true)
            {
                txtGiaDuThuyen.Text = "200";
            }
        }

        private void radNuaNgay_CheckedChanged(object sender, EventArgs e)
        {
            if(radNuaNgay.Checked == true)
            {
                txtGiaDuThuyen.Text = "100";
            }
        }

        private void txtTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSoLuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxSoLuong.SelectedIndex == -1)
            {

            }else
            {
                string tenDoUong = comboBoxChonDoUong.SelectedItem.ToString();
                int soLuong = int.Parse(comboBoxSoLuong.SelectedItem.ToString());
                if (tenDoUong.Equals("Coca cola"))
                    txtTien.Text = (0.5 * soLuong).ToString();
                if (tenDoUong.Equals("Pepsi"))
                    txtTien.Text = (0.8 * soLuong).ToString();
                if (tenDoUong.Equals("Seven up"))
                    txtTien.Text = (1 * soLuong).ToString();
            }
        }

        private void btnThemVaoDS_Click(object sender, EventArgs e)
        {
            string s = "";
            if(radCaNgay.Checked == true)
            {
                s = radCaNgay.Text;
            }
            if(radNuaNgay.Checked == true)
            {
                s = radNuaNgay.Text;
            }
            double tongTien = int.Parse(txtGiaDuThuyen.Text) + double.Parse(txtTien.Text);
            listBoxDSKhachDatTuor.Items.Add(txtHoTen.Text + " | " + s + " | " + txtGiaDuThuyen.Text + "$ | " + comboBoxChonDoUong.SelectedItem.ToString() + " " + comboBoxSoLuong.SelectedItem.ToString() + "$ | Tổng " + tongTien);
        }

        private void comboBoxChonDoUong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxChonDoUong.SelectedIndex == -1)
            {

            }
            else
            {
                if(comboBoxSoLuong.SelectedIndex > -1)
                {
                    string tenDoUong = comboBoxChonDoUong.SelectedItem.ToString();
                    int soLuong = int.Parse(comboBoxSoLuong.SelectedItem.ToString());
                    if (tenDoUong.Equals("Coca cola"))
                        txtTien.Text = (0.5 * soLuong).ToString();
                    if (tenDoUong.Equals("Pepsi"))
                        txtTien.Text = (0.8 * soLuong).ToString();
                    if (tenDoUong.Equals("Seven up"))
                        txtTien.Text = (1 * soLuong).ToString();
                }
            }
        }
    }
}