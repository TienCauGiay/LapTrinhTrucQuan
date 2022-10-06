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
    public partial class frmBDT1 : Form
    {
        List<string> listDapAn = new List<string>();
        List<TextBox> listTextbox = new List<TextBox>();
        public frmBDT1()
        {
            InitializeComponent();
        }

        private void frmBDT1_Load(object sender, EventArgs e)
        {
            //for(int i = 0; i < 10; i++)
            //{
            //    listDapAn.Add("dap an " + (i + 1));
            //}
            listDapAn.Add("dap an 1");
            listDapAn.Add("dap an 2");
            listDapAn.Add("dap an 3");
            listDapAn.Add("dap an 4");
            listDapAn.Add("dap an 5");
            listDapAn.Add("dap an 6");
            listDapAn.Add("dap an 7");
            listDapAn.Add("dap an 8");
            listDapAn.Add("dap an 9");
            listDapAn.Add("dap an 10");
            listTextbox.Add(txt1);
            listTextbox.Add(txt2);
            listTextbox.Add(txt3);
            listTextbox.Add(txt4);
            listTextbox.Add(txt5);
            listTextbox.Add(txt6);
            listTextbox.Add(txt7);
            listTextbox.Add(txt8);
            listTextbox.Add(txt9);
            listTextbox.Add(txt10);
        }

        // Kiểm tra textbox null
        public bool checkNullDapAn()
        {
            foreach(TextBox txt in listTextbox)
            {
                if (txt.Text == "")
                    return false;
            }
            return true;
        }

        // OK
        private void button1_Click(object sender, EventArgs e)
        {
            if(checkNullDapAn() == false)
            {
                MessageBox.Show("Không được bỏ trống các đáp án");
            }
            else
            {
                int diem = 0;
                for (int i = 0; i < 10; i++)
                {
                    if (listTextbox[i].Text == listDapAn[i])
                    {
                        listTextbox[i].BackColor = Color.LightBlue;
                        diem += 1;

                    }
                    else
                    {
                        listTextbox[i].BackColor = Color.Pink;
                    }
                }
                txtDiem.Text = diem.ToString();
            }
        }

        // Thoát
        private void button4_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Do you want exit?", "Thông báo", MessageBoxButtons.YesNo))
            {
                this.Close();
            }
        }

        // Làm lại
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "      My grandfather was bom in China. He came from a very poor \r\nfamily and was (1)____ of seven children. His parents lived \r\n(2)____ a small farm. He didn't have a very good education. At\r\nthe age of 17 he (3)____ home. First he went to Shanghai and \r\n(4)____ he went to Hong Kong. He worded (5)____ a waiter and\r\nthen as a cook. When he was 21, he (6)____ my grandmother and\r\nhad four children.\r\n      My mother was (7)____ oldest. My grandmother died recently, \r\nand my grandfather lives alone now. He is almost 80. (8)____ he \r\nis still very active and interested in everything (9)____ is going on. \r\nHe reads the papes and (10)____ televison even though his \r\neyesight is fairly poor.";
            txtDiem.Text = "";
            foreach(TextBox txt in listTextbox)
            {
                txt.Text = "";
                txt.BackColor = Color.White;
            }
            btnDapAn.Enabled = true;
        }

        // Đáp án
        private void button3_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                string s = "("+(i+1)+")____";
                richTextBox1.Find(s, 0, RichTextBoxFinds.None);
                richTextBox1.Focus();
                richTextBox1.SelectedText = "("+(i+1)+") " + listDapAn[i];
            }
            btnDapAn.Enabled = false;
        }
    }
}
