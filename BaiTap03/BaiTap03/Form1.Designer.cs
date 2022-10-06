namespace BaiTap03
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
            this.lbTieuDe = new System.Windows.Forms.Label();
            this.lbNhapa = new System.Windows.Forms.Label();
            this.lbNhapb = new System.Windows.Forms.Label();
            this.lbNhapc = new System.Windows.Forms.Label();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.txtNhapa = new System.Windows.Forms.TextBox();
            this.txtNhapb = new System.Windows.Forms.TextBox();
            this.txtNhapc = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnGiaiPT = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.AutoSize = true;
            this.lbTieuDe.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTieuDe.ForeColor = System.Drawing.Color.Red;
            this.lbTieuDe.Location = new System.Drawing.Point(187, 32);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(444, 41);
            this.lbTieuDe.TabIndex = 0;
            this.lbTieuDe.Text = "Giải Phương Trình Bậc Hai";
            // 
            // lbNhapa
            // 
            this.lbNhapa.AutoSize = true;
            this.lbNhapa.Location = new System.Drawing.Point(52, 107);
            this.lbNhapa.Name = "lbNhapa";
            this.lbNhapa.Size = new System.Drawing.Size(73, 25);
            this.lbNhapa.TabIndex = 1;
            this.lbNhapa.Text = "Nhập a:";
            // 
            // lbNhapb
            // 
            this.lbNhapb.AutoSize = true;
            this.lbNhapb.Location = new System.Drawing.Point(52, 180);
            this.lbNhapb.Name = "lbNhapb";
            this.lbNhapb.Size = new System.Drawing.Size(75, 25);
            this.lbNhapb.TabIndex = 2;
            this.lbNhapb.Text = "Nhập b:";
            // 
            // lbNhapc
            // 
            this.lbNhapc.AutoSize = true;
            this.lbNhapc.Location = new System.Drawing.Point(52, 246);
            this.lbNhapc.Name = "lbNhapc";
            this.lbNhapc.Size = new System.Drawing.Size(72, 25);
            this.lbNhapc.TabIndex = 3;
            this.lbNhapc.Text = "Nhập c:";
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Location = new System.Drawing.Point(52, 324);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(81, 25);
            this.lbKetQua.TabIndex = 4;
            this.lbKetQua.Text = "Kết quả: ";
            // 
            // txtNhapa
            // 
            this.txtNhapa.Location = new System.Drawing.Point(213, 108);
            this.txtNhapa.Name = "txtNhapa";
            this.txtNhapa.Size = new System.Drawing.Size(479, 31);
            this.txtNhapa.TabIndex = 5;
            // 
            // txtNhapb
            // 
            this.txtNhapb.Location = new System.Drawing.Point(213, 180);
            this.txtNhapb.Name = "txtNhapb";
            this.txtNhapb.Size = new System.Drawing.Size(479, 31);
            this.txtNhapb.TabIndex = 6;
            // 
            // txtNhapc
            // 
            this.txtNhapc.Location = new System.Drawing.Point(213, 246);
            this.txtNhapc.Name = "txtNhapc";
            this.txtNhapc.Size = new System.Drawing.Size(479, 31);
            this.txtNhapc.TabIndex = 7;
            // 
            // txtKetQua
            // 
            this.txtKetQua.BackColor = System.Drawing.SystemColors.Info;
            this.txtKetQua.Enabled = false;
            this.txtKetQua.Location = new System.Drawing.Point(213, 318);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(479, 31);
            this.txtKetQua.TabIndex = 8;
            // 
            // btnGiaiPT
            // 
            this.btnGiaiPT.Location = new System.Drawing.Point(52, 384);
            this.btnGiaiPT.Name = "btnGiaiPT";
            this.btnGiaiPT.Size = new System.Drawing.Size(112, 34);
            this.btnGiaiPT.TabIndex = 9;
            this.btnGiaiPT.Text = "&Giải PT";
            this.btnGiaiPT.UseVisualStyleBackColor = true;
            this.btnGiaiPT.Click += new System.EventHandler(this.btnGiaiPT_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(333, 384);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(112, 34);
            this.btnLamLai.TabIndex = 10;
            this.btnLamLai.Text = "&Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(580, 393);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 34);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "&Thoát";
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
            this.Controls.Add(this.btnGiaiPT);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtNhapc);
            this.Controls.Add(this.txtNhapb);
            this.Controls.Add(this.txtNhapa);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.lbNhapc);
            this.Controls.Add(this.lbNhapb);
            this.Controls.Add(this.lbNhapa);
            this.Controls.Add(this.lbTieuDe);
            this.Name = "Form1";
            this.Text = "Bài tập 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbTieuDe;
        private Label lbNhapa;
        private Label lbNhapb;
        private Label lbNhapc;
        private Label lbKetQua;
        private TextBox txtNhapa;
        private TextBox txtNhapb;
        private TextBox txtNhapc;
        private TextBox txtKetQua;
        private Button btnGiaiPT;
        private Button btnLamLai;
        private Button btnThoat;
    }
}