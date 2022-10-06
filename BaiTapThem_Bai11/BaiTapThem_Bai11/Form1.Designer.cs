namespace BaiTapThem_Bai11
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
            this.txtKq = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbKichThuoc = new System.Windows.Forms.ComboBox();
            this.cbbFont = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkGach = new System.Windows.Forms.CheckBox();
            this.checkNghieng = new System.Windows.Forms.CheckBox();
            this.checkDam = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radDen = new System.Windows.Forms.RadioButton();
            this.radXanh = new System.Windows.Forms.RadioButton();
            this.radDo = new System.Windows.Forms.RadioButton();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKq
            // 
            this.txtKq.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.txtKq.ForeColor = System.Drawing.Color.Red;
            this.txtKq.Location = new System.Drawing.Point(132, 31);
            this.txtKq.Margin = new System.Windows.Forms.Padding(2);
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(393, 32);
            this.txtKq.TabIndex = 0;
            this.txtKq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbKichThuoc);
            this.groupBox1.Controls.Add(this.cbbFont);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(62, 77);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(512, 67);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiểu chữ";
            // 
            // cbbKichThuoc
            // 
            this.cbbKichThuoc.FormattingEnabled = true;
            this.cbbKichThuoc.Items.AddRange(new object[] {
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.cbbKichThuoc.Location = new System.Drawing.Point(336, 26);
            this.cbbKichThuoc.Margin = new System.Windows.Forms.Padding(2);
            this.cbbKichThuoc.Name = "cbbKichThuoc";
            this.cbbKichThuoc.Size = new System.Drawing.Size(166, 23);
            this.cbbKichThuoc.TabIndex = 3;
            this.cbbKichThuoc.SelectedIndexChanged += new System.EventHandler(this.cbbKichThuoc_SelectedIndexChanged);
            // 
            // cbbFont
            // 
            this.cbbFont.FormattingEnabled = true;
            this.cbbFont.Items.AddRange(new object[] {
            ".vnTime",
            ".vnTimeH",
            ".vnArial",
            ".vnArialH",
            ".vnUniverse",
            ".vnUniverseH"});
            this.cbbFont.Location = new System.Drawing.Point(64, 26);
            this.cbbFont.Margin = new System.Windows.Forms.Padding(2);
            this.cbbFont.Name = "cbbFont";
            this.cbbFont.Size = new System.Drawing.Size(166, 23);
            this.cbbFont.TabIndex = 2;
            this.cbbFont.SelectedIndexChanged += new System.EventHandler(this.cbbFont_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kích thước";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Font";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkGach);
            this.groupBox2.Controls.Add(this.checkNghieng);
            this.groupBox2.Controls.Add(this.checkDam);
            this.groupBox2.Location = new System.Drawing.Point(62, 152);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(512, 67);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiệu ứng chữ";
            // 
            // checkGach
            // 
            this.checkGach.AutoSize = true;
            this.checkGach.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.checkGach.Location = new System.Drawing.Point(377, 27);
            this.checkGach.Margin = new System.Windows.Forms.Padding(2);
            this.checkGach.Name = "checkGach";
            this.checkGach.Size = new System.Drawing.Size(82, 19);
            this.checkGach.TabIndex = 2;
            this.checkGach.Text = "Gạch chân";
            this.checkGach.UseVisualStyleBackColor = true;
            this.checkGach.CheckedChanged += new System.EventHandler(this.checkGach_CheckedChanged);
            // 
            // checkNghieng
            // 
            this.checkNghieng.AutoSize = true;
            this.checkNghieng.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.checkNghieng.Location = new System.Drawing.Point(202, 27);
            this.checkNghieng.Margin = new System.Windows.Forms.Padding(2);
            this.checkNghieng.Name = "checkNghieng";
            this.checkNghieng.Size = new System.Drawing.Size(72, 19);
            this.checkNghieng.TabIndex = 1;
            this.checkNghieng.Text = "Nghiêng";
            this.checkNghieng.UseVisualStyleBackColor = true;
            this.checkNghieng.CheckedChanged += new System.EventHandler(this.checkNghieng_CheckedChanged);
            // 
            // checkDam
            // 
            this.checkDam.AutoSize = true;
            this.checkDam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkDam.Location = new System.Drawing.Point(27, 27);
            this.checkDam.Margin = new System.Windows.Forms.Padding(2);
            this.checkDam.Name = "checkDam";
            this.checkDam.Size = new System.Drawing.Size(52, 19);
            this.checkDam.TabIndex = 0;
            this.checkDam.Text = "Đậm";
            this.checkDam.UseVisualStyleBackColor = true;
            this.checkDam.CheckedChanged += new System.EventHandler(this.checkDam_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radDen);
            this.groupBox3.Controls.Add(this.radXanh);
            this.groupBox3.Controls.Add(this.radDo);
            this.groupBox3.Location = new System.Drawing.Point(62, 228);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(512, 67);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Màu chữ";
            // 
            // radDen
            // 
            this.radDen.AutoSize = true;
            this.radDen.Location = new System.Drawing.Point(377, 33);
            this.radDen.Margin = new System.Windows.Forms.Padding(2);
            this.radDen.Name = "radDen";
            this.radDen.Size = new System.Drawing.Size(46, 19);
            this.radDen.TabIndex = 2;
            this.radDen.TabStop = true;
            this.radDen.Text = "Đen";
            this.radDen.UseVisualStyleBackColor = true;
            this.radDen.CheckedChanged += new System.EventHandler(this.radDen_CheckedChanged);
            // 
            // radXanh
            // 
            this.radXanh.AutoSize = true;
            this.radXanh.ForeColor = System.Drawing.Color.Chartreuse;
            this.radXanh.Location = new System.Drawing.Point(202, 33);
            this.radXanh.Margin = new System.Windows.Forms.Padding(2);
            this.radXanh.Name = "radXanh";
            this.radXanh.Size = new System.Drawing.Size(64, 19);
            this.radXanh.TabIndex = 1;
            this.radXanh.TabStop = true;
            this.radXanh.Text = "Xanh lá";
            this.radXanh.UseVisualStyleBackColor = true;
            this.radXanh.CheckedChanged += new System.EventHandler(this.radXanh_CheckedChanged);
            // 
            // radDo
            // 
            this.radDo.AutoSize = true;
            this.radDo.ForeColor = System.Drawing.Color.Red;
            this.radDo.Location = new System.Drawing.Point(19, 33);
            this.radDo.Margin = new System.Windows.Forms.Padding(2);
            this.radDo.Name = "radDo";
            this.radDo.Size = new System.Drawing.Size(40, 19);
            this.radDo.TabIndex = 0;
            this.radDo.TabStop = true;
            this.radDo.Text = "Đỏ";
            this.radDo.UseVisualStyleBackColor = true;
            this.radDo.CheckedChanged += new System.EventHandler(this.radDo_CheckedChanged);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(186, 308);
            this.btnLamLai.Margin = new System.Windows.Forms.Padding(2);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(78, 20);
            this.btnLamLai.TabIndex = 3;
            this.btnLamLai.Text = "&Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(340, 308);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(78, 20);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 352);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtKq);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Thay đổi font chữ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtKq;
        private GroupBox groupBox1;
        private ComboBox cbbKichThuoc;
        private ComboBox cbbFont;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private CheckBox checkGach;
        private CheckBox checkNghieng;
        private CheckBox checkDam;
        private GroupBox groupBox3;
        private Button btnLamLai;
        private Button btnThoat;
        private RadioButton radDen;
        private RadioButton radXanh;
        private RadioButton radDo;
        private OpenFileDialog openFileDialog1;
    }
}