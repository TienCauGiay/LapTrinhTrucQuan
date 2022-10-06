namespace BaiTapThem_TinhDienTich
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbNhap = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.lbThongTinTimKiem = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNhap
            // 
            this.lbNhap.AutoSize = true;
            this.lbNhap.Location = new System.Drawing.Point(77, 50);
            this.lbNhap.Name = "lbNhap";
            this.lbNhap.Size = new System.Drawing.Size(244, 25);
            this.lbNhap.TabIndex = 0;
            this.lbNhap.Text = "Nhập tên khách hàng cần tìm";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(391, 50);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(365, 31);
            this.txtNhap.TabIndex = 1;
            // 
            // lbThongTinTimKiem
            // 
            this.lbThongTinTimKiem.AutoSize = true;
            this.lbThongTinTimKiem.Location = new System.Drawing.Point(77, 272);
            this.lbThongTinTimKiem.Name = "lbThongTinTimKiem";
            this.lbThongTinTimKiem.Size = new System.Drawing.Size(0, 25);
            this.lbThongTinTimKiem.TabIndex = 2;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(77, 148);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(112, 34);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.lbThongTinTimKiem);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.lbNhap);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbNhap;
        private TextBox txtNhap;
        private Label lbThongTinTimKiem;
        private Button btnTim;
    }
}