namespace Tuan2_BTTuongTu_Bai2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radNuaNgay = new System.Windows.Forms.RadioButton();
            this.radCaNgay = new System.Windows.Forms.RadioButton();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnThemVaoDS = new System.Windows.Forms.Button();
            this.comboBoxSoLuong = new System.Windows.Forms.ComboBox();
            this.comboBoxChonDoUong = new System.Windows.Forms.ComboBox();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.txtGiaDuThuyen = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxDSKhachDatTuor = new System.Windows.Forms.ListBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radNuaNgay);
            this.groupBox1.Controls.Add(this.radCaNgay);
            this.groupBox1.Controls.Add(this.btnThemMoi);
            this.groupBox1.Controls.Add(this.btnThemVaoDS);
            this.groupBox1.Controls.Add(this.comboBoxSoLuong);
            this.groupBox1.Controls.Add(this.comboBoxChonDoUong);
            this.groupBox1.Controls.Add(this.txtTien);
            this.groupBox1.Controls.Add(this.txtGiaDuThuyen);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(42, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(547, 372);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thông Tin Khách Hàng Đặt Tuor";
            // 
            // radNuaNgay
            // 
            this.radNuaNgay.AutoSize = true;
            this.radNuaNgay.Location = new System.Drawing.Point(323, 81);
            this.radNuaNgay.Name = "radNuaNgay";
            this.radNuaNgay.Size = new System.Drawing.Size(104, 24);
            this.radNuaNgay.TabIndex = 14;
            this.radNuaNgay.TabStop = true;
            this.radNuaNgay.Text = "Nửa ngày";
            this.radNuaNgay.UseVisualStyleBackColor = true;
            this.radNuaNgay.CheckedChanged += new System.EventHandler(this.radNuaNgay_CheckedChanged);
            // 
            // radCaNgay
            // 
            this.radCaNgay.AutoSize = true;
            this.radCaNgay.Location = new System.Drawing.Point(65, 81);
            this.radCaNgay.Name = "radCaNgay";
            this.radCaNgay.Size = new System.Drawing.Size(93, 24);
            this.radCaNgay.TabIndex = 13;
            this.radCaNgay.TabStop = true;
            this.radCaNgay.Text = "Cả ngày";
            this.radCaNgay.UseVisualStyleBackColor = true;
            this.radCaNgay.CheckedChanged += new System.EventHandler(this.radCaNgay_CheckedChanged);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(303, 309);
            this.btnThemMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(150, 27);
            this.btnThemMoi.TabIndex = 12;
            this.btnThemMoi.Text = "     Thêm mới       &M";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnThemVaoDS
            // 
            this.btnThemVaoDS.Location = new System.Drawing.Point(86, 309);
            this.btnThemVaoDS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemVaoDS.Name = "btnThemVaoDS";
            this.btnThemVaoDS.Size = new System.Drawing.Size(125, 27);
            this.btnThemVaoDS.TabIndex = 11;
            this.btnThemVaoDS.Text = "Thêm vào DS";
            this.btnThemVaoDS.UseVisualStyleBackColor = true;
            this.btnThemVaoDS.Click += new System.EventHandler(this.btnThemVaoDS_Click);
            // 
            // comboBoxSoLuong
            // 
            this.comboBoxSoLuong.FormattingEnabled = true;
            this.comboBoxSoLuong.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxSoLuong.Location = new System.Drawing.Point(215, 245);
            this.comboBoxSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSoLuong.Name = "comboBoxSoLuong";
            this.comboBoxSoLuong.Size = new System.Drawing.Size(118, 28);
            this.comboBoxSoLuong.TabIndex = 10;
            this.comboBoxSoLuong.SelectedIndexChanged += new System.EventHandler(this.comboBoxSoLuong_SelectedIndexChanged);
            // 
            // comboBoxChonDoUong
            // 
            this.comboBoxChonDoUong.FormattingEnabled = true;
            this.comboBoxChonDoUong.Items.AddRange(new object[] {
            "Coca cola",
            "Pepsi",
            "Seven up"});
            this.comboBoxChonDoUong.Location = new System.Drawing.Point(61, 245);
            this.comboBoxChonDoUong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxChonDoUong.Name = "comboBoxChonDoUong";
            this.comboBoxChonDoUong.Size = new System.Drawing.Size(118, 28);
            this.comboBoxChonDoUong.TabIndex = 9;
            this.comboBoxChonDoUong.SelectedIndexChanged += new System.EventHandler(this.comboBoxChonDoUong_SelectedIndexChanged);
            // 
            // txtTien
            // 
            this.txtTien.Enabled = false;
            this.txtTien.Location = new System.Drawing.Point(369, 246);
            this.txtTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(150, 28);
            this.txtTien.TabIndex = 8;
            this.txtTien.TextChanged += new System.EventHandler(this.txtTien_TextChanged);
            // 
            // txtGiaDuThuyen
            // 
            this.txtGiaDuThuyen.Enabled = false;
            this.txtGiaDuThuyen.Location = new System.Drawing.Point(178, 129);
            this.txtGiaDuThuyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaDuThuyen.Name = "txtGiaDuThuyen";
            this.txtGiaDuThuyen.Size = new System.Drawing.Size(150, 28);
            this.txtGiaDuThuyen.TabIndex = 7;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(161, 37);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(267, 28);
            this.txtHoTen.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chọn đồ uống";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá du thuyền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxDSKhachDatTuor);
            this.groupBox2.Location = new System.Drawing.Point(614, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(754, 372);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // listBoxDSKhachDatTuor
            // 
            this.listBoxDSKhachDatTuor.FormattingEnabled = true;
            this.listBoxDSKhachDatTuor.ItemHeight = 20;
            this.listBoxDSKhachDatTuor.Location = new System.Drawing.Point(6, 27);
            this.listBoxDSKhachDatTuor.Name = "listBoxDSKhachDatTuor";
            this.listBoxDSKhachDatTuor.Size = new System.Drawing.Size(742, 324);
            this.listBoxDSKhachDatTuor.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1100, 426);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(148, 34);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "        Thoát          &H";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1368, 472);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Công ty du thuyền Hồ Tây";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnThemMoi;
        private Button btnThemVaoDS;
        private ComboBox comboBoxSoLuong;
        private ComboBox comboBoxChonDoUong;
        private TextBox txtTien;
        private TextBox txtGiaDuThuyen;
        private TextBox txtHoTen;
        private Label label6;
        private RadioButton radNuaNgay;
        private RadioButton radCaNgay;
        private GroupBox groupBox2;
        private ListBox listBoxDSKhachDatTuor;
        private Button btnThoat;
    }
}