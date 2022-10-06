namespace BaiTapThem_TinhDienTich
{
    public partial class Form1 : Form
    {
        List<KhachHang> listKH;
        public Form1()
        {
            InitializeComponent();
            listKH = new List<KhachHang>();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes ==  MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtHoTenKH.Text = "";
            txtDiaChi.Text = "";
            txtNgayChotSo.Text = "";
            txtSoThangTruoc.Text = "";
            txtSoThangNay.Text = "";
            txtMaKH.Focus();
        }

        private void txtSoThangTruoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThemVaoDS_Click(object sender, EventArgs e)
        {
            int t = 1;
            int soThangTruoc = int.Parse(txtSoThangTruoc.Text);
            int soThangNay = int.Parse(txtSoThangNay.Text);
            if (txtMaKH.Text.Length < 6)
            {
                MessageBox.Show("Nhập lại mã khách hàng");
                t = 0;
            }
            if(txtHoTenKH.Text == "")
            {
                MessageBox.Show("Nhập lại họ tên ");
                t = 0;
            }
            if(txtDiaChi.Text == "")
            {
                MessageBox.Show("Nhập lại địa chỉ");
                t = 0;
            }
            if(DateTime.TryParse(txtNgayChotSo.Text, out DateTime dt) == false)
            {
                MessageBox.Show("Nhập lại ngày tháng năm (mm/dd/yyyy)");
                t = 0;
            }
            if(soThangTruoc > soThangNay)
            {
                MessageBox.Show("Số tháng trước k được lớn hơn số tháng này");
                t = 0;
            }
            if(t == 0)
            {
                MessageBox.Show("Input không đúng");
            } 
            else
            {
                int soDienTieuDung = soThangNay - soThangTruoc;
                double tienPhaiTra = 0;
                if(soDienTieuDung > 0 && soDienTieuDung <= 50) 
                {
                    tienPhaiTra = soDienTieuDung * 100;
                } else if(soDienTieuDung > 50 && soDienTieuDung <= 100)
                {
                    tienPhaiTra = (soDienTieuDung - 50) * 200 + 50 * 100 + 50 * 100 * 10 / 100;
                } else if(soDienTieuDung > 100 && soDienTieuDung <= 200)
                {
                    tienPhaiTra = (soDienTieuDung - 100) * 300 + 50 * 200 + 50 * 100 + (50 * 200 + 50 * 100) * 10 / 100;
                } else
                {
                    tienPhaiTra = (soDienTieuDung - 200) * 400 + 100 * 300 + 50 * 200 + 50 * 100 + (100 * 300 + 50 * 200 + 50 * 100) * 10 / 100;
                }
                listDanhSachKhachHang.Items.Add(txtMaKH.Text + " | " + txtHoTenKH.Text + " | " + txtDiaChi.Text + " | " + txtNgayChotSo.Text + " | "
                    + txtSoThangTruoc.Text + " | " + txtSoThangNay.Text + " | " + tienPhaiTra);
                listKH.Add(new KhachHang(txtMaKH.Text, txtHoTenKH.Text, txtDiaChi.Text, txtNgayChotSo.Text, soThangTruoc, soThangNay, tienPhaiTra));
                StaticData._KhachHang = listKH;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}