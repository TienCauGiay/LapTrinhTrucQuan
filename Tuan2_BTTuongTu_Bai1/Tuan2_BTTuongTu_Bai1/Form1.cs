namespace Tuan2_BTTuongTu_Bai1
{
    public partial class Form1 : Form
    {
        List<int> listSoTinChi = new List<int>();
        List<double> listDiem = new List<double>();  
        List<string> listTenMonHoc = new List<string>();
        public Form1()
        {
            InitializeComponent();
            //listTenMonHoc.Add("Tin học đại cương");
            //listTenMonHoc.Add("Giải tích F1");
            //listTenMonHoc.Add("Tiếng Anh A0");
            //listTenMonHoc.Add("Triết học Mác – Lênin");
            //listTenMonHoc.Add("Vật lý F1");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo))
            {
                this.Close();
            }
        }

        private void comboBoxTenMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTenMonHoc.SelectedItem.ToString() == "Tin học đại cương")
                txtSoTinChi.Text = "2";
            if (comboBoxTenMonHoc.SelectedItem.ToString() == "Giải tích F1")
                txtSoTinChi.Text = "3";
            if (comboBoxTenMonHoc.SelectedItem.ToString() == "Tiếng Anh A0")
                txtSoTinChi.Text = "3";
            if (comboBoxTenMonHoc.SelectedItem.ToString() == "Triết học Mác - Lênin")
                txtSoTinChi.Text = "2";
            if (comboBoxTenMonHoc.SelectedItem.ToString() == "Vật lý F1")
                txtSoTinChi.Text = "3";
        }

        private void txtDiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar) || Convert.ToUInt16(e.KeyChar) == 8 || e.KeyChar == '.')
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnThemVaoDanhSach_Click(object sender, EventArgs e)
        {
            if(txtDiem.Text == "")
            {
                MessageBox.Show("Chưa nhập điểm");
            }
            else
            {
                string tenMonHoc = comboBoxTenMonHoc.SelectedItem.ToString();
                int soTinChi = int.Parse(txtSoTinChi.Text);
                double diem = double.Parse(txtDiem.Text);
                listDanhSachCacMonHoc.Items.Add(tenMonHoc + " | " + soTinChi + " | " + diem);
                listSoTinChi.Add(soTinChi);
                listDiem.Add(diem);
                listTenMonHoc.Add(tenMonHoc);
            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int dem1 = 0;
            foreach(string s in listTenMonHoc)
            {
                if ("Tin học đại cương".Equals(s) == true)
                    dem1++;
            }
            if (dem1 == 0)
                MessageBox.Show("Thêm môn học Tin học đại cương vào danh sách");
            int dem2 = 0;
            foreach (string s in listTenMonHoc)
            {
                if ("Giải tích F1".Equals(s) == true)
                    dem2++;
            }
            if (dem2 == 0)
                MessageBox.Show("Thêm môn học Giải tích F1 vào danh sách");
            int dem3 = 0;
            foreach (string s in listTenMonHoc)
            {
                if ("Tiếng Anh A0".Equals(s) == true)
                    dem3++;
            }
            if (dem3 == 0)
                MessageBox.Show("Thêm môn học Tiếng Anh A0 vào danh sách");
            int dem4 = 0;
            foreach (string s in listTenMonHoc)
            {
                if ("Triết học Mác - Lênin".Equals(s) == true)
                    dem4++;
            }
            if (dem4 == 0)
                MessageBox.Show("Thêm môn học Triết học Mác - Lênin vào danh sách");
            int dem5 = 0;
            foreach (string s in listTenMonHoc)
            {
                if ("Vật lý F1".Equals(s) == true)
                    dem5++;
            }
            if (dem5 == 0)
                MessageBox.Show("Thêm môn học Vật lý F1 vào danh sách");
            int tongSoTinChi = 0;
            foreach(int stc in listSoTinChi)
            {
                tongSoTinChi += stc;
            }
            txtTongSoTinChi.Text = tongSoTinChi.ToString();
            int n = listSoTinChi.Count;
            double tongSoDiem = 0;
            for(int i = 0; i < n; i++)
            {
                tongSoDiem += listSoTinChi[i] * listDiem[i];
            }
            txtTongSoDiem.Text = tongSoDiem.ToString();
            txtDiemTrungBinh.Text = Math.Round((tongSoDiem / tongSoTinChi), 2).ToString();
        }
    }
}