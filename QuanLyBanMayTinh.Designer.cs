namespace Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử
{
    partial class QuanLyBanMayTinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyBanMayTinh));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblMenu = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoHanh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMaGiamGia = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDonHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlPageHost = new System.Windows.Forms.Panel();
            this.pnlSanPham = new System.Windows.Forms.Panel();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.lblDanhMuc = new System.Windows.Forms.Label();
            this.cboDanhMuc = new System.Windows.Forms.ComboBox();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnThem = new Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử.RoundedButton();
            this.btnSua = new Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử.RoundedButton();
            this.btnXoa = new Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử.RoundedButton();
            this.btnLamMoi = new Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử.RoundedButton();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.lblTimMa = new System.Windows.Forms.Label();
            this.txtTimMa = new System.Windows.Forms.TextBox();
            this.lblTimTen = new System.Windows.Forms.Label();
            this.txtTimTen = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử.RoundedButton();
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.colMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.tblHeader = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHeaderContent = new System.Windows.Forms.Panel();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.tblMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlPageHost.SuspendLayout();
            this.pnlSanPham.SuspendLayout();
            this.tblMain.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.grpTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.tblHeader.SuspendLayout();
            this.pnlHeaderContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMenu
            // 
            this.tblMenu.BackColor = System.Drawing.Color.White;
            this.tblMenu.ColumnCount = 3;
            this.tblMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 850F));
            this.tblMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMenu.Controls.Add(this.menuStrip1, 1, 0);
            this.tblMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblMenu.Location = new System.Drawing.Point(0, 0);
            this.tblMenu.Name = "tblMenu";
            this.tblMenu.RowCount = 1;
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tblMenu.Size = new System.Drawing.Size(1200, 39);
            this.tblMenu.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSanPham,
            this.mnuDanhMuc,
            this.mnuBaoHanh,
            this.mnuMaGiamGia,
            this.mnuDonHang,
            this.mnuThongKe,
            this.mnuThoat});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(175, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(850, 39);
            this.menuStrip1.TabIndex = 0;
            // 
            // mnuSanPham
            // 
            this.mnuSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(107)))));
            this.mnuSanPham.Name = "mnuSanPham";
            this.mnuSanPham.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.mnuSanPham.Size = new System.Drawing.Size(103, 39);
            this.mnuSanPham.Text = "Sản phẩm";
            this.mnuSanPham.Click += new System.EventHandler(this.mnuSanPham_Click);
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.mnuDanhMuc.Size = new System.Drawing.Size(103, 39);
            this.mnuDanhMuc.Text = "Danh mục";
            this.mnuDanhMuc.Click += new System.EventHandler(this.mnuDanhMuc_Click);
            // 
            // mnuBaoHanh
            // 
            this.mnuBaoHanh.Name = "mnuBaoHanh";
            this.mnuBaoHanh.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.mnuBaoHanh.Size = new System.Drawing.Size(140, 39);
            this.mnuBaoHanh.Text = "Phiếu bảo hành";
            this.mnuBaoHanh.Click += new System.EventHandler(this.mnuBaoHanh_Click);
            // 
            // mnuMaGiamGia
            // 
            this.mnuMaGiamGia.Name = "mnuMaGiamGia";
            this.mnuMaGiamGia.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.mnuMaGiamGia.Size = new System.Drawing.Size(121, 39);
            this.mnuMaGiamGia.Text = "Mã giảm giá";
            this.mnuMaGiamGia.Click += new System.EventHandler(this.mnuMaGiamGia_Click);
            // 
            // mnuDonHang
            // 
            this.mnuDonHang.Name = "mnuDonHang";
            this.mnuDonHang.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.mnuDonHang.Size = new System.Drawing.Size(101, 39);
            this.mnuDonHang.Text = "Đơn hàng";
            this.mnuDonHang.Click += new System.EventHandler(this.mnuDonHang_Click);
            // 
            // mnuThongKe
            // 
            this.mnuThongKe.Name = "mnuThongKe";
            this.mnuThongKe.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.mnuThongKe.Size = new System.Drawing.Size(170, 39);
            this.mnuThongKe.Text = "Thống kê doanh thu";
            this.mnuThongKe.Click += new System.EventHandler(this.mnuThongKe_Click);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.mnuThoat.Size = new System.Drawing.Size(75, 39);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // pnlPageHost
            // 
            this.pnlPageHost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlPageHost.Controls.Add(this.pnlSanPham);
            this.pnlPageHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPageHost.Location = new System.Drawing.Point(0, 39);
            this.pnlPageHost.Name = "pnlPageHost";
            this.pnlPageHost.Size = new System.Drawing.Size(1200, 761);
            this.pnlPageHost.TabIndex = 1;
            // 
            // pnlSanPham
            // 
            this.pnlSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlSanPham.Controls.Add(this.tblMain);
            this.pnlSanPham.Controls.Add(this.pnlHeader);
            this.pnlSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSanPham.Location = new System.Drawing.Point(0, 0);
            this.pnlSanPham.Name = "pnlSanPham";
            this.pnlSanPham.Size = new System.Drawing.Size(1200, 761);
            this.pnlSanPham.TabIndex = 0;
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
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 665F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Size = new System.Drawing.Size(1200, 656);
            this.tblMain.TabIndex = 2;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlContent.Controls.Add(this.grpThongTin);
            this.pnlContent.Controls.Add(this.pnlButtons);
            this.pnlContent.Controls.Add(this.grpTimKiem);
            this.pnlContent.Controls.Add(this.lblDanhSach);
            this.pnlContent.Controls.Add(this.dgvSanPham);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(25, 15);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1150, 650);
            this.pnlContent.TabIndex = 0;
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.lblMaSP);
            this.grpThongTin.Controls.Add(this.txtMaSP);
            this.grpThongTin.Controls.Add(this.lblTenSP);
            this.grpThongTin.Controls.Add(this.txtTenSP);
            this.grpThongTin.Controls.Add(this.lblDanhMuc);
            this.grpThongTin.Controls.Add(this.cboDanhMuc);
            this.grpThongTin.Controls.Add(this.lblGiaBan);
            this.grpThongTin.Controls.Add(this.txtGiaBan);
            this.grpThongTin.Controls.Add(this.lblSoLuong);
            this.grpThongTin.Controls.Add(this.txtSoLuong);
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(107)))));
            this.grpThongTin.Location = new System.Drawing.Point(10, 5);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(1130, 155);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "THÔNG TIN SẢN PHẨM";
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblMaSP.Location = new System.Drawing.Point(20, 38);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(82, 15);
            this.lblMaSP.TabIndex = 0;
            this.lblMaSP.Text = "Mã sản phẩm:";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaSP.Location = new System.Drawing.Point(155, 34);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(390, 25);
            this.txtMaSP.TabIndex = 1;
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTenSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblTenSP.Location = new System.Drawing.Point(20, 77);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(84, 15);
            this.lblTenSP.TabIndex = 2;
            this.lblTenSP.Text = "Tên sản phẩm:";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenSP.Location = new System.Drawing.Point(155, 73);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(390, 25);
            this.txtTenSP.TabIndex = 3;
            // 
            // lblDanhMuc
            // 
            this.lblDanhMuc.AutoSize = true;
            this.lblDanhMuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDanhMuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblDanhMuc.Location = new System.Drawing.Point(20, 116);
            this.lblDanhMuc.Name = "lblDanhMuc";
            this.lblDanhMuc.Size = new System.Drawing.Size(65, 15);
            this.lblDanhMuc.TabIndex = 4;
            this.lblDanhMuc.Text = "Danh mục:";
            // 
            // cboDanhMuc
            // 
            this.cboDanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDanhMuc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboDanhMuc.FormattingEnabled = true;
            this.cboDanhMuc.Location = new System.Drawing.Point(155, 112);
            this.cboDanhMuc.Name = "cboDanhMuc";
            this.cboDanhMuc.Size = new System.Drawing.Size(390, 25);
            this.cboDanhMuc.TabIndex = 5;
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGiaBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblGiaBan.Location = new System.Drawing.Point(585, 38);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(50, 15);
            this.lblGiaBan.TabIndex = 6;
            this.lblGiaBan.Text = "Giá bán:";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGiaBan.Location = new System.Drawing.Point(700, 34);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(390, 25);
            this.txtGiaBan.TabIndex = 7;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblSoLuong.Location = new System.Drawing.Point(585, 77);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(57, 15);
            this.lblSoLuong.TabIndex = 8;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSoLuong.Location = new System.Drawing.Point(700, 73);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(390, 25);
            this.txtSoLuong.TabIndex = 9;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnThem);
            this.pnlButtons.Controls.Add(this.btnSua);
            this.pnlButtons.Controls.Add(this.btnXoa);
            this.pnlButtons.Controls.Add(this.btnLamMoi);
            this.pnlButtons.Location = new System.Drawing.Point(10, 170);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1130, 60);
            this.pnlButtons.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(156)))), ((int)(((byte)(110)))));
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(100, 8);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(210, 44);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "   THÊM";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(190)))));
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(343, 8);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(207, 44);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "   SỬA";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.IndianRed;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(580, 8);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(210, 44);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "   XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.Navy;
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.Location = new System.Drawing.Point(820, 8);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(210, 44);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "   LÀM MỚI";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // grpTimKiem
            // 
            this.grpTimKiem.Controls.Add(this.lblTimMa);
            this.grpTimKiem.Controls.Add(this.txtTimMa);
            this.grpTimKiem.Controls.Add(this.lblTimTen);
            this.grpTimKiem.Controls.Add(this.txtTimTen);
            this.grpTimKiem.Controls.Add(this.btnTimKiem);
            this.grpTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(107)))));
            this.grpTimKiem.Location = new System.Drawing.Point(10, 235);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(1130, 80);
            this.grpTimKiem.TabIndex = 2;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "TÌM KIẾM SẢN PHẨM";
            // 
            // lblTimMa
            // 
            this.lblTimMa.AutoSize = true;
            this.lblTimMa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTimMa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblTimMa.Location = new System.Drawing.Point(20, 36);
            this.lblTimMa.Name = "lblTimMa";
            this.lblTimMa.Size = new System.Drawing.Size(82, 15);
            this.lblTimMa.TabIndex = 0;
            this.lblTimMa.Text = "Mã sản phẩm:";
            // 
            // txtTimMa
            // 
            this.txtTimMa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimMa.Location = new System.Drawing.Point(125, 32);
            this.txtTimMa.Name = "txtTimMa";
            this.txtTimMa.Size = new System.Drawing.Size(220, 25);
            this.txtTimMa.TabIndex = 1;
            // 
            // lblTimTen
            // 
            this.lblTimTen.AutoSize = true;
            this.lblTimTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTimTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblTimTen.Location = new System.Drawing.Point(370, 36);
            this.lblTimTen.Name = "lblTimTen";
            this.lblTimTen.Size = new System.Drawing.Size(84, 15);
            this.lblTimTen.TabIndex = 2;
            this.lblTimTen.Text = "Tên sản phẩm:";
            // 
            // txtTimTen
            // 
            this.txtTimTen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimTen.Location = new System.Drawing.Point(480, 32);
            this.txtTimTen.Name = "txtTimTen";
            this.txtTimTen.Size = new System.Drawing.Size(360, 25);
            this.txtTimTen.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(156)))), ((int)(((byte)(170)))));
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(875, 25);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(220, 40);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "   TÌM KIẾM";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // lblDanhSach
            // 
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDanhSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(107)))));
            this.lblDanhSach.Location = new System.Drawing.Point(10, 330);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(173, 19);
            this.lblDanhSach.TabIndex = 3;
            this.lblDanhSach.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.AllowUserToDeleteRows = false;
            this.dgvSanPham.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgvSanPham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgvSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSanPham.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSanPham.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSanPham.ColumnHeadersHeight = 38;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSP,
            this.colTenSP,
            this.colDanhMuc,
            this.colGiaBan,
            this.colSoLuong});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSanPham.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSanPham.EnableHeadersVisualStyles = false;
            this.dgvSanPham.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.dgvSanPham.Location = new System.Drawing.Point(10, 360);
            this.dgvSanPham.MultiSelect = false;
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersVisible = false;
            this.dgvSanPham.RowTemplate.Height = 32;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(1130, 280);
            this.dgvSanPham.TabIndex = 4;
            // 
            // colMaSP
            // 
            this.colMaSP.FillWeight = 90F;
            this.colMaSP.HeaderText = "Mã sản phẩm";
            this.colMaSP.Name = "colMaSP";
            this.colMaSP.ReadOnly = true;
            // 
            // colTenSP
            // 
            this.colTenSP.FillWeight = 160F;
            this.colTenSP.HeaderText = "Tên sản phẩm";
            this.colTenSP.Name = "colTenSP";
            this.colTenSP.ReadOnly = true;
            // 
            // colDanhMuc
            // 
            this.colDanhMuc.FillWeight = 110F;
            this.colDanhMuc.HeaderText = "Danh mục";
            this.colDanhMuc.Name = "colDanhMuc";
            this.colDanhMuc.ReadOnly = true;
            // 
            // colGiaBan
            // 
            this.colGiaBan.HeaderText = "Giá bán";
            this.colGiaBan.Name = "colGiaBan";
            this.colGiaBan.ReadOnly = true;
            // 
            // colSoLuong
            // 
            this.colSoLuong.FillWeight = 75F;
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
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
            this.tblHeader.BackColor = System.Drawing.Color.Transparent;
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
            this.pnlHeaderContent.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeaderContent.Controls.Add(this.picProduct);
            this.pnlHeaderContent.Controls.Add(this.lblTitle);
            this.pnlHeaderContent.Controls.Add(this.lblSubTitle);
            this.pnlHeaderContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeaderContent.Location = new System.Drawing.Point(25, 0);
            this.pnlHeaderContent.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeaderContent.Name = "pnlHeaderContent";
            this.pnlHeaderContent.Size = new System.Drawing.Size(1150, 105);
            this.pnlHeaderContent.TabIndex = 0;
            // 
            // picProduct
            // 
            this.picProduct.Image = global::Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử.Properties.Resources.product;
            this.picProduct.Location = new System.Drawing.Point(10, 20);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(60, 60);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProduct.TabIndex = 0;
            this.picProduct.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(85, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(285, 37);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.lblSubTitle.Location = new System.Drawing.Point(88, 65);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(266, 15);
            this.lblSubTitle.TabIndex = 2;
            this.lblSubTitle.Text = "Quản lý thông tin máy tính và các thiết bị điện tử";
            // 
            // QuanLyBanMayTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.pnlPageHost);
            this.Controls.Add(this.tblMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "QuanLyBanMayTinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bán máy tính và thiết bị điện tử";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tblMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlPageHost.ResumeLayout(false);
            this.pnlSanPham.ResumeLayout(false);
            this.tblMain.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.tblHeader.ResumeLayout(false);
            this.pnlHeaderContent.ResumeLayout(false);
            this.pnlHeaderContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TableLayoutPanel tblMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel pnlPageHost;
        private System.Windows.Forms.Panel pnlSanPham;

        private System.Windows.Forms.ToolStripMenuItem mnuSanPham;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoHanh;
        private System.Windows.Forms.ToolStripMenuItem mnuMaGiamGia;
        private System.Windows.Forms.ToolStripMenuItem mnuDonHang;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKe;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.TableLayoutPanel tblHeader;
        private System.Windows.Forms.Panel pnlHeaderContent;

        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.Panel pnlContent;

        private System.Windows.Forms.GroupBox grpThongTin;

        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.TextBox txtMaSP;

        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.TextBox txtTenSP;

        private System.Windows.Forms.Label lblDanhMuc;
        private System.Windows.Forms.ComboBox cboDanhMuc;

        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.TextBox txtGiaBan;

        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtSoLuong;

        private System.Windows.Forms.Panel pnlButtons;

        private Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử.RoundedButton btnThem;
        private Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử.RoundedButton btnSua;
        private Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử.RoundedButton btnXoa;
        private Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử.RoundedButton btnLamMoi;

        private System.Windows.Forms.GroupBox grpTimKiem;

        private System.Windows.Forms.Label lblTimMa;
        private System.Windows.Forms.TextBox txtTimMa;

        private System.Windows.Forms.Label lblTimTen;
        private System.Windows.Forms.TextBox txtTimTen;

        private Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử.RoundedButton btnTimKiem;

        private System.Windows.Forms.Label lblDanhSach;

        private System.Windows.Forms.DataGridView dgvSanPham;

        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
    }
}