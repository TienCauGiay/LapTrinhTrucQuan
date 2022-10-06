namespace ThucHanhTuan_02_Bai2
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
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbDienThoai = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.lbDanhSachMH = new System.Windows.Forms.Label();
            this.lbHangDatMua = new System.Windows.Forms.Label();
            this.listBoxDanhSachMH = new System.Windows.Forms.ListBox();
            this.listBoxHangDatMua = new System.Windows.Forms.ListBox();
            this.grbPhuongThucThanhToan = new System.Windows.Forms.GroupBox();
            this.radTheTinDung = new System.Windows.Forms.RadioButton();
            this.radSec = new System.Windows.Forms.RadioButton();
            this.radTienMat = new System.Windows.Forms.RadioButton();
            this.grbHinhThucLienLac = new System.Windows.Forms.GroupBox();
            this.checkBoxEmail = new System.Windows.Forms.CheckBox();
            this.checkBoxFax = new System.Windows.Forms.CheckBox();
            this.checkBoxDienThoai = new System.Windows.Forms.CheckBox();
            this.btnDongY = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbPhuongThucThanhToan.SuspendLayout();
            this.grbHinhThucLienLac.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Location = new System.Drawing.Point(51, 38);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(75, 25);
            this.lbHoTen.TabIndex = 0;
            this.lbHoTen.Text = "Họ tên: ";
            // 
            // lbDienThoai
            // 
            this.lbDienThoai.AutoSize = true;
            this.lbDienThoai.Location = new System.Drawing.Point(569, 38);
            this.lbDienThoai.Name = "lbDienThoai";
            this.lbDienThoai.Size = new System.Drawing.Size(102, 25);
            this.lbDienThoai.TabIndex = 1;
            this.lbDienThoai.Text = "Điện thoại: ";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(165, 38);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(317, 31);
            this.txtHoTen.TabIndex = 2;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(693, 38);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(317, 31);
            this.txtDienThoai.TabIndex = 3;
            // 
            // lbDanhSachMH
            // 
            this.lbDanhSachMH.AutoSize = true;
            this.lbDanhSachMH.Location = new System.Drawing.Point(51, 119);
            this.lbDanhSachMH.Name = "lbDanhSachMH";
            this.lbDanhSachMH.Size = new System.Drawing.Size(209, 25);
            this.lbDanhSachMH.TabIndex = 4;
            this.lbDanhSachMH.Text = "Danh sách các mặt hàng:";
            // 
            // lbHangDatMua
            // 
            this.lbHangDatMua.AutoSize = true;
            this.lbHangDatMua.Location = new System.Drawing.Point(569, 119);
            this.lbHangDatMua.Name = "lbHangDatMua";
            this.lbHangDatMua.Size = new System.Drawing.Size(126, 25);
            this.lbHangDatMua.TabIndex = 5;
            this.lbHangDatMua.Text = "Hàng đặt mua";
            this.lbHangDatMua.Click += new System.EventHandler(this.label2_Click);
            // 
            // listBoxDanhSachMH
            // 
            this.listBoxDanhSachMH.FormattingEnabled = true;
            this.listBoxDanhSachMH.ItemHeight = 25;
            this.listBoxDanhSachMH.Location = new System.Drawing.Point(51, 172);
            this.listBoxDanhSachMH.Name = "listBoxDanhSachMH";
            this.listBoxDanhSachMH.Size = new System.Drawing.Size(431, 279);
            this.listBoxDanhSachMH.TabIndex = 6;
            this.listBoxDanhSachMH.DoubleClick += new System.EventHandler(this.listBoxDanhSachMH_DoubleClick);
            // 
            // listBoxHangDatMua
            // 
            this.listBoxHangDatMua.FormattingEnabled = true;
            this.listBoxHangDatMua.ItemHeight = 25;
            this.listBoxHangDatMua.Location = new System.Drawing.Point(579, 172);
            this.listBoxHangDatMua.Name = "listBoxHangDatMua";
            this.listBoxHangDatMua.Size = new System.Drawing.Size(431, 279);
            this.listBoxHangDatMua.TabIndex = 7;
            this.listBoxHangDatMua.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxHangDatMua_MouseDoubleClick);
            // 
            // grbPhuongThucThanhToan
            // 
            this.grbPhuongThucThanhToan.Controls.Add(this.radTheTinDung);
            this.grbPhuongThucThanhToan.Controls.Add(this.radSec);
            this.grbPhuongThucThanhToan.Controls.Add(this.radTienMat);
            this.grbPhuongThucThanhToan.Location = new System.Drawing.Point(52, 503);
            this.grbPhuongThucThanhToan.Name = "grbPhuongThucThanhToan";
            this.grbPhuongThucThanhToan.Size = new System.Drawing.Size(317, 198);
            this.grbPhuongThucThanhToan.TabIndex = 8;
            this.grbPhuongThucThanhToan.TabStop = false;
            this.grbPhuongThucThanhToan.Text = "Phương thức thanh toán";
            // 
            // radTheTinDung
            // 
            this.radTheTinDung.AutoSize = true;
            this.radTheTinDung.Location = new System.Drawing.Point(30, 150);
            this.radTheTinDung.Name = "radTheTinDung";
            this.radTheTinDung.Size = new System.Drawing.Size(137, 29);
            this.radTheTinDung.TabIndex = 2;
            this.radTheTinDung.TabStop = true;
            this.radTheTinDung.Text = "Thẻ tín dụng";
            this.radTheTinDung.UseVisualStyleBackColor = true;
            // 
            // radSec
            // 
            this.radSec.AutoSize = true;
            this.radSec.Location = new System.Drawing.Point(30, 98);
            this.radSec.Name = "radSec";
            this.radSec.Size = new System.Drawing.Size(64, 29);
            this.radSec.TabIndex = 1;
            this.radSec.TabStop = true;
            this.radSec.Text = "Sec";
            this.radSec.UseVisualStyleBackColor = true;
            // 
            // radTienMat
            // 
            this.radTienMat.AutoSize = true;
            this.radTienMat.Location = new System.Drawing.Point(30, 46);
            this.radTienMat.Name = "radTienMat";
            this.radTienMat.Size = new System.Drawing.Size(105, 29);
            this.radTienMat.TabIndex = 0;
            this.radTienMat.TabStop = true;
            this.radTienMat.Text = "Tiền mặt";
            this.radTienMat.UseVisualStyleBackColor = true;
            // 
            // grbHinhThucLienLac
            // 
            this.grbHinhThucLienLac.Controls.Add(this.checkBoxEmail);
            this.grbHinhThucLienLac.Controls.Add(this.checkBoxFax);
            this.grbHinhThucLienLac.Controls.Add(this.checkBoxDienThoai);
            this.grbHinhThucLienLac.Location = new System.Drawing.Point(579, 512);
            this.grbHinhThucLienLac.Name = "grbHinhThucLienLac";
            this.grbHinhThucLienLac.Size = new System.Drawing.Size(300, 189);
            this.grbHinhThucLienLac.TabIndex = 9;
            this.grbHinhThucLienLac.TabStop = false;
            this.grbHinhThucLienLac.Text = "Hình thức liên lạc";
            // 
            // checkBoxEmail
            // 
            this.checkBoxEmail.AutoSize = true;
            this.checkBoxEmail.Location = new System.Drawing.Point(41, 141);
            this.checkBoxEmail.Name = "checkBoxEmail";
            this.checkBoxEmail.Size = new System.Drawing.Size(80, 29);
            this.checkBoxEmail.TabIndex = 2;
            this.checkBoxEmail.Text = "Email";
            this.checkBoxEmail.UseVisualStyleBackColor = true;
            this.checkBoxEmail.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBoxFax
            // 
            this.checkBoxFax.AutoSize = true;
            this.checkBoxFax.Location = new System.Drawing.Point(41, 90);
            this.checkBoxFax.Name = "checkBoxFax";
            this.checkBoxFax.Size = new System.Drawing.Size(63, 29);
            this.checkBoxFax.TabIndex = 1;
            this.checkBoxFax.Text = "Fax";
            this.checkBoxFax.UseVisualStyleBackColor = true;
            // 
            // checkBoxDienThoai
            // 
            this.checkBoxDienThoai.AutoSize = true;
            this.checkBoxDienThoai.Location = new System.Drawing.Point(41, 35);
            this.checkBoxDienThoai.Name = "checkBoxDienThoai";
            this.checkBoxDienThoai.Size = new System.Drawing.Size(119, 29);
            this.checkBoxDienThoai.TabIndex = 0;
            this.checkBoxDienThoai.Text = "Điện thoại";
            this.checkBoxDienThoai.UseVisualStyleBackColor = true;
            // 
            // btnDongY
            // 
            this.btnDongY.Location = new System.Drawing.Point(324, 765);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(112, 34);
            this.btnDongY.TabIndex = 10;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(637, 765);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 34);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 840);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.grbHinhThucLienLac);
            this.Controls.Add(this.grbPhuongThucThanhToan);
            this.Controls.Add(this.listBoxHangDatMua);
            this.Controls.Add(this.listBoxDanhSachMH);
            this.Controls.Add(this.lbHangDatMua);
            this.Controls.Add(this.lbDanhSachMH);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lbDienThoai);
            this.Controls.Add(this.lbHoTen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbPhuongThucThanhToan.ResumeLayout(false);
            this.grbPhuongThucThanhToan.PerformLayout();
            this.grbHinhThucLienLac.ResumeLayout(false);
            this.grbHinhThucLienLac.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbHoTen;
        private Label lbDienThoai;
        private TextBox txtHoTen;
        private TextBox txtDienThoai;
        private Label lbDanhSachMH;
        private Label lbHangDatMua;
        private ListBox listBoxDanhSachMH;
        private ListBox listBoxHangDatMua;
        private GroupBox grbPhuongThucThanhToan;
        private RadioButton radTheTinDung;
        private RadioButton radSec;
        private RadioButton radTienMat;
        private GroupBox grbHinhThucLienLac;
        private CheckBox checkBoxEmail;
        private CheckBox checkBoxFax;
        private CheckBox checkBoxDienThoai;
        private Button btnDongY;
        private Button btnThoat;
    }
}