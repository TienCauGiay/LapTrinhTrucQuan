using System.Drawing;

namespace ThucHanhListView_BT2
{
    public partial class Form1 : Form
    {
        List<string> listTenMonHoc = new List<string>();
        List<int> listSoTinChi = new List<int>();
        List<double> listDiem = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThemVaoDS_Click(object sender, EventArgs e)
        {
            string tenMonHoc = comboTenMonHoc.SelectedItem.ToString();
            int soTinChi = int.Parse(txtSoTinChi.Text);
            double diem = double.Parse(txtDiem.Text);
            ListViewItem item = new ListViewItem();
            if (tenMonHoc.Equals("") || soTinChi.Equals("") || diem.Equals(""))
            {
                MessageBox.Show("Hãy nhập đủ dữ liệu");
            }
            else
            {
                item.Text = tenMonHoc;
                item.SubItems.Add(soTinChi.ToString());
                item.SubItems.Add(diem.ToString());
            }
            if (listTenMonHoc.Contains(tenMonHoc) == true)
            {
                MessageBox.Show("Đã có rồi");
            }
            else
            {
                listView1.Items.Add(item);
                listTenMonHoc.Add(tenMonHoc);
                listSoTinChi.Add(soTinChi);
                listDiem.Add(diem);
            }
        }

        private void txtSoTinChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int sumSoTinChi = 0;
            foreach(int stc in listSoTinChi)
            {
                sumSoTinChi += stc;
            }
            txtTongSoTinChi.Text = sumSoTinChi.ToString();
            double tongSoDiem = 0;
            foreach(double diem in listDiem)
            {
                tongSoDiem += diem;
            }
            txtTongSoDiem.Text = tongSoDiem.ToString();

            int n = listDiem.Count;
            double dtb = 0;
            for(int i = 0; i < n; i++)
            {
                dtb += (listDiem[i] * listSoTinChi[i]) / sumSoTinChi;
            }
            dtb = Math.Round(dtb, 2);
            txtDiemTrungBinh.Text = dtb.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int i = listView1.SelectedItems[0].Index;
                listView1.Items[i].SubItems[0].Text = comboTenMonHoc.SelectedItem.ToString();
                listView1.Items[i].SubItems[1].Text = txtSoTinChi.Text;
                listView1.Items[i].SubItems[2].Text = txtDiem.Text;
            }
        }

        private void btnXoaKhoiDS_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (DialogResult.OK == MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel))
                {
                    int i = listView1.SelectedItems[0].Index;
                    listView1.Items.RemoveAt(i);
                    listTenMonHoc.RemoveAt(i);
                    listSoTinChi.RemoveAt(i);
                    listDiem.RemoveAt(i);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar) || Convert.ToInt16(e.KeyChar) == 8 || e.KeyChar == '.') {

            }
            else
            {
                e.Handled = true;
            }
        }
    }
}