namespace BaiTapThem_Bai11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Bạn có muốn thoát k?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkDam.Checked = false;
            checkNghieng.Checked = false;
            checkGach.Checked = false;
            radDo.Checked = false;
            radXanh.Checked = false;
            radDen.Checked = false;
            cbbFont.SelectedIndex = -1;
            cbbKichThuoc.SelectedIndex = -1;
            txtKq.ForeColor = Color.Red;
            txtKq.Font = new Font("Segoe UI", 14);
            txtKq.Font = new Font(txtKq.Font, FontStyle.Underline | FontStyle.Regular);
        }

        private void cbbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbFont.SelectedIndex > -1)
            {
                string s = cbbFont.SelectedItem.ToString();
                txtKq.Font = new Font(s, txtKq.Font.Size, txtKq.Font.Style);
            }
        }

        private void cbbKichThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbKichThuoc.SelectedIndex > -1)
            {
                int kt = int.Parse(cbbKichThuoc.SelectedItem.ToString());
                txtKq.Font = new Font(txtKq.Font.FontFamily, kt, txtKq.Font.Style);
            }
        }

        private void checkDam_CheckedChanged(object sender, EventArgs e)
        {
            txtKq.Font = new Font(txtKq.Font, txtKq.Font.Style ^ FontStyle.Bold);
        }

        private void checkNghieng_CheckedChanged(object sender, EventArgs e)
        {
            txtKq.Font = new Font(txtKq.Font, txtKq.Font.Style ^ FontStyle.Italic);
        }

        private void checkGach_CheckedChanged(object sender, EventArgs e)
        {
            txtKq.Font = new Font(txtKq.Font, txtKq.Font.Style ^ FontStyle.Underline);
        }

        private void radDo_CheckedChanged(object sender, EventArgs e)
        {
            txtKq.ForeColor = Color.Red;
        }

        private void radXanh_CheckedChanged(object sender, EventArgs e)
        {
            txtKq.ForeColor = Color.Green;
        }

        private void radDen_CheckedChanged(object sender, EventArgs e)
        {
            txtKq.ForeColor = Color.Black;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtKq.Text = "BÙI NGỌC TIẾN";
        }
    }
}