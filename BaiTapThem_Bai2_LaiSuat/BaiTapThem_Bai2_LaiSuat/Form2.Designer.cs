namespace BaiTapThem_Bai2_LaiSuat
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
            this.lbNhapMaKHCanTim = new System.Windows.Forms.Label();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.txtNhapMaKHCanTim = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNhapMaKHCanTim
            // 
            this.lbNhapMaKHCanTim.AutoSize = true;
            this.lbNhapMaKHCanTim.Location = new System.Drawing.Point(50, 43);
            this.lbNhapMaKHCanTim.Name = "lbNhapMaKHCanTim";
            this.lbNhapMaKHCanTim.Size = new System.Drawing.Size(287, 25);
            this.lbNhapMaKHCanTim.TabIndex = 0;
            this.lbNhapMaKHCanTim.Text = "Nhập mã khách hàng cần tìm kiếm";
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Location = new System.Drawing.Point(50, 311);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(0, 25);
            this.lbKetQua.TabIndex = 1;
            // 
            // txtNhapMaKHCanTim
            // 
            this.txtNhapMaKHCanTim.Location = new System.Drawing.Point(394, 43);
            this.txtNhapMaKHCanTim.Name = "txtNhapMaKHCanTim";
            this.txtNhapMaKHCanTim.Size = new System.Drawing.Size(332, 31);
            this.txtNhapMaKHCanTim.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(233, 177);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(337, 34);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtNhapMaKHCanTim);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.lbNhapMaKHCanTim);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbNhapMaKHCanTim;
        private Label lbKetQua;
        private TextBox txtNhapMaKHCanTim;
        private Button btnTimKiem;
    }
}