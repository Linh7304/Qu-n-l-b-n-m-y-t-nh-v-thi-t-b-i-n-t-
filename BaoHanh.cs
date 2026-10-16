using System;
using System.Windows.Forms;
using System.Data;
using ClosedXML.Excel;
using Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử.Data;

namespace Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử
{
    public partial class BaoHanh : Form
    {
        private string maPhieuDangSua;

        public BaoHanh()
        {
            InitializeComponent();
            dtpNgayHetHan.Enabled = false;
            cboTrangThai.Enabled = false;
            dtpNgayMua.ValueChanged += (sender, args) => CapNhatNgayHetHan();
            numThoiHan.ValueChanged += (sender, args) => CapNhatNgayHetHan();
            CapNhatNgayHetHan();
            dgvBaoHanh.CellClick += dgvBaoHanh_CellClick;
            btnTimKiem.Click += btnTimKiem_Click;
            txtTimMaPhieu.KeyDown += (s, e) => { if (e.KeyCode == System.Windows.Forms.Keys.Enter) TimKiemBaoHanh(); };
            txtTimMaSanPham.KeyDown += (s, e) => { if (e.KeyCode == System.Windows.Forms.Keys.Enter) TimKiemBaoHanh(); };
            txtTimKhachHang.KeyDown += (s, e) => { if (e.KeyCode == System.Windows.Forms.Keys.Enter) TimKiemBaoHanh(); };
            Load += (sender, args) => TaiDanhSach();
        }

        private void dgvBaoHanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string ma = Convert.ToString(dgvBaoHanh.Rows[e.RowIndex].Cells[0].Value);
            try
            {
                DataTable result = Database.Query(
                    "SELECT MaPhieu, MaSanPham, TenKhachHang, SoDienThoai, NgayMua, ThoiHan, GhiChu " +
                    "FROM dbo.BaoHanh WHERE MaPhieu = @Ma",
                    parameters => parameters.Add("@Ma", SqlDbType.NVarChar, 30).Value = ma);
                if (result.Rows.Count == 0)
                {
                    MessageBox.Show("Phiếu bảo hành này không còn trong database.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LamMoi();
                    return;
                }

                DataRow row = result.Rows[0];
                maPhieuDangSua = ma;
                txtMaPhieu.Text = ma;
                txtMaSanPham.Text = Convert.ToString(row["MaSanPham"]);
                txtTenKhachHang.Text = Convert.ToString(row["TenKhachHang"]);
                txtSoDienThoai.Text = Convert.ToString(row["SoDienThoai"]);
                dtpNgayMua.Value = ((DateTime)row["NgayMua"]).Date;
                numThoiHan.Value = (int)row["ThoiHan"];
                txtGhiChu.Text = Convert.ToString(row["GhiChu"]);
                CapNhatNgayHetHan();
                txtMaPhieu.ReadOnly = true;
            }
            catch (Exception error)
            {
                MessageBox.Show("Không thể đọc phiếu bảo hành: " + error.Message, "Lỗi dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (maPhieuDangSua != null)
            {
                return;
            }

            string maPhieu, maSanPham, khachHang, soDienThoai, ghiChu;
            if (!InputValidation.Required(txtMaPhieu, "mã phiếu", 30, out maPhieu)
                || !InputValidation.Required(txtMaSanPham, "mã sản phẩm", 30, out maSanPham)
                || !InputValidation.Required(txtTenKhachHang, "tên khách hàng", 150, out khachHang)
                || !InputValidation.Optional(txtSoDienThoai, "số điện thoại", 20, out soDienThoai)
                || !InputValidation.Optional(txtGhiChu, "ghi chú", 500, out ghiChu))
                return;

            DateTime ngayMua = dtpNgayMua.Value.Date;
            int thoiHan = (int)numThoiHan.Value;
            DateTime ngayHetHan = ngayMua.AddMonths(thoiHan);

            try
            {
                Database.Execute(
                    "INSERT INTO dbo.BaoHanh " +
                    "(MaPhieu, MaSanPham, TenKhachHang, SoDienThoai, NgayMua, ThoiHan, NgayHetHan, GhiChu) " +
                    "VALUES (@MaPhieu, @MaSanPham, @KhachHang, @SoDienThoai, @NgayMua, @ThoiHan, @NgayHetHan, @GhiChu)",
                    parameters =>
                    {
                        parameters.Add("@MaPhieu", SqlDbType.NVarChar, 30).Value = maPhieu;
                        parameters.Add("@MaSanPham", SqlDbType.NVarChar, 30).Value = maSanPham;
                        parameters.Add("@KhachHang", SqlDbType.NVarChar, 150).Value = khachHang;
                        parameters.Add("@SoDienThoai", SqlDbType.NVarChar, 20).Value =
                            soDienThoai.Length == 0 ? (object)DBNull.Value : soDienThoai;
                        parameters.Add("@NgayMua", SqlDbType.Date).Value = ngayMua;
                        parameters.Add("@ThoiHan", SqlDbType.Int).Value = thoiHan;
                        parameters.Add("@NgayHetHan", SqlDbType.Date).Value = ngayHetHan;
                        parameters.Add("@GhiChu", SqlDbType.NVarChar, 500).Value =
                            ghiChu.Length == 0 ? (object)DBNull.Value : ghiChu;
                    });
            }
            catch (Exception error)
            {
                MessageBox.Show(Database.SaveError(error, "phiếu bảo hành"), "Lỗi lưu dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtMaPhieu.Clear();
            txtMaSanPham.Clear();
            txtTenKhachHang.Clear();
            txtSoDienThoai.Clear();
            txtGhiChu.Clear();
            dtpNgayMua.Value = DateTime.Today;
            numThoiHan.Value = 12;
            CapNhatNgayHetHan();
            TaiDanhSach();
            MessageBox.Show("Đã thêm phiếu bảo hành.", "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtMaPhieu.Focus();
        }

        private void CapNhatNgayHetHan()
        {
            DateTime ngayHetHan = dtpNgayMua.Value.Date.AddMonths((int)numThoiHan.Value);
            dtpNgayHetHan.Value = ngayHetHan;
            cboTrangThai.SelectedItem = ngayHetHan >= DateTime.Today
                ? "Còn bảo hành" : "Hết bảo hành";
        }

        private void TaiDanhSach()
        {
            try
            {
                Database.LoadGrid(dgvBaoHanh,
                    "SELECT MaPhieu, MaSanPham, TenKhachHang, SoDienThoai, " +
                    "NgayMua, ThoiHan, NgayHetHan, TrangThai " +
                    "FROM dbo.vwBaoHanh ORDER BY MaPhieu");
            }
            catch (Exception error)
            {
                MessageBox.Show("Không thể tải phiếu bảo hành: " + error.Message, "Lỗi dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (maPhieuDangSua == null)
            {
                return;
            }

            string maSanPham, khachHang, soDienThoai, ghiChu;
            if (!InputValidation.Required(txtMaSanPham, "mã sản phẩm", 30, out maSanPham)
                || !InputValidation.Required(txtTenKhachHang, "tên khách hàng", 150, out khachHang)
                || !InputValidation.Optional(txtSoDienThoai, "số điện thoại", 20, out soDienThoai)
                || !InputValidation.Optional(txtGhiChu, "ghi chú", 500, out ghiChu))
                return;

            DateTime ngayMua = dtpNgayMua.Value.Date;
            int thoiHan = (int)numThoiHan.Value;
            DateTime ngayHetHan = ngayMua.AddMonths(thoiHan);
            int updated;
            try
            {
                updated = Database.Execute(
                    "UPDATE dbo.BaoHanh SET MaSanPham = @MaSanPham, TenKhachHang = @KhachHang, " +
                    "SoDienThoai = @SoDienThoai, NgayMua = @NgayMua, ThoiHan = @ThoiHan, " +
                    "NgayHetHan = @NgayHetHan, GhiChu = @GhiChu WHERE MaPhieu = @MaPhieu",
                    parameters =>
                    {
                        parameters.Add("@MaPhieu", SqlDbType.NVarChar, 30).Value = maPhieuDangSua;
                        parameters.Add("@MaSanPham", SqlDbType.NVarChar, 30).Value = maSanPham;
                        parameters.Add("@KhachHang", SqlDbType.NVarChar, 150).Value = khachHang;
                        parameters.Add("@SoDienThoai", SqlDbType.NVarChar, 20).Value =
                            soDienThoai.Length == 0 ? (object)DBNull.Value : soDienThoai;
                        parameters.Add("@NgayMua", SqlDbType.Date).Value = ngayMua;
                        parameters.Add("@ThoiHan", SqlDbType.Int).Value = thoiHan;
                        parameters.Add("@NgayHetHan", SqlDbType.Date).Value = ngayHetHan;
                        parameters.Add("@GhiChu", SqlDbType.NVarChar, 500).Value =
                            ghiChu.Length == 0 ? (object)DBNull.Value : ghiChu;
                    });
            }
            catch (Exception error)
            {
                MessageBox.Show(Database.SaveError(error, "phiếu bảo hành"), "Lỗi sửa dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LamMoi();
            MessageBox.Show(updated == 0 ? "Phiếu bảo hành đã không còn trong database." : "Đã sửa phiếu bảo hành.",
                updated == 0 ? "Thông báo" : "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Database.DeleteSelected(dgvBaoHanh, "phiếu bảo hành",
                "DELETE FROM dbo.BaoHanh WHERE MaPhieu = @Ma", LamMoi);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            int soDong = 0;
            foreach (DataGridViewRow row in dgvBaoHanh.Rows)
            {
                if (row == null || row.IsNewRow) continue;
                soDong++;
            }

            if (soDong == 0)
            {
                MessageBox.Show("Không có phiếu bảo hành để xuất Excel.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var dialog = new SaveFileDialog())
            {
                dialog.Title = "Xuất danh sách phiếu bảo hành";
                dialog.Filter = "Tệp Excel (*.xlsx)|*.xlsx";
                dialog.DefaultExt = "xlsx";
                dialog.AddExtension = true;
                dialog.FileName = "DanhSachPhieuBaoHanh_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx";
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

                MessageBox.Show("Đã xuất " + soDong + " phiếu bảo hành ra file Excel.", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void XuatDanhSachExcel(string filePath)
        {
            using (var workbook = new XLWorkbook())
            {
                IXLWorksheet sheet = workbook.Worksheets.Add("Phiếu bảo hành");
                int excelCol = 1;

                foreach (DataGridViewColumn column in dgvBaoHanh.Columns)
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
                foreach (DataGridViewRow row in dgvBaoHanh.Rows)
                {
                    if (row == null || row.IsNewRow)
                        continue;

                    excelCol = 1;
                    foreach (DataGridViewColumn column in dgvBaoHanh.Columns)
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
            if (column.Name == "colNgayMua" || column.Name == "colNgayHetHan")
            {
                DateTime dt;
                if (value is DateTime)
                {
                    cell.Value = ((DateTime)value).Date;
                }
                else if (value != null && DateTime.TryParse(Convert.ToString(value), out dt))
                {
                    cell.Value = dt.Date;
                }
                else
                {
                    cell.Value = Convert.ToString(value);
                }

                cell.Style.DateFormat.Format = "dd/MM/yyyy";
                cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                return;
            }

            if (column.Name == "colThoiHan")
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
            sheet.Columns().AdjustToContents();
        }


        private void LamMoi()
        {
            maPhieuDangSua = null;
            txtMaPhieu.ReadOnly = false;
            txtMaPhieu.Clear();
            txtMaSanPham.Clear();
            txtTenKhachHang.Clear();
            txtSoDienThoai.Clear();
            dtpNgayMua.Value = DateTime.Today;
            numThoiHan.Value = 12;
            txtGhiChu.Clear();
            txtTimMaPhieu.Clear();
            txtTimMaSanPham.Clear();
            txtTimKhachHang.Clear();
            CapNhatNgayHetHan();
            TaiDanhSach();
            txtMaPhieu.Focus();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiemBaoHanh();
        }

        private void TimKiemBaoHanh()
        {
            string maPhieu = txtTimMaPhieu.Text.Trim();
            string maSanPham = txtTimMaSanPham.Text.Trim();
            string khachHang = txtTimKhachHang.Text.Trim();

            string sql =
                "SELECT MaPhieu, MaSanPham, TenKhachHang, SoDienThoai, " +
                "NgayMua, ThoiHan, NgayHetHan, TrangThai " +
                "FROM dbo.vwBaoHanh WHERE 1=1";

            if (!string.IsNullOrEmpty(maPhieu))
                sql += " AND MaPhieu LIKE N'%" + maPhieu.Replace("'", "''") + "%'";

            if (!string.IsNullOrEmpty(maSanPham))
                sql += " AND MaSanPham LIKE N'%" + maSanPham.Replace("'", "''") + "%'";

            if (!string.IsNullOrEmpty(khachHang))
                sql += " AND TenKhachHang LIKE N'%" + khachHang.Replace("'", "''") + "%'";

            sql += " ORDER BY MaPhieu";

            try
            {
                Database.LoadGrid(dgvBaoHanh, sql);
            }
            catch (Exception error)
            {
                MessageBox.Show("Không thể tìm kiếm phiếu bảo hành: " + error.Message, "Lỗi dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
