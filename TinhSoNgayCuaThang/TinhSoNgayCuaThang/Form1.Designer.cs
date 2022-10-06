namespace TinhSoNgayCuaThang
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
            this.lbThang = new System.Windows.Forms.Label();
            this.lbNam = new System.Windows.Forms.Label();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.txtMess = new System.Windows.Forms.TextBox();
            this.btnKetQua = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbThang
            // 
            this.lbThang.AutoSize = true;
            this.lbThang.Location = new System.Drawing.Point(120, 71);
            this.lbThang.Name = "lbThang";
            this.lbThang.Size = new System.Drawing.Size(109, 25);
            this.lbThang.TabIndex = 0;
            this.lbThang.Text = "Nhập Tháng";
            // 
            // lbNam
            // 
            this.lbNam.AutoSize = true;
            this.lbNam.Location = new System.Drawing.Point(120, 170);
            this.lbNam.Name = "lbNam";
            this.lbNam.Size = new System.Drawing.Size(98, 25);
            this.lbNam.TabIndex = 1;
            this.lbNam.Text = "Nhập Năm";
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(397, 78);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(150, 31);
            this.txtThang.TabIndex = 2;
            this.txtThang.TextChanged += new System.EventHandler(this.txtThang_TextChanged);
            this.txtThang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThang_KeyPress);
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(397, 170);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(150, 31);
            this.txtNam.TabIndex = 3;
            this.txtNam.TextChanged += new System.EventHandler(this.txtNam_TextChanged);
            this.txtNam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNam_KeyPress);
            // 
            // txtMess
            // 
            this.txtMess.Enabled = false;
            this.txtMess.Location = new System.Drawing.Point(120, 252);
            this.txtMess.Name = "txtMess";
            this.txtMess.Size = new System.Drawing.Size(438, 31);
            this.txtMess.TabIndex = 4;
            // 
            // btnKetQua
            // 
            this.btnKetQua.Location = new System.Drawing.Point(121, 348);
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.Size = new System.Drawing.Size(112, 34);
            this.btnKetQua.TabIndex = 5;
            this.btnKetQua.Text = "Kết quả";
            this.btnKetQua.UseVisualStyleBackColor = true;
            this.btnKetQua.Click += new System.EventHandler(this.btnKetQua_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(357, 348);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(112, 34);
            this.btnLamLai.TabIndex = 6;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(583, 348);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 34);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnKetQua);
            this.Controls.Add(this.txtMess);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.lbNam);
            this.Controls.Add(this.lbThang);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbThang;
        private Label lbNam;
        private TextBox txtThang;
        private TextBox txtNam;
        private TextBox txtMess;
        private Button btnKetQua;
        private Button btnLamLai;
        private Button btnThoat;
    }
}