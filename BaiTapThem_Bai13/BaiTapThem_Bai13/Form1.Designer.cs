namespace BaiTapThem_Bai13
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
            this.lbDaySo = new System.Windows.Forms.Label();
            this.txtNhapSPT = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnTimSoDuong = new System.Windows.Forms.Button();
            this.lbTimSoDuong = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNhapK = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số phần tử";
            // 
            // lbDaySo
            // 
            this.lbDaySo.AutoSize = true;
            this.lbDaySo.ForeColor = System.Drawing.Color.Red;
            this.lbDaySo.Location = new System.Drawing.Point(38, 116);
            this.lbDaySo.Name = "lbDaySo";
            this.lbDaySo.Size = new System.Drawing.Size(0, 25);
            this.lbDaySo.TabIndex = 1;
            // 
            // txtNhapSPT
            // 
            this.txtNhapSPT.Location = new System.Drawing.Point(273, 30);
            this.txtNhapSPT.Name = "txtNhapSPT";
            this.txtNhapSPT.Size = new System.Drawing.Size(236, 31);
            this.txtNhapSPT.TabIndex = 2;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(676, 30);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(147, 34);
            this.btnNhap.TabIndex = 3;
            this.btnNhap.Text = "&Nhập dãy";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnTimSoDuong
            // 
            this.btnTimSoDuong.Location = new System.Drawing.Point(38, 199);
            this.btnTimSoDuong.Name = "btnTimSoDuong";
            this.btnTimSoDuong.Size = new System.Drawing.Size(232, 34);
            this.btnTimSoDuong.TabIndex = 4;
            this.btnTimSoDuong.Text = "Tìm số dương nhỏ nhất";
            this.btnTimSoDuong.UseVisualStyleBackColor = true;
            this.btnTimSoDuong.Click += new System.EventHandler(this.btnTimSoDuong_Click);
            // 
            // lbTimSoDuong
            // 
            this.lbTimSoDuong.AutoSize = true;
            this.lbTimSoDuong.Location = new System.Drawing.Point(38, 279);
            this.lbTimSoDuong.Name = "lbTimSoDuong";
            this.lbTimSoDuong.Size = new System.Drawing.Size(0, 25);
            this.lbTimSoDuong.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nhập một số k";
            // 
            // txtNhapK
            // 
            this.txtNhapK.Location = new System.Drawing.Point(273, 373);
            this.txtNhapK.Name = "txtNhapK";
            this.txtNhapK.Size = new System.Drawing.Size(236, 31);
            this.txtNhapK.TabIndex = 7;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(676, 370);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(147, 34);
            this.btnTim.TabIndex = 8;
            this.btnTim.Text = "&Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(402, 506);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(147, 34);
            this.btnLamLai.TabIndex = 9;
            this.btnLamLai.Text = "&Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(676, 506);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(147, 34);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "T&hoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 569);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtNhapK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbTimSoDuong);
            this.Controls.Add(this.btnTimSoDuong);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.txtNhapSPT);
            this.Controls.Add(this.lbDaySo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lbDaySo;
        private TextBox txtNhapSPT;
        private Button btnNhap;
        private Button btnTimSoDuong;
        private Label lbTimSoDuong;
        private Label label4;
        private TextBox txtNhapK;
        private Button btnTim;
        private Button btnLamLai;
        private Button btnThoat;
    }
}