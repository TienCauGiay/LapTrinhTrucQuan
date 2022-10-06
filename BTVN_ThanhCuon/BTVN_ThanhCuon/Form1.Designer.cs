namespace BTVN_ThanhCuon
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
            this.barRed = new System.Windows.Forms.HScrollBar();
            this.barGreen = new System.Windows.Forms.HScrollBar();
            this.barBlue = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbRed = new System.Windows.Forms.Label();
            this.lbGreen = new System.Windows.Forms.Label();
            this.lbBlue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // barRed
            // 
            this.barRed.LargeChange = 1;
            this.barRed.Location = new System.Drawing.Point(131, 157);
            this.barRed.Maximum = 255;
            this.barRed.Name = "barRed";
            this.barRed.Size = new System.Drawing.Size(526, 39);
            this.barRed.TabIndex = 0;
            this.barRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // barGreen
            // 
            this.barGreen.LargeChange = 1;
            this.barGreen.Location = new System.Drawing.Point(131, 240);
            this.barGreen.Maximum = 255;
            this.barGreen.Name = "barGreen";
            this.barGreen.Size = new System.Drawing.Size(526, 39);
            this.barGreen.TabIndex = 1;
            this.barGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.barGreen_Scroll);
            // 
            // barBlue
            // 
            this.barBlue.LargeChange = 1;
            this.barBlue.Location = new System.Drawing.Point(131, 333);
            this.barBlue.Maximum = 255;
            this.barBlue.Name = "barBlue";
            this.barBlue.Size = new System.Drawing.Size(526, 39);
            this.barBlue.TabIndex = 2;
            this.barBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.barBlue_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Redd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Blue";
            // 
            // lbRed
            // 
            this.lbRed.AutoSize = true;
            this.lbRed.Location = new System.Drawing.Point(701, 172);
            this.lbRed.Name = "lbRed";
            this.lbRed.Size = new System.Drawing.Size(22, 25);
            this.lbRed.TabIndex = 6;
            this.lbRed.Text = "0";
            // 
            // lbGreen
            // 
            this.lbGreen.AutoSize = true;
            this.lbGreen.Location = new System.Drawing.Point(701, 253);
            this.lbGreen.Name = "lbGreen";
            this.lbGreen.Size = new System.Drawing.Size(22, 25);
            this.lbGreen.TabIndex = 7;
            this.lbGreen.Text = "0";
            // 
            // lbBlue
            // 
            this.lbBlue.AutoSize = true;
            this.lbBlue.Location = new System.Drawing.Point(701, 347);
            this.lbBlue.Name = "lbBlue";
            this.lbBlue.Size = new System.Drawing.Size(22, 25);
            this.lbBlue.TabIndex = 8;
            this.lbBlue.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbBlue);
            this.Controls.Add(this.lbGreen);
            this.Controls.Add(this.lbRed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barBlue);
            this.Controls.Add(this.barGreen);
            this.Controls.Add(this.barRed);
            this.Name = "Form1";
            this.Text = "Màu nền Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HScrollBar barRed;
        private HScrollBar barGreen;
        private HScrollBar barBlue;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbRed;
        private Label lbGreen;
        private Label lbBlue;
    }
}