
using ClosedXML.Excel;
using Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử.Data;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử
{
    public partial class DonHang : Form
    {
        private string maDonDangSua;

        public DonHang()
        {
            InitializeComponent();

            numThanhTien.Enabled = false;

            numTongTien.ValueChanged += (sender, args) => CapNhatThanhTien();
            numGiamGia.ValueChanged += (sender, args) => CapNhatThanhTien();

            cboTrangThai.SelectedIndex = 0;
            CapNhatThanhTien();

            dgvDonHang.CellClick += dgvDonHang_CellClick;

            // Tìm kiếm bằng phím Enter
            txtTimMaDon.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnTimKiem_Click(s, e);
                    e.SuppressKeyPress = true;
                }
            };

            txtTimKhachHang.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnTimKiem_Click(s, e);
                    e.SuppressKeyPress = true;
                }
            };

            Load += (sender, args) => TaiDanhSach();
        }

        private void dgvDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            string ma = Convert.ToString(
                dgvDonHang.Rows[e.RowIndex].Cells[0].Value);

            try
            {
                DataTable result = Database.Query(
                    "SELECT MaDonHang, KhachHang, SoDienThoai, NgayDat, TongTien, MaGiamGia, " +
                    "GiamGia, TrangThai, GhiChu FROM dbo.DonHang WHERE MaDonHang = @Ma",
                    parameters =>
                        parameters.Add("@Ma", SqlDbType.NVarChar, 30).Value = ma);

                if (result.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Đơn hàng này không còn trong database.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LamMoi();
                    return;
                }

                DataRow row = result.Rows[0];

                txtMaDon.Text = ma;
                txtKhachHang.Text = Convert.ToString(row["KhachHang"]);
                txtSoDienThoai.Text = Convert.ToString(row["SoDienThoai"]);
                dtpNgayDat.Value = ((DateTime)row["NgayDat"]).Date;
                numTongTien.Value = (decimal)row["TongTien"];
                txtMaGiamGia.Text = Convert.ToString(row["MaGiamGia"]);
                numGiamGia.Value = (decimal)row["GiamGia"];
                cboTrangThai.SelectedItem = Convert.ToString(row["TrangThai"]);
                txtGhiChu.Text = Convert.ToString(row["GhiChu"]);

                CapNhatThanhTien();

                maDonDangSua = ma;
                txtMaDon.ReadOnly = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(
                    "Không thể đọc đơn hàng: " + error.Message,
                    "Lỗi dữ liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (maDonDangSua != null)
                return;

            string maDon, khachHang, soDienThoai, maGiamGia, ghiChu;

            if (!InputValidation.Required(txtMaDon, "mã đơn", 30, out maDon)
                || !InputValidation.Required(txtKhachHang, "tên khách hàng", 150, out khachHang)
                || !InputValidation.Optional(txtSoDienThoai, "số điện thoại", 20, out soDienThoai)
                || !InputValidation.Optional(txtMaGiamGia, "mã giảm giá", 30, out maGiamGia)
                || !InputValidation.Optional(txtGhiChu, "ghi chú", 500, out ghiChu))
                return;

            if (numTongTien.Value <= 0)
            {
                InputValidation.Invalid(
                    numTongTien,
                    "Tổng tiền phải lớn hơn 0.");
                return;
            }

            if (numGiamGia.Value > numTongTien.Value)
            {
                InputValidation.Invalid(
                    numGiamGia,
                    "Giảm giá không được lớn hơn tổng tiền.");
                return;
            }

            string trangThai = cboTrangThai.SelectedItem as string;

            if (string.IsNullOrEmpty(trangThai))
            {
                InputValidation.Invalid(
                    cboTrangThai,
                    "Vui lòng chọn trạng thái đơn hàng.");
                return;
            }

            try
            {
                Database.Execute("INSERT INTO dbo.DonHang " +
                    "(MaDonHang, KhachHang, SoDienThoai, NgayDat, TongTien, MaGiamGia, GiamGia, TrangThai, GhiChu) " +
                    "VALUES (@MaDon, @KhachHang, @SoDienThoai, @NgayDat, @TongTien, @MaGiamGia, @GiamGia, @TrangThai, @GhiChu)",// Them ban ghi moi vao bang
                    parameters =>
                    {
                        parameters.Add("@MaDon", SqlDbType.NVarChar, 30).Value = maDon;
                        parameters.Add("@KhachHang", SqlDbType.NVarChar, 150).Value = khachHang;

                        parameters.Add("@SoDienThoai", SqlDbType.NVarChar, 20).Value =
                            soDienThoai.Length == 0
                                ? (object)DBNull.Value
                                : soDienThoai;

                        parameters.Add("@NgayDat", SqlDbType.Date).Value =
                            dtpNgayDat.Value.Date;

                        var total = parameters.Add("@TongTien", SqlDbType.Decimal);
                        total.Precision = 18;
                        total.Scale = 2;
                        total.Value = numTongTien.Value;

                        parameters.Add("@MaGiamGia", SqlDbType.NVarChar, 30).Value =
                            maGiamGia.Length == 0
                                ? (object)DBNull.Value
                                : maGiamGia;

                        var discount = parameters.Add("@GiamGia", SqlDbType.Decimal);
                        discount.Precision = 18;
                        discount.Scale = 2;
                        discount.Value = numGiamGia.Value;

                        parameters.Add("@TrangThai", SqlDbType.NVarChar, 30).Value =
                            trangThai;

                        parameters.Add("@GhiChu", SqlDbType.NVarChar, 500).Value =
                            ghiChu.Length == 0
                                ? (object)DBNull.Value
                                : ghiChu;
                    });
            }
            catch (Exception error)
            {
                MessageBox.Show(
                    Database.SaveError(error, "đơn hàng"),
                    "Lỗi lưu dữ liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            txtMaDon.Clear();
            txtKhachHang.Clear();
            txtSoDienThoai.Clear();
            dtpNgayDat.Value = DateTime.Today;
            numTongTien.Value = 0;
            txtMaGiamGia.Clear();
            numGiamGia.Value = 0;
            cboTrangThai.SelectedIndex = 0;
            txtGhiChu.Clear();

            CapNhatThanhTien();
            TaiDanhSach();

            MessageBox.Show(
                "Đã thêm đơn hàng.",
                "Thành công",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            txtMaDon.Focus();
        }

        private void CapNhatThanhTien()
        {
            numThanhTien.Value = Math.Max(
                0,
                numTongTien.Value - numGiamGia.Value);
        }

        private void TaiDanhSach()
        {
            try
            {
                Database.LoadGrid(
                    dgvDonHang,
                    "SELECT MaDonHang, KhachHang, SoDienThoai, NgayDat, TongTien, " +
                    "GiamGia, ThanhTien, TrangThai FROM dbo.DonHang " +
                    "ORDER BY NgayDat DESC, MaDonHang");
            }
            catch (Exception error)
            {
                MessageBox.Show(
                    "Không thể tải đơn hàng: " + error.Message,
                    "Lỗi dữ liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (maDonDangSua == null)
                return;

            string khachHang, soDienThoai, maGiamGia, ghiChu;

            if (!InputValidation.Required(txtKhachHang, "tên khách hàng", 150, out khachHang)
                || !InputValidation.Optional(txtSoDienThoai, "số điện thoại", 20, out soDienThoai)
                || !InputValidation.Optional(txtMaGiamGia, "mã giảm giá", 30, out maGiamGia)
                || !InputValidation.Optional(txtGhiChu, "ghi chú", 500, out ghiChu))
                return;

            if (numTongTien.Value <= 0)
            {
                InputValidation.Invalid(
                    numTongTien,
                    "Tổng tiền phải lớn hơn 0.");
                return;
            }

            if (numGiamGia.Value > numTongTien.Value)
            {
                InputValidation.Invalid(
                    numGiamGia,
                    "Giảm giá không được lớn hơn tổng tiền.");
                return;
            }

            string trangThai = cboTrangThai.SelectedItem as string;

            if (string.IsNullOrEmpty(trangThai))
            {
                InputValidation.Invalid(
                    cboTrangThai,
                    "Vui lòng chọn trạng thái đơn hàng.");
                return;
            }

            int updated;

            try
            {
                updated = Database.Execute(
                    "UPDATE dbo.DonHang SET KhachHang = @KhachHang, SoDienThoai = @SoDienThoai, " +
                    "NgayDat = @NgayDat, TongTien = @TongTien, MaGiamGia = @MaGiamGia, " +
                    "GiamGia = @GiamGia, TrangThai = @TrangThai, GhiChu = @GhiChu " +
                    "WHERE MaDonHang = @MaDon",
                    parameters =>
                    {
                        parameters.Add("@MaDon", SqlDbType.NVarChar, 30).Value =
                            maDonDangSua;

                        parameters.Add("@KhachHang", SqlDbType.NVarChar, 150).Value =
                            khachHang;

                        parameters.Add("@SoDienThoai", SqlDbType.NVarChar, 20).Value =
                            soDienThoai.Length == 0
                                ? (object)DBNull.Value
                                : soDienThoai;

                        parameters.Add("@NgayDat", SqlDbType.Date).Value =
                            dtpNgayDat.Value.Date;

                        var total = parameters.Add("@TongTien", SqlDbType.Decimal);
                        total.Precision = 18;
                        total.Scale = 2;
                        total.Value = numTongTien.Value;

                        parameters.Add("@MaGiamGia", SqlDbType.NVarChar, 30).Value =
                            maGiamGia.Length == 0
                                ? (object)DBNull.Value
                                : maGiamGia;

                        var discount = parameters.Add("@GiamGia", SqlDbType.Decimal);
                        discount.Precision = 18;
                        discount.Scale = 2;
                        discount.Value = numGiamGia.Value;

                        parameters.Add("@TrangThai", SqlDbType.NVarChar, 30).Value =
                            trangThai;

                        parameters.Add("@GhiChu", SqlDbType.NVarChar, 500).Value =
                            ghiChu.Length == 0
                                ? (object)DBNull.Value
                                : ghiChu;
                    });
            }
            catch (Exception error)
            {
                MessageBox.Show(
                    Database.SaveError(error, "đơn hàng"),
                    "Lỗi sửa dữ liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            LamMoi();

            MessageBox.Show(
                updated == 0
                    ? "Đơn hàng đã không còn trong database."
                    : "Đã sửa đơn hàng.",
                updated == 0 ? "Thông báo" : "Thành công",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Database.DeleteSelected(
                dgvDonHang,
                "đơn hàng",
                "DELETE FROM dbo.DonHang WHERE MaDonHang = @Ma",
                LamMoi);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void LamMoi()
        {
            maDonDangSua = null;
            txtMaDon.ReadOnly = false;

            txtMaDon.Clear();
            txtKhachHang.Clear();
            txtSoDienThoai.Clear();
            dtpNgayDat.Value = DateTime.Today;
            numTongTien.Value = 0;
            txtMaGiamGia.Clear();
            numGiamGia.Value = 0;
            cboTrangThai.SelectedIndex = 0;
            txtGhiChu.Clear();

            txtTimMaDon.Clear();
            txtTimKhachHang.Clear();
            cboTimTrangThai.SelectedIndex = -1;

            CapNhatThanhTien();
            TaiDanhSach();

            txtMaDon.Focus();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maDon = txtTimMaDon.Text.Trim();
            string khachHang = txtTimKhachHang.Text.Trim();
            string trangThai = cboTimTrangThai.SelectedItem as string;

            string sql =
                "SELECT MaDonHang, KhachHang, SoDienThoai, NgayDat, TongTien, " +
                "GiamGia, ThanhTien, TrangThai FROM dbo.DonHang WHERE 1=1";

            if (!string.IsNullOrEmpty(maDon))
            {
                sql += " AND MaDonHang LIKE N'%" +
                    maDon.Replace("'", "''") + "%'";
            }

            if (!string.IsNullOrEmpty(khachHang))
            {
                sql += " AND KhachHang LIKE N'%" +
                    khachHang.Replace("'", "''") + "%'";
            }

            if (!string.IsNullOrEmpty(trangThai) && trangThai != "Tất cả")
            {
                sql += " AND TrangThai = N'" +
                    trangThai.Replace("'", "''") + "'";
            }

            sql += " ORDER BY NgayDat DESC, MaDonHang";

            try
            {
                Database.LoadGrid(dgvDonHang, sql);
            }
            catch (Exception error)
            {
                MessageBox.Show(
                    "Không thể tìm kiếm đơn hàng: " + error.Message,
                    "Lỗi dữ liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (dgvDonHang.Rows.Count == 0 || (dgvDonHang.Rows.Count == 1 && dgvDonHang.Rows[0].IsNewRow))
            {
                MessageBox.Show("Không có đơn hàng để xuất Excel.");
                return;
            }

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "Tệp Excel (*.xlsx)|*.xlsx";
                dialog.FileName = "DanhSachDonHang.xlsx";

                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    XuatExcel(dialog.FileName);
                    MessageBox.Show("Xuất Excel thành công.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        private void XuatExcel(string filePath)
        {
            using (var workbook = new XLWorkbook())
            {
                var sheet = workbook.Worksheets.Add("Đơn hàng");

                // Ghi tiêu đề cột
                for (int i = 0; i < dgvDonHang.Columns.Count; i++)
                {
                    if (dgvDonHang.Columns[i].Visible)
                        sheet.Cell(1, i + 1).Value =
                            dgvDonHang.Columns[i].HeaderText;
                }

                // Ghi dữ liệu
                int dong = 2;

                foreach (DataGridViewRow row in dgvDonHang.Rows)
                {
                    if (row.IsNewRow ||
                        string.IsNullOrWhiteSpace(Convert.ToString(row.Cells[0].Value)))
                        continue;

                    int cot = 1;

                    foreach (DataGridViewColumn column in dgvDonHang.Columns)
                    {
                        if (!column.Visible)  continue;

                        sheet.Cell(dong, cot).Value =  Convert.ToString(row.Cells[column.Index].Value);

                        cot++;
                    }

                    dong++;
                }

                // Định dạng tiêu đề
                var tieuDe = sheet.Range(1, 1, 1, sheet.ColumnsUsed().Count()); 
                tieuDe.Style.Font.Bold = true; 
                tieuDe.Style.Font.FontColor = XLColor.White;
                tieuDe.Style.Fill.BackgroundColor = XLColor.FromArgb(27, 75, 107);
                tieuDe.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                sheet.ColumnsUsed().AdjustToContents();
                sheet.SheetView.FreezeRows(1);
                workbook.SaveAs(filePath);
            }
        }
    }
}
