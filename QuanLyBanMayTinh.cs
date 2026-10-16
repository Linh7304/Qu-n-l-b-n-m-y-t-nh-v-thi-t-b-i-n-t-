using System;
using System.Data;
using System.Drawing;
using ClosedXML.Excel;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;
using Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử.Data;

namespace Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử
{
    public partial class QuanLyBanMayTinh : Form
    {
        private Form trangDangMo = null;
        private string maSanPhamDangSua;

        public QuanLyBanMayTinh()
        {
            InitializeComponent();

            ChonMenu(mnuSanPham);
            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnLamMoi.Click += btnLamMoi_Click;
            btnXuatExcel.Click += btnXuatExcel_Click;
            btnTimKiem.Click += btnTimKiem_Click;
            dgvSanPham.CellClick += dgvSanPham_CellClick;
            txtTimMa.KeyDown += (s, e) => { if (e.KeyCode == System.Windows.Forms.Keys.Enter) TimKiemSanPham(); };
            txtTimTen.KeyDown += (s, e) => { if (e.KeyCode == System.Windows.Forms.Keys.Enter) TimKiemSanPham(); };
            Shown += (sender, args) => TaiDuLieuSanPham();
        }

        private void ChonMenu(ToolStripMenuItem item)
        {
            foreach (ToolStripItem menu in menuStrip1.Items)
            {
                if (menu is ToolStripMenuItem m)
                {
                    m.BackColor = Color.White;
                    m.ForeColor = Color.Black;
                }
            }

            item.BackColor = Color.FromArgb(27, 75, 107);
            item.ForeColor = Color.White;
        }

        private void DongTrangDangMo()
        {
            if (trangDangMo != null)
            {
                if (!trangDangMo.IsDisposed)
                {
                    trangDangMo.Close();
                }

                trangDangMo = null;
            }
        }

        private void HienTrangSanPham()
        {
            // Màn hình Sản phẩm nằm sẵn phía dưới và hiện lại khi Form con đóng.
            DongTrangDangMo();

            ChonMenu(mnuSanPham);
            LamMoiSanPham();
        }

        private void MoTrang(
            string tenForm,
            ToolStripMenuItem menuDuocChon)
        {
            ChonMenu(menuDuocChon);

            DongTrangDangMo();

            string tenDayDu =
                "Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử."
                + tenForm;

            Type loaiForm =
                Assembly.GetExecutingAssembly()
                        .GetType(tenDayDu);

            if (loaiForm == null)
            {
                MessageBox.Show(
                    "Chức năng \"" +
                    menuDuocChon.Text +
                    "\" chưa được tạo.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                HienTrangSanPham();
                return;
            }

            if (!typeof(Form).IsAssignableFrom(loaiForm))
            {
                MessageBox.Show(
                    tenForm + " không phải là Windows Form.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                HienTrangSanPham();
                return;
            }

            try
            {
                trangDangMo =
                    (Form)Activator.CreateInstance(loaiForm);

                trangDangMo.TopLevel = false;

                trangDangMo.FormBorderStyle =
                    FormBorderStyle.None;

                trangDangMo.WindowState =
                    FormWindowState.Normal;

                // Giữ Form con dưới menu để không che thanh điều hướng.
                trangDangMo.Dock = DockStyle.None;

                trangDangMo.Location =
                    new Point(
                        0,
                        tblMenu.Bottom
                    );

                trangDangMo.Size =
                    new Size(
                        this.ClientSize.Width,
                        this.ClientSize.Height - tblMenu.Bottom
                    );

                trangDangMo.Anchor =
                    AnchorStyles.Top |
                    AnchorStyles.Bottom |
                    AnchorStyles.Left |
                    AnchorStyles.Right;

                this.Controls.Add(trangDangMo);

                trangDangMo.Show();

                trangDangMo.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể mở trang "
                    + tenForm
                    + ".\n\n"
                    + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                HienTrangSanPham();
            }
        }

        private void mnuSanPham_Click(
            object sender,
            EventArgs e)
        {
            HienTrangSanPham();
        }

        private void mnuDanhMuc_Click(
            object sender,
            EventArgs e)
        {
            MoTrang(
                "DanhMuc",
                mnuDanhMuc
            );
        }

        private void mnuBaoHanh_Click(
            object sender,
            EventArgs e)
        {
            MoTrang(
                "BaoHanh",
                mnuBaoHanh
            );
        }

        private void mnuMaGiamGia_Click(
            object sender,
            EventArgs e)
        {
            MoTrang(
                "MaGiamGia",
                mnuMaGiamGia
            );
        }

        private void mnuDonHang_Click(
            object sender,
            EventArgs e)
        {
            MoTrang(
                "DonHang",
                mnuDonHang
            );
        }

        private void mnuThongKe_Click(
            object sender,
            EventArgs e)
        {
            MoTrang(
                "ThongKe",
                mnuThongKe
            );
        }

        private void mnuThoat_Click(
            object sender,
            EventArgs e)
        {
            DialogResult result =
                MessageBox.Show(
                    "Bạn có chắc muốn thoát chương trình?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnThem_Click(
            object sender,
            EventArgs e)
        {
            if (maSanPhamDangSua != null)
            {
                return;
            }

            string ma, ten;
            decimal giaBan;
            int soLuong;
            if (!InputValidation.Required(txtMaSP, "mã sản phẩm", 30, out ma)
                || !InputValidation.Required(txtTenSP, "tên sản phẩm", 200, out ten))
                return;

            string maDanhMuc = cboDanhMuc.SelectedValue as string;
            if (string.IsNullOrEmpty(maDanhMuc))
            {
                InputValidation.Invalid(cboDanhMuc, "Vui lòng chọn danh mục.");
                return;
            }

            if (!InputValidation.NonNegativeMoney(txtGiaBan, "Giá bán", out giaBan)
                || !InputValidation.NonNegativeInt(txtSoLuong, "Số lượng", out soLuong))
                return;

            try
            {
                Database.Execute(
                    "INSERT INTO dbo.SanPham (MaSanPham, TenSanPham, MaDanhMuc, GiaBan, SoLuong) " +
                    "VALUES (@Ma, @Ten, @DanhMuc, @GiaBan, @SoLuong)",
                    parameters =>
                    {
                        parameters.Add("@Ma", SqlDbType.NVarChar, 30).Value = ma;
                        parameters.Add("@Ten", SqlDbType.NVarChar, 200).Value = ten;
                        parameters.Add("@DanhMuc", SqlDbType.NVarChar, 30).Value = maDanhMuc;
                        var price = parameters.Add("@GiaBan", SqlDbType.Decimal);
                        price.Precision = 18;
                        price.Scale = 2;
                        price.Value = giaBan;
                        parameters.Add("@SoLuong", SqlDbType.Int).Value = soLuong;
                    });
            }
            catch (Exception error)
            {
                MessageBox.Show(Database.SaveError(error, "sản phẩm"), "Lỗi lưu dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtMaSP.Clear();
            txtTenSP.Clear();
            cboDanhMuc.SelectedIndex = -1;
            txtGiaBan.Clear();
            txtSoLuong.Clear();
            TaiDanhSachSanPham();
            MessageBox.Show("Đã thêm sản phẩm.", "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtMaSP.Focus();
        }

        private void TaiDuLieuSanPham()
        {
            try
            {
                DataTable danhMuc = Database.Query(
                    "SELECT MaDanhMuc, TenDanhMuc FROM dbo.DanhMuc ORDER BY TenDanhMuc");
                cboDanhMuc.DisplayMember = "TenDanhMuc";
                cboDanhMuc.ValueMember = "MaDanhMuc";
                cboDanhMuc.DataSource = danhMuc;
                cboDanhMuc.SelectedIndex = -1;
                TaiDanhSachSanPham();
            }
            catch (Exception error)
            {
                MessageBox.Show("Không thể tải danh mục: " + error.Message, "Lỗi dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string ma = Convert.ToString(dgvSanPham.Rows[e.RowIndex].Cells[0].Value);
            try
            {
                DataTable result = Database.Query(
                    "SELECT MaSanPham, TenSanPham, MaDanhMuc, GiaBan, SoLuong " +
                    "FROM dbo.SanPham WHERE MaSanPham = @Ma",
                    parameters => parameters.Add("@Ma", SqlDbType.NVarChar, 30).Value = ma);
                if (result.Rows.Count == 0)
                {
                    MessageBox.Show("Sản phẩm này không còn trong database.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LamMoiSanPham();
                    return;
                }

                DataRow row = result.Rows[0];
                maSanPhamDangSua = ma;
                txtMaSP.Text = ma;
                txtTenSP.Text = Convert.ToString(row["TenSanPham"]);
                cboDanhMuc.SelectedValue = Convert.ToString(row["MaDanhMuc"]);
                txtGiaBan.Text = ((decimal)row["GiaBan"]).ToString(CultureInfo.CurrentCulture);
                txtSoLuong.Text = Convert.ToString(row["SoLuong"]);
                txtMaSP.ReadOnly = true;
            }
            catch (Exception error)
            {
                MessageBox.Show("Không thể đọc sản phẩm: " + error.Message, "Lỗi dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (maSanPhamDangSua == null)
            {
                return;
            }

            string ten;
            decimal giaBan;
            int soLuong;
            if (!InputValidation.Required(txtTenSP, "tên sản phẩm", 200, out ten))
                return;

            string maDanhMuc = cboDanhMuc.SelectedValue as string;
            if (string.IsNullOrEmpty(maDanhMuc))
            {
                InputValidation.Invalid(cboDanhMuc, "Vui lòng chọn danh mục.");
                return;
            }

            if (!InputValidation.NonNegativeMoney(txtGiaBan, "Giá bán", out giaBan)
                || !InputValidation.NonNegativeInt(txtSoLuong, "Số lượng", out soLuong))
                return;

            int updated;
            try
            {
                updated = Database.Execute(
                    "UPDATE dbo.SanPham SET TenSanPham = @Ten, MaDanhMuc = @DanhMuc, " +
                    "GiaBan = @GiaBan, SoLuong = @SoLuong WHERE MaSanPham = @Ma",
                    parameters =>
                    {
                        parameters.Add("@Ma", SqlDbType.NVarChar, 30).Value = maSanPhamDangSua;
                        parameters.Add("@Ten", SqlDbType.NVarChar, 200).Value = ten;
                        parameters.Add("@DanhMuc", SqlDbType.NVarChar, 30).Value = maDanhMuc;
                        var price = parameters.Add("@GiaBan", SqlDbType.Decimal);
                        price.Precision = 18;
                        price.Scale = 2;
                        price.Value = giaBan;
                        parameters.Add("@SoLuong", SqlDbType.Int).Value = soLuong;
                    });
            }
            catch (Exception error)
            {
                MessageBox.Show(Database.SaveError(error, "sản phẩm"), "Lỗi sửa dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LamMoiSanPham();
            MessageBox.Show(updated == 0 ? "Sản phẩm đã không còn trong database." : "Đã sửa sản phẩm.",
                updated == 0 ? "Thông báo" : "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiSanPham();
        }

        private void LamMoiSanPham()
        {
            maSanPhamDangSua = null;
            txtMaSP.ReadOnly = false;
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtGiaBan.Clear();
            txtSoLuong.Clear();
            txtTimMa.Clear();
            txtTimTen.Clear();
            TaiDuLieuSanPham();
            txtMaSP.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Database.DeleteSelected(dgvSanPham, "sản phẩm",
                "DELETE FROM dbo.SanPham WHERE MaSanPham = @Ma", LamMoiSanPham);
        }

        private void TaiDanhSachSanPham()
        {
            try
            {
                Database.LoadGrid(dgvSanPham,
                    "SELECT sp.MaSanPham, sp.TenSanPham, dm.TenDanhMuc, sp.GiaBan, sp.SoLuong " +
                    "FROM dbo.SanPham sp JOIN dbo.DanhMuc dm ON dm.MaDanhMuc = sp.MaDanhMuc " +
                    "ORDER BY sp.MaSanPham");
            }
            catch (Exception error)
            {
                MessageBox.Show("Không thể tải sản phẩm: " + error.Message, "Lỗi dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TimKiemSanPham()
        {
            string tuKhoa = txtTimMa.Text.Trim();
            string ten = txtTimTen.Text.Trim();

            string sql =
                "SELECT sp.MaSanPham, sp.TenSanPham, dm.TenDanhMuc, sp.GiaBan, sp.SoLuong " +
                "FROM dbo.SanPham sp JOIN dbo.DanhMuc dm ON dm.MaDanhMuc = sp.MaDanhMuc " +
                "WHERE 1=1";

            if (!string.IsNullOrEmpty(tuKhoa))
                sql += " AND sp.MaSanPham LIKE N'%" + tuKhoa.Replace("'", "''") + "%'";

            if (!string.IsNullOrEmpty(ten))
                sql += " AND sp.TenSanPham LIKE N'%" + ten.Replace("'", "''") + "%'";

            sql += " ORDER BY sp.MaSanPham";

            try
            {
                Database.LoadGrid(dgvSanPham, sql);
            }
            catch (Exception error)
            {
                MessageBox.Show("Không thể tìm kiếm sản phẩm: " + error.Message, "Lỗi dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiemSanPham();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            int soDong = 0;
            foreach (DataGridViewRow row in dgvSanPham.Rows)
            {
                if (row == null || row.IsNewRow) continue;
                soDong++;
            }

            if (soDong == 0)
            {
                MessageBox.Show("Không có sản phẩm để xuất Excel.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var dialog = new SaveFileDialog())
            {
                dialog.Title = "Xuất danh sách sản phẩm";
                dialog.Filter = "Tệp Excel (*.xlsx)|*.xlsx";
                dialog.DefaultExt = "xlsx";
                dialog.AddExtension = true;
                dialog.FileName = "DanhSachSanPham_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx";
                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    XuatDanhSachExcel(dialog.FileName);
                }
                catch (Exception error)
                {
                    MessageBox.Show("Không thể xuất Excel: " + error.Message, "Lỗi xuất file",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Đã xuất " + soDong + " sản phẩm ra file Excel.", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void XuatDanhSachExcel(string filePath)
        {
            using (var workbook = new XLWorkbook())
            {
                IXLWorksheet sheet = workbook.Worksheets.Add("Sản phẩm");
                int excelCol = 1;

                foreach (DataGridViewColumn column in dgvSanPham.Columns)
                {
                    if (!column.Visible)
                        continue;

                    IXLCell header = sheet.Cell(1, excelCol);
                    header.Value = column.HeaderText;
                    excelCol++;
                }

                int lastCol = excelCol - 1;
                if (lastCol >= 1)
                {
                    IXLRange headerRange = sheet.Range(1, 1, 1, lastCol);
                    headerRange.Style.Font.Bold = true;
                    headerRange.Style.Font.FontColor = XLColor.White;
                    headerRange.Style.Fill.BackgroundColor = XLColor.FromArgb(27, 75, 107);
                    headerRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    headerRange.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                    sheet.Row(1).Height = 22;
                }

                int excelRow = 2;
                foreach (DataGridViewRow row in dgvSanPham.Rows)
                {
                    if (row == null || row.IsNewRow)
                        continue;

                    excelCol = 1;
                    foreach (DataGridViewColumn column in dgvSanPham.Columns)
                    {
                        if (!column.Visible)
                            continue;

                        GhiOExcel(sheet.Cell(excelRow, excelCol), column, row.Cells[column.Index].Value);
                        excelCol++;
                    }

                    excelRow++;
                }

                DatDoRongCotExcel(sheet);
                sheet.SheetView.FreezeRows(1);
                workbook.SaveAs(filePath);
            }
        }

        private static void GhiOExcel(IXLCell cell, DataGridViewColumn column, object value)
        {
            if (column.Name == "colGiaBan" || column.Name == "colSoLuong")
            {
                decimal num;
                if (value == null || value == DBNull.Value)
                    num = 0;
                else
                    num = Convert.ToDecimal(value);

                cell.Value = num;
                cell.Style.NumberFormat.Format = "#,##0";
                cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
                return;
            }

            cell.Value = value == null || value == DBNull.Value ? string.Empty : Convert.ToString(value);
        }

        private static void DatDoRongCotExcel(IXLWorksheet sheet)
        {
            sheet.Column(1).Width = 18; // Mã
            sheet.Column(2).Width = 36; // Tên
            sheet.Column(3).Width = 20; // Danh mục
            sheet.Column(4).Width = 16; // Giá bán
            sheet.Column(5).Width = 12; // Số lượng
        }
    }
}
