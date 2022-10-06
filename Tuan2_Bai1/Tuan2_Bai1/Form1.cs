using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Tuan2_Bai1
{
    public partial class Form1 : Form
    {
        List<Nguoi> lNguoi;
        public Form1()
        {
            InitializeComponent();
            lNguoi = new List<Nguoi>();
        }

        private void txtMaKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoTienGui_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtHoTenKH.Text = "";
            txtDiaChi.Text = "";
            txtSoTienGui.Text = "";
            txtNgayGui.Text = "";
            radThuong.Checked = false;
            radPhatLoc.Checked = false;
            comboBoxThoiGianGui.SelectedIndex = -1;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }

        private void btnThemVao_Click(object sender, EventArgs e)
        {
            int check = 1;
            double tienlai = 0;
            if (txtMaKH.Text.Length < 6)
            {
                check = 0;
                MessageBox.Show("Lỗi maKH");
            }
            if (txtHoTenKH.Text == "")
            {
                check = 0;
                MessageBox.Show("Lỗi tenKH");
            }
            if (txtDiaChi.Text == "")
            {
                check = 0;
                MessageBox.Show("Lỗi diaChi");
            }
            if (DateTime.TryParse(txtNgayGui.Text, out DateTime dt) == false)
            {
                check = 0;
                MessageBox.Show("Lỗi ngay");
            }

            if (check == 0)
            {
                MessageBox.Show("Nhập lại");
            }
            else
            {
                if (radThuong.Checked == true)
                {
                    if (comboBoxThoiGianGui.SelectedItem == "1")
                    {
                        tienlai = Convert.ToInt32(txtSoTienGui.Text) * 0.06;
                    }
                    if (comboBoxThoiGianGui.SelectedItem == "3")
                    {
                        tienlai = Convert.ToInt32(txtSoTienGui.Text) * 0.07;
                    }
                    if (comboBoxThoiGianGui.SelectedItem == "6")
                    {
                        tienlai = Convert.ToInt32(txtSoTienGui.Text) * 0.08;
                    }
                    if (comboBoxThoiGianGui.SelectedItem == "12")
                    {
                        tienlai = Convert.ToDouble(txtSoTienGui.Text) * 0.09;
                    }
                }
                else if (radPhatLoc.Checked == true)
                {
                    if (comboBoxThoiGianGui.SelectedItem == "1")
                    {
                        tienlai = Convert.ToInt32(txtSoTienGui.Text) * 0.07;
                    }
                    if (comboBoxThoiGianGui.SelectedItem == "3")
                    {
                        tienlai = Convert.ToInt32(txtSoTienGui.Text) * 0.08;
                    }
                    if (comboBoxThoiGianGui.SelectedItem == "6")
                    {
                        tienlai = Convert.ToInt32(txtSoTienGui.Text) * 0.09;
                    }
                    if (comboBoxThoiGianGui.SelectedItem == "12")
                    {
                        tienlai = Convert.ToInt32(txtSoTienGui.Text) * 0.1;
                    }
                }
            }
            listDanhSach.Items.Add(txtMaKH.Text + " | " + txtHoTenKH.Text + " | " +
                    txtDiaChi.Text + " | " + txtNgayGui.Text + " | " + txtSoTienGui.Text + " | "
                    + comboBoxThoiGianGui.Text + " tháng | " + tienlai);
            Nguoi n = new Nguoi(int.Parse(txtMaKH.Text), txtHoTenKH.Text, txtDiaChi.Text, int.Parse(txtSoTienGui.Text), txtNgayGui.Text, comboBoxThoiGianGui.Text, (tienlai + int.Parse(txtSoTienGui.Text)));
            lNguoi.Add(n);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string message, title, defaulValue;
            object myValue;

            message = "Nhập mã khách hàng";
            title = "Tìm Kiếm";
            defaulValue = "";

            myValue = Interaction.InputBox(message, title, defaulValue);

            if ((string)myValue == "")
            {
                myValue = defaulValue;
                Microsoft.VisualBasic.Interaction.MsgBox("Bạn Chưa nhập mã khách hàng", MsgBoxStyle.OkOnly |
                    MsgBoxStyle.Information, "Bù lu bù loa");
            }
            else
            {
                int dem = 0;
                Nguoi nguoi = new Nguoi(1);
                foreach (Nguoi n in lNguoi)
                {
                    if ((string) myValue == n.getMaKH())
                    {
                        dem++;
                        nguoi = n;
                    }
                }
                if(dem != 0)
                {
                    Interaction.MsgBox("Tồn tại khách hàng có mã " + myValue.ToString() + "|" + Environment.NewLine + "Số tiền phải trả " + nguoi.getSoTienPhaiTra(), MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "");
                }
                else
                {
                    Interaction.MsgBox("Không tồn tại khách hàng có mã " + myValue.ToString() + "|" + Environment.NewLine + "Vui lòng thử lại", MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "");
                }
            }
        }
    }

    class Nguoi
    {
        private int MaKH;
        private string TenKH;
        private string DiaChi;
        private int SoTienGui;
        private string NgayGui;
        private string ThoiGianGui;
        private double Tien;

        public Nguoi(int maKH)
        {
            MaKH = maKH;
        }

        public string getMaKH()
        {
            return MaKH.ToString();
        }

        public string getSoTienPhaiTra()
        {
            return Tien.ToString();
        }

        public Nguoi(int maKH, string tenKH, string diaChi, int soTienGui, string ngayGui, string thoiGianGui, double tien)
        {
            MaKH = maKH;
            TenKH = tenKH;
            DiaChi = diaChi;
            SoTienGui = soTienGui;
            NgayGui = ngayGui;
            ThoiGianGui = thoiGianGui;
            Tien = tien;
        }
    }
}