using System.IO;
using System.Linq.Expressions;

namespace Bai_20_BaiGiang
{
    public partial class frmNhungBaiHatHay : Form
    {
        public frmNhungBaiHatHay()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Rich Text Format|*.rtf";
            dlgOpen.InitialDirectory = "E:\\DHGTVT\\Lap_Trinh_Truc_Quan";
            dlgOpen.Title = "Chọn File để mở";
            if(dlgOpen.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(dlgOpen.FileName);
                try
                {
                    richTextBox1.Text = sr.ReadToEnd();
                    MessageBox.Show("Open file done");
                }
                catch
                {
                    MessageBox.Show("Open file error");
                }
                sr.Close();
            }
            else
            {
                MessageBox.Show("Bạn đã chọn Cancel");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlgSave = new SaveFileDialog();
            dlgSave.Filter = "Rich Text Format|*.rtf";
            dlgSave.InitialDirectory = "E:\\DHGTVT\\Lap_Trinh_Truc_Quan";
            dlgSave.Title = "Chọn file để lưu";
            dlgSave.AddExtension = true;
            dlgSave.DefaultExt = ".rtf";
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(dlgSave.FileName);
                try
                {
                    sw.Write(richTextBox1.Text);
                    MessageBox.Show("Lưu thành công");
                }
                catch
                {
                    MessageBox.Show("Lỗi ghi file");
                }
                sw.Close();
            }
            else
            {
                MessageBox.Show("Bạn đã chọn Cancel");
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog dlgFont = new FontDialog();
            dlgFont.ShowColor = true;
            if(dlgFont.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = dlgFont.Font;
                richTextBox1.ForeColor = dlgFont.Color;
            }
            else
            {
                MessageBox.Show("Bạn đã chọn Cancel");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("bạn có muốn thoát k?","Thông báo", MessageBoxButtons.YesNo))
            {
                this.Close();
            } 
        }
    }
}