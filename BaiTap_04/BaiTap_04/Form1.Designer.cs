namespace BaiTap_04
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
            this.grbNhap = new System.Windows.Forms.GroupBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.txtNhapb = new System.Windows.Forms.TextBox();
            this.txtNhapa = new System.Windows.Forms.TextBox();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.lbNhapb = new System.Windows.Forms.Label();
            this.lbNhapa = new System.Windows.Forms.Label();
            this.grbPhepTinh = new System.Windows.Forms.GroupBox();
            this.radChia = new System.Windows.Forms.RadioButton();
            this.radNhan = new System.Windows.Forms.RadioButton();
            this.radTru = new System.Windows.Forms.RadioButton();
            this.radCong = new System.Windows.Forms.RadioButton();
            this.grbSoSanh = new System.Windows.Forms.GroupBox();
            this.checkMin = new System.Windows.Forms.CheckBox();
            this.checkMax = new System.Windows.Forms.CheckBox();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbNhap.SuspendLayout();
            this.grbPhepTinh.SuspendLayout();
            this.grbSoSanh.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbNhap
            // 
            this.grbNhap.Controls.Add(this.txtKetQua);
            this.grbNhap.Controls.Add(this.txtNhapb);
            this.grbNhap.Controls.Add(this.txtNhapa);
            this.grbNhap.Controls.Add(this.lbKetQua);
            this.grbNhap.Controls.Add(this.lbNhapb);
            this.grbNhap.Controls.Add(this.lbNhapa);
            this.grbNhap.Location = new System.Drawing.Point(153, 47);
            this.grbNhap.Name = "grbNhap";
            this.grbNhap.Size = new System.Drawing.Size(544, 204);
            this.grbNhap.TabIndex = 0;
            this.grbNhap.TabStop = false;
            // 
            // txtKetQua
            // 
            this.txtKetQua.Enabled = false;
            this.txtKetQua.Location = new System.Drawing.Point(219, 146);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(278, 31);
            this.txtKetQua.TabIndex = 5;
            // 
            // txtNhapb
            // 
            this.txtNhapb.Location = new System.Drawing.Point(219, 94);
            this.txtNhapb.Name = "txtNhapb";
            this.txtNhapb.Size = new System.Drawing.Size(278, 31);
            this.txtNhapb.TabIndex = 4;
            this.txtNhapb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhapb_KeyPress);
            // 
            // txtNhapa
            // 
            this.txtNhapa.Location = new System.Drawing.Point(219, 38);
            this.txtNhapa.Name = "txtNhapa";
            this.txtNhapa.Size = new System.Drawing.Size(278, 31);
            this.txtNhapa.TabIndex = 3;
            this.txtNhapa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhapa_KeyPress);
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Location = new System.Drawing.Point(52, 152);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(72, 25);
            this.lbKetQua.TabIndex = 2;
            this.lbKetQua.Text = "Kết quả";
            // 
            // lbNhapb
            // 
            this.lbNhapb.AutoSize = true;
            this.lbNhapb.Location = new System.Drawing.Point(52, 100);
            this.lbNhapb.Name = "lbNhapb";
            this.lbNhapb.Size = new System.Drawing.Size(93, 25);
            this.lbNhapb.TabIndex = 1;
            this.lbNhapb.Text = "Nhập b = ";
            // 
            // lbNhapa
            // 
            this.lbNhapa.AutoSize = true;
            this.lbNhapa.Location = new System.Drawing.Point(52, 38);
            this.lbNhapa.Name = "lbNhapa";
            this.lbNhapa.Size = new System.Drawing.Size(91, 25);
            this.lbNhapa.TabIndex = 0;
            this.lbNhapa.Text = "Nhập a = ";
            // 
            // grbPhepTinh
            // 
            this.grbPhepTinh.Controls.Add(this.radChia);
            this.grbPhepTinh.Controls.Add(this.radNhan);
            this.grbPhepTinh.Controls.Add(this.radTru);
            this.grbPhepTinh.Controls.Add(this.radCong);
            this.grbPhepTinh.Location = new System.Drawing.Point(73, 296);
            this.grbPhepTinh.Name = "grbPhepTinh";
            this.grbPhepTinh.Size = new System.Drawing.Size(300, 250);
            this.grbPhepTinh.TabIndex = 1;
            this.grbPhepTinh.TabStop = false;
            this.grbPhepTinh.Text = "Phép tính";
            // 
            // radChia
            // 
            this.radChia.AutoSize = true;
            this.radChia.Location = new System.Drawing.Point(32, 196);
            this.radChia.Name = "radChia";
            this.radChia.Size = new System.Drawing.Size(71, 29);
            this.radChia.TabIndex = 3;
            this.radChia.TabStop = true;
            this.radChia.Text = "Chia";
            this.radChia.UseVisualStyleBackColor = true;
            this.radChia.CheckedChanged += new System.EventHandler(this.radChia_CheckedChanged);
            // 
            // radNhan
            // 
            this.radNhan.AutoSize = true;
            this.radNhan.Location = new System.Drawing.Point(32, 146);
            this.radNhan.Name = "radNhan";
            this.radNhan.Size = new System.Drawing.Size(79, 29);
            this.radNhan.TabIndex = 2;
            this.radNhan.TabStop = true;
            this.radNhan.Text = "Nhân";
            this.radNhan.UseVisualStyleBackColor = true;
            this.radNhan.CheckedChanged += new System.EventHandler(this.radNhan_CheckedChanged);
            // 
            // radTru
            // 
            this.radTru.AutoSize = true;
            this.radTru.Location = new System.Drawing.Point(32, 90);
            this.radTru.Name = "radTru";
            this.radTru.Size = new System.Drawing.Size(61, 29);
            this.radTru.TabIndex = 1;
            this.radTru.TabStop = true;
            this.radTru.Text = "Trừ";
            this.radTru.UseVisualStyleBackColor = true;
            this.radTru.CheckedChanged += new System.EventHandler(this.radTru_CheckedChanged);
            // 
            // radCong
            // 
            this.radCong.AutoSize = true;
            this.radCong.Location = new System.Drawing.Point(32, 38);
            this.radCong.Name = "radCong";
            this.radCong.Size = new System.Drawing.Size(80, 29);
            this.radCong.TabIndex = 0;
            this.radCong.TabStop = true;
            this.radCong.Text = "Cộng";
            this.radCong.UseVisualStyleBackColor = true;
            this.radCong.CheckedChanged += new System.EventHandler(this.radCong_CheckedChanged);
            // 
            // grbSoSanh
            // 
            this.grbSoSanh.Controls.Add(this.checkMin);
            this.grbSoSanh.Controls.Add(this.checkMax);
            this.grbSoSanh.Location = new System.Drawing.Point(450, 296);
            this.grbSoSanh.Name = "grbSoSanh";
            this.grbSoSanh.Size = new System.Drawing.Size(300, 250);
            this.grbSoSanh.TabIndex = 4;
            this.grbSoSanh.TabStop = false;
            this.grbSoSanh.Text = "So sánh";
            // 
            // checkMin
            // 
            this.checkMin.AutoSize = true;
            this.checkMin.Location = new System.Drawing.Point(43, 174);
            this.checkMin.Name = "checkMin";
            this.checkMin.Size = new System.Drawing.Size(90, 29);
            this.checkMin.TabIndex = 1;
            this.checkMin.Text = "Min = ";
            this.checkMin.UseVisualStyleBackColor = true;
            this.checkMin.CheckedChanged += new System.EventHandler(this.checkMin_CheckedChanged);
            // 
            // checkMax
            // 
            this.checkMax.AutoSize = true;
            this.checkMax.Location = new System.Drawing.Point(43, 59);
            this.checkMax.Name = "checkMax";
            this.checkMax.Size = new System.Drawing.Size(93, 29);
            this.checkMax.TabIndex = 0;
            this.checkMax.Text = "Max = ";
            this.checkMax.UseVisualStyleBackColor = true;
            this.checkMax.CheckedChanged += new System.EventHandler(this.checkMax_CheckedChanged);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(205, 581);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(112, 34);
            this.btnLamLai.TabIndex = 5;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(504, 581);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 34);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 640);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.grbSoSanh);
            this.Controls.Add(this.grbPhepTinh);
            this.Controls.Add(this.grbNhap);
            this.Name = "Form1";
            this.Text = "Chương trình tính toán";
            this.grbNhap.ResumeLayout(false);
            this.grbNhap.PerformLayout();
            this.grbPhepTinh.ResumeLayout(false);
            this.grbPhepTinh.PerformLayout();
            this.grbSoSanh.ResumeLayout(false);
            this.grbSoSanh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grbNhap;
        private TextBox txtKetQua;
        private TextBox txtNhapb;
        private TextBox txtNhapa;
        private Label lbKetQua;
        private Label lbNhapb;
        private Label lbNhapa;
        private GroupBox grbPhepTinh;
        private RadioButton radChia;
        private RadioButton radNhan;
        private RadioButton radTru;
        private RadioButton radCong;
        private GroupBox grbSoSanh;
        private CheckBox checkMin;
        private CheckBox checkMax;
        private Button btnLamLai;
        private Button btnThoat;
    }
}