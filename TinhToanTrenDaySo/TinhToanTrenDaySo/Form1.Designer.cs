namespace TinhToanTrenDaySo
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
            this.lbNhapn = new System.Windows.Forms.Label();
            this.txtNhapn = new System.Windows.Forms.TextBox();
            this.lbDaySo = new System.Windows.Forms.Label();
            this.lbHienDaySo = new System.Windows.Forms.Label();
            this.lbTongDaySo = new System.Windows.Forms.Label();
            this.lbDaySoGiam = new System.Windows.Forms.Label();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnTinhTong = new System.Windows.Forms.Button();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lbHienTongDaySo = new System.Windows.Forms.Label();
            this.lbHienDaySoSapXepGiam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNhapn
            // 
            this.lbNhapn.AutoSize = true;
            this.lbNhapn.Location = new System.Drawing.Point(77, 59);
            this.lbNhapn.Name = "lbNhapn";
            this.lbNhapn.Size = new System.Drawing.Size(74, 25);
            this.lbNhapn.TabIndex = 0;
            this.lbNhapn.Text = "Nhập n:";
            // 
            // txtNhapn
            // 
            this.txtNhapn.Location = new System.Drawing.Point(292, 59);
            this.txtNhapn.Name = "txtNhapn";
            this.txtNhapn.Size = new System.Drawing.Size(427, 31);
            this.txtNhapn.TabIndex = 1;
            this.txtNhapn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhapn_KeyPress);
            // 
            // lbDaySo
            // 
            this.lbDaySo.AutoSize = true;
            this.lbDaySo.Location = new System.Drawing.Point(77, 130);
            this.lbDaySo.Name = "lbDaySo";
            this.lbDaySo.Size = new System.Drawing.Size(76, 25);
            this.lbDaySo.TabIndex = 2;
            this.lbDaySo.Text = "Dãy số: ";
            // 
            // lbHienDaySo
            // 
            this.lbHienDaySo.AutoSize = true;
            this.lbHienDaySo.Location = new System.Drawing.Point(181, 130);
            this.lbHienDaySo.Name = "lbHienDaySo";
            this.lbHienDaySo.Size = new System.Drawing.Size(0, 25);
            this.lbHienDaySo.TabIndex = 3;
            // 
            // lbTongDaySo
            // 
            this.lbTongDaySo.AutoSize = true;
            this.lbTongDaySo.Location = new System.Drawing.Point(77, 196);
            this.lbTongDaySo.Name = "lbTongDaySo";
            this.lbTongDaySo.Size = new System.Drawing.Size(115, 25);
            this.lbTongDaySo.TabIndex = 5;
            this.lbTongDaySo.Text = "Tổng dãy số:";
            // 
            // lbDaySoGiam
            // 
            this.lbDaySoGiam.AutoSize = true;
            this.lbDaySoGiam.Location = new System.Drawing.Point(77, 269);
            this.lbDaySoGiam.Name = "lbDaySoGiam";
            this.lbDaySoGiam.Size = new System.Drawing.Size(263, 25);
            this.lbDaySoGiam.TabIndex = 6;
            this.lbDaySoGiam.Text = "Dãy số được sắp xếp giảm dần:";
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(69, 339);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(112, 34);
            this.btnNhap.TabIndex = 7;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnTinhTong
            // 
            this.btnTinhTong.Location = new System.Drawing.Point(231, 339);
            this.btnTinhTong.Name = "btnTinhTong";
            this.btnTinhTong.Size = new System.Drawing.Size(112, 34);
            this.btnTinhTong.TabIndex = 8;
            this.btnTinhTong.Text = "Tính tổng";
            this.btnTinhTong.UseVisualStyleBackColor = true;
            this.btnTinhTong.Click += new System.EventHandler(this.btnTinhTong_Click);
            // 
            // btnSapXep
            // 
            this.btnSapXep.Location = new System.Drawing.Point(389, 339);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(112, 34);
            this.btnSapXep.TabIndex = 9;
            this.btnSapXep.Text = "Sắp xếp";
            this.btnSapXep.UseVisualStyleBackColor = true;
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(549, 339);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(112, 34);
            this.btnLamLai.TabIndex = 10;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(705, 339);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 34);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lbHienTongDaySo
            // 
            this.lbHienTongDaySo.AutoSize = true;
            this.lbHienTongDaySo.Location = new System.Drawing.Point(207, 196);
            this.lbHienTongDaySo.Name = "lbHienTongDaySo";
            this.lbHienTongDaySo.Size = new System.Drawing.Size(0, 25);
            this.lbHienTongDaySo.TabIndex = 12;
            // 
            // lbHienDaySoSapXepGiam
            // 
            this.lbHienDaySoSapXepGiam.AutoSize = true;
            this.lbHienDaySoSapXepGiam.Location = new System.Drawing.Point(366, 269);
            this.lbHienDaySoSapXepGiam.Name = "lbHienDaySoSapXepGiam";
            this.lbHienDaySoSapXepGiam.Size = new System.Drawing.Size(0, 25);
            this.lbHienDaySoSapXepGiam.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.ClientSize = new System.Drawing.Size(878, 450);
            this.Controls.Add(this.lbHienDaySoSapXepGiam);
            this.Controls.Add(this.lbHienTongDaySo);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnSapXep);
            this.Controls.Add(this.btnTinhTong);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.lbDaySoGiam);
            this.Controls.Add(this.lbTongDaySo);
            this.Controls.Add(this.lbHienDaySo);
            this.Controls.Add(this.lbDaySo);
            this.Controls.Add(this.txtNhapn);
            this.Controls.Add(this.lbNhapn);
            this.Name = "Form1";
            this.Text = "Tính toán trên dãy số";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbNhapn;
        private TextBox txtNhapn;
        private Label lbDaySo;
        private Label lbHienDaySo;
        private Label lbTongDaySo;
        private Label lbDaySoGiam;
        private Button btnNhap;
        private Button btnTinhTong;
        private Button btnSapXep;
        private Button btnLamLai;
        private Button btnThoat;
        private Label lbHienTongDaySo;
        private Label lbHienDaySoSapXepGiam;
    }
}