namespace BaiTapThem_Bai10
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.btnToat = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnGPT = new System.Windows.Forms.Button();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.txtNhapC = new System.Windows.Forms.TextBox();
            this.txtNhapB = new System.Windows.Forms.TextBox();
            this.txtNhapA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbCCN = new System.Windows.Forms.GroupBox();
            this.radgptbh = new System.Windows.Forms.RadioButton();
            this.radgptbn = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grbCCN.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnToat);
            this.splitContainer1.Panel2.Controls.Add(this.btnLamLai);
            this.splitContainer1.Panel2.Controls.Add(this.btnGPT);
            this.splitContainer1.Panel2.Controls.Add(this.txtKetQua);
            this.splitContainer1.Panel2.Controls.Add(this.txtNhapC);
            this.splitContainer1.Panel2.Controls.Add(this.txtNhapB);
            this.splitContainer1.Panel2.Controls.Add(this.txtNhapA);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.grbCCN);
            this.splitContainer1.Size = new System.Drawing.Size(800, 528);
            this.splitContainer1.SplitterDistance = 89;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giải Phương Trình";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnToat
            // 
            this.btnToat.Location = new System.Drawing.Point(554, 360);
            this.btnToat.Name = "btnToat";
            this.btnToat.Size = new System.Drawing.Size(190, 49);
            this.btnToat.TabIndex = 11;
            this.btnToat.Text = "&Thoát";
            this.btnToat.UseVisualStyleBackColor = true;
            this.btnToat.Click += new System.EventHandler(this.btnToat_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(554, 282);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(190, 55);
            this.btnLamLai.TabIndex = 10;
            this.btnLamLai.Text = "&Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnGPT
            // 
            this.btnGPT.Location = new System.Drawing.Point(554, 198);
            this.btnGPT.Name = "btnGPT";
            this.btnGPT.Size = new System.Drawing.Size(190, 57);
            this.btnGPT.TabIndex = 9;
            this.btnGPT.Text = "Giải phương trình";
            this.btnGPT.UseVisualStyleBackColor = true;
            this.btnGPT.Click += new System.EventHandler(this.btnGPT_Click);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Enabled = false;
            this.txtKetQua.Location = new System.Drawing.Point(232, 369);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(271, 31);
            this.txtKetQua.TabIndex = 8;
            // 
            // txtNhapC
            // 
            this.txtNhapC.Location = new System.Drawing.Point(232, 312);
            this.txtNhapC.Name = "txtNhapC";
            this.txtNhapC.Size = new System.Drawing.Size(271, 31);
            this.txtNhapC.TabIndex = 7;
            // 
            // txtNhapB
            // 
            this.txtNhapB.Location = new System.Drawing.Point(232, 255);
            this.txtNhapB.Name = "txtNhapB";
            this.txtNhapB.Size = new System.Drawing.Size(271, 31);
            this.txtNhapB.TabIndex = 6;
            // 
            // txtNhapA
            // 
            this.txtNhapA.Location = new System.Drawing.Point(232, 198);
            this.txtNhapA.Name = "txtNhapA";
            this.txtNhapA.Size = new System.Drawing.Size(271, 31);
            this.txtNhapA.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kết quả:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập c:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhâp b:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập a:";
            // 
            // grbCCN
            // 
            this.grbCCN.Controls.Add(this.radgptbh);
            this.grbCCN.Controls.Add(this.radgptbn);
            this.grbCCN.Location = new System.Drawing.Point(82, 22);
            this.grbCCN.Name = "grbCCN";
            this.grbCCN.Size = new System.Drawing.Size(562, 150);
            this.grbCCN.TabIndex = 0;
            this.grbCCN.TabStop = false;
            this.grbCCN.Text = "Chọn chức năng";
            // 
            // radgptbh
            // 
            this.radgptbh.AutoSize = true;
            this.radgptbh.Location = new System.Drawing.Point(40, 84);
            this.radgptbh.Name = "radgptbh";
            this.radgptbh.Size = new System.Drawing.Size(224, 29);
            this.radgptbh.TabIndex = 1;
            this.radgptbh.TabStop = true;
            this.radgptbh.Text = "Giải phương trình bậc 2";
            this.radgptbh.UseVisualStyleBackColor = true;
            this.radgptbh.CheckedChanged += new System.EventHandler(this.radgptbh_CheckedChanged);
            // 
            // radgptbn
            // 
            this.radgptbn.AutoSize = true;
            this.radgptbn.Location = new System.Drawing.Point(40, 38);
            this.radgptbn.Name = "radgptbn";
            this.radgptbn.Size = new System.Drawing.Size(249, 29);
            this.radgptbn.TabIndex = 0;
            this.radgptbn.TabStop = true;
            this.radgptbn.Text = "Giải phương trình bậc nhất";
            this.radgptbn.UseVisualStyleBackColor = true;
            this.radgptbn.CheckedChanged += new System.EventHandler(this.radgptbn_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grbCCN.ResumeLayout(false);
            this.grbCCN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private GroupBox grbCCN;
        private Button btnToat;
        private Button btnLamLai;
        private Button btnGPT;
        private TextBox txtKetQua;
        private TextBox txtNhapC;
        private TextBox txtNhapB;
        private TextBox txtNhapA;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private RadioButton radgptbh;
        private RadioButton radgptbn;
    }
}