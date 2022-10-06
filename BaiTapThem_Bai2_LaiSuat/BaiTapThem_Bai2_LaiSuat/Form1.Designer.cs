namespace BaiTapThem_Bai2_LaiSuat
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
            this.grbTTKH = new System.Windows.Forms.GroupBox();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnThemVaoDS = new System.Windows.Forms.Button();
            this.grbLTK = new System.Windows.Forms.GroupBox();
            this.radPhatLoc = new System.Windows.Forms.RadioButton();
            this.radThuong = new System.Windows.Forms.RadioButton();
            this.cbbThoiGianGui = new System.Windows.Forms.ComboBox();
            this.txtNgayGui = new System.Windows.Forms.TextBox();
            this.txtSoTienGui = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHotenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.lbThoiGianGui = new System.Windows.Forms.Label();
            this.lbNgayGui = new System.Windows.Forms.Label();
            this.lbSoTienGui = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbHotenKH = new System.Windows.Forms.Label();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.grbDSKH = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbTTKH.SuspendLayout();
            this.grbLTK.SuspendLayout();
            this.grbDSKH.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTTKH
            // 
            this.grbTTKH.Controls.Add(this.btnThemMoi);
            this.grbTTKH.Controls.Add(this.btnThemVaoDS);
            this.grbTTKH.Controls.Add(this.grbLTK);
            this.grbTTKH.Controls.Add(this.cbbThoiGianGui);
            this.grbTTKH.Controls.Add(this.txtNgayGui);
            this.grbTTKH.Controls.Add(this.txtSoTienGui);
            this.grbTTKH.Controls.Add(this.txtDiaChi);
            this.grbTTKH.Controls.Add(this.txtHotenKH);
            this.grbTTKH.Controls.Add(this.txtMaKH);
            this.grbTTKH.Controls.Add(this.lbThoiGianGui);
            this.grbTTKH.Controls.Add(this.lbNgayGui);
            this.grbTTKH.Controls.Add(this.lbSoTienGui);
            this.grbTTKH.Controls.Add(this.lbDiaChi);
            this.grbTTKH.Controls.Add(this.lbHotenKH);
            this.grbTTKH.Controls.Add(this.lbMaKH);
            this.grbTTKH.Location = new System.Drawing.Point(12, 12);
            this.grbTTKH.Name = "grbTTKH";
            this.grbTTKH.Size = new System.Drawing.Size(561, 518);
            this.grbTTKH.TabIndex = 0;
            this.grbTTKH.TabStop = false;
            this.grbTTKH.Text = "Nhập thông tin khách hàng gửi tiết kiệm";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(350, 457);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(144, 34);
            this.btnThemMoi.TabIndex = 14;
            this.btnThemMoi.Text = "Thêm &mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnThemVaoDS
            // 
            this.btnThemVaoDS.Location = new System.Drawing.Point(84, 457);
            this.btnThemVaoDS.Name = "btnThemVaoDS";
            this.btnThemVaoDS.Size = new System.Drawing.Size(145, 34);
            this.btnThemVaoDS.TabIndex = 13;
            this.btnThemVaoDS.Text = "&Thêm vào DS";
            this.btnThemVaoDS.UseVisualStyleBackColor = true;
            this.btnThemVaoDS.Click += new System.EventHandler(this.btnThemVaoDS_Click);
            // 
            // grbLTK
            // 
            this.grbLTK.Controls.Add(this.radPhatLoc);
            this.grbLTK.Controls.Add(this.radThuong);
            this.grbLTK.Location = new System.Drawing.Point(26, 352);
            this.grbLTK.Name = "grbLTK";
            this.grbLTK.Size = new System.Drawing.Size(524, 84);
            this.grbLTK.TabIndex = 12;
            this.grbLTK.TabStop = false;
            this.grbLTK.Text = "Loại tiết kiệm";
            // 
            // radPhatLoc
            // 
            this.radPhatLoc.AutoSize = true;
            this.radPhatLoc.Location = new System.Drawing.Point(308, 33);
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
            this.radThuong.Location = new System.Drawing.Point(45, 33);
            this.radThuong.Name = "radThuong";
            this.radThuong.Size = new System.Drawing.Size(99, 29);
            this.radThuong.TabIndex = 0;
            this.radThuong.TabStop = true;
            this.radThuong.Text = "Thường";
            this.radThuong.UseVisualStyleBackColor = true;
            // 
            // cbbThoiGianGui
            // 
            this.cbbThoiGianGui.FormattingEnabled = true;
            this.cbbThoiGianGui.Items.AddRange(new object[] {
            "1",
            "3",
            "6",
            "12"});
            this.cbbThoiGianGui.Location = new System.Drawing.Point(195, 292);
            this.cbbThoiGianGui.Name = "cbbThoiGianGui";
            this.cbbThoiGianGui.Size = new System.Drawing.Size(182, 33);
            this.cbbThoiGianGui.TabIndex = 11;
            // 
            // txtNgayGui
            // 
            this.txtNgayGui.Location = new System.Drawing.Point(196, 244);
            this.txtNgayGui.Name = "txtNgayGui";
            this.txtNgayGui.Size = new System.Drawing.Size(228, 31);
            this.txtNgayGui.TabIndex = 10;
            // 
            // txtSoTienGui
            // 
            this.txtSoTienGui.Location = new System.Drawing.Point(196, 191);
            this.txtSoTienGui.Name = "txtSoTienGui";
            this.txtSoTienGui.Size = new System.Drawing.Size(228, 31);
            this.txtSoTienGui.TabIndex = 9;
            this.txtSoTienGui.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTienGui_KeyPress);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(196, 132);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(228, 31);
            this.txtDiaChi.TabIndex = 8;
            // 
            // txtHotenKH
            // 
            this.txtHotenKH.Location = new System.Drawing.Point(196, 88);
            this.txtHotenKH.Name = "txtHotenKH";
            this.txtHotenKH.Size = new System.Drawing.Size(228, 31);
            this.txtHotenKH.TabIndex = 7;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(196, 41);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(228, 31);
            this.txtMaKH.TabIndex = 6;
            this.txtMaKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaKH_KeyPress);
            // 
            // lbThoiGianGui
            // 
            this.lbThoiGianGui.AutoSize = true;
            this.lbThoiGianGui.Location = new System.Drawing.Point(18, 290);
            this.lbThoiGianGui.Name = "lbThoiGianGui";
            this.lbThoiGianGui.Size = new System.Drawing.Size(116, 25);
            this.lbThoiGianGui.TabIndex = 5;
            this.lbThoiGianGui.Text = "Thời gian gửi";
            // 
            // lbNgayGui
            // 
            this.lbNgayGui.AutoSize = true;
            this.lbNgayGui.Location = new System.Drawing.Point(18, 244);
            this.lbNgayGui.Name = "lbNgayGui";
            this.lbNgayGui.Size = new System.Drawing.Size(85, 25);
            this.lbNgayGui.TabIndex = 4;
            this.lbNgayGui.Text = "Ngày gửi";
            // 
            // lbSoTienGui
            // 
            this.lbSoTienGui.AutoSize = true;
            this.lbSoTienGui.Location = new System.Drawing.Point(18, 191);
            this.lbSoTienGui.Name = "lbSoTienGui";
            this.lbSoTienGui.Size = new System.Drawing.Size(103, 25);
            this.lbSoTienGui.TabIndex = 3;
            this.lbSoTienGui.Text = "Số tiền gửi ";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(18, 138);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(65, 25);
            this.lbDiaChi.TabIndex = 2;
            this.lbDiaChi.Text = "Địa chỉ";
            // 
            // lbHotenKH
            // 
            this.lbHotenKH.AutoSize = true;
            this.lbHotenKH.Location = new System.Drawing.Point(18, 88);
            this.lbHotenKH.Name = "lbHotenKH";
            this.lbHotenKH.Size = new System.Drawing.Size(94, 25);
            this.lbHotenKH.TabIndex = 1;
            this.lbHotenKH.Text = "Họ tên KH";
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Location = new System.Drawing.Point(18, 41);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(65, 25);
            this.lbMaKH.TabIndex = 0;
            this.lbMaKH.Text = "Mã KH";
            // 
            // grbDSKH
            // 
            this.grbDSKH.Controls.Add(this.listBox1);
            this.grbDSKH.Location = new System.Drawing.Point(592, 12);
            this.grbDSKH.Name = "grbDSKH";
            this.grbDSKH.Size = new System.Drawing.Size(726, 436);
            this.grbDSKH.TabIndex = 1;
            this.grbDSKH.TabStop = false;
            this.grbDSKH.Text = "Danh sách khách hàng";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(18, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(702, 379);
            this.listBox1.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(734, 469);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(112, 34);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm &kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1067, 469);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 34);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "T&hoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 555);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.grbDSKH);
            this.Controls.Add(this.grbTTKH);
            this.Name = "Form1";
            this.Text = "Tính lãi suất tiết kiệm";
            this.grbTTKH.ResumeLayout(false);
            this.grbTTKH.PerformLayout();
            this.grbLTK.ResumeLayout(false);
            this.grbLTK.PerformLayout();
            this.grbDSKH.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grbTTKH;
        private Button btnThemMoi;
        private Button btnThemVaoDS;
        private GroupBox grbLTK;
        private RadioButton radPhatLoc;
        private RadioButton radThuong;
        private ComboBox cbbThoiGianGui;
        private TextBox txtNgayGui;
        private TextBox txtSoTienGui;
        private TextBox txtDiaChi;
        private TextBox txtHotenKH;
        private TextBox txtMaKH;
        private Label lbThoiGianGui;
        private Label lbNgayGui;
        private Label lbSoTienGui;
        private Label lbDiaChi;
        private Label lbHotenKH;
        private Label lbMaKH;
        private GroupBox grbDSKH;
        private ListBox listBox1;
        private Button btnTimKiem;
        private Button btnThoat;
    }
}