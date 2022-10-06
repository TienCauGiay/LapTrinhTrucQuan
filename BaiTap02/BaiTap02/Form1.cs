namespace BaiTap02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinhToan_Click(object sender, EventArgs e)
        {
            double x1, y1, x2, y2; 
            x1 = double.Parse(txtDTNX.Text);
            y1 = double.Parse(txtDTNY.Text);
            x2 = double.Parse(txtDTHX.Text);
            y2 = double.Parse(txtDTHY.Text);

            txtHSG.Text = ((y2 - y1) / (x2 - x1)).ToString();
            txtKC.Text = (Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2))).ToString();
        }
    }
}