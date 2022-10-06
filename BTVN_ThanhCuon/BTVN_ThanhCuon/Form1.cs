namespace BTVN_ThanhCuon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            this.BackColor = Color.FromArgb(barRed.Value, barGreen.Value, barBlue.Value);
            lbRed.Text = barRed.Value.ToString();
        }

        private void barGreen_Scroll(object sender, ScrollEventArgs e)
        {
            this.BackColor = Color.FromArgb(barRed.Value, barGreen.Value, barBlue.Value);
            lbGreen.Text = barGreen.Value.ToString();
        }

        private void barBlue_Scroll(object sender, ScrollEventArgs e)
        {
            this.BackColor = Color.FromArgb(barRed.Value, barGreen.Value, barBlue.Value);
            lbBlue.Text = barBlue.Value.ToString();
        }
    }
}