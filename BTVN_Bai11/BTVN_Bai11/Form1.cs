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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void baiDienTu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBDT1 f = new frmBDT1();
            f.ShowDialog();
        }

        private void bienDoiCauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBienDoiCau f = new frmBienDoiCau();
            f.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Bạn có muốn thoát k?", "Thông báo", MessageBoxButtons.YesNo))
            {
                this.Close();
            }
        }
    }
}
