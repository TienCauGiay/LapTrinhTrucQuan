using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTVN_Bai10
{
    public partial class Form1 : Form
    {
        string pathName = "";
        List<string> lHoa = new List<string>();
        public Form1()
        {
            InitializeComponent();
            lHoa.Add("Hoa Thược dược");
            lHoa.Add("Hoa Tường vi dại");
            lHoa.Add("Hoa Mai");
            lHoa.Add("Hoa Sen");
            lHoa.Add("Hoa Lý"); 
            lHoa.Add("Hoa Lan");
            lHoa.Add("Hoa Cẩm Qui (Mauve )");
            lHoa.Add("Hoa Immotet( bất tử)");
            lHoa.Add("Hoa Đinh hương (Lilas ]");
            lHoa.Add("Hoa Cẩm Nhung");
            lHoa.Add("Hoa Cẩm Chướng");
            lHoa.Add("Hoa Cúc");
            lHoa.Add("Hoa Thiên Lý");
            lHoa.Add("Hoa Huệ");
            lHoa.Add("Hoa Thủy Tiên");
            lHoa.Add("Hoa Phương Chúc");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo))
            {
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Rich Text Format|*.rtf";
            openFileDialog.InitialDirectory = "E:\\DHGTVT\\Lap_Trinh_Truc_Quan";
            openFileDialog.Title = "Chọn File để mở";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog.FileName);
                pathName = openFileDialog.FileName;
                try
                {
                    richTextBox1.Text = sr.ReadToEnd();
                    MessageBox.Show("Open file done");
                }
                catch
                {
                    MessageBox.Show("Open file Error");
                }
                sr.Close();
            }
            else
            {
                MessageBox.Show("Đã thoát");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(pathName);
            try
            {
                sw.Write(richTextBox1.Text);
                MessageBox.Show("Lưu thành công");
            }
            catch
            {
                MessageBox.Show("Error");
            }
            sw.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Rich Text Format|*.rtf";
            saveFileDialog.InitialDirectory = "E:\\DHGTVT\\Lap_Trinh_Truc_Quan";
            saveFileDialog.Title = "Lưu file";
            saveFileDialog.AddExtension = true;
            saveFileDialog.DefaultExt = ".rtf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                try
                {
                    sw.Write(richTextBox1.Text);
                    MessageBox.Show("Save done");
                }
                catch
                {
                    MessageBox.Show("Save Error");
                }
                sw.Close();
            }
            else
            {
                MessageBox.Show("Đã thoát");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true;
            if(fontDialog.ShowDialog() == DialogResult.OK)
            {
                foreach(string word in lHoa)
                {
                    int strarindex = 0;
                    while (strarindex < richTextBox1.TextLength)
                    {
                        int wordStarIndex = richTextBox1.Find(word, strarindex, RichTextBoxFinds.None);
                        if (wordStarIndex != -1)
                        {
                            richTextBox1.SelectionStart = wordStarIndex;
                            richTextBox1.SelectionLength = word.Length;
                            richTextBox1.SelectionFont = fontDialog.Font;
                        }
                        else
                            break;
                        strarindex += wordStarIndex + word.Length;
                    }
                }
            }
            else
            {
                MessageBox.Show("Đã thoát");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true;
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string word in lHoa)
                {
                    int strarindex = 0;
                    while (strarindex < richTextBox1.TextLength)
                    {
                        int wordStarIndex = richTextBox1.Find(word, strarindex, RichTextBoxFinds.None);
                        if (wordStarIndex != -1)
                        {
                            richTextBox1.SelectionStart = wordStarIndex;
                            richTextBox1.SelectionLength = word.Length;
                            richTextBox1.SelectionColor = fontDialog.Color;
                        }
                        else
                            break;
                        strarindex += wordStarIndex + word.Length;
                    }
                }
            }
            else
            {
                MessageBox.Show("Đã thoát");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if(printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, new Font("Arial", 30, FontStyle.Bold), Brushes.Black, 100, 50);
        }

        private void coppyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.SelectedText);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += Clipboard.GetText();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.SelectedText);
            richTextBox1.SelectedText = "";
        }

        private void mởToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }
    }
}
