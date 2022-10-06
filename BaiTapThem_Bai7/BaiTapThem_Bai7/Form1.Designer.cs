namespace BaiTapThem_Bai7
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
            this.lbNhapSoPtuDay = new System.Windows.Forms.Label();
            this.lbDaySoVuaNhap = new System.Windows.Forms.Label();
            this.lbChonChucNang = new System.Windows.Forms.Label();
            this.lbKetQuaChucNang = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.cbbChonChucNang = new System.Windows.Forms.ComboBox();
            this.btnNhapDay = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnTHoat = new System.Windows.Forms.Button();
            this.lbKQDaySoVuaNhap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNhapSoPtuDay
            // 
            this.lbNhapSoPtuDay.AutoSize = true;
            this.lbNhapSoPtuDay.Location = new System.Drawing.Point(38, 30);
            this.lbNhapSoPtuDay.Name = "lbNhapSoPtuDay";
            this.lbNhapSoPtuDay.Size = new System.Drawing.Size(221, 25);
            this.lbNhapSoPtuDay.TabIndex = 0;
            this.lbNhapSoPtuDay.Text = "Nhập số phần tử của dãy: ";
            // 
            // lbDaySoVuaNhap
            // 
            this.lbDaySoVuaNhap.AutoSize = true;
            this.lbDaySoVuaNhap.Location = new System.Drawing.Point(38, 119);
            this.lbDaySoVuaNhap.Name = "lbDaySoVuaNhap";
            this.lbDaySoVuaNhap.Size = new System.Drawing.Size(173, 25);
            this.lbDaySoVuaNhap.TabIndex = 1;
            this.lbDaySoVuaNhap.Text = "Dãy số vừa nhập là: ";
            // 
            // lbChonChucNang
            // 
            this.lbChonChucNang.AutoSize = true;
            this.lbChonChucNang.Location = new System.Drawing.Point(38, 223);
            this.lbChonChucNang.Name = "lbChonChucNang";
            this.lbChonChucNang.Size = new System.Drawing.Size(141, 25);
            this.lbChonChucNang.TabIndex = 2;
            this.lbChonChucNang.Text = "Chọn chức năng";
            // 
            // lbKetQuaChucNang
            // 
            this.lbKetQuaChucNang.AutoSize = true;
            this.lbKetQuaChucNang.Location = new System.Drawing.Point(38, 325);
            this.lbKetQuaChucNang.Name = "lbKetQuaChucNang";
            this.lbKetQuaChucNang.Size = new System.Drawing.Size(0, 25);
            this.lbKetQuaChucNang.TabIndex = 3;
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(288, 30);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(150, 31);
            this.txtNhap.TabIndex = 4;
            // 
            // cbbChonChucNang
            // 
            this.cbbChonChucNang.FormattingEnabled = true;
            this.cbbChonChucNang.Items.AddRange(new object[] {
            "Trung bình cộng của dãy",
            "Đếm số phần tử âm"});
            this.cbbChonChucNang.Location = new System.Drawing.Point(288, 223);
            this.cbbChonChucNang.Name = "cbbChonChucNang";
            this.cbbChonChucNang.Size = new System.Drawing.Size(323, 33);
            this.cbbChonChucNang.TabIndex = 5;
            this.cbbChonChucNang.SelectedIndexChanged += new System.EventHandler(this.cbbChonChucNang_SelectedIndexChanged);
            // 
            // btnNhapDay
            // 
            this.btnNhapDay.Location = new System.Drawing.Point(630, 30);
            this.btnNhapDay.Name = "btnNhapDay";
            this.btnNhapDay.Size = new System.Drawing.Size(112, 34);
            this.btnNhapDay.TabIndex = 6;
            this.btnNhapDay.Text = "Nhập dãy";
            this.btnNhapDay.UseVisualStyleBackColor = true;
            this.btnNhapDay.Click += new System.EventHandler(this.btnNhapDay_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(422, 385);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(112, 34);
            this.btnLamLai.TabIndex = 7;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnTHoat
            // 
            this.btnTHoat.Location = new System.Drawing.Point(630, 385);
            this.btnTHoat.Name = "btnTHoat";
            this.btnTHoat.Size = new System.Drawing.Size(112, 34);
            this.btnTHoat.TabIndex = 8;
            this.btnTHoat.Text = "Thoát";
            this.btnTHoat.UseVisualStyleBackColor = true;
            this.btnTHoat.Click += new System.EventHandler(this.btnTHoat_Click);
            // 
            // lbKQDaySoVuaNhap
            // 
            this.lbKQDaySoVuaNhap.AutoSize = true;
            this.lbKQDaySoVuaNhap.Location = new System.Drawing.Point(217, 119);
            this.lbKQDaySoVuaNhap.Name = "lbKQDaySoVuaNhap";
            this.lbKQDaySoVuaNhap.Size = new System.Drawing.Size(0, 25);
            this.lbKQDaySoVuaNhap.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbKQDaySoVuaNhap);
            this.Controls.Add(this.btnTHoat);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnNhapDay);
            this.Controls.Add(this.cbbChonChucNang);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.lbKetQuaChucNang);
            this.Controls.Add(this.lbChonChucNang);
            this.Controls.Add(this.lbDaySoVuaNhap);
            this.Controls.Add(this.lbNhapSoPtuDay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbNhapSoPtuDay;
        private Label lbDaySoVuaNhap;
        private Label lbChonChucNang;
        private Label lbKetQuaChucNang;
        private TextBox txtNhap;
        private ComboBox cbbChonChucNang;
        private Button btnNhapDay;
        private Button btnLamLai;
        private Button btnTHoat;
        private Label lbKQDaySoVuaNhap;
    }
}