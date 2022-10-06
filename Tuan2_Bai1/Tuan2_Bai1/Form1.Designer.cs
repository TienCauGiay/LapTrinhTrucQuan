namespace Tuan2_Bai1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbInputInfoKH = new System.Windows.Forms.GroupBox();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnThemVao = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radPhatLoc = new System.Windows.Forms.RadioButton();
            this.radThuong = new System.Windows.Forms.RadioButton();
            this.comboBoxThoiGianGui = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSoTienGui = new System.Windows.Forms.TextBox();
            this.txtNgayGui = new System.Windows.Forms.TextBox();
            this.txtHoTenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.lbThoiGianGui = new System.Windows.Forms.Label();
            this.lbNgayGui = new System.Windows.Forms.Label();
            this.lbSoTienGui = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbHoTenKH = new System.Windows.Forms.Label();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listDanhSach = new System.Windows.Forms.ListBox();
            this.grbInputInfoKH.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbInputInfoKH
            // 
            this.grbInputInfoKH.Controls.Add(this.btnThemMoi);
            this.grbInputInfoKH.Controls.Add(this.btnThemVao);
            this.grbInputInfoKH.Controls.Add(this.groupBox2);
            this.grbInputInfoKH.Controls.Add(this.comboBoxThoiGianGui);
            this.grbInputInfoKH.Controls.Add(this.txtDiaChi);
            this.grbInputInfoKH.Controls.Add(this.txtSoTienGui);
            this.grbInputInfoKH.Controls.Add(this.txtNgayGui);
            this.grbInputInfoKH.Controls.Add(this.txtHoTenKH);
            this.grbInputInfoKH.Controls.Add(this.txtMaKH);
            this.grbInputInfoKH.Controls.Add(this.lbThoiGianGui);
            this.grbInputInfoKH.Controls.Add(this.lbNgayGui);
            this.grbInputInfoKH.Controls.Add(this.lbSoTienGui);
            this.grbInputInfoKH.Controls.Add(this.lbDiaChi);
            this.grbInputInfoKH.Controls.Add(this.lbHoTenKH);
            this.grbInputInfoKH.Controls.Add(this.lbMaKH);
            this.grbInputInfoKH.Location = new System.Drawing.Point(12, 20);
            this.grbInputInfoKH.Name = "grbInputInfoKH";
            this.grbInputInfoKH.Size = new System.Drawing.Size(509, 443);
            this.grbInputInfoKH.TabIndex = 0;
            this.grbInputInfoKH.TabStop = false;
            this.grbInputInfoKH.Text = "Nhập thông tin khách hàng gửi tiết kiệm";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(287, 400);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(112, 34);
            this.btnThemMoi.TabIndex = 15;
            this.btnThemMoi.Text = "Thêm mới &M";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnThemVao
            // 
            this.btnThemVao.Location = new System.Drawing.Point(110, 400);
            this.btnThemVao.Name = "btnThemVao";
            this.btnThemVao.Size = new System.Drawing.Size(112, 34);
            this.btnThemVao.TabIndex = 14;
            this.btnThemVao.Text = "Thêm vào DS &T";
            this.btnThemVao.UseVisualStyleBackColor = true;
            this.btnThemVao.Click += new System.EventHandler(this.btnThemVao_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radPhatLoc);
            this.groupBox2.Controls.Add(this.radThuong);
            this.groupBox2.Location = new System.Drawing.Point(18, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 73);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loại tiết kiệm";
            // 
            // radPhatLoc
            // 
            this.radPhatLoc.AutoSize = true;
            this.radPhatLoc.Location = new System.Drawing.Point(281, 32);
            this.radPhatLoc.Name = "radPhatLoc";
            this.radPhatLoc.Size = new System.Drawing.Size(100, 29);
            this.radPhatLoc.TabIndex = 1;
            this.radPhatLoc.TabStop = true;
            this.radPhatLoc.Text = "Phát lộc";
            this.radPhatLoc.UseVisualStyleBackColor = true;
            // 
            // radThuong
            // 
            this.radThuong.AutoSize = true;
            this.radThuong.Location = new System.Drawing.Point(44, 32);
            this.radThuong.Name = "radThuong";
            this.radThuong.Size = new System.Drawing.Size(99, 29);
            this.radThuong.TabIndex = 0;
            this.radThuong.TabStop = true;
            this.radThuong.Text = "Thường";
            this.radThuong.UseVisualStyleBackColor = true;
            // 
            // comboBoxThoiGianGui
            // 
            this.comboBoxThoiGianGui.FormattingEnabled = true;
            this.comboBoxThoiGianGui.Items.AddRange(new object[] {
            "1",
            "3",
            "6",
            "12"});
            this.comboBoxThoiGianGui.Location = new System.Drawing.Point(351, 251);
            this.comboBoxThoiGianGui.Name = "comboBoxThoiGianGui";
            this.comboBoxThoiGianGui.Size = new System.Drawing.Size(125, 33);
            this.comboBoxThoiGianGui.TabIndex = 12;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(143, 118);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(333, 31);
            this.txtDiaChi.TabIndex = 11;
            // 
            // txtSoTienGui
            // 
            this.txtSoTienGui.Location = new System.Drawing.Point(223, 172);
            this.txtSoTienGui.Name = "txtSoTienGui";
            this.txtSoTienGui.Size = new System.Drawing.Size(253, 31);
            this.txtSoTienGui.TabIndex = 10;
            this.txtSoTienGui.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTienGui_KeyPress);
            // 
            // txtNgayGui
            // 
            this.txtNgayGui.Location = new System.Drawing.Point(223, 209);
            this.txtNgayGui.Name = "txtNgayGui";
            this.txtNgayGui.Size = new System.Drawing.Size(253, 31);
            this.txtNgayGui.TabIndex = 8;
            // 
            // txtHoTenKH
            // 
            this.txtHoTenKH.Location = new System.Drawing.Point(223, 81);
            this.txtHoTenKH.Name = "txtHoTenKH";
            this.txtHoTenKH.Size = new System.Drawing.Size(253, 31);
            this.txtHoTenKH.TabIndex = 7;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(223, 43);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(253, 31);
            this.txtMaKH.TabIndex = 6;
            this.txtMaKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaKH_KeyPress);
            // 
            // lbThoiGianGui
            // 
            this.lbThoiGianGui.AutoSize = true;
            this.lbThoiGianGui.Location = new System.Drawing.Point(18, 254);
            this.lbThoiGianGui.Name = "lbThoiGianGui";
            this.lbThoiGianGui.Size = new System.Drawing.Size(116, 25);
            this.lbThoiGianGui.TabIndex = 5;
            this.lbThoiGianGui.Text = "Thời gian gửi";
            // 
            // lbNgayGui
            // 
            this.lbNgayGui.AutoSize = true;
            this.lbNgayGui.Location = new System.Drawing.Point(18, 209);
            this.lbNgayGui.Name = "lbNgayGui";
            this.lbNgayGui.Size = new System.Drawing.Size(199, 25);
            this.lbNgayGui.TabIndex = 4;
            this.lbNgayGui.Text = "Ngày gửi(mm/dd/yyyy)";
            // 
            // lbSoTienGui
            // 
            this.lbSoTienGui.AutoSize = true;
            this.lbSoTienGui.Location = new System.Drawing.Point(18, 164);
            this.lbSoTienGui.Name = "lbSoTienGui";
            this.lbSoTienGui.Size = new System.Drawing.Size(98, 25);
            this.lbSoTienGui.TabIndex = 3;
            this.lbSoTienGui.Text = "Số tiền gửi";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(18, 118);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(68, 25);
            this.lbDiaChi.TabIndex = 2;
            this.lbDiaChi.Text = "Địa Chỉ";
            // 
            // lbHoTenKH
            // 
            this.lbHoTenKH.AutoSize = true;
            this.lbHoTenKH.Location = new System.Drawing.Point(18, 80);
            this.lbHoTenKH.Name = "lbHoTenKH";
            this.lbHoTenKH.Size = new System.Drawing.Size(94, 25);
            this.lbHoTenKH.TabIndex = 1;
            this.lbHoTenKH.Text = "Họ tên KH";
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Location = new System.Drawing.Point(18, 43);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(65, 25);
            this.lbMaKH.TabIndex = 0;
            this.lbMaKH.Text = "Mã KH";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(919, 424);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(112, 34);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1185, 424);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 34);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát            &H";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listDanhSach);
            this.groupBox1.Location = new System.Drawing.Point(575, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 356);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách khách hàng";
            // 
            // listDanhSach
            // 
            this.listDanhSach.FormattingEnabled = true;
            this.listDanhSach.ItemHeight = 25;
            this.listDanhSach.Location = new System.Drawing.Point(20, 30);
            this.listDanhSach.Name = "listDanhSach";
            this.listDanhSach.Size = new System.Drawing.Size(712, 304);
            this.listDanhSach.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1325, 475);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.grbInputInfoKH);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbInputInfoKH.ResumeLayout(false);
            this.grbInputInfoKH.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grbInputInfoKH;
        private Button btnThemMoi;
        private Button btnThemVao;
        private GroupBox groupBox2;
        private RadioButton radPhatLoc;
        private RadioButton radThuong;
        private ComboBox comboBoxThoiGianGui;
        private TextBox txtDiaChi;
        private TextBox txtSoTienGui;
        private TextBox txtNgayGui;
        private TextBox txtHoTenKH;
        private TextBox txtMaKH;
        private Label lbThoiGianGui;
        private Label lbNgayGui;
        private Label lbSoTienGui;
        private Label lbDiaChi;
        private Label lbHoTenKH;
        private Label lbMaKH;
        private Button btnTimKiem;
        private Button btnThoat;
        private GroupBox groupBox1;
        private ListBox listDanhSach;
    }
}