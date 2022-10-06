namespace BTVN_FormBanHang
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
            this.listBoxMatHang = new System.Windows.Forms.ListBox();
            this.lbNameKH = new System.Windows.Forms.Label();
            this.lbAddressKH = new System.Windows.Forms.Label();
            this.lbListProduct = new System.Windows.Forms.Label();
            this.lbProducted = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.listBoxHangDatMua = new System.Windows.Forms.ListBox();
            this.grbPTTT = new System.Windows.Forms.GroupBox();
            this.checkBoxThe = new System.Windows.Forms.CheckBox();
            this.checkBoxSec = new System.Windows.Forms.CheckBox();
            this.checkBoxTienMat = new System.Windows.Forms.CheckBox();
            this.grbHTLL = new System.Windows.Forms.GroupBox();
            this.checkBoxPhone = new System.Windows.Forms.CheckBox();
            this.checkBoxFax = new System.Windows.Forms.CheckBox();
            this.checkBoxEmail = new System.Windows.Forms.CheckBox();
            this.btnDongY = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbPTTT.SuspendLayout();
            this.grbHTLL.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxMatHang
            // 
            this.listBoxMatHang.FormattingEnabled = true;
            this.listBoxMatHang.ItemHeight = 25;
            this.listBoxMatHang.Location = new System.Drawing.Point(46, 209);
            this.listBoxMatHang.Name = "listBoxMatHang";
            this.listBoxMatHang.Size = new System.Drawing.Size(454, 229);
            this.listBoxMatHang.TabIndex = 0;
            this.listBoxMatHang.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxMatHang_MouseDoubleClick);
            // 
            // lbNameKH
            // 
            this.lbNameKH.AutoSize = true;
            this.lbNameKH.Location = new System.Drawing.Point(12, 25);
            this.lbNameKH.Name = "lbNameKH";
            this.lbNameKH.Size = new System.Drawing.Size(162, 25);
            this.lbNameKH.TabIndex = 1;
            this.lbNameKH.Text = "Họ tên khách hàng";
            // 
            // lbAddressKH
            // 
            this.lbAddressKH.AutoSize = true;
            this.lbAddressKH.Location = new System.Drawing.Point(557, 25);
            this.lbAddressKH.Name = "lbAddressKH";
            this.lbAddressKH.Size = new System.Drawing.Size(71, 25);
            this.lbAddressKH.TabIndex = 2;
            this.lbAddressKH.Text = "Địa chủ";
            // 
            // lbListProduct
            // 
            this.lbListProduct.AutoSize = true;
            this.lbListProduct.Location = new System.Drawing.Point(46, 153);
            this.lbListProduct.Name = "lbListProduct";
            this.lbListProduct.Size = new System.Drawing.Size(205, 25);
            this.lbListProduct.TabIndex = 3;
            this.lbListProduct.Text = "Danh sách các mặt hàng";
            // 
            // lbProducted
            // 
            this.lbProducted.AutoSize = true;
            this.lbProducted.Location = new System.Drawing.Point(647, 153);
            this.lbProducted.Name = "lbProducted";
            this.lbProducted.Size = new System.Drawing.Size(126, 25);
            this.lbProducted.TabIndex = 4;
            this.lbProducted.Text = "Hàng đặt mua";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(202, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(326, 31);
            this.txtName.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(647, 25);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(283, 85);
            this.txtAddress.TabIndex = 6;
            // 
            // listBoxHangDatMua
            // 
            this.listBoxHangDatMua.FormattingEnabled = true;
            this.listBoxHangDatMua.ItemHeight = 25;
            this.listBoxHangDatMua.Location = new System.Drawing.Point(557, 209);
            this.listBoxHangDatMua.Name = "listBoxHangDatMua";
            this.listBoxHangDatMua.Size = new System.Drawing.Size(454, 229);
            this.listBoxHangDatMua.TabIndex = 7;
            this.listBoxHangDatMua.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxHangDatMua_MouseDoubleClick);
            // 
            // grbPTTT
            // 
            this.grbPTTT.Controls.Add(this.checkBoxThe);
            this.grbPTTT.Controls.Add(this.checkBoxSec);
            this.grbPTTT.Controls.Add(this.checkBoxTienMat);
            this.grbPTTT.Location = new System.Drawing.Point(111, 489);
            this.grbPTTT.Name = "grbPTTT";
            this.grbPTTT.Size = new System.Drawing.Size(300, 150);
            this.grbPTTT.TabIndex = 8;
            this.grbPTTT.TabStop = false;
            this.grbPTTT.Text = "Phương thức thanh toán";
            // 
            // checkBoxThe
            // 
            this.checkBoxThe.AutoSize = true;
            this.checkBoxThe.Location = new System.Drawing.Point(20, 105);
            this.checkBoxThe.Name = "checkBoxThe";
            this.checkBoxThe.Size = new System.Drawing.Size(138, 29);
            this.checkBoxThe.TabIndex = 2;
            this.checkBoxThe.Text = "Thẻ tín dụng";
            this.checkBoxThe.UseVisualStyleBackColor = true;
            // 
            // checkBoxSec
            // 
            this.checkBoxSec.AutoSize = true;
            this.checkBoxSec.Location = new System.Drawing.Point(20, 70);
            this.checkBoxSec.Name = "checkBoxSec";
            this.checkBoxSec.Size = new System.Drawing.Size(65, 29);
            this.checkBoxSec.TabIndex = 1;
            this.checkBoxSec.Text = "Sec";
            this.checkBoxSec.UseVisualStyleBackColor = true;
            // 
            // checkBoxTienMat
            // 
            this.checkBoxTienMat.AutoSize = true;
            this.checkBoxTienMat.Location = new System.Drawing.Point(20, 35);
            this.checkBoxTienMat.Name = "checkBoxTienMat";
            this.checkBoxTienMat.Size = new System.Drawing.Size(106, 29);
            this.checkBoxTienMat.TabIndex = 0;
            this.checkBoxTienMat.Text = "Tiền mặt";
            this.checkBoxTienMat.UseVisualStyleBackColor = true;
            // 
            // grbHTLL
            // 
            this.grbHTLL.Controls.Add(this.checkBoxPhone);
            this.grbHTLL.Controls.Add(this.checkBoxFax);
            this.grbHTLL.Controls.Add(this.checkBoxEmail);
            this.grbHTLL.Location = new System.Drawing.Point(598, 489);
            this.grbHTLL.Name = "grbHTLL";
            this.grbHTLL.Size = new System.Drawing.Size(300, 150);
            this.grbHTLL.TabIndex = 9;
            this.grbHTLL.TabStop = false;
            this.grbHTLL.Text = "Hình thức liên lạc";
            // 
            // checkBoxPhone
            // 
            this.checkBoxPhone.AutoSize = true;
            this.checkBoxPhone.Location = new System.Drawing.Point(6, 35);
            this.checkBoxPhone.Name = "checkBoxPhone";
            this.checkBoxPhone.Size = new System.Drawing.Size(119, 29);
            this.checkBoxPhone.TabIndex = 5;
            this.checkBoxPhone.Text = "Điện thoại";
            this.checkBoxPhone.UseVisualStyleBackColor = true;
            // 
            // checkBoxFax
            // 
            this.checkBoxFax.AutoSize = true;
            this.checkBoxFax.Location = new System.Drawing.Point(6, 70);
            this.checkBoxFax.Name = "checkBoxFax";
            this.checkBoxFax.Size = new System.Drawing.Size(63, 29);
            this.checkBoxFax.TabIndex = 4;
            this.checkBoxFax.Text = "Fax";
            this.checkBoxFax.UseVisualStyleBackColor = true;
            // 
            // checkBoxEmail
            // 
            this.checkBoxEmail.AutoSize = true;
            this.checkBoxEmail.Location = new System.Drawing.Point(6, 105);
            this.checkBoxEmail.Name = "checkBoxEmail";
            this.checkBoxEmail.Size = new System.Drawing.Size(80, 29);
            this.checkBoxEmail.TabIndex = 3;
            this.checkBoxEmail.Text = "Email";
            this.checkBoxEmail.UseVisualStyleBackColor = true;
            // 
            // btnDongY
            // 
            this.btnDongY.Location = new System.Drawing.Point(345, 654);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(112, 34);
            this.btnDongY.TabIndex = 10;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(538, 654);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 34);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 700);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.grbHTLL);
            this.Controls.Add(this.grbPTTT);
            this.Controls.Add(this.listBoxHangDatMua);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbProducted);
            this.Controls.Add(this.lbListProduct);
            this.Controls.Add(this.lbAddressKH);
            this.Controls.Add(this.lbNameKH);
            this.Controls.Add(this.listBoxMatHang);
            this.Name = "Form1";
            this.Text = "Bán sách qua mạng";
            this.grbPTTT.ResumeLayout(false);
            this.grbPTTT.PerformLayout();
            this.grbHTLL.ResumeLayout(false);
            this.grbHTLL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxMatHang;
        private Label lbNameKH;
        private Label lbAddressKH;
        private Label lbListProduct;
        private Label lbProducted;
        private TextBox txtName;
        private TextBox txtAddress;
        private ListBox listBoxHangDatMua;
        private GroupBox grbPTTT;
        private GroupBox grbHTLL;
        private CheckBox checkBoxThe;
        private CheckBox checkBoxSec;
        private CheckBox checkBoxTienMat;
        private CheckBox checkBoxPhone;
        private CheckBox checkBoxFax;
        private CheckBox checkBoxEmail;
        private Button btnDongY;
        private Button btnThoat;
    }
}