namespace BaiTapThem_Bai6_DaySo
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.grbTimMax = new System.Windows.Forms.GroupBox();
            this.lbMax = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lbNhapMotSo = new System.Windows.Forms.Label();
            this.txtNhapSo = new System.Windows.Forms.TextBox();
            this.grbDaySo.SuspendLayout();
            this.grbTimMax.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDaySo
            // 
            this.grbDaySo.Controls.Add(this.btnXoa);
            this.grbDaySo.Controls.Add(this.listBox1);
            this.grbDaySo.Location = new System.Drawing.Point(532, 37);
            this.grbDaySo.Name = "grbDaySo";
            this.grbDaySo.Size = new System.Drawing.Size(257, 323);
            this.grbDaySo.TabIndex = 0;
            this.grbDaySo.TabStop = false;
            this.grbDaySo.Text = "Dãy số";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(54, 264);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 34);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(20, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(170, 204);
            this.listBox1.TabIndex = 0;
            //this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // grbTimMax
            // 
            this.grbTimMax.Controls.Add(this.lbMax);
            this.grbTimMax.Controls.Add(this.btnTim);
            this.grbTimMax.Location = new System.Drawing.Point(22, 194);
            this.grbTimMax.Name = "grbTimMax";
            this.grbTimMax.Size = new System.Drawing.Size(465, 166);
            this.grbTimMax.TabIndex = 1;
            this.grbTimMax.TabStop = false;
            this.grbTimMax.Text = "Tìm giá trị lớn nhất";
            // 
            // lbMax
            // 
            this.lbMax.AutoSize = true;
            this.lbMax.Location = new System.Drawing.Point(28, 112);
            this.lbMax.Name = "lbMax";
            this.lbMax.Size = new System.Drawing.Size(0, 25);
            this.lbMax.TabIndex = 8;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(110, 43);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(112, 34);
            this.btnTim.TabIndex = 5;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(683, 400);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 34);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "T&hoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(518, 400);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(112, 34);
            this.btnLamLai.TabIndex = 3;
            this.btnLamLai.Text = "&Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(22, 110);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 34);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lbNhapMotSo
            // 
            this.lbNhapMotSo.AutoSize = true;
            this.lbNhapMotSo.Location = new System.Drawing.Point(22, 37);
            this.lbNhapMotSo.Name = "lbNhapMotSo";
            this.lbNhapMotSo.Size = new System.Drawing.Size(117, 25);
            this.lbNhapMotSo.TabIndex = 7;
            this.lbNhapMotSo.Text = "Nhập một số";
            // 
            // txtNhapSo
            // 
            this.txtNhapSo.Location = new System.Drawing.Point(212, 37);
            this.txtNhapSo.Name = "txtNhapSo";
            this.txtNhapSo.Size = new System.Drawing.Size(251, 31);
            this.txtNhapSo.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 478);
            this.Controls.Add(this.txtNhapSo);
            this.Controls.Add(this.lbNhapMotSo);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.grbTimMax);
            this.Controls.Add(this.grbDaySo);
            this.Name = "Form1";
            this.Text = "Làm việc trên dãy số";
            this.grbDaySo.ResumeLayout(false);
            this.grbTimMax.ResumeLayout(false);
            this.grbTimMax.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grbDaySo;
        private Button btnXoa;
        private ListBox listBox1;
        private GroupBox grbTimMax;
        private Label lbMax;
        private Button btnTim;
        private Button btnThoat;
        private Button btnLamLai;
        private Button btnThem;
        private Label lbNhapMotSo;
        private TextBox txtNhapSo;
    }
}