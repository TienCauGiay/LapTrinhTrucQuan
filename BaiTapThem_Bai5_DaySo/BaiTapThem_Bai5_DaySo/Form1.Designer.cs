namespace BaiTapThem_Bai5_DaySo
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
            this.grbDaySo = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.lbNhapSo = new System.Windows.Forms.Label();
            this.lbTinhTong = new System.Windows.Forms.Label();
            this.lbMax = new System.Windows.Forms.Label();
            this.txtNhapSo = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbDaySo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDaySo
            // 
            this.grbDaySo.Controls.Add(this.listBox1);
            this.grbDaySo.Location = new System.Drawing.Point(244, 37);
            this.grbDaySo.Name = "grbDaySo";
            this.grbDaySo.Size = new System.Drawing.Size(300, 350);
            this.grbDaySo.TabIndex = 0;
            this.grbDaySo.TabStop = false;
            this.grbDaySo.Text = "Dãy số";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(24, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(233, 279);
            this.listBox1.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(61, 100);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(141, 34);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm vào &DS";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(61, 213);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(141, 34);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "&Xóa khỏi DS";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(61, 319);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(141, 34);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "&Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(588, 100);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(112, 34);
            this.btnTong.TabIndex = 4;
            this.btnTong.Text = "T&ính tổng";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(588, 208);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(112, 34);
            this.btnMax.TabIndex = 5;
            this.btnMax.Text = "Tìm M&ax";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // lbNhapSo
            // 
            this.lbNhapSo.AutoSize = true;
            this.lbNhapSo.Location = new System.Drawing.Point(12, 26);
            this.lbNhapSo.Name = "lbNhapSo";
            this.lbNhapSo.Size = new System.Drawing.Size(79, 25);
            this.lbNhapSo.TabIndex = 6;
            this.lbNhapSo.Text = "Nhập số";
            // 
            // lbTinhTong
            // 
            this.lbTinhTong.AutoSize = true;
            this.lbTinhTong.ForeColor = System.Drawing.Color.IndianRed;
            this.lbTinhTong.Location = new System.Drawing.Point(839, 109);
            this.lbTinhTong.Name = "lbTinhTong";
            this.lbTinhTong.Size = new System.Drawing.Size(0, 25);
            this.lbTinhTong.TabIndex = 7;
            // 
            // lbMax
            // 
            this.lbMax.AutoSize = true;
            this.lbMax.ForeColor = System.Drawing.Color.IndianRed;
            this.lbMax.Location = new System.Drawing.Point(839, 213);
            this.lbMax.Name = "lbMax";
            this.lbMax.Size = new System.Drawing.Size(0, 25);
            this.lbMax.TabIndex = 8;
            // 
            // txtNhapSo
            // 
            this.txtNhapSo.Location = new System.Drawing.Point(154, 26);
            this.txtNhapSo.Name = "txtNhapSo";
            this.txtNhapSo.Size = new System.Drawing.Size(84, 31);
            this.txtNhapSo.TabIndex = 9;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(588, 319);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 34);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "T&hoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtNhapSo);
            this.Controls.Add(this.lbMax);
            this.Controls.Add(this.lbTinhTong);
            this.Controls.Add(this.lbNhapSo);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grbDaySo);
            this.Name = "Form1";
            this.Text = "Dãy số";
            this.grbDaySo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grbDaySo;
        private ListBox listBox1;
        private Button btnThem;
        private Button btnXoa;
        private Button btnLamMoi;
        private Button btnTong;
        private Button btnMax;
        private Label lbNhapSo;
        private Label lbTinhTong;
        private Label lbMax;
        private TextBox txtNhapSo;
        private Button btnThoat;
    }
}