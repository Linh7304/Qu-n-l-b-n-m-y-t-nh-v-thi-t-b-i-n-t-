namespace Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử
{
    partial class DonHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.tblHeader = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHeaderContent = new System.Windows.Forms.Panel();
            this.picDonHang = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblMaDon = new System.Windows.Forms.Label();
            this.txtMaDon = new System.Windows.Forms.TextBox();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.lblNgayDat = new System.Windows.Forms.Label();
            this.dtpNgayDat = new System.Windows.Forms.DateTimePicker();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.numTongTien = new System.Windows.Forms.NumericUpDown();
            this.lblMaGiamGia = new System.Windows.Forms.Label();
            this.txtMaGiamGia = new System.Windows.Forms.TextBox();
            this.lblGiamGia = new System.Windows.Forms.Label();
            this.numGiamGia = new System.Windows.Forms.NumericUpDown();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.numThanhTien = new System.Windows.Forms.NumericUpDown();
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
            this.lblTimMaDon = new System.Windows.Forms.Label();
            this.txtTimMaDon = new System.Windows.Forms.TextBox();
            this.lblTimKhachHang = new System.Windows.Forms.Label();
            this.txtTimKhachHang = new System.Windows.Forms.TextBox();
            this.lblTimTrangThai = new System.Windows.Forms.Label();
            this.cboTimTrangThai = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử.RoundedButton();
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.dgvDonHang = new System.Windows.Forms.DataGridView();
            this.colMaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader.SuspendLayout();
            this.tblHeader.SuspendLayout();
            this.pnlHeaderContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDonHang)).BeginInit();
            this.tblMain.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTongTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiamGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThanhTien)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.grpTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).BeginInit();
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
            this.pnlHeader.TabIndex = 0;
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
            this.pnlHeaderContent.Controls.Add(this.picDonHang);
            this.pnlHeaderContent.Controls.Add(this.lblTitle);
            this.pnlHeaderContent.Controls.Add(this.lblSubTitle);
            this.pnlHeaderContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeaderContent.Location = new System.Drawing.Point(25, 0);
            this.pnlHeaderContent.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeaderContent.Name = "pnlHeaderContent";
            this.pnlHeaderContent.Size = new System.Drawing.Size(1150, 105);
            this.pnlHeaderContent.TabIndex = 0;
            // 
            // picDonHang
            // 
            this.picDonHang.Image = global::Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử.Properties.Resources.order;
            this.picDonHang.Location = new System.Drawing.Point(10, 22);
            this.picDonHang.Name = "picDonHang";
            this.picDonHang.Size = new System.Drawing.Size(60, 60);
            this.picDonHang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDonHang.TabIndex = 0;
            this.picDonHang.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(85, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(289, 37);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "QUẢN LÝ ĐƠN HÀNG";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.lblSubTitle.Location = new System.Drawing.Point(88, 65);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(230, 15);
            this.lblSubTitle.TabIndex = 2;
            this.lblSubTitle.Text = "Quản lý thông tin đơn hàng và thanh toán";
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
            this.tblMain.RowCount = 1;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
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
            this.pnlContent.Controls.Add(this.dgvDonHang);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(25, 15);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1150, 680);
            this.pnlContent.TabIndex = 0;
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.lblMaDon);
            this.grpThongTin.Controls.Add(this.txtMaDon);
            this.grpThongTin.Controls.Add(this.lblKhachHang);
            this.grpThongTin.Controls.Add(this.txtKhachHang);
            this.grpThongTin.Controls.Add(this.lblSoDienThoai);
            this.grpThongTin.Controls.Add(this.txtSoDienThoai);
            this.grpThongTin.Controls.Add(this.lblNgayDat);
            this.grpThongTin.Controls.Add(this.dtpNgayDat);
            this.grpThongTin.Controls.Add(this.lblTongTien);
            this.grpThongTin.Controls.Add(this.numTongTien);
            this.grpThongTin.Controls.Add(this.lblMaGiamGia);
            this.grpThongTin.Controls.Add(this.txtMaGiamGia);
            this.grpThongTin.Controls.Add(this.lblGiamGia);
            this.grpThongTin.Controls.Add(this.numGiamGia);
            this.grpThongTin.Controls.Add(this.lblThanhTien);
            this.grpThongTin.Controls.Add(this.numThanhTien);
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
            this.grpThongTin.Text = "THÔNG TIN ĐƠN HÀNG";
            // 
            // lblMaDon
            // 
            this.lblMaDon.AutoSize = true;
            this.lblMaDon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblMaDon.Location = new System.Drawing.Point(20, 38);
            this.lblMaDon.Name = "lblMaDon";
            this.lblMaDon.Size = new System.Drawing.Size(51, 15);
            this.lblMaDon.TabIndex = 0;
            this.lblMaDon.Text = "Mã đơn:";
            // 
            // txtMaDon
            // 
            this.txtMaDon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaDon.Location = new System.Drawing.Point(155, 34);
            this.txtMaDon.Name = "txtMaDon";
            this.txtMaDon.Size = new System.Drawing.Size(390, 25);
            this.txtMaDon.TabIndex = 1;
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblKhachHang.Location = new System.Drawing.Point(585, 38);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(73, 15);
            this.lblKhachHang.TabIndex = 2;
            this.lblKhachHang.Text = "Khách hàng:";
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtKhachHang.Location = new System.Drawing.Point(700, 34);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(390, 25);
            this.txtKhachHang.TabIndex = 3;
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSoDienThoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblSoDienThoai.Location = new System.Drawing.Point(20, 77);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(79, 15);
            this.lblSoDienThoai.TabIndex = 4;
            this.lblSoDienThoai.Text = "Số điện thoại:";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSoDienThoai.Location = new System.Drawing.Point(155, 73);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(390, 25);
            this.txtSoDienThoai.TabIndex = 5;
            // 
            // lblNgayDat
            // 
            this.lblNgayDat.AutoSize = true;
            this.lblNgayDat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNgayDat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblNgayDat.Location = new System.Drawing.Point(585, 77);
            this.lblNgayDat.Name = "lblNgayDat";
            this.lblNgayDat.Size = new System.Drawing.Size(58, 15);
            this.lblNgayDat.TabIndex = 6;
            this.lblNgayDat.Text = "Ngày đặt:";
            // 
            // dtpNgayDat
            // 
            this.dtpNgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDat.Location = new System.Drawing.Point(700, 73);
            this.dtpNgayDat.Name = "dtpNgayDat";
            this.dtpNgayDat.Size = new System.Drawing.Size(390, 25);
            this.dtpNgayDat.TabIndex = 7;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblTongTien.Location = new System.Drawing.Point(20, 116);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(61, 15);
            this.lblTongTien.TabIndex = 8;
            this.lblTongTien.Text = "Tổng tiền:";
            // 
            // numTongTien
            // 
            this.numTongTien.Location = new System.Drawing.Point(155, 111);
            this.numTongTien.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numTongTien.Name = "numTongTien";
            this.numTongTien.Size = new System.Drawing.Size(180, 25);
            this.numTongTien.TabIndex = 9;
            // 
            // lblMaGiamGia
            // 
            this.lblMaGiamGia.AutoSize = true;
            this.lblMaGiamGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaGiamGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblMaGiamGia.Location = new System.Drawing.Point(365, 116);
            this.lblMaGiamGia.Name = "lblMaGiamGia";
            this.lblMaGiamGia.Size = new System.Drawing.Size(76, 15);
            this.lblMaGiamGia.TabIndex = 10;
            this.lblMaGiamGia.Text = "Mã giảm giá:";
            // 
            // txtMaGiamGia
            // 
            this.txtMaGiamGia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaGiamGia.Location = new System.Drawing.Point(455, 111);
            this.txtMaGiamGia.Name = "txtMaGiamGia";
            this.txtMaGiamGia.Size = new System.Drawing.Size(180, 25);
            this.txtMaGiamGia.TabIndex = 11;
            // 
            // lblGiamGia
            // 
            this.lblGiamGia.AutoSize = true;
            this.lblGiamGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGiamGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblGiamGia.Location = new System.Drawing.Point(665, 116);
            this.lblGiamGia.Name = "lblGiamGia";
            this.lblGiamGia.Size = new System.Drawing.Size(57, 15);
            this.lblGiamGia.TabIndex = 12;
            this.lblGiamGia.Text = "Giảm giá:";
            // 
            // numGiamGia
            // 
            this.numGiamGia.Location = new System.Drawing.Point(735, 111);
            this.numGiamGia.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numGiamGia.Name = "numGiamGia";
            this.numGiamGia.Size = new System.Drawing.Size(145, 25);
            this.numGiamGia.TabIndex = 13;
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblThanhTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblThanhTien.Location = new System.Drawing.Point(900, 116);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(67, 15);
            this.lblThanhTien.TabIndex = 14;
            this.lblThanhTien.Text = "Thành tiền:";
            // 
            // numThanhTien
            // 
            this.numThanhTien.Location = new System.Drawing.Point(990, 111);
            this.numThanhTien.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numThanhTien.Name = "numThanhTien";
            this.numThanhTien.Size = new System.Drawing.Size(100, 25);
            this.numThanhTien.TabIndex = 15;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblTrangThai.Location = new System.Drawing.Point(20, 158);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(63, 15);
            this.lblTrangThai.TabIndex = 16;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Chờ xử lý",
            "Đã xác nhận",
            "Đang giao",
            "Hoàn thành",
            "Đã hủy"});
            this.cboTrangThai.Location = new System.Drawing.Point(155, 153);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(390, 25);
            this.cboTrangThai.TabIndex = 17;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGhiChu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblGhiChu.Location = new System.Drawing.Point(585, 158);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(51, 15);
            this.lblGhiChu.TabIndex = 18;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGhiChu.Location = new System.Drawing.Point(700, 151);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(390, 50);
            this.txtGhiChu.TabIndex = 19;
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
            this.grpTimKiem.Controls.Add(this.lblTimMaDon);
            this.grpTimKiem.Controls.Add(this.txtTimMaDon);
            this.grpTimKiem.Controls.Add(this.lblTimKhachHang);
            this.grpTimKiem.Controls.Add(this.txtTimKhachHang);
            this.grpTimKiem.Controls.Add(this.lblTimTrangThai);
            this.grpTimKiem.Controls.Add(this.cboTimTrangThai);
            this.grpTimKiem.Controls.Add(this.btnTimKiem);
            this.grpTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(107)))));
            this.grpTimKiem.Location = new System.Drawing.Point(10, 300);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(1130, 85);
            this.grpTimKiem.TabIndex = 2;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "TÌM KIẾM ĐƠN HÀNG";
            // 
            // lblTimMaDon
            // 
            this.lblTimMaDon.AutoSize = true;
            this.lblTimMaDon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTimMaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblTimMaDon.Location = new System.Drawing.Point(20, 38);
            this.lblTimMaDon.Name = "lblTimMaDon";
            this.lblTimMaDon.Size = new System.Drawing.Size(51, 15);
            this.lblTimMaDon.TabIndex = 0;
            this.lblTimMaDon.Text = "Mã đơn:";
            // 
            // txtTimMaDon
            // 
            this.txtTimMaDon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimMaDon.Location = new System.Drawing.Point(85, 34);
            this.txtTimMaDon.Name = "txtTimMaDon";
            this.txtTimMaDon.Size = new System.Drawing.Size(200, 25);
            this.txtTimMaDon.TabIndex = 1;
            // 
            // lblTimKhachHang
            // 
            this.lblTimKhachHang.AutoSize = true;
            this.lblTimKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTimKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblTimKhachHang.Location = new System.Drawing.Point(310, 38);
            this.lblTimKhachHang.Name = "lblTimKhachHang";
            this.lblTimKhachHang.Size = new System.Drawing.Size(73, 15);
            this.lblTimKhachHang.TabIndex = 2;
            this.lblTimKhachHang.Text = "Khách hàng:";
            // 
            // txtTimKhachHang
            // 
            this.txtTimKhachHang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimKhachHang.Location = new System.Drawing.Point(395, 34);
            this.txtTimKhachHang.Name = "txtTimKhachHang";
            this.txtTimKhachHang.Size = new System.Drawing.Size(260, 25);
            this.txtTimKhachHang.TabIndex = 3;
            // 
            // lblTimTrangThai
            // 
            this.lblTimTrangThai.AutoSize = true;
            this.lblTimTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTimTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblTimTrangThai.Location = new System.Drawing.Point(680, 38);
            this.lblTimTrangThai.Name = "lblTimTrangThai";
            this.lblTimTrangThai.Size = new System.Drawing.Size(63, 15);
            this.lblTimTrangThai.TabIndex = 4;
            this.lblTimTrangThai.Text = "Trạng thái:";
            // 
            // cboTimTrangThai
            // 
            this.cboTimTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimTrangThai.Items.AddRange(new object[] {
            "Tất cả",
            "Chờ xử lý",
            "Đã xác nhận",
            "Đang giao",
            "Hoàn thành",
            "Đã hủy"});
            this.cboTimTrangThai.Location = new System.Drawing.Point(755, 34);
            this.cboTimTrangThai.Name = "cboTimTrangThai";
            this.cboTimTrangThai.Size = new System.Drawing.Size(145, 25);
            this.cboTimTrangThai.TabIndex = 5;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(156)))), ((int)(((byte)(170)))));
            this.btnTimKiem.BorderRadius = 20;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(920, 26);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(175, 40);
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
            this.lblDanhSach.Size = new System.Drawing.Size(175, 19);
            this.lblDanhSach.TabIndex = 3;
            this.lblDanhSach.Text = "DANH SÁCH ĐƠN HÀNG";
            // 
            // dgvDonHang
            // 
            this.dgvDonHang.AllowUserToAddRows = false;
            this.dgvDonHang.AllowUserToDeleteRows = false;
            this.dgvDonHang.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgvDonHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvDonHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDonHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDonHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDonHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDonHang.ColumnHeadersHeight = 38;
            this.dgvDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDon,
            this.colKhachHang,
            this.colSoDienThoai,
            this.colNgayDat,
            this.colTongTien,
            this.colGiamGia,
            this.colThanhTien,
            this.colTrangThai});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDonHang.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDonHang.EnableHeadersVisualStyles = false;
            this.dgvDonHang.Location = new System.Drawing.Point(10, 430);
            this.dgvDonHang.MultiSelect = false;
            this.dgvDonHang.Name = "dgvDonHang";
            this.dgvDonHang.ReadOnly = true;
            this.dgvDonHang.RowHeadersVisible = false;
            this.dgvDonHang.RowTemplate.Height = 32;
            this.dgvDonHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonHang.Size = new System.Drawing.Size(1130, 210);
            this.dgvDonHang.TabIndex = 4;
            // 
            // colMaDon
            // 
            this.colMaDon.HeaderText = "Mã đơn";
            this.colMaDon.Name = "colMaDon";
            this.colMaDon.ReadOnly = true;
            // 
            // colKhachHang
            // 
            this.colKhachHang.HeaderText = "Khách hàng";
            this.colKhachHang.Name = "colKhachHang";
            this.colKhachHang.ReadOnly = true;
            // 
            // colSoDienThoai
            // 
            this.colSoDienThoai.HeaderText = "SĐT";
            this.colSoDienThoai.Name = "colSoDienThoai";
            this.colSoDienThoai.ReadOnly = true;
            // 
            // colNgayDat
            // 
            this.colNgayDat.HeaderText = "Ngày đặt";
            this.colNgayDat.Name = "colNgayDat";
            this.colNgayDat.ReadOnly = true;
            // 
            // colTongTien
            // 
            this.colTongTien.HeaderText = "Tổng tiền";
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.ReadOnly = true;
            // 
            // colGiamGia
            // 
            this.colGiamGia.HeaderText = "Giảm giá";
            this.colGiamGia.Name = "colGiamGia";
            this.colGiamGia.ReadOnly = true;
            // 
            // colThanhTien
            // 
            this.colThanhTien.HeaderText = "Thành tiền";
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.ReadOnly = true;
            // 
            // colTrangThai
            // 
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            // 
            // DonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.tblMain);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "DonHang";
            this.Text = "Quản lý đơn hàng";
            this.pnlHeader.ResumeLayout(false);
            this.tblHeader.ResumeLayout(false);
            this.pnlHeaderContent.ResumeLayout(false);
            this.pnlHeaderContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDonHang)).EndInit();
            this.tblMain.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTongTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiamGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThanhTien)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.TableLayoutPanel tblHeader;
        private System.Windows.Forms.Panel pnlHeaderContent;
        private System.Windows.Forms.PictureBox picDonHang;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.Panel pnlContent;

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblMaDon;
        private System.Windows.Forms.TextBox txtMaDon;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblNgayDat;
        private System.Windows.Forms.DateTimePicker dtpNgayDat;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.NumericUpDown numTongTien;
        private System.Windows.Forms.Label lblMaGiamGia;
        private System.Windows.Forms.TextBox txtMaGiamGia;
        private System.Windows.Forms.Label lblGiamGia;
        private System.Windows.Forms.NumericUpDown numGiamGia;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.NumericUpDown numThanhTien;
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
        private System.Windows.Forms.Label lblTimMaDon;
        private System.Windows.Forms.TextBox txtTimMaDon;
        private System.Windows.Forms.Label lblTimKhachHang;
        private System.Windows.Forms.TextBox txtTimKhachHang;
        private System.Windows.Forms.Label lblTimTrangThai;
        private System.Windows.Forms.ComboBox cboTimTrangThai;
        private Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử.RoundedButton btnTimKiem;

        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.DataGridView dgvDonHang;

        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}
