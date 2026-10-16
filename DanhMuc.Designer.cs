namespace Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử
{
    partial class DanhMuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhMuc));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.tblHeader = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHeaderContent = new System.Windows.Forms.Panel();
            this.picDanhMuc = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblMaDanhMuc = new System.Windows.Forms.Label();
            this.txtMaDanhMuc = new System.Windows.Forms.TextBox();
            this.lblTenDanhMuc = new System.Windows.Forms.Label();
            this.txtTenDanhMuc = new System.Windows.Forms.TextBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
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
            this.dgvDanhMuc = new System.Windows.Forms.DataGridView();
            this.colMaDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader.SuspendLayout();
            this.tblHeader.SuspendLayout();
            this.pnlHeaderContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDanhMuc)).BeginInit();
            this.tblMain.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.grpTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).BeginInit();
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
            this.pnlHeaderContent.Controls.Add(this.picDanhMuc);
            this.pnlHeaderContent.Controls.Add(this.lblTitle);
            this.pnlHeaderContent.Controls.Add(this.lblSubTitle);
            this.pnlHeaderContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeaderContent.Location = new System.Drawing.Point(25, 0);
            this.pnlHeaderContent.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeaderContent.Name = "pnlHeaderContent";
            this.pnlHeaderContent.Size = new System.Drawing.Size(1150, 105);
            this.pnlHeaderContent.TabIndex = 0;
            // 
            // picDanhMuc
            // 
            this.picDanhMuc.Image = global::Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử.Properties.Resources.category;
            this.picDanhMuc.Location = new System.Drawing.Point(10, 22);
            this.picDanhMuc.Name = "picDanhMuc";
            this.picDanhMuc.Size = new System.Drawing.Size(60, 60);
            this.picDanhMuc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDanhMuc.TabIndex = 0;
            this.picDanhMuc.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(85, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(291, 37);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "QUẢN LÝ DANH MỤC";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.lblSubTitle.Location = new System.Drawing.Point(88, 65);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(160, 15);
            this.lblSubTitle.TabIndex = 2;
            this.lblSubTitle.Text = "Quản lý danh mục sản phẩm";
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
            this.pnlContent.Controls.Add(this.dgvDanhMuc);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(25, 15);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1150, 650);
            this.pnlContent.TabIndex = 0;
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.lblMaDanhMuc);
            this.grpThongTin.Controls.Add(this.txtMaDanhMuc);
            this.grpThongTin.Controls.Add(this.lblTenDanhMuc);
            this.grpThongTin.Controls.Add(this.txtTenDanhMuc);
            this.grpThongTin.Controls.Add(this.lblMoTa);
            this.grpThongTin.Controls.Add(this.txtMoTa);
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(107)))));
            this.grpThongTin.Location = new System.Drawing.Point(10, 5);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(1130, 155);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "THÔNG TIN DANH MỤC";
            // 
            // lblMaDanhMuc
            // 
            this.lblMaDanhMuc.AutoSize = true;
            this.lblMaDanhMuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaDanhMuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblMaDanhMuc.Location = new System.Drawing.Point(20, 38);
            this.lblMaDanhMuc.Name = "lblMaDanhMuc";
            this.lblMaDanhMuc.Size = new System.Drawing.Size(84, 15);
            this.lblMaDanhMuc.TabIndex = 0;
            this.lblMaDanhMuc.Text = "Mã danh mục:";
            // 
            // txtMaDanhMuc
            // 
            this.txtMaDanhMuc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaDanhMuc.Location = new System.Drawing.Point(155, 34);
            this.txtMaDanhMuc.Name = "txtMaDanhMuc";
            this.txtMaDanhMuc.Size = new System.Drawing.Size(390, 25);
            this.txtMaDanhMuc.TabIndex = 1;
            // 
            // lblTenDanhMuc
            // 
            this.lblTenDanhMuc.AutoSize = true;
            this.lblTenDanhMuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTenDanhMuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblTenDanhMuc.Location = new System.Drawing.Point(585, 38);
            this.lblTenDanhMuc.Name = "lblTenDanhMuc";
            this.lblTenDanhMuc.Size = new System.Drawing.Size(86, 15);
            this.lblTenDanhMuc.TabIndex = 2;
            this.lblTenDanhMuc.Text = "Tên danh mục:";
            // 
            // txtTenDanhMuc
            // 
            this.txtTenDanhMuc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenDanhMuc.Location = new System.Drawing.Point(700, 34);
            this.txtTenDanhMuc.Name = "txtTenDanhMuc";
            this.txtTenDanhMuc.Size = new System.Drawing.Size(390, 25);
            this.txtTenDanhMuc.TabIndex = 3;
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMoTa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblMoTa.Location = new System.Drawing.Point(20, 82);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(41, 15);
            this.lblMoTa.TabIndex = 4;
            this.lblMoTa.Text = "Mô tả:";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMoTa.Location = new System.Drawing.Point(155, 75);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(935, 55);
            this.txtMoTa.TabIndex = 5;
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
            this.grpTimKiem.Text = "TÌM KIẾM DANH MỤC";
            // 
            // lblTimMa
            // 
            this.lblTimMa.AutoSize = true;
            this.lblTimMa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTimMa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblTimMa.Location = new System.Drawing.Point(20, 36);
            this.lblTimMa.Name = "lblTimMa";
            this.lblTimMa.Size = new System.Drawing.Size(84, 15);
            this.lblTimMa.TabIndex = 0;
            this.lblTimMa.Text = "Mã danh mục:";
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
            this.lblTimTen.Size = new System.Drawing.Size(86, 15);
            this.lblTimTen.TabIndex = 2;
            this.lblTimTen.Text = "Tên danh mục:";
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
            this.btnTimKiem.BorderRadius = 20;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(875, 25);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(220, 40);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "   TÌM KIẾM";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lblDanhSach
            // 
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDanhSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(107)))));
            this.lblDanhSach.Location = new System.Drawing.Point(10, 330);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(175, 19);
            this.lblDanhSach.TabIndex = 3;
            this.lblDanhSach.Text = "DANH SÁCH DANH MỤC";
            // 
            // dgvDanhMuc
            // 
            this.dgvDanhMuc.AllowUserToAddRows = false;
            this.dgvDanhMuc.AllowUserToDeleteRows = false;
            this.dgvDanhMuc.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgvDanhMuc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhMuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhMuc.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhMuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDanhMuc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDanhMuc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhMuc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhMuc.ColumnHeadersHeight = 38;
            this.dgvDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDanhMuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDanhMuc,
            this.colTenDanhMuc,
            this.colMoTa});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhMuc.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhMuc.EnableHeadersVisualStyles = false;
            this.dgvDanhMuc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.dgvDanhMuc.Location = new System.Drawing.Point(10, 360);
            this.dgvDanhMuc.MultiSelect = false;
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.ReadOnly = true;
            this.dgvDanhMuc.RowHeadersVisible = false;
            this.dgvDanhMuc.RowTemplate.Height = 32;
            this.dgvDanhMuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhMuc.Size = new System.Drawing.Size(1130, 280);
            this.dgvDanhMuc.TabIndex = 4;
            // 
            // colMaDanhMuc
            // 
            this.colMaDanhMuc.FillWeight = 80F;
            this.colMaDanhMuc.HeaderText = "Mã danh mục";
            this.colMaDanhMuc.Name = "colMaDanhMuc";
            this.colMaDanhMuc.ReadOnly = true;
            // 
            // colTenDanhMuc
            // 
            this.colTenDanhMuc.FillWeight = 120F;
            this.colTenDanhMuc.HeaderText = "Tên danh mục";
            this.colTenDanhMuc.Name = "colTenDanhMuc";
            this.colTenDanhMuc.ReadOnly = true;
            // 
            // colMoTa
            // 
            this.colMoTa.FillWeight = 250F;
            this.colMoTa.HeaderText = "Mô tả";
            this.colMoTa.Name = "colMoTa";
            this.colMoTa.ReadOnly = true;
            // 
            // DanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.tblMain);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "DanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý danh mục";
            this.pnlHeader.ResumeLayout(false);
            this.tblHeader.ResumeLayout(false);
            this.pnlHeaderContent.ResumeLayout(false);
            this.pnlHeaderContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDanhMuc)).EndInit();
            this.tblMain.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.TableLayoutPanel tblHeader;
        private System.Windows.Forms.Panel pnlHeaderContent;

        private System.Windows.Forms.PictureBox picDanhMuc;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.Panel pnlContent;

        private System.Windows.Forms.GroupBox grpThongTin;

        private System.Windows.Forms.Label lblMaDanhMuc;
        private System.Windows.Forms.TextBox txtMaDanhMuc;

        private System.Windows.Forms.Label lblTenDanhMuc;
        private System.Windows.Forms.TextBox txtTenDanhMuc;

        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.TextBox txtMoTa;

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

        private System.Windows.Forms.DataGridView dgvDanhMuc;

        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoTa;
    }
}