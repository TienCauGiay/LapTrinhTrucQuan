namespace Tuan2_BTTuongTu_Bai1
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
            this.grbThongTinDiemSV = new System.Windows.Forms.GroupBox();
            this.btnThemVaoDanhSach = new System.Windows.Forms.Button();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.txtSoTinChi = new System.Windows.Forms.TextBox();
            this.comboBoxTenMonHoc = new System.Windows.Forms.ComboBox();
            this.lbDiem = new System.Windows.Forms.Label();
            this.lbSoTinChi = new System.Windows.Forms.Label();
            this.lbTenMonHoc = new System.Windows.Forms.Label();
            this.grbDanhSachCacMonHoc = new System.Windows.Forms.GroupBox();
            this.listDanhSachCacMonHoc = new System.Windows.Forms.ListBox();
            this.lbTongSoTinChi = new System.Windows.Forms.Label();
            this.lbTongSoDiem = new System.Windows.Forms.Label();
            this.lbDiemTrungBinh = new System.Windows.Forms.Label();
            this.txtTongSoTinChi = new System.Windows.Forms.TextBox();
            this.txtTongSoDiem = new System.Windows.Forms.TextBox();
            this.txtDiemTrungBinh = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbThongTinDiemSV.SuspendLayout();
            this.grbDanhSachCacMonHoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbThongTinDiemSV
            // 
            this.grbThongTinDiemSV.Controls.Add(this.btnThemVaoDanhSach);
            this.grbThongTinDiemSV.Controls.Add(this.txtDiem);
            this.grbThongTinDiemSV.Controls.Add(this.txtSoTinChi);
            this.grbThongTinDiemSV.Controls.Add(this.comboBoxTenMonHoc);
            this.grbThongTinDiemSV.Controls.Add(this.lbDiem);
            this.grbThongTinDiemSV.Controls.Add(this.lbSoTinChi);
            this.grbThongTinDiemSV.Controls.Add(this.lbTenMonHoc);
            this.grbThongTinDiemSV.Location = new System.Drawing.Point(12, 12);
            this.grbThongTinDiemSV.Name = "grbThongTinDiemSV";
            this.grbThongTinDiemSV.Size = new System.Drawing.Size(499, 495);
            this.grbThongTinDiemSV.TabIndex = 0;
            this.grbThongTinDiemSV.TabStop = false;
            this.grbThongTinDiemSV.Text = "Thông tin điểm sinh viên";
            // 
            // btnThemVaoDanhSach
            // 
            this.btnThemVaoDanhSach.Location = new System.Drawing.Point(137, 348);
            this.btnThemVaoDanhSach.Name = "btnThemVaoDanhSach";
            this.btnThemVaoDanhSach.Size = new System.Drawing.Size(240, 41);
            this.btnThemVaoDanhSach.TabIndex = 6;
            this.btnThemVaoDanhSach.Text = "          Thêm vào DS            &D";
            this.btnThemVaoDanhSach.UseVisualStyleBackColor = true;
            this.btnThemVaoDanhSach.Click += new System.EventHandler(this.btnThemVaoDanhSach_Click);
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(196, 238);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(166, 31);
            this.txtDiem.TabIndex = 5;
            this.txtDiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiem_KeyPress);
            // 
            // txtSoTinChi
            // 
            this.txtSoTinChi.Enabled = false;
            this.txtSoTinChi.Location = new System.Drawing.Point(196, 178);
            this.txtSoTinChi.Name = "txtSoTinChi";
            this.txtSoTinChi.Size = new System.Drawing.Size(257, 31);
            this.txtSoTinChi.TabIndex = 4;
            // 
            // comboBoxTenMonHoc
            // 
            this.comboBoxTenMonHoc.FormattingEnabled = true;
            this.comboBoxTenMonHoc.Items.AddRange(new object[] {
            "Tin học đại cương",
            "Giải tích F1",
            "Tiếng Anh A0",
            "Triết học Mác - Lênin",
            "Vật lý F1"});
            this.comboBoxTenMonHoc.Location = new System.Drawing.Point(51, 105);
            this.comboBoxTenMonHoc.Name = "comboBoxTenMonHoc";
            this.comboBoxTenMonHoc.Size = new System.Drawing.Size(402, 33);
            this.comboBoxTenMonHoc.TabIndex = 3;
            this.comboBoxTenMonHoc.SelectedIndexChanged += new System.EventHandler(this.comboBoxTenMonHoc_SelectedIndexChanged);
            // this.comboBoxTenMonHoc.SelectedValueChanged += new System.EventHandler(this.comboBoxTenMonHoc_SelectedValueChanged);
            // 
            // lbDiem
            // 
            this.lbDiem.AutoSize = true;
            this.lbDiem.Location = new System.Drawing.Point(51, 244);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(54, 25);
            this.lbDiem.TabIndex = 2;
            this.lbDiem.Text = "Điểm";
            // 
            // lbSoTinChi
            // 
            this.lbSoTinChi.AutoSize = true;
            this.lbSoTinChi.Location = new System.Drawing.Point(51, 178);
            this.lbSoTinChi.Name = "lbSoTinChi";
            this.lbSoTinChi.Size = new System.Drawing.Size(85, 25);
            this.lbSoTinChi.TabIndex = 1;
            this.lbSoTinChi.Text = "Số tín chỉ";
            // 
            // lbTenMonHoc
            // 
            this.lbTenMonHoc.AutoSize = true;
            this.lbTenMonHoc.Location = new System.Drawing.Point(51, 55);
            this.lbTenMonHoc.Name = "lbTenMonHoc";
            this.lbTenMonHoc.Size = new System.Drawing.Size(114, 25);
            this.lbTenMonHoc.TabIndex = 0;
            this.lbTenMonHoc.Text = "Tên môn học";
            // 
            // grbDanhSachCacMonHoc
            // 
            this.grbDanhSachCacMonHoc.Controls.Add(this.listDanhSachCacMonHoc);
            this.grbDanhSachCacMonHoc.Location = new System.Drawing.Point(545, 12);
            this.grbDanhSachCacMonHoc.Name = "grbDanhSachCacMonHoc";
            this.grbDanhSachCacMonHoc.Size = new System.Drawing.Size(740, 257);
            this.grbDanhSachCacMonHoc.TabIndex = 1;
            this.grbDanhSachCacMonHoc.TabStop = false;
            this.grbDanhSachCacMonHoc.Text = "Danh sách các môn học";
            // 
            // listDanhSachCacMonHoc
            // 
            this.listDanhSachCacMonHoc.FormattingEnabled = true;
            this.listDanhSachCacMonHoc.ItemHeight = 25;
            this.listDanhSachCacMonHoc.Location = new System.Drawing.Point(26, 30);
            this.listDanhSachCacMonHoc.Name = "listDanhSachCacMonHoc";
            this.listDanhSachCacMonHoc.Size = new System.Drawing.Size(692, 204);
            this.listDanhSachCacMonHoc.TabIndex = 0;
            // 
            // lbTongSoTinChi
            // 
            this.lbTongSoTinChi.AutoSize = true;
            this.lbTongSoTinChi.Location = new System.Drawing.Point(545, 317);
            this.lbTongSoTinChi.Name = "lbTongSoTinChi";
            this.lbTongSoTinChi.Size = new System.Drawing.Size(129, 25);
            this.lbTongSoTinChi.TabIndex = 2;
            this.lbTongSoTinChi.Text = "Tổng số tín chỉ";
            // 
            // lbTongSoDiem
            // 
            this.lbTongSoDiem.AutoSize = true;
            this.lbTongSoDiem.Location = new System.Drawing.Point(896, 320);
            this.lbTongSoDiem.Name = "lbTongSoDiem";
            this.lbTongSoDiem.Size = new System.Drawing.Size(122, 25);
            this.lbTongSoDiem.TabIndex = 3;
            this.lbTongSoDiem.Text = "Tổng số điểm";
            // 
            // lbDiemTrungBinh
            // 
            this.lbDiemTrungBinh.AutoSize = true;
            this.lbDiemTrungBinh.Location = new System.Drawing.Point(545, 389);
            this.lbDiemTrungBinh.Name = "lbDiemTrungBinh";
            this.lbDiemTrungBinh.Size = new System.Drawing.Size(142, 25);
            this.lbDiemTrungBinh.TabIndex = 4;
            this.lbDiemTrungBinh.Text = "Điểm trung bình";
            // 
            // txtTongSoTinChi
            // 
            this.txtTongSoTinChi.Location = new System.Drawing.Point(696, 314);
            this.txtTongSoTinChi.Name = "txtTongSoTinChi";
            this.txtTongSoTinChi.Size = new System.Drawing.Size(174, 31);
            this.txtTongSoTinChi.TabIndex = 5;
            // 
            // txtTongSoDiem
            // 
            this.txtTongSoDiem.Location = new System.Drawing.Point(1053, 314);
            this.txtTongSoDiem.Name = "txtTongSoDiem";
            this.txtTongSoDiem.Size = new System.Drawing.Size(210, 31);
            this.txtTongSoDiem.TabIndex = 6;
            // 
            // txtDiemTrungBinh
            // 
            this.txtDiemTrungBinh.Location = new System.Drawing.Point(739, 389);
            this.txtDiemTrungBinh.Name = "txtDiemTrungBinh";
            this.txtDiemTrungBinh.Size = new System.Drawing.Size(218, 31);
            this.txtDiemTrungBinh.TabIndex = 7;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(643, 451);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(144, 34);
            this.btnTinh.TabIndex = 8;
            this.btnTinh.Text = "        Tính          &T";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(977, 451);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(165, 34);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "         Thoát                           &H";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 519);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtDiemTrungBinh);
            this.Controls.Add(this.txtTongSoDiem);
            this.Controls.Add(this.txtTongSoTinChi);
            this.Controls.Add(this.lbDiemTrungBinh);
            this.Controls.Add(this.lbTongSoDiem);
            this.Controls.Add(this.lbTongSoTinChi);
            this.Controls.Add(this.grbDanhSachCacMonHoc);
            this.Controls.Add(this.grbThongTinDiemSV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbThongTinDiemSV.ResumeLayout(false);
            this.grbThongTinDiemSV.PerformLayout();
            this.grbDanhSachCacMonHoc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grbThongTinDiemSV;
        private TextBox txtDiem;
        private TextBox txtSoTinChi;
        private ComboBox comboBoxTenMonHoc;
        private Label lbDiem;
        private Label lbSoTinChi;
        private Label lbTenMonHoc;
        private Button btnThemVaoDanhSach;
        private GroupBox grbDanhSachCacMonHoc;
        private ListBox listDanhSachCacMonHoc;
        private Label lbTongSoTinChi;
        private Label lbTongSoDiem;
        private Label lbDiemTrungBinh;
        private TextBox txtTongSoTinChi;
        private TextBox txtTongSoDiem;
        private TextBox txtDiemTrungBinh;
        private Button btnTinh;
        private Button btnThoat;
    }
}