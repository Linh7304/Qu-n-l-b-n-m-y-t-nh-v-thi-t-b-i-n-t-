using System;
using System.Windows.Forms;
using System.Data;
using ClosedXML.Excel;
using Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử.Data;

namespace Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử
{
    public partial class MaGiamGia : Form
    {
        private string maDangSua;

        public MaGiamGia()
        {
            InitializeComponent();
            dgvMaGiamGia.CellClick += dgvMaGiamGia_CellClick;
            btnTimKiem.Click += btnTimKiem_Click;
            txtTimMa.KeyDown += (s, e) => { if (e.KeyCode == System.Windows.Forms.Keys.Enter) TimKiemMaGiamGia(); };
            txtTimTen.KeyDown += (s, e) => { if (e.KeyCode == System.Windows.Forms.Keys.Enter) TimKiemMaGiamGia(); };
            Load += (sender, args) => TaiDanhSach();
        }

        private void dgvMaGiamGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string ma = Convert.ToString(dgvMaGiamGia.Rows[e.RowIndex].Cells[0].Value);
            try
            {
                DataTable result = Database.Query(
                    "SELECT MaGiamGia, TenChuongTrinh, LoaiGiam, GiaTriGiam, DonToiThieu, " +
                    "GiamToiDa, NgayBatDau, NgayKetThuc, SoLuong, TrangThai, GhiChu " +
                    "FROM dbo.MaGiamGia WHERE MaGiamGia = @Ma",
                    parameters => parameters.Add("@Ma", SqlDbType.NVarChar, 30).Value = ma);
                if (result.Rows.Count == 0)
                {
                    MessageBox.Show("Mã giảm giá này không còn trong database.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LamMoi();
                    return;
                }

                DataRow row = result.Rows[0];
                txtMaGiamGia.Text = ma;
                txtTenChuongTrinh.Text = Convert.ToString(row["TenChuongTrinh"]);
                cboLoaiGiam.SelectedItem = Convert.ToString(row["LoaiGiam"]);
                numGiaTriGiam.Value = (decimal)row["GiaTriGiam"];
                numDonToiThieu.Value = (decimal)row["DonToiThieu"];
                numGiamToiDa.Value = row.IsNull("GiamToiDa") ? 0 : (decimal)row["GiamToiDa"];
                dtpNgayBatDau.Value = ((DateTime)row["NgayBatDau"]).Date;
                dtpNgayKetThuc.Value = ((DateTime)row["NgayKetThuc"]).Date;
                numSoLuong.Value = (int)row["SoLuong"];
                cboTrangThai.SelectedItem = Convert.ToString(row["TrangThai"]);
                txtGhiChu.Text = Convert.ToString(row["GhiChu"]);
                maDangSua = ma;
                txtMaGiamGia.ReadOnly = true;
            }
            catch (Exception error)
            {
                MessageBox.Show("Không thể đọc mã giảm giá: " + error.Message, "Lỗi dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (maDangSua != null)
            {
                return;
            }

            string ma, ten, ghiChu;
            if (!InputValidation.Required(txtMaGiamGia, "mã giảm giá", 30, out ma)
                || !InputValidation.Required(txtTenChuongTrinh, "tên chương trình", 200, out ten)
                || !InputValidation.Optional(txtGhiChu, "ghi chú", 500, out ghiChu))
                return;

            string loaiGiam = cboLoaiGiam.SelectedItem as string;
            if (string.IsNullOrEmpty(loaiGiam))
            {
                InputValidation.Invalid(cboLoaiGiam, "Vui lòng chọn loại giảm giá.");
                return;
            }

            decimal giaTri = numGiaTriGiam.Value;
            if (giaTri <= 0 || (loaiGiam == "Phần trăm" && giaTri > 100))
            {
                InputValidation.Invalid(numGiaTriGiam,
                    loaiGiam == "Phần trăm" ? "Giá trị giảm phải từ 1 đến 100%." : "Giá trị giảm phải lớn hơn 0.");
                return;
            }

            if (dtpNgayKetThuc.Value.Date < dtpNgayBatDau.Value.Date)
            {
                InputValidation.Invalid(dtpNgayKetThuc, "Ngày kết thúc không được trước ngày bắt đầu.");
                return;
            }

            if (numSoLuong.Value <= 0)
            {
                InputValidation.Invalid(numSoLuong, "Số lượng mã phải lớn hơn 0.");
                return;
            }

            string trangThai = cboTrangThai.SelectedItem as string;
            if (string.IsNullOrEmpty(trangThai))
            {
                InputValidation.Invalid(cboTrangThai, "Vui lòng chọn trạng thái.");
                return;
            }

            try
            {
                Database.Execute(
                    "INSERT INTO dbo.MaGiamGia " +
                    "(MaGiamGia, TenChuongTrinh, LoaiGiam, GiaTriGiam, DonToiThieu, GiamToiDa, " +
                    "NgayBatDau, NgayKetThuc, SoLuong, TrangThai, GhiChu) " +
                    "VALUES (@Ma, @Ten, @Loai, @GiaTri, @DonToiThieu, @GiamToiDa, " +
                    "@NgayBatDau, @NgayKetThuc, @SoLuong, @TrangThai, @GhiChu)",
                    parameters =>
                    {
                        parameters.Add("@Ma", SqlDbType.NVarChar, 30).Value = ma;
                        parameters.Add("@Ten", SqlDbType.NVarChar, 200).Value = ten;
                        parameters.Add("@Loai", SqlDbType.NVarChar, 20).Value = loaiGiam;
                        var value = parameters.Add("@GiaTri", SqlDbType.Decimal);
                        value.Precision = 18;
                        value.Scale = 2;
                        value.Value = giaTri;
                        var minimum = parameters.Add("@DonToiThieu", SqlDbType.Decimal);
                        minimum.Precision = 18;
                        minimum.Scale = 2;
                        minimum.Value = numDonToiThieu.Value;
                        var maximum = parameters.Add("@GiamToiDa", SqlDbType.Decimal);
                        maximum.Precision = 18;
                        maximum.Scale = 2;
                        maximum.Value = numGiamToiDa.Value == 0
                            ? (object)DBNull.Value : numGiamToiDa.Value;
                        parameters.Add("@NgayBatDau", SqlDbType.Date).Value = dtpNgayBatDau.Value.Date;
                        parameters.Add("@NgayKetThuc", SqlDbType.Date).Value = dtpNgayKetThuc.Value.Date;
                        parameters.Add("@SoLuong", SqlDbType.Int).Value = (int)numSoLuong.Value;
                        parameters.Add("@TrangThai", SqlDbType.NVarChar, 30).Value = trangThai;
                        parameters.Add("@GhiChu", SqlDbType.NVarChar, 500).Value =
                            ghiChu.Length == 0 ? (object)DBNull.Value : ghiChu;
                    });
            }
            catch (Exception error)
            {
                MessageBox.Show(Database.SaveError(error, "mã giảm giá"), "Lỗi lưu dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtMaGiamGia.Clear();
            txtTenChuongTrinh.Clear();
            cboLoaiGiam.SelectedIndex = -1;
            numGiaTriGiam.Value = 0;
            numDonToiThieu.Value = 0;
            numGiamToiDa.Value = 0;
            dtpNgayBatDau.Value = DateTime.Today;
            dtpNgayKetThuc.Value = DateTime.Today;
            numSoLuong.Value = 0;
            cboTrangThai.SelectedIndex = -1;
            txtGhiChu.Clear();
            TaiDanhSach();
            MessageBox.Show("Đã thêm mã giảm giá.", "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtMaGiamGia.Focus();
        }

        private void TaiDanhSach()
        {
            try
            {
                Database.LoadGrid(dgvMaGiamGia,
                    "SELECT MaGiamGia, TenChuongTrinh, LoaiGiam, GiaTriGiam, DonToiThieu, " +
                    "GiamToiDa, NgayBatDau, NgayKetThuc, SoLuong, TrangThai " +
                    "FROM dbo.MaGiamGia ORDER BY MaGiamGia");
            }
            catch (Exception error)
            {
                MessageBox.Show("Không thể tải mã giảm giá: " + error.Message, "Lỗi dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (maDangSua == null)
            {
                return;
            }

            string ten, ghiChu;
            if (!InputValidation.Required(txtTenChuongTrinh, "tên chương trình", 200, out ten)
                || !InputValidation.Optional(txtGhiChu, "ghi chú", 500, out ghiChu))
                return;

            string loaiGiam = cboLoaiGiam.SelectedItem as string;
            if (string.IsNullOrEmpty(loaiGiam))
            {
                InputValidation.Invalid(cboLoaiGiam, "Vui lòng chọn loại giảm giá.");
                return;
            }

            decimal giaTri = numGiaTriGiam.Value;
            if (giaTri <= 0 || (loaiGiam == "Phần trăm" && giaTri > 100))
            {
                InputValidation.Invalid(numGiaTriGiam,
                    loaiGiam == "Phần trăm" ? "Giá trị giảm phải từ 1 đến 100%." : "Giá trị giảm phải lớn hơn 0.");
                return;
            }

            if (dtpNgayKetThuc.Value.Date < dtpNgayBatDau.Value.Date)
            {
                InputValidation.Invalid(dtpNgayKetThuc, "Ngày kết thúc không được trước ngày bắt đầu.");
                return;
            }

            if (numSoLuong.Value <= 0)
            {
                InputValidation.Invalid(numSoLuong, "Số lượng mã phải lớn hơn 0.");
                return;
            }

            string trangThai = cboTrangThai.SelectedItem as string;
            if (string.IsNullOrEmpty(trangThai))
            {
                InputValidation.Invalid(cboTrangThai, "Vui lòng chọn trạng thái.");
                return;
            }

            int updated;
            try
            {
                updated = Database.Execute(
                    "UPDATE dbo.MaGiamGia SET TenChuongTrinh = @Ten, LoaiGiam = @Loai, " +
                    "GiaTriGiam = @GiaTri, DonToiThieu = @DonToiThieu, GiamToiDa = @GiamToiDa, " +
                    "NgayBatDau = @NgayBatDau, NgayKetThuc = @NgayKetThuc, SoLuong = @SoLuong, " +
                    "TrangThai = @TrangThai, GhiChu = @GhiChu WHERE MaGiamGia = @Ma",
                    parameters =>
                    {
                        parameters.Add("@Ma", SqlDbType.NVarChar, 30).Value = maDangSua;
                        parameters.Add("@Ten", SqlDbType.NVarChar, 200).Value = ten;
                        parameters.Add("@Loai", SqlDbType.NVarChar, 20).Value = loaiGiam;
                        var value = parameters.Add("@GiaTri", SqlDbType.Decimal);
                        value.Precision = 18;
                        value.Scale = 2;
                        value.Value = giaTri;
                        var minimum = parameters.Add("@DonToiThieu", SqlDbType.Decimal);
                        minimum.Precision = 18;
                        minimum.Scale = 2;
                        minimum.Value = numDonToiThieu.Value;
                        var maximum = parameters.Add("@GiamToiDa", SqlDbType.Decimal);
                        maximum.Precision = 18;
                        maximum.Scale = 2;
                        maximum.Value = numGiamToiDa.Value == 0
                            ? (object)DBNull.Value : numGiamToiDa.Value;
                        parameters.Add("@NgayBatDau", SqlDbType.Date).Value = dtpNgayBatDau.Value.Date;
                        parameters.Add("@NgayKetThuc", SqlDbType.Date).Value = dtpNgayKetThuc.Value.Date;
                        parameters.Add("@SoLuong", SqlDbType.Int).Value = (int)numSoLuong.Value;
                        parameters.Add("@TrangThai", SqlDbType.NVarChar, 30).Value = trangThai;
                        parameters.Add("@GhiChu", SqlDbType.NVarChar, 500).Value =
                            ghiChu.Length == 0 ? (object)DBNull.Value : ghiChu;
                    });
            }
            catch (Exception error)
            {
                MessageBox.Show(Database.SaveError(error, "mã giảm giá"), "Lỗi sửa dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LamMoi();
            MessageBox.Show(updated == 0 ? "Mã giảm giá đã không còn trong database." : "Đã sửa mã giảm giá.",
                updated == 0 ? "Thông báo" : "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Database.DeleteSelected(dgvMaGiamGia, "mã giảm giá",
                "DELETE FROM dbo.MaGiamGia WHERE MaGiamGia = @Ma", LamMoi);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void LamMoi()
        {
            maDangSua = null;
            txtMaGiamGia.ReadOnly = false;
            txtMaGiamGia.Clear();
            txtTenChuongTrinh.Clear();
            cboLoaiGiam.SelectedIndex = -1;
            numGiaTriGiam.Value = 0;
            numDonToiThieu.Value = 0;
            numGiamToiDa.Value = 0;
            dtpNgayBatDau.Value = DateTime.Today;
            dtpNgayKetThuc.Value = DateTime.Today;
            numSoLuong.Value = 0;
            cboTrangThai.SelectedIndex = -1;
            txtGhiChu.Clear();
            txtTimMa.Clear();
            txtTimTen.Clear();
            cboTimTrangThai.SelectedIndex = -1;
            TaiDanhSach();
            txtMaGiamGia.Focus();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiemMaGiamGia();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            int soDong = 0;
            foreach (DataGridViewRow row in dgvMaGiamGia.Rows)
            {
                if (row == null || row.IsNewRow) continue;
                soDong++;
            }

            if (soDong == 0)
            {
                MessageBox.Show("Không có mã giảm giá để xuất Excel.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var dialog = new SaveFileDialog())
            {
                dialog.Title = "Xuất danh sách mã giảm giá";
                dialog.Filter = "Tệp Excel (*.xlsx)|*.xlsx";
                dialog.DefaultExt = "xlsx";
                dialog.AddExtension = true;
                dialog.FileName = "DanhSachMaGiamGia_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx";
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

                MessageBox.Show("Đã xuất " + soDong + " mã giảm giá ra file Excel.", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void XuatDanhSachExcel(string filePath)
        {
            using (var workbook = new XLWorkbook())
            {
                IXLWorksheet sheet = workbook.Worksheets.Add("Mã giảm giá");
                int excelCol = 1;

                foreach (DataGridViewColumn column in dgvMaGiamGia.Columns)
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
                foreach (DataGridViewRow row in dgvMaGiamGia.Rows)
                {
                    if (row == null || row.IsNewRow)
                        continue;

                    excelCol = 1;
                    foreach (DataGridViewColumn column in dgvMaGiamGia.Columns)
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
            if (column.Name == "colNgayBatDau" || column.Name == "colNgayKetThuc")
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

            if (column.Name == "colGiaTriGiam" || column.Name == "colDonToiThieu" || column.Name == "colGiamToiDa" || column.Name == "colSoLuong")
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

        private void TimKiemMaGiamGia()
        {
            string ma = txtTimMa.Text.Trim();
            string ten = txtTimTen.Text.Trim();
            string trangThai = cboTimTrangThai.SelectedItem as string;

            string sql =
                "SELECT MaGiamGia, TenChuongTrinh, LoaiGiam, GiaTriGiam, DonToiThieu, " +
                "GiamToiDa, NgayBatDau, NgayKetThuc, SoLuong, TrangThai " +
                "FROM dbo.MaGiamGia WHERE 1=1";

            if (!string.IsNullOrEmpty(ma))
                sql += " AND MaGiamGia LIKE N'%" + ma.Replace("'", "''") + "%'";

            if (!string.IsNullOrEmpty(ten))
                sql += " AND TenChuongTrinh LIKE N'%" + ten.Replace("'", "''") + "%'";

            if (!string.IsNullOrEmpty(trangThai) && trangThai != "Tất cả")
                sql += " AND TrangThai = N'" + trangThai.Replace("'", "''") + "'";

            sql += " ORDER BY MaGiamGia";

            try
            {
                Database.LoadGrid(dgvMaGiamGia, sql);
            }
            catch (Exception error)
            {
                MessageBox.Show("Không thể tìm kiếm mã giảm giá: " + error.Message, "Lỗi dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
