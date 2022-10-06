namespace BaiTapThem_Bai8
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
            this.lbNhap = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTang3 = new System.Windows.Forms.Button();
            this.btnChon = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnChonLe = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNhap
            // 
            this.lbNhap.AutoSize = true;
            this.lbNhap.Location = new System.Drawing.Point(43, 31);
            this.lbNhap.Name = "lbNhap";
            this.lbNhap.Size = new System.Drawing.Size(126, 25);
            this.lbNhap.TabIndex = 0;
            this.lbNhap.Text = "Nhập một số: ";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(195, 31);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(160, 31);
            this.txtNhap.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(93, 101);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(226, 67);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTang3
            // 
            this.btnTang3.Location = new System.Drawing.Point(93, 193);
            this.btnTang3.Name = "btnTang3";
            this.btnTang3.Size = new System.Drawing.Size(226, 67);
            this.btnTang3.TabIndex = 3;
            this.btnTang3.Text = "Tăng mỗi số lên 3 ";
            this.btnTang3.UseVisualStyleBackColor = true;
            this.btnTang3.Click += new System.EventHandler(this.btnTang3_Click);
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(93, 285);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(226, 67);
            this.btnChon.TabIndex = 4;
            this.btnChon.Text = "Chọn số chắn đầu";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(435, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 353);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dãy số";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(85, 302);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 34);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(59, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(180, 229);
            this.listBox1.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(623, 415);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 34);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "T&hoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnChonLe
            // 
            this.btnChonLe.Location = new System.Drawing.Point(93, 377);
            this.btnChonLe.Name = "btnChonLe";
            this.btnChonLe.Size = new System.Drawing.Size(226, 67);
            this.btnChonLe.TabIndex = 6;
            this.btnChonLe.Text = "Chọn số lẻ cuối";
            this.btnChonLe.UseVisualStyleBackColor = true;
            this.btnChonLe.Click += new System.EventHandler(this.btnChonLe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.btnChonLe);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.btnTang3);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.lbNhap);
            this.Name = "Form1";
            this.Text = "Làm việc với dãy số";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbNhap;
        private TextBox txtNhap;
        private Button btnThem;
        private Button btnTang3;
        private Button btnChon;
        private GroupBox groupBox1;
        private Button btnXoa;
        private ListBox listBox1;
        private Button btnThoat;
        private Button btnChonLe;
    }
}