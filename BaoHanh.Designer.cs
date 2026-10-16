namespace Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử
{
    partial class BaoHanh
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaoHanh));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.tblHeader = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHeaderContent = new System.Windows.Forms.Panel();
            this.picBaoHanh = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblMaPhieu = new System.Windows.Forms.Label();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.lblMaSanPham = new System.Windows.Forms.Label();
            this.txtMaSanPham = new System.Windows.Forms.TextBox();
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.lblNgayMua = new System.Windows.Forms.Label();
            this.dtpNgayMua = new System.Windows.Forms.DateTimePicker();
            this.lblThoiHan = new System.Windows.Forms.Label();
            this.numThoiHan = new System.Windows.Forms.NumericUpDown();
            this.lblNgayHetHan = new System.Windows.Forms.Label();
            this.dtpNgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnThem = new Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử.RoundedButton();
            this.btnSua = new Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử.RoundedButton();
            this.btnXoa = new Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử.RoundedButton();
            this.btnLamMoi = new Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử.RoundedButton();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.lblTimMaPhieu = new System.Windows.Forms.Label();
            this.txtTimMaPhieu = new System.Windows.Forms.TextBox();
            this.lblTimMaSanPham = new System.Windows.Forms.Label();
            this.txtTimMaSanPham = new System.Windows.Forms.TextBox();
            this.lblTimKhachHang = new System.Windows.Forms.Label();
            this.txtTimKhachHang = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử.RoundedButton();
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.dgvBaoHanh = new System.Windows.Forms.DataGridView();
            this.colMaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThoiHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayHetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader.SuspendLayout();
            this.tblHeader.SuspendLayout();
            this.pnlHeaderContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBaoHanh)).BeginInit();
            this.tblMain.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThoiHan)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.grpTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoHanh)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(107)))));
            this.pnlHeader.Controls.Add(this.tblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1200, 105);
            this.pnlHeader.TabIndex = 1;
            // 
            // tblHeader
            // 
            this.tblHeader.ColumnCount = 3;
            this.tblHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1150F));
            this.tblHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblHeader.Controls.Add(this.pnlHeaderContent, 1, 0);
            this.tblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblHeader.Location = new System.Drawing.Point(0, 0);
            this.tblHeader.Name = "tblHeader";
            this.tblHeader.RowCount = 1;
            this.tblHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblHeader.Size = new System.Drawing.Size(1200, 105);
            this.tblHeader.TabIndex = 0;
            // 
            // pnlHeaderContent
            // 
            this.pnlHeaderContent.Controls.Add(this.picBaoHanh);
            this.pnlHeaderContent.Controls.Add(this.lblTitle);
            this.pnlHeaderContent.Controls.Add(this.lblSubTitle);
            this.pnlHeaderContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeaderContent.Location = new System.Drawing.Point(28, 3);
            this.pnlHeaderContent.Name = "pnlHeaderContent";
            this.pnlHeaderContent.Size = new System.Drawing.Size(1144, 99);
            this.pnlHeaderContent.TabIndex = 0;
            // 
            // picBaoHanh
            // 
            this.picBaoHanh.Image = global::Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử.Properties.Resources.warranty;
            this.picBaoHanh.Location = new System.Drawing.Point(10, 22);
            this.picBaoHanh.Name = "picBaoHanh";
            this.picBaoHanh.Size = new System.Drawing.Size(60, 60);
            this.picBaoHanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBaoHanh.TabIndex = 0;
            this.picBaoHanh.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(85, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(373, 37);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "QUẢN LÝ PHIẾU BẢO HÀNH";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.lblSubTitle.Location = new System.Drawing.Point(88, 65);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(208, 15);
            this.lblSubTitle.TabIndex = 2;
            this.lblSubTitle.Text = "Quản lý thông tin bảo hành sản phẩm";
            // 
            // tblMain
            // 
            this.tblMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.tblMain.ColumnCount = 3;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1150F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Controls.Add(this.pnlContent, 1, 0);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 105);
            this.tblMain.Name = "tblMain";
            this.tblMain.Size = new System.Drawing.Size(1200, 695);
            this.tblMain.TabIndex = 0;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlContent.Controls.Add(this.grpThongTin);
            this.pnlContent.Controls.Add(this.pnlButtons);
            this.pnlContent.Controls.Add(this.grpTimKiem);
            this.pnlContent.Controls.Add(this.lblDanhSach);
            this.pnlContent.Controls.Add(this.dgvBaoHanh);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(25, 15);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1150, 680);
            this.pnlContent.TabIndex = 0;
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.lblMaPhieu);
            this.grpThongTin.Controls.Add(this.txtMaPhieu);
            this.grpThongTin.Controls.Add(this.lblMaSanPham);
            this.grpThongTin.Controls.Add(this.txtMaSanPham);
            this.grpThongTin.Controls.Add(this.lblTenKhachHang);
            this.grpThongTin.Controls.Add(this.txtTenKhachHang);
            this.grpThongTin.Controls.Add(this.lblSoDienThoai);
            this.grpThongTin.Controls.Add(this.txtSoDienThoai);
            this.grpThongTin.Controls.Add(this.lblNgayMua);
            this.grpThongTin.Controls.Add(this.dtpNgayMua);
            this.grpThongTin.Controls.Add(this.lblThoiHan);
            this.grpThongTin.Controls.Add(this.numThoiHan);
            this.grpThongTin.Controls.Add(this.lblNgayHetHan);
            this.grpThongTin.Controls.Add(this.dtpNgayHetHan);
            this.grpThongTin.Controls.Add(this.lblTrangThai);
            this.grpThongTin.Controls.Add(this.cboTrangThai);
            this.grpThongTin.Controls.Add(this.lblGhiChu);
            this.grpThongTin.Controls.Add(this.txtGhiChu);
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(107)))));
            this.grpThongTin.Location = new System.Drawing.Point(10, 5);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(1130, 225);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "THÔNG TIN PHIẾU BẢO HÀNH";
            // 
            // lblMaPhieu
            // 
            this.lblMaPhieu.AutoSize = true;
            this.lblMaPhieu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaPhieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblMaPhieu.Location = new System.Drawing.Point(20, 38);
            this.lblMaPhieu.Name = "lblMaPhieu";
            this.lblMaPhieu.Size = new System.Drawing.Size(60, 15);
            this.lblMaPhieu.TabIndex = 0;
            this.lblMaPhieu.Text = "Mã phiếu:";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaPhieu.Location = new System.Drawing.Point(155, 34);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(390, 25);
            this.txtMaPhieu.TabIndex = 1;
            // 
            // lblMaSanPham
            // 
            this.lblMaSanPham.AutoSize = true;
            this.lblMaSanPham.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblMaSanPham.Location = new System.Drawing.Point(585, 38);
            this.lblMaSanPham.Name = "lblMaSanPham";
            this.lblMaSanPham.Size = new System.Drawing.Size(82, 15);
            this.lblMaSanPham.TabIndex = 2;
            this.lblMaSanPham.Text = "Mã sản phẩm:";
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaSanPham.Location = new System.Drawing.Point(700, 34);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.Size = new System.Drawing.Size(390, 25);
            this.txtMaSanPham.TabIndex = 3;
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTenKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblTenKhachHang.Location = new System.Drawing.Point(20, 77);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(94, 15);
            this.lblTenKhachHang.TabIndex = 4;
            this.lblTenKhachHang.Text = "Tên khách hàng:";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenKhachHang.Location = new System.Drawing.Point(155, 73);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(390, 25);
            this.txtTenKhachHang.TabIndex = 5;
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSoDienThoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblSoDienThoai.Location = new System.Drawing.Point(585, 77);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(79, 15);
            this.lblSoDienThoai.TabIndex = 6;
            this.lblSoDienThoai.Text = "Số điện thoại:";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSoDienThoai.Location = new System.Drawing.Point(700, 73);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(390, 25);
            this.txtSoDienThoai.TabIndex = 7;
            // 
            // lblNgayMua
            // 
            this.lblNgayMua.AutoSize = true;
            this.lblNgayMua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNgayMua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblNgayMua.Location = new System.Drawing.Point(20, 116);
            this.lblNgayMua.Name = "lblNgayMua";
            this.lblNgayMua.Size = new System.Drawing.Size(65, 15);
            this.lblNgayMua.TabIndex = 8;
            this.lblNgayMua.Text = "Ngày mua:";
            // 
            // dtpNgayMua
            // 
            this.dtpNgayMua.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayMua.Location = new System.Drawing.Point(155, 111);
            this.dtpNgayMua.Name = "dtpNgayMua";
            this.dtpNgayMua.Size = new System.Drawing.Size(180, 25);
            this.dtpNgayMua.TabIndex = 9;
            // 
            // lblThoiHan
            // 
            this.lblThoiHan.AutoSize = true;
            this.lblThoiHan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblThoiHan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblThoiHan.Location = new System.Drawing.Point(365, 116);
            this.lblThoiHan.Name = "lblThoiHan";
            this.lblThoiHan.Size = new System.Drawing.Size(99, 15);
            this.lblThoiHan.TabIndex = 10;
            this.lblThoiHan.Text = "Thời hạn (tháng):";
            // 
            // numThoiHan
            // 
            this.numThoiHan.Location = new System.Drawing.Point(475, 111);
            this.numThoiHan.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numThoiHan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numThoiHan.Name = "numThoiHan";
            this.numThoiHan.Size = new System.Drawing.Size(70, 25);
            this.numThoiHan.TabIndex = 11;
            this.numThoiHan.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // lblNgayHetHan
            // 
            this.lblNgayHetHan.AutoSize = true;
            this.lblNgayHetHan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNgayHetHan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblNgayHetHan.Location = new System.Drawing.Point(585, 116);
            this.lblNgayHetHan.Name = "lblNgayHetHan";
            this.lblNgayHetHan.Size = new System.Drawing.Size(81, 15);
            this.lblNgayHetHan.TabIndex = 12;
            this.lblNgayHetHan.Text = "Ngày hết hạn:";
            // 
            // dtpNgayHetHan
            // 
            this.dtpNgayHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayHetHan.Location = new System.Drawing.Point(700, 111);
            this.dtpNgayHetHan.Name = "dtpNgayHetHan";
            this.dtpNgayHetHan.Size = new System.Drawing.Size(180, 25);
            this.dtpNgayHetHan.TabIndex = 13;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblTrangThai.Location = new System.Drawing.Point(20, 155);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(63, 15);
            this.lblTrangThai.TabIndex = 14;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Còn bảo hành",
            "Hết bảo hành"});
            this.cboTrangThai.Location = new System.Drawing.Point(155, 150);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(390, 25);
            this.cboTrangThai.TabIndex = 15;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGhiChu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblGhiChu.Location = new System.Drawing.Point(585, 155);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(51, 15);
            this.lblGhiChu.TabIndex = 16;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGhiChu.Location = new System.Drawing.Point(700, 150);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(390, 50);
            this.txtGhiChu.TabIndex = 17;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnThem);
            this.pnlButtons.Controls.Add(this.btnSua);
            this.pnlButtons.Controls.Add(this.btnXoa);
            this.pnlButtons.Controls.Add(this.btnLamMoi);
            this.pnlButtons.Location = new System.Drawing.Point(10, 235);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1130, 60);
            this.pnlButtons.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(156)))), ((int)(((byte)(110)))));
            this.btnThem.BorderRadius = 20;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(100, 8);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(210, 44);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "   THÊM";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(190)))));
            this.btnSua.BorderRadius = 20;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(340, 8);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(210, 44);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "   SỬA";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.IndianRed;
            this.btnXoa.BorderRadius = 20;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(580, 8);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(210, 44);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "   XÓA";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.Navy;
            this.btnLamMoi.BorderRadius = 20;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.Location = new System.Drawing.Point(820, 8);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(210, 44);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "   LÀM MỚI";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // grpTimKiem
            // 
            this.grpTimKiem.Controls.Add(this.lblTimMaPhieu);
            this.grpTimKiem.Controls.Add(this.txtTimMaPhieu);
            this.grpTimKiem.Controls.Add(this.lblTimMaSanPham);
            this.grpTimKiem.Controls.Add(this.txtTimMaSanPham);
            this.grpTimKiem.Controls.Add(this.lblTimKhachHang);
            this.grpTimKiem.Controls.Add(this.txtTimKhachHang);
            this.grpTimKiem.Controls.Add(this.btnTimKiem);
            this.grpTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(107)))));
            this.grpTimKiem.Location = new System.Drawing.Point(10, 300);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(1130, 85);
            this.grpTimKiem.TabIndex = 2;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "TÌM KIẾM PHIẾU BẢO HÀNH";
            // 
            // lblTimMaPhieu
            // 
            this.lblTimMaPhieu.AutoSize = true;
            this.lblTimMaPhieu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTimMaPhieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblTimMaPhieu.Location = new System.Drawing.Point(20, 38);
            this.lblTimMaPhieu.Name = "lblTimMaPhieu";
            this.lblTimMaPhieu.Size = new System.Drawing.Size(60, 15);
            this.lblTimMaPhieu.TabIndex = 0;
            this.lblTimMaPhieu.Text = "Mã phiếu:";
            // 
            // txtTimMaPhieu
            // 
            this.txtTimMaPhieu.Location = new System.Drawing.Point(90, 34);
            this.txtTimMaPhieu.Name = "txtTimMaPhieu";
            this.txtTimMaPhieu.Size = new System.Drawing.Size(180, 25);
            this.txtTimMaPhieu.TabIndex = 1;
            // 
            // lblTimMaSanPham
            // 
            this.lblTimMaSanPham.AutoSize = true;
            this.lblTimMaSanPham.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTimMaSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblTimMaSanPham.Location = new System.Drawing.Point(295, 38);
            this.lblTimMaSanPham.Name = "lblTimMaSanPham";
            this.lblTimMaSanPham.Size = new System.Drawing.Size(82, 15);
            this.lblTimMaSanPham.TabIndex = 2;
            this.lblTimMaSanPham.Text = "Mã sản phẩm:";
            // 
            // txtTimMaSanPham
            // 
            this.txtTimMaSanPham.Location = new System.Drawing.Point(390, 34);
            this.txtTimMaSanPham.Name = "txtTimMaSanPham";
            this.txtTimMaSanPham.Size = new System.Drawing.Size(180, 25);
            this.txtTimMaSanPham.TabIndex = 3;
            // 
            // lblTimKhachHang
            // 
            this.lblTimKhachHang.AutoSize = true;
            this.lblTimKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTimKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblTimKhachHang.Location = new System.Drawing.Point(590, 38);
            this.lblTimKhachHang.Name = "lblTimKhachHang";
            this.lblTimKhachHang.Size = new System.Drawing.Size(73, 15);
            this.lblTimKhachHang.TabIndex = 4;
            this.lblTimKhachHang.Text = "Khách hàng:";
            // 
            // txtTimKhachHang
            // 
            this.txtTimKhachHang.Location = new System.Drawing.Point(670, 34);
            this.txtTimKhachHang.Name = "txtTimKhachHang";
            this.txtTimKhachHang.Size = new System.Drawing.Size(200, 25);
            this.txtTimKhachHang.TabIndex = 5;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(156)))), ((int)(((byte)(170)))));
            this.btnTimKiem.BorderRadius = 20;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(890, 26);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(205, 40);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "   TÌM KIẾM";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lblDanhSach
            // 
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDanhSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(107)))));
            this.lblDanhSach.Location = new System.Drawing.Point(10, 400);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(219, 19);
            this.lblDanhSach.TabIndex = 3;
            this.lblDanhSach.Text = "DANH SÁCH PHIẾU BẢO HÀNH";
            // 
            // dgvBaoHanh
            // 
            this.dgvBaoHanh.AllowUserToAddRows = false;
            this.dgvBaoHanh.AllowUserToDeleteRows = false;
            this.dgvBaoHanh.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgvBaoHanh.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBaoHanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBaoHanh.BackgroundColor = System.Drawing.Color.White;
            this.dgvBaoHanh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBaoHanh.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBaoHanh.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(107)))));
            this.dgvBaoHanh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBaoHanh.ColumnHeadersHeight = 38;
            this.dgvBaoHanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPhieu,
            this.colMaSanPham,
            this.colTenKhachHang,
            this.colSoDienThoai,
            this.colNgayMua,
            this.colThoiHan,
            this.colNgayHetHan,
            this.colTrangThai});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBaoHanh.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBaoHanh.EnableHeadersVisualStyles = false;
            this.dgvBaoHanh.Location = new System.Drawing.Point(10, 430);
            this.dgvBaoHanh.Name = "dgvBaoHanh";
            this.dgvBaoHanh.ReadOnly = true;
            this.dgvBaoHanh.RowHeadersVisible = false;
            this.dgvBaoHanh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBaoHanh.Size = new System.Drawing.Size(1130, 210);
            this.dgvBaoHanh.TabIndex = 4;
            // 
            // colMaPhieu
            // 
            this.colMaPhieu.HeaderText = "Mã phiếu";
            this.colMaPhieu.Name = "colMaPhieu";
            this.colMaPhieu.ReadOnly = true;
            // 
            // colMaSanPham
            // 
            this.colMaSanPham.HeaderText = "Mã sản phẩm";
            this.colMaSanPham.Name = "colMaSanPham";
            this.colMaSanPham.ReadOnly = true;
            // 
            // colTenKhachHang
            // 
            this.colTenKhachHang.HeaderText = "Khách hàng";
            this.colTenKhachHang.Name = "colTenKhachHang";
            this.colTenKhachHang.ReadOnly = true;
            // 
            // colSoDienThoai
            // 
            this.colSoDienThoai.HeaderText = "SĐT";
            this.colSoDienThoai.Name = "colSoDienThoai";
            this.colSoDienThoai.ReadOnly = true;
            // 
            // colNgayMua
            // 
            this.colNgayMua.HeaderText = "Ngày mua";
            this.colNgayMua.Name = "colNgayMua";
            this.colNgayMua.ReadOnly = true;
            // 
            // colThoiHan
            // 
            this.colThoiHan.HeaderText = "Thời hạn";
            this.colThoiHan.Name = "colThoiHan";
            this.colThoiHan.ReadOnly = true;
            // 
            // colNgayHetHan
            // 
            this.colNgayHetHan.HeaderText = "Ngày hết hạn";
            this.colNgayHetHan.Name = "colNgayHetHan";
            this.colNgayHetHan.ReadOnly = true;
            // 
            // colTrangThai
            // 
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            // 
            // BaoHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.tblMain);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "BaoHanh";
            this.Text = "Phiếu bảo hành";
            this.pnlHeader.ResumeLayout(false);
            this.tblHeader.ResumeLayout(false);
            this.pnlHeaderContent.ResumeLayout(false);
            this.pnlHeaderContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBaoHanh)).EndInit();
            this.tblMain.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThoiHan)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoHanh)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.TableLayoutPanel tblHeader;
        private System.Windows.Forms.Panel pnlHeaderContent;

        private System.Windows.Forms.PictureBox picBaoHanh;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.Panel pnlContent;

        private System.Windows.Forms.GroupBox grpThongTin;

        private System.Windows.Forms.Label lblMaPhieu;
        private System.Windows.Forms.TextBox txtMaPhieu;

        private System.Windows.Forms.Label lblMaSanPham;
        private System.Windows.Forms.TextBox txtMaSanPham;

        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.TextBox txtTenKhachHang;

        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.TextBox txtSoDienThoai;

        private System.Windows.Forms.Label lblNgayMua;
        private System.Windows.Forms.DateTimePicker dtpNgayMua;

        private System.Windows.Forms.Label lblThoiHan;
        private System.Windows.Forms.NumericUpDown numThoiHan;

        private System.Windows.Forms.Label lblNgayHetHan;
        private System.Windows.Forms.DateTimePicker dtpNgayHetHan;

        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cboTrangThai;

        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;

        private System.Windows.Forms.Panel pnlButtons;

        private Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử.RoundedButton btnThem;
        private Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử.RoundedButton btnSua;
        private Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử.RoundedButton btnXoa;
        private Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử.RoundedButton btnLamMoi;

        private System.Windows.Forms.GroupBox grpTimKiem;

        private System.Windows.Forms.Label lblTimMaPhieu;
        private System.Windows.Forms.TextBox txtTimMaPhieu;

        private System.Windows.Forms.Label lblTimMaSanPham;
        private System.Windows.Forms.TextBox txtTimMaSanPham;

        private System.Windows.Forms.Label lblTimKhachHang;
        private System.Windows.Forms.TextBox txtTimKhachHang;

        private Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử.RoundedButton btnTimKiem;

        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.DataGridView dgvBaoHanh;

        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoiHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayHetHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}