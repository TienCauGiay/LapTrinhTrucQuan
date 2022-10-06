namespace ThucHanhListView_BT2
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            ""}, -1);
            this.grbThongTinSinhVien = new System.Windows.Forms.GroupBox();
            this.comboTenMonHoc = new System.Windows.Forms.ComboBox();
            this.btnThemVaoDS = new System.Windows.Forms.Button();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.txtSoTinChi = new System.Windows.Forms.TextBox();
            this.lbDiem = new System.Windows.Forms.Label();
            this.lbSoTinChi = new System.Windows.Forms.Label();
            this.lbTenMonHoc = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoaKhoiDS = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTinh = new System.Windows.Forms.Button();
            this.txtDiemTrungBinh = new System.Windows.Forms.TextBox();
            this.txtTongSoDiem = new System.Windows.Forms.TextBox();
            this.txtTongSoTinChi = new System.Windows.Forms.TextBox();
            this.lbDiemTrungBinh = new System.Windows.Forms.Label();
            this.lbTongSoDiem = new System.Windows.Forms.Label();
            this.lbTongSoTinChi = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.grbThongTinSinhVien.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbThongTinSinhVien
            // 
            this.grbThongTinSinhVien.Controls.Add(this.comboTenMonHoc);
            this.grbThongTinSinhVien.Controls.Add(this.btnThemVaoDS);
            this.grbThongTinSinhVien.Controls.Add(this.txtDiem);
            this.grbThongTinSinhVien.Controls.Add(this.txtSoTinChi);
            this.grbThongTinSinhVien.Controls.Add(this.lbDiem);
            this.grbThongTinSinhVien.Controls.Add(this.lbSoTinChi);
            this.grbThongTinSinhVien.Controls.Add(this.lbTenMonHoc);
            this.grbThongTinSinhVien.Location = new System.Drawing.Point(12, 7);
            this.grbThongTinSinhVien.Name = "grbThongTinSinhVien";
            this.grbThongTinSinhVien.Size = new System.Drawing.Size(527, 678);
            this.grbThongTinSinhVien.TabIndex = 0;
            this.grbThongTinSinhVien.TabStop = false;
            this.grbThongTinSinhVien.Text = "Thông tin điểm sinh viên";
            // 
            // comboTenMonHoc
            // 
            this.comboTenMonHoc.FormattingEnabled = true;
            this.comboTenMonHoc.Items.AddRange(new object[] {
            "Thiết Kế Web",
            "Cơ Sở Dữ Liệu",
            "Lập Trình Trực Quan",
            "Cấu Trúc Dữ Liệu Giải Thuật",
            "Lập Trình Java",
            ""});
            this.comboTenMonHoc.Location = new System.Drawing.Point(42, 120);
            this.comboTenMonHoc.Name = "comboTenMonHoc";
            this.comboTenMonHoc.Size = new System.Drawing.Size(443, 33);
            this.comboTenMonHoc.TabIndex = 6;
            // 
            // btnThemVaoDS
            // 
            this.btnThemVaoDS.Location = new System.Drawing.Point(133, 408);
            this.btnThemVaoDS.Name = "btnThemVaoDS";
            this.btnThemVaoDS.Size = new System.Drawing.Size(229, 34);
            this.btnThemVaoDS.TabIndex = 5;
            this.btnThemVaoDS.Text = "Thêm vào DS";
            this.btnThemVaoDS.UseVisualStyleBackColor = true;
            this.btnThemVaoDS.Click += new System.EventHandler(this.btnThemVaoDS_Click);
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(163, 308);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(162, 31);
            this.txtDiem.TabIndex = 4;
            this.txtDiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiem_KeyPress);
            // 
            // txtSoTinChi
            // 
            this.txtSoTinChi.Location = new System.Drawing.Point(163, 232);
            this.txtSoTinChi.Name = "txtSoTinChi";
            this.txtSoTinChi.Size = new System.Drawing.Size(322, 31);
            this.txtSoTinChi.TabIndex = 3;
            this.txtSoTinChi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTinChi_KeyPress);
            // 
            // lbDiem
            // 
            this.lbDiem.AutoSize = true;
            this.lbDiem.Location = new System.Drawing.Point(34, 314);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(54, 25);
            this.lbDiem.TabIndex = 2;
            this.lbDiem.Text = "Điểm";
            // 
            // lbSoTinChi
            // 
            this.lbSoTinChi.AutoSize = true;
            this.lbSoTinChi.Location = new System.Drawing.Point(34, 232);
            this.lbSoTinChi.Name = "lbSoTinChi";
            this.lbSoTinChi.Size = new System.Drawing.Size(85, 25);
            this.lbSoTinChi.TabIndex = 1;
            this.lbSoTinChi.Text = "Số tín chỉ";
            // 
            // lbTenMonHoc
            // 
            this.lbTenMonHoc.AutoSize = true;
            this.lbTenMonHoc.Location = new System.Drawing.Point(34, 72);
            this.lbTenMonHoc.Name = "lbTenMonHoc";
            this.lbTenMonHoc.Size = new System.Drawing.Size(114, 25);
            this.lbTenMonHoc.TabIndex = 0;
            this.lbTenMonHoc.Text = "Tên môn học";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(562, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(699, 664);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách môn học";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnXoaKhoiDS);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnTinh);
            this.panel1.Controls.Add(this.txtDiemTrungBinh);
            this.panel1.Controls.Add(this.txtTongSoDiem);
            this.panel1.Controls.Add(this.txtTongSoTinChi);
            this.panel1.Controls.Add(this.lbDiemTrungBinh);
            this.panel1.Controls.Add(this.lbTongSoDiem);
            this.panel1.Controls.Add(this.lbTongSoTinChi);
            this.panel1.Location = new System.Drawing.Point(27, 422);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 236);
            this.panel1.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(524, 180);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 34);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoaKhoiDS
            // 
            this.btnXoaKhoiDS.Location = new System.Drawing.Point(364, 180);
            this.btnXoaKhoiDS.Name = "btnXoaKhoiDS";
            this.btnXoaKhoiDS.Size = new System.Drawing.Size(124, 34);
            this.btnXoaKhoiDS.TabIndex = 8;
            this.btnXoaKhoiDS.Text = "Xóa khỏi DS";
            this.btnXoaKhoiDS.UseVisualStyleBackColor = true;
            this.btnXoaKhoiDS.Click += new System.EventHandler(this.btnXoaKhoiDS_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(194, 180);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 34);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(23, 180);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(112, 34);
            this.btnTinh.TabIndex = 6;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // txtDiemTrungBinh
            // 
            this.txtDiemTrungBinh.Location = new System.Drawing.Point(209, 88);
            this.txtDiemTrungBinh.Name = "txtDiemTrungBinh";
            this.txtDiemTrungBinh.Size = new System.Drawing.Size(360, 31);
            this.txtDiemTrungBinh.TabIndex = 5;
            // 
            // txtTongSoDiem
            // 
            this.txtTongSoDiem.Location = new System.Drawing.Point(453, 17);
            this.txtTongSoDiem.Name = "txtTongSoDiem";
            this.txtTongSoDiem.Size = new System.Drawing.Size(183, 31);
            this.txtTongSoDiem.TabIndex = 4;
            // 
            // txtTongSoTinChi
            // 
            this.txtTongSoTinChi.Location = new System.Drawing.Point(174, 17);
            this.txtTongSoTinChi.Name = "txtTongSoTinChi";
            this.txtTongSoTinChi.Size = new System.Drawing.Size(141, 31);
            this.txtTongSoTinChi.TabIndex = 3;
            // 
            // lbDiemTrungBinh
            // 
            this.lbDiemTrungBinh.AutoSize = true;
            this.lbDiemTrungBinh.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDiemTrungBinh.Location = new System.Drawing.Point(23, 94);
            this.lbDiemTrungBinh.Name = "lbDiemTrungBinh";
            this.lbDiemTrungBinh.Size = new System.Drawing.Size(137, 20);
            this.lbDiemTrungBinh.TabIndex = 2;
            this.lbDiemTrungBinh.Text = "Điểm trung bình";
            // 
            // lbTongSoDiem
            // 
            this.lbTongSoDiem.AutoSize = true;
            this.lbTongSoDiem.Location = new System.Drawing.Point(328, 20);
            this.lbTongSoDiem.Name = "lbTongSoDiem";
            this.lbTongSoDiem.Size = new System.Drawing.Size(122, 25);
            this.lbTongSoDiem.TabIndex = 1;
            this.lbTongSoDiem.Text = "Tổng số điểm";
            // 
            // lbTongSoTinChi
            // 
            this.lbTongSoTinChi.AutoSize = true;
            this.lbTongSoTinChi.Location = new System.Drawing.Point(23, 17);
            this.lbTongSoTinChi.Name = "lbTongSoTinChi";
            this.lbTongSoTinChi.Size = new System.Drawing.Size(129, 25);
            this.lbTongSoTinChi.TabIndex = 0;
            this.lbTongSoTinChi.Text = "Tổng số tín chỉ";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(24, 58);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(656, 344);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên môn";
            this.columnHeader1.Width = 450;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số tín chỉ";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Điểm";
            this.columnHeader3.Width = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 697);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbThongTinSinhVien);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbThongTinSinhVien.ResumeLayout(false);
            this.grbThongTinSinhVien.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grbThongTinSinhVien;
        private Button btnThemVaoDS;
        private TextBox txtDiem;
        private TextBox txtSoTinChi;
        private Label lbDiem;
        private Label lbSoTinChi;
        private Label lbTenMonHoc;
        private ComboBox comboTenMonHoc;
        private GroupBox groupBox1;
        private Panel panel1;
        private Label lbDiemTrungBinh;
        private Label lbTongSoDiem;
        private Label lbTongSoTinChi;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button btnThoat;
        private Button btnXoaKhoiDS;
        private Button btnSua;
        private Button btnTinh;
        private TextBox txtDiemTrungBinh;
        private TextBox txtTongSoDiem;
        private TextBox txtTongSoTinChi;
    }
}