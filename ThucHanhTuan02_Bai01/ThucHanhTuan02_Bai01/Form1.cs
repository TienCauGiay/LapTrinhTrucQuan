namespace ThucHanhTuan02_Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void EmptyOption()
        {
            radcAnkara.Checked = false;
            radcBrazil.Checked = false;
            radcBuenosAires.Checked = false;
            radcBudapest.Checked = false;
            radcLondon.Checked = false;
            radcMadrid.Checked = false;
            radcParis.Checked = false;
            radcRome.Checked = false;
            radcTokyo.Checked = false;
            radcWashington.Checked = false;
        }

        private string getNotification(string country)
        {
            EmptyOption();
            return "Hãy chọn thành phố cho " + country;
        }

        private void radFrance_CheckedChanged(object sender, EventArgs e)
        {
            lbYeuCau.Text = getNotification(radFrance.Text);
        }

        private void radJapan_CheckedChanged(object sender, EventArgs e)
        {
            lbYeuCau.Text = getNotification(radJapan.Text);
        }

        private void radHungary_CheckedChanged(object sender, EventArgs e)
        {
            lbYeuCau.Text = getNotification(radHungary.Text);
        }

        private void radSpain_CheckedChanged(object sender, EventArgs e)
        {
            lbYeuCau.Text = getNotification(radSpain.Text);
        }

        private void radTurkey_CheckedChanged(object sender, EventArgs e)
        {
            lbYeuCau.Text = getNotification(radTurkey.Text);
        }

        private void radTheUK_CheckedChanged(object sender, EventArgs e)
        {
            lbYeuCau.Text = getNotification(radTheUK.Text);
        }

        private void radItalia_CheckedChanged(object sender, EventArgs e)
        {
            lbYeuCau.Text = getNotification(radItalia.Text);
        }

        private void radArgentina_CheckedChanged(object sender, EventArgs e)
        {
            lbYeuCau.Text = getNotification(radArgentina.Text);
        }

        private void radBrazil_CheckedChanged(object sender, EventArgs e)
        {
            lbYeuCau.Text = getNotification(radBrazil.Text);
        }

        private void radTheUSA_CheckedChanged(object sender, EventArgs e)
        {
            lbYeuCau.Text = getNotification(radTheUSA.Text);
        }

        private void radcBuenosAires_CheckedChanged(object sender, EventArgs e)
        {
            if(radArgentina.Checked == true && radcBuenosAires.Checked == true)
            {
                lbYeuCau.Text = "Chúc mừng bạn, thủ đô của " + radArgentina.Text + " là " + radcBuenosAires.Text;
            }
            else
            {
                lbYeuCau.Text = "Sai rồi ";
            }
        }

        private void radcBrazil_CheckedChanged(object sender, EventArgs e)
        {
            if (radBrazil.Checked == true && radcBrazil.Checked == true)
            {
                lbYeuCau.Text = "Chúc mừng bạn, thủ đô của " + radBrazil.Text + " là " + radcBrazil.Text;
            }
            else
            {
                lbYeuCau.Text = "Sai rồi ";
            }
        }

        private void radcTokyo_CheckedChanged(object sender, EventArgs e)
        {
            if (radJapan.Checked == true && radcTokyo.Checked == true)
            {
                lbYeuCau.Text = "Chúc mừng bạn, thủ đô của " + radJapan.Text + " là " + radcTokyo.Text;
            }
            else
            {
                lbYeuCau.Text = "Sai rồi ";
            }
        }

        private void radcRome_CheckedChanged(object sender, EventArgs e)
        {
            if (radItalia.Checked == true && radcRome.Checked == true)
            {
                lbYeuCau.Text = "Chúc mừng bạn, thủ đô của " + radItalia.Text + " là " + radcRome.Text;
            }
            else
            {
                lbYeuCau.Text = "Sai rồi ";
            }
        }

        private void radcWashington_CheckedChanged(object sender, EventArgs e)
        {
            if (radTheUSA.Checked == true && radcWashington.Checked == true)
            {
                lbYeuCau.Text = "Chúc mừng bạn, thủ đô của " + radTheUSA.Text + " là " + radcWashington.Text;
            }
            else
            {
                lbYeuCau.Text = "Sai rồi ";
            }
        }

        private void radcMadrid_CheckedChanged(object sender, EventArgs e)
        {
            if (radSpain.Checked == true && radcMadrid.Checked == true)
            {
                lbYeuCau.Text = "Chúc mừng bạn, thủ đô của " + radSpain.Text + " là " + radcMadrid.Text;
            }
            else
            {
                lbYeuCau.Text = "Sai rồi ";
            }
        }

        private void radcLondon_CheckedChanged(object sender, EventArgs e)
        {
            if (radTheUK.Checked == true && radcLondon.Checked == true)
            {
                lbYeuCau.Text = "Chúc mừng bạn, thủ đô của " + radTheUK.Text + " là " + radcLondon.Text;
            }
            else
            {
                lbYeuCau.Text = "Sai rồi ";
            }
        }

        private void radcAnkara_CheckedChanged(object sender, EventArgs e)
        {
            if (radTurkey.Checked == true && radcAnkara.Checked == true)
            {
                lbYeuCau.Text = "Chúc mừng bạn, thủ đô của " + radTurkey.Text + " là " + radcAnkara.Text;
            }
            else
            {
                lbYeuCau.Text = "Sai rồi ";
            }
        }

        private void radcBudapest_CheckedChanged(object sender, EventArgs e)
        {
            if (radHungary.Checked == true && radcBudapest.Checked == true)
            {
                lbYeuCau.Text = "Chúc mừng bạn, thủ đô của " + radHungary.Text + " là " + radcBudapest.Text;
            }
            else
            {
                lbYeuCau.Text = "Sai rồi ";
            }
        }

        private void radcParis_CheckedChanged(object sender, EventArgs e)
        {
            if (radFrance.Checked == true && radcParis.Checked == true)
            {
                lbYeuCau.Text = "Chúc mừng bạn, thủ đô của " + radFrance.Text + " là " + radcParis.Text;
            }
            else
            {
                lbYeuCau.Text = "Sai rồi ";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}