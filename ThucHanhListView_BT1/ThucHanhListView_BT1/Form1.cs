using System.Collections.Generic;

namespace ThucHanhListView_BT1
{
    public partial class Form1 : Form
    {
        List<string> lMaPhong = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maPhong = txtMaPhong.Text;
            string tenPhong = txtTenPhong.Text;
            ListViewItem item = new ListViewItem();
            if(maPhong == "" || tenPhong == "")
            {
                MessageBox.Show("Hãy nhập đủ dữ liệu");
            }
            else
            {
                item.Text = maPhong;
                item.SubItems.Add(tenPhong);
            }
            if(lMaPhong.Contains(maPhong) == true)
            {
                MessageBox.Show("Phòng có mã " + maPhong + " đã tồn tại");
            }
            else
            {
                listView1.Items.Add(item);
                lMaPhong.Add(maPhong);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                int i = listView1.SelectedItems[0].Index;
                listView1.Items[i].SubItems[0].Text = txtMaPhong.Text;
                listView1.Items[i].SubItems[1].Text = txtTenPhong.Text;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                if(DialogResult.OK == MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.OKCancel))
                {
                    int i = listView1.SelectedItems[0].Index;
                    listView1.Items.RemoveAt(i);
                    lMaPhong.RemoveAt(i);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}