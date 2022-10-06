namespace BaiTapThem_Bai9
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
            this.grbChonSach = new System.Windows.Forms.GroupBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.cbbTenSach = new System.Windows.Forms.ComboBox();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.lbGia = new System.Windows.Forms.Label();
            this.lbTenSach = new System.Windows.Forms.Label();
            this.grbPTTT = new System.Windows.Forms.GroupBox();
            this.lbPhanTram = new System.Windows.Forms.Label();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.lbGiamGia = new System.Windows.Forms.Label();
            this.radThe = new System.Windows.Forms.RadioButton();
            this.radTienMat = new System.Windows.Forms.RadioButton();
            this.btnThem = new System.Windows.Forms.Button();
            this.grbSachDaMua = new System.Windows.Forms.GroupBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnTinhTong = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbChonSach.SuspendLayout();
            this.grbPTTT.SuspendLayout();
            this.grbSachDaMua.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbChonSach
            // 
            this.grbChonSach.Controls.Add(this.txtSoLuong);
            this.grbChonSach.Controls.Add(this.txtGia);
            this.grbChonSach.Controls.Add(this.cbbTenSach);
            this.grbChonSach.Controls.Add(this.lbSoLuong);
            this.grbChonSach.Controls.Add(this.lbGia);
            this.grbChonSach.Controls.Add(this.lbTenSach);
            this.grbChonSach.Location = new System.Drawing.Point(13, 18);
            this.grbChonSach.Name = "grbChonSach";
            this.grbChonSach.Size = new System.Drawing.Size(401, 204);
            this.grbChonSach.TabIndex = 0;
            this.grbChonSach.TabStop = false;
            this.grbChonSach.Text = "Chọn sách";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(159, 143);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(223, 31);
            this.txtSoLuong.TabIndex = 5;
            // 
            // txtGia
            // 
            this.txtGia.Enabled = false;
            this.txtGia.Location = new System.Drawing.Point(159, 92);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(223, 31);
            this.txtGia.TabIndex = 4;
            // 
            // cbbTenSach
            // 
            this.cbbTenSach.FormattingEnabled = true;
            this.cbbTenSach.Items.AddRange(new object[] {
            "Tin đại cương",
            "Tiếng Anh F2",
            "Giải tích F1",
            "Đại số tuyến tính"});
            this.cbbTenSach.Location = new System.Drawing.Point(159, 41);
            this.cbbTenSach.Name = "cbbTenSach";
            this.cbbTenSach.Size = new System.Drawing.Size(223, 33);
            this.cbbTenSach.TabIndex = 3;
            this.cbbTenSach.SelectedIndexChanged += new System.EventHandler(this.cbbTenSach_SelectedIndexChanged);
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Location = new System.Drawing.Point(14, 143);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(85, 25);
            this.lbSoLuong.TabIndex = 2;
            this.lbSoLuong.Text = "Số lượng";
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Location = new System.Drawing.Point(14, 92);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(42, 25);
            this.lbGia.TabIndex = 1;
            this.lbGia.Text = "Giá ";
            // 
            // lbTenSach
            // 
            this.lbTenSach.AutoSize = true;
            this.lbTenSach.Location = new System.Drawing.Point(14, 41);
            this.lbTenSach.Name = "lbTenSach";
            this.lbTenSach.Size = new System.Drawing.Size(78, 25);
            this.lbTenSach.TabIndex = 0;
            this.lbTenSach.Text = "Tên sách";
            // 
            // grbPTTT
            // 
            this.grbPTTT.Controls.Add(this.lbPhanTram);
            this.grbPTTT.Controls.Add(this.txtGiamGia);
            this.grbPTTT.Controls.Add(this.lbGiamGia);
            this.grbPTTT.Controls.Add(this.radThe);
            this.grbPTTT.Controls.Add(this.radTienMat);
            this.grbPTTT.Location = new System.Drawing.Point(459, 18);
            this.grbPTTT.Name = "grbPTTT";
            this.grbPTTT.Size = new System.Drawing.Size(401, 204);
            this.grbPTTT.TabIndex = 1;
            this.grbPTTT.TabStop = false;
            this.grbPTTT.Text = "Phương thức thanh toán";
            // 
            // lbPhanTram
            // 
            this.lbPhanTram.AutoSize = true;
            this.lbPhanTram.ForeColor = System.Drawing.Color.Red;
            this.lbPhanTram.Location = new System.Drawing.Point(302, 118);
            this.lbPhanTram.Name = "lbPhanTram";
            this.lbPhanTram.Size = new System.Drawing.Size(27, 25);
            this.lbPhanTram.TabIndex = 4;
            this.lbPhanTram.Text = "%";
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Enabled = false;
            this.txtGiamGia.Location = new System.Drawing.Point(130, 115);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(150, 31);
            this.txtGiamGia.TabIndex = 3;
            // 
            // lbGiamGia
            // 
            this.lbGiamGia.AutoSize = true;
            this.lbGiamGia.Location = new System.Drawing.Point(38, 118);
            this.lbGiamGia.Name = "lbGiamGia";
            this.lbGiamGia.Size = new System.Drawing.Size(82, 25);
            this.lbGiamGia.TabIndex = 2;
            this.lbGiamGia.Text = "Giảm giá";
            // 
            // radThe
            // 
            this.radThe.AutoSize = true;
            this.radThe.Location = new System.Drawing.Point(231, 37);
            this.radThe.Name = "radThe";
            this.radThe.Size = new System.Drawing.Size(106, 29);
            this.radThe.TabIndex = 1;
            this.radThe.TabStop = true;
            this.radThe.Text = "Thẻ ATM";
            this.radThe.UseVisualStyleBackColor = true;
            this.radThe.CheckedChanged += new System.EventHandler(this.radThe_CheckedChanged);
            // 
            // radTienMat
            // 
            this.radTienMat.AutoSize = true;
            this.radTienMat.Location = new System.Drawing.Point(38, 37);
            this.radTienMat.Name = "radTienMat";
            this.radTienMat.Size = new System.Drawing.Size(105, 29);
            this.radTienMat.TabIndex = 0;
            this.radTienMat.TabStop = true;
            this.radTienMat.Text = "Tiền mặt";
            this.radTienMat.UseVisualStyleBackColor = true;
            this.radTienMat.CheckedChanged += new System.EventHandler(this.radTienMat_CheckedChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(376, 244);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 34);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grbSachDaMua
            // 
            this.grbSachDaMua.Controls.Add(this.txtTongTien);
            this.grbSachDaMua.Controls.Add(this.btnTinhTong);
            this.grbSachDaMua.Controls.Add(this.btnXoa);
            this.grbSachDaMua.Controls.Add(this.listBox1);
            this.grbSachDaMua.Location = new System.Drawing.Point(172, 297);
            this.grbSachDaMua.Name = "grbSachDaMua";
            this.grbSachDaMua.Size = new System.Drawing.Size(520, 251);
            this.grbSachDaMua.TabIndex = 3;
            this.grbSachDaMua.TabStop = false;
            this.grbSachDaMua.Text = "Sách đã mua";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(343, 201);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(150, 31);
            this.txtTongTien.TabIndex = 5;
            this.txtTongTien.Text = "0";
            // 
            // btnTinhTong
            // 
            this.btnTinhTong.Location = new System.Drawing.Point(150, 199);
            this.btnTinhTong.Name = "btnTinhTong";
            this.btnTinhTong.Size = new System.Drawing.Size(144, 34);
            this.btnTinhTong.TabIndex = 2;
            this.btnTinhTong.Text = "Tính tổng tiền";
            this.btnTinhTong.UseVisualStyleBackColor = true;
            this.btnTinhTong.Click += new System.EventHandler(this.btnTinhTong_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(18, 199);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 34);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(18, 39);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(475, 129);
            this.listBox1.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(748, 514);
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
            this.ClientSize = new System.Drawing.Size(891, 560);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.grbSachDaMua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grbPTTT);
            this.Controls.Add(this.grbChonSach);
            this.Name = "Form1";
            this.Text = "Cửa hàng bán sách";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbChonSach.ResumeLayout(false);
            this.grbChonSach.PerformLayout();
            this.grbPTTT.ResumeLayout(false);
            this.grbPTTT.PerformLayout();
            this.grbSachDaMua.ResumeLayout(false);
            this.grbSachDaMua.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grbChonSach;
        private TextBox txtSoLuong;
        private TextBox txtGia;
        private ComboBox cbbTenSach;
        private Label lbSoLuong;
        private Label lbGia;
        private Label lbTenSach;
        private GroupBox grbPTTT;
        private Label lbPhanTram;
        private TextBox txtGiamGia;
        private Label lbGiamGia;
        private RadioButton radThe;
        private RadioButton radTienMat;
        private Button btnThem;
        private GroupBox grbSachDaMua;
        private TextBox txtTongTien;
        private Button btnTinhTong;
        private Button btnXoa;
        private ListBox listBox1;
        private Button btnThoat;
    }
}