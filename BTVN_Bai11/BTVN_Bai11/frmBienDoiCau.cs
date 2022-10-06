using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN_Bai11
{
    public partial class frmBienDoiCau : Form
    {
        List<TextBox> listTextBox = new List<TextBox> ();
        List<string> listDapan = new List<string>();
        List<Label> listLabel = new List<Label> ();
        public frmBienDoiCau()
        {
            InitializeComponent();
        }

        private void frmBienDoiCau_Load(object sender, EventArgs e)
        {
            listTextBox.Add(txt1);
            listTextBox.Add(txt2);
            listTextBox.Add(txt3);
            listTextBox.Add(txt4);
            listTextBox.Add(txt5);
            listTextBox.Add(txt6);
            listTextBox.Add(txt7);
            listTextBox.Add(txt8);
            listTextBox.Add(txt9);
            listTextBox.Add(txt10);
            listLabel.Add(lbKq1);
            listLabel.Add(lbKq2);
            listLabel.Add(lbKq3);
            listLabel.Add(lbKq4);
            listLabel.Add(lbKq5);
            listLabel.Add(lbKq6);
            listLabel.Add(lbKq7);
            listLabel.Add(lbKq8);
            listLabel.Add(lbKq9);
            listLabel.Add(lbKq10);
            listDapan.Add("You don't Day la dap an cau 1");
            listDapan.Add("Sally finally succeeded Day la dap an cau 2");
            listDapan.Add("You'd better Day la dap an cau 3");
            listDapan.Add("Peter apologised Day la dap an cau 4");
            listDapan.Add("He'd rather Day la dap an cau 5");
            listDapan.Add("I wish Day la dap an cau 6");
            listDapan.Add("It is such Day la dap an cau 7");
            listDapan.Add("In spite of Day la dap an cau 8");
            listDapan.Add("Although Day la dap an cau 9");
            listDapan.Add("John a is too Day la dap an cau 10");
        }

        public bool checkNullDapAn()
        {
            foreach(TextBox txt in listTextBox)
            {
                if (txt.Text == "")
                    return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!checkNullDapAn())
            {
                MessageBox.Show("Không được bỏ trống các câu trả lời");
            }
            else
            {
                int diem = 0;
                for(int i = 0; i < 10; i++)
                {
                    if (listTextBox[i].Text.Trim() == listDapan[i])
                    {
                        diem += 1;
                        listTextBox[i].BackColor = Color.LightBlue;
                    }
                    else
                    {
                        listTextBox[i].BackColor = Color.Pink;
                    }
                }
                txtDiemCuaBan.Text = diem.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Bạn có muốn thoát k ?", "Thông báo", MessageBoxButtons.YesNo))
            {
                this.Close();
            }
        }

        private void btnDapAn_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                listLabel[i].Text = listDapan[i].ToString();
            }
            btnDapAn.Enabled = false;
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            btnDapAn.Enabled = true;
            for(int i = 0; i < 10; i++)
            {
                listLabel[i].Text = "";
                txtDiemCuaBan.Text = "";
                listTextBox[i].BackColor = Color.White;
            }
            listTextBox[0].Text = "You don't";
            listTextBox[1].Text = "Sally finally succeeded";
            listTextBox[2].Text = "You'd better";
            listTextBox[3].Text = "Peter apologised";
            listTextBox[4].Text = "He'd rather";
            listTextBox[5].Text = "I wish";
            listTextBox[6].Text = "It is such";
            listTextBox[7].Text = "In spite of";
            listTextBox[8].Text = "Although";
            listTextBox[9].Text = "John a is too";
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string s = "Succeeded in doing\r\nHad better do something\r\nApologise to someone for doing something\r\nWould rather do domething than do something else\r\nI wish I had done\r\nSuch + noun + that\r\nIn spite of + noun/doing something\r\nAlthough + Clause\r\nTo be too + adj for something to do something";
            MessageBox.Show(s,"Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
