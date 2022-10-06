namespace BaiTapThem_Bai14
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.listBoxDSGT = new System.Windows.Forms.ListBox();
            this.btnDangKi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.listBoxDSSVM = new System.Windows.Forms.ListBox();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.cbbKhoas = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khóa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Danh sách giáo trình";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(177, 33);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(271, 31);
            this.txtHoTen.TabIndex = 4;
            // 
            // listBoxDSGT
            // 
            this.listBoxDSGT.FormattingEnabled = true;
            this.listBoxDSGT.ItemHeight = 25;
            this.listBoxDSGT.Items.AddRange(new object[] {
            "Tin học đại cương",
            "Cơ lý thuyết",
            "Triết học",
            "Vật lý đại cương",
            "Lập trình trực quan"});
            this.listBoxDSGT.Location = new System.Drawing.Point(30, 294);
            this.listBoxDSGT.Name = "listBoxDSGT";
            this.listBoxDSGT.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxDSGT.Size = new System.Drawing.Size(418, 104);
            this.listBoxDSGT.TabIndex = 7;
            // 
            // btnDangKi
            // 
            this.btnDangKi.Location = new System.Drawing.Point(357, 444);
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Size = new System.Drawing.Size(112, 34);
            this.btnDangKi.TabIndex = 8;
            this.btnDangKi.Text = "Đăng &kí";
            this.btnDangKi.UseVisualStyleBackColor = true;
            this.btnDangKi.Click += new System.EventHandler(this.btnDangKi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.listBoxDSSVM);
            this.groupBox1.Location = new System.Drawing.Point(509, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(803, 445);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sinh viên mượn giáo trình";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(672, 388);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 34);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // listBoxDSSVM
            // 
            this.listBoxDSSVM.FormattingEnabled = true;
            this.listBoxDSSVM.ItemHeight = 25;
            this.listBoxDSSVM.Location = new System.Drawing.Point(26, 37);
            this.listBoxDSSVM.Name = "listBoxDSSVM";
            this.listBoxDSSVM.Size = new System.Drawing.Size(758, 329);
            this.listBoxDSSVM.TabIndex = 0;
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(689, 512);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(172, 34);
            this.btnLamLai.TabIndex = 11;
            this.btnLamLai.Text = "&Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(909, 512);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(165, 34);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "T&hoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Items.AddRange(new object[] {
            "Công trình",
            "Công nghệ thông tin",
            "Vận tải kinh tế"});
            this.cbbKhoa.Location = new System.Drawing.Point(177, 104);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(271, 33);
            this.cbbKhoa.TabIndex = 13;
            // 
            // cbbKhoas
            // 
            this.cbbKhoas.FormattingEnabled = true;
            this.cbbKhoas.Items.AddRange(new object[] {
            "53",
            "54",
            "55"});
            this.cbbKhoas.Location = new System.Drawing.Point(177, 175);
            this.cbbKhoas.Name = "cbbKhoas";
            this.cbbKhoas.Size = new System.Drawing.Size(191, 33);
            this.cbbKhoas.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 574);
            this.Controls.Add(this.cbbKhoas);
            this.Controls.Add(this.cbbKhoa);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDangKi);
            this.Controls.Add(this.listBoxDSGT);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtHoTen;
        private ListBox listBoxDSGT;
        private Button btnDangKi;
        private GroupBox groupBox1;
        private Button btnXoa;
        private ListBox listBoxDSSVM;
        private Button btnLamLai;
        private Button btnThoat;
        private ComboBox cbbKhoa;
        private ComboBox cbbKhoas;
    }
}