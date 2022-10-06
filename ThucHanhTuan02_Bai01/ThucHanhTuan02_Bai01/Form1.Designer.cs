namespace ThucHanhTuan02_Bai01
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
            this.country = new System.Windows.Forms.GroupBox();
            this.radTheUSA = new System.Windows.Forms.RadioButton();
            this.radBrazil = new System.Windows.Forms.RadioButton();
            this.radArgentina = new System.Windows.Forms.RadioButton();
            this.radItalia = new System.Windows.Forms.RadioButton();
            this.radTheUK = new System.Windows.Forms.RadioButton();
            this.radTurkey = new System.Windows.Forms.RadioButton();
            this.radSpain = new System.Windows.Forms.RadioButton();
            this.radHungary = new System.Windows.Forms.RadioButton();
            this.radJapan = new System.Windows.Forms.RadioButton();
            this.radFrance = new System.Windows.Forms.RadioButton();
            this.capital = new System.Windows.Forms.GroupBox();
            this.radcParis = new System.Windows.Forms.RadioButton();
            this.radcBudapest = new System.Windows.Forms.RadioButton();
            this.radcAnkara = new System.Windows.Forms.RadioButton();
            this.radcLondon = new System.Windows.Forms.RadioButton();
            this.radcMadrid = new System.Windows.Forms.RadioButton();
            this.radcWashington = new System.Windows.Forms.RadioButton();
            this.radcRome = new System.Windows.Forms.RadioButton();
            this.radcTokyo = new System.Windows.Forms.RadioButton();
            this.radcBrazil = new System.Windows.Forms.RadioButton();
            this.radcBuenosAires = new System.Windows.Forms.RadioButton();
            this.lbYeuCau = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.country.SuspendLayout();
            this.capital.SuspendLayout();
            this.SuspendLayout();
            // 
            // country
            // 
            this.country.Controls.Add(this.radTheUSA);
            this.country.Controls.Add(this.radBrazil);
            this.country.Controls.Add(this.radArgentina);
            this.country.Controls.Add(this.radItalia);
            this.country.Controls.Add(this.radTheUK);
            this.country.Controls.Add(this.radTurkey);
            this.country.Controls.Add(this.radSpain);
            this.country.Controls.Add(this.radHungary);
            this.country.Controls.Add(this.radJapan);
            this.country.Controls.Add(this.radFrance);
            this.country.Location = new System.Drawing.Point(66, 46);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(300, 552);
            this.country.TabIndex = 0;
            this.country.TabStop = false;
            this.country.Text = "Country";
            // 
            // radTheUSA
            // 
            this.radTheUSA.AutoSize = true;
            this.radTheUSA.Location = new System.Drawing.Point(44, 504);
            this.radTheUSA.Name = "radTheUSA";
            this.radTheUSA.Size = new System.Drawing.Size(104, 29);
            this.radTheUSA.TabIndex = 9;
            this.radTheUSA.TabStop = true;
            this.radTheUSA.Text = "The USA";
            this.radTheUSA.UseVisualStyleBackColor = true;
            this.radTheUSA.CheckedChanged += new System.EventHandler(this.radTheUSA_CheckedChanged);
            // 
            // radBrazil
            // 
            this.radBrazil.AutoSize = true;
            this.radBrazil.Location = new System.Drawing.Point(44, 459);
            this.radBrazil.Name = "radBrazil";
            this.radBrazil.Size = new System.Drawing.Size(78, 29);
            this.radBrazil.TabIndex = 8;
            this.radBrazil.TabStop = true;
            this.radBrazil.Text = "Brazil";
            this.radBrazil.UseVisualStyleBackColor = true;
            this.radBrazil.CheckedChanged += new System.EventHandler(this.radBrazil_CheckedChanged);
            // 
            // radArgentina
            // 
            this.radArgentina.AutoSize = true;
            this.radArgentina.Location = new System.Drawing.Point(44, 407);
            this.radArgentina.Name = "radArgentina";
            this.radArgentina.Size = new System.Drawing.Size(114, 29);
            this.radArgentina.TabIndex = 7;
            this.radArgentina.TabStop = true;
            this.radArgentina.Text = "Argentina";
            this.radArgentina.UseVisualStyleBackColor = true;
            this.radArgentina.CheckedChanged += new System.EventHandler(this.radArgentina_CheckedChanged);
            // 
            // radItalia
            // 
            this.radItalia.AutoSize = true;
            this.radItalia.Location = new System.Drawing.Point(44, 354);
            this.radItalia.Name = "radItalia";
            this.radItalia.Size = new System.Drawing.Size(74, 29);
            this.radItalia.TabIndex = 6;
            this.radItalia.TabStop = true;
            this.radItalia.Text = "Italia";
            this.radItalia.UseVisualStyleBackColor = true;
            this.radItalia.CheckedChanged += new System.EventHandler(this.radItalia_CheckedChanged);
            // 
            // radTheUK
            // 
            this.radTheUK.AutoSize = true;
            this.radTheUK.Location = new System.Drawing.Point(44, 302);
            this.radTheUK.Name = "radTheUK";
            this.radTheUK.Size = new System.Drawing.Size(92, 29);
            this.radTheUK.TabIndex = 5;
            this.radTheUK.TabStop = true;
            this.radTheUK.Text = "The UK";
            this.radTheUK.UseVisualStyleBackColor = true;
            this.radTheUK.CheckedChanged += new System.EventHandler(this.radTheUK_CheckedChanged);
            // 
            // radTurkey
            // 
            this.radTurkey.AutoSize = true;
            this.radTurkey.Location = new System.Drawing.Point(44, 249);
            this.radTurkey.Name = "radTurkey";
            this.radTurkey.Size = new System.Drawing.Size(89, 29);
            this.radTurkey.TabIndex = 4;
            this.radTurkey.TabStop = true;
            this.radTurkey.Text = "Turkey";
            this.radTurkey.UseVisualStyleBackColor = true;
            this.radTurkey.CheckedChanged += new System.EventHandler(this.radTurkey_CheckedChanged);
            // 
            // radSpain
            // 
            this.radSpain.AutoSize = true;
            this.radSpain.Location = new System.Drawing.Point(44, 194);
            this.radSpain.Name = "radSpain";
            this.radSpain.Size = new System.Drawing.Size(81, 29);
            this.radSpain.TabIndex = 3;
            this.radSpain.TabStop = true;
            this.radSpain.Text = "Spain";
            this.radSpain.UseVisualStyleBackColor = true;
            this.radSpain.CheckedChanged += new System.EventHandler(this.radSpain_CheckedChanged);
            // 
            // radHungary
            // 
            this.radHungary.AutoSize = true;
            this.radHungary.Location = new System.Drawing.Point(44, 143);
            this.radHungary.Name = "radHungary";
            this.radHungary.Size = new System.Drawing.Size(105, 29);
            this.radHungary.TabIndex = 2;
            this.radHungary.TabStop = true;
            this.radHungary.Text = "Hungary";
            this.radHungary.UseVisualStyleBackColor = true;
            this.radHungary.CheckedChanged += new System.EventHandler(this.radHungary_CheckedChanged);
            // 
            // radJapan
            // 
            this.radJapan.AutoSize = true;
            this.radJapan.Location = new System.Drawing.Point(44, 93);
            this.radJapan.Name = "radJapan";
            this.radJapan.Size = new System.Drawing.Size(82, 29);
            this.radJapan.TabIndex = 1;
            this.radJapan.TabStop = true;
            this.radJapan.Text = "Japan";
            this.radJapan.UseVisualStyleBackColor = true;
            this.radJapan.CheckedChanged += new System.EventHandler(this.radJapan_CheckedChanged);
            // 
            // radFrance
            // 
            this.radFrance.AutoSize = true;
            this.radFrance.Location = new System.Drawing.Point(44, 47);
            this.radFrance.Name = "radFrance";
            this.radFrance.Size = new System.Drawing.Size(88, 29);
            this.radFrance.TabIndex = 0;
            this.radFrance.TabStop = true;
            this.radFrance.Text = "France";
            this.radFrance.UseVisualStyleBackColor = true;
            this.radFrance.CheckedChanged += new System.EventHandler(this.radFrance_CheckedChanged);
            // 
            // capital
            // 
            this.capital.Controls.Add(this.radcParis);
            this.capital.Controls.Add(this.radcBudapest);
            this.capital.Controls.Add(this.radcAnkara);
            this.capital.Controls.Add(this.radcLondon);
            this.capital.Controls.Add(this.radcMadrid);
            this.capital.Controls.Add(this.radcWashington);
            this.capital.Controls.Add(this.radcRome);
            this.capital.Controls.Add(this.radcTokyo);
            this.capital.Controls.Add(this.radcBrazil);
            this.capital.Controls.Add(this.radcBuenosAires);
            this.capital.Location = new System.Drawing.Point(483, 56);
            this.capital.Name = "capital";
            this.capital.Size = new System.Drawing.Size(300, 552);
            this.capital.TabIndex = 1;
            this.capital.TabStop = false;
            this.capital.Text = "Capital";
            // 
            // radcParis
            // 
            this.radcParis.AutoSize = true;
            this.radcParis.Location = new System.Drawing.Point(44, 504);
            this.radcParis.Name = "radcParis";
            this.radcParis.Size = new System.Drawing.Size(73, 29);
            this.radcParis.TabIndex = 9;
            this.radcParis.TabStop = true;
            this.radcParis.Text = "Paris";
            this.radcParis.UseVisualStyleBackColor = true;
            this.radcParis.CheckedChanged += new System.EventHandler(this.radcParis_CheckedChanged);
            // 
            // radcBudapest
            // 
            this.radcBudapest.AutoSize = true;
            this.radcBudapest.Location = new System.Drawing.Point(44, 459);
            this.radcBudapest.Name = "radcBudapest";
            this.radcBudapest.Size = new System.Drawing.Size(111, 29);
            this.radcBudapest.TabIndex = 8;
            this.radcBudapest.TabStop = true;
            this.radcBudapest.Text = "Budapest";
            this.radcBudapest.UseVisualStyleBackColor = true;
            this.radcBudapest.CheckedChanged += new System.EventHandler(this.radcBudapest_CheckedChanged);
            // 
            // radcAnkara
            // 
            this.radcAnkara.AutoSize = true;
            this.radcAnkara.Location = new System.Drawing.Point(44, 407);
            this.radcAnkara.Name = "radcAnkara";
            this.radcAnkara.Size = new System.Drawing.Size(92, 29);
            this.radcAnkara.TabIndex = 7;
            this.radcAnkara.TabStop = true;
            this.radcAnkara.Text = "Ankara";
            this.radcAnkara.UseVisualStyleBackColor = true;
            this.radcAnkara.CheckedChanged += new System.EventHandler(this.radcAnkara_CheckedChanged);
            // 
            // radcLondon
            // 
            this.radcLondon.AutoSize = true;
            this.radcLondon.Location = new System.Drawing.Point(44, 354);
            this.radcLondon.Name = "radcLondon";
            this.radcLondon.Size = new System.Drawing.Size(98, 29);
            this.radcLondon.TabIndex = 6;
            this.radcLondon.TabStop = true;
            this.radcLondon.Text = "London";
            this.radcLondon.UseVisualStyleBackColor = true;
            this.radcLondon.CheckedChanged += new System.EventHandler(this.radcLondon_CheckedChanged);
            // 
            // radcMadrid
            // 
            this.radcMadrid.AutoSize = true;
            this.radcMadrid.Location = new System.Drawing.Point(44, 302);
            this.radcMadrid.Name = "radcMadrid";
            this.radcMadrid.Size = new System.Drawing.Size(94, 29);
            this.radcMadrid.TabIndex = 5;
            this.radcMadrid.TabStop = true;
            this.radcMadrid.Text = "Madrid";
            this.radcMadrid.UseVisualStyleBackColor = true;
            this.radcMadrid.CheckedChanged += new System.EventHandler(this.radcMadrid_CheckedChanged);
            // 
            // radcWashington
            // 
            this.radcWashington.AutoSize = true;
            this.radcWashington.Location = new System.Drawing.Point(44, 249);
            this.radcWashington.Name = "radcWashington";
            this.radcWashington.Size = new System.Drawing.Size(132, 29);
            this.radcWashington.TabIndex = 4;
            this.radcWashington.TabStop = true;
            this.radcWashington.Text = "Washington";
            this.radcWashington.UseVisualStyleBackColor = true;
            this.radcWashington.CheckedChanged += new System.EventHandler(this.radcWashington_CheckedChanged);
            // 
            // radcRome
            // 
            this.radcRome.AutoSize = true;
            this.radcRome.Location = new System.Drawing.Point(44, 194);
            this.radcRome.Name = "radcRome";
            this.radcRome.Size = new System.Drawing.Size(83, 29);
            this.radcRome.TabIndex = 3;
            this.radcRome.TabStop = true;
            this.radcRome.Text = "Rome";
            this.radcRome.UseVisualStyleBackColor = true;
            this.radcRome.CheckedChanged += new System.EventHandler(this.radcRome_CheckedChanged);
            // 
            // radcTokyo
            // 
            this.radcTokyo.AutoSize = true;
            this.radcTokyo.Location = new System.Drawing.Point(44, 143);
            this.radcTokyo.Name = "radcTokyo";
            this.radcTokyo.Size = new System.Drawing.Size(84, 29);
            this.radcTokyo.TabIndex = 2;
            this.radcTokyo.TabStop = true;
            this.radcTokyo.Text = "Tokyo";
            this.radcTokyo.UseVisualStyleBackColor = true;
            this.radcTokyo.CheckedChanged += new System.EventHandler(this.radcTokyo_CheckedChanged);
            // 
            // radcBrazil
            // 
            this.radcBrazil.AutoSize = true;
            this.radcBrazil.Location = new System.Drawing.Point(44, 93);
            this.radcBrazil.Name = "radcBrazil";
            this.radcBrazil.Size = new System.Drawing.Size(78, 29);
            this.radcBrazil.TabIndex = 1;
            this.radcBrazil.TabStop = true;
            this.radcBrazil.Text = "Brazil";
            this.radcBrazil.UseVisualStyleBackColor = true;
            this.radcBrazil.CheckedChanged += new System.EventHandler(this.radcBrazil_CheckedChanged);
            // 
            // radcBuenosAires
            // 
            this.radcBuenosAires.AutoSize = true;
            this.radcBuenosAires.Location = new System.Drawing.Point(44, 47);
            this.radcBuenosAires.Name = "radcBuenosAires";
            this.radcBuenosAires.Size = new System.Drawing.Size(139, 29);
            this.radcBuenosAires.TabIndex = 0;
            this.radcBuenosAires.TabStop = true;
            this.radcBuenosAires.Text = "Buenos Aires";
            this.radcBuenosAires.UseVisualStyleBackColor = true;
            this.radcBuenosAires.CheckedChanged += new System.EventHandler(this.radcBuenosAires_CheckedChanged);
            // 
            // lbYeuCau
            // 
            this.lbYeuCau.AutoSize = true;
            this.lbYeuCau.Location = new System.Drawing.Point(65, 644);
            this.lbYeuCau.Name = "lbYeuCau";
            this.lbYeuCau.Size = new System.Drawing.Size(0, 25);
            this.lbYeuCau.TabIndex = 2;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(768, 639);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 34);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Exit";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(910, 685);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lbYeuCau);
            this.Controls.Add(this.capital);
            this.Controls.Add(this.country);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Capital of Country";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.country.ResumeLayout(false);
            this.country.PerformLayout();
            this.capital.ResumeLayout(false);
            this.capital.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox country;
        private RadioButton radFrance;
        private RadioButton radTheUSA;
        private RadioButton radBrazil;
        private RadioButton radArgentina;
        private RadioButton radItalia;
        private RadioButton radTheUK;
        private RadioButton radTurkey;
        private RadioButton radSpain;
        private RadioButton radHungary;
        private RadioButton radJapan;
        private GroupBox capital;
        private RadioButton radcParis;
        private RadioButton radcBudapest;
        private RadioButton radcAnkara;
        private RadioButton radcLondon;
        private RadioButton radcMadrid;
        private RadioButton radcWashington;
        private RadioButton radcRome;
        private RadioButton radcTokyo;
        private RadioButton radcBrazil;
        private RadioButton radcBuenosAires;
        private Label lbYeuCau;
        private Button btnThoat;
    }
}