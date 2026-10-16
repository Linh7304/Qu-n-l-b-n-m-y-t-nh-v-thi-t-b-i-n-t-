using System;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            int soDong = 0;
            foreach (DataGridViewRow row in dgvThongKe.Rows)
            {
                if (row == null || row.IsNewRow) continue;
                soDong++;
            }

            if (soDong == 0)
            {
                MessageBox.Show("Không có dữ liệu thống kê để xuất Excel.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var dialog = new SaveFileDialog())
            {
                dialog.Title = "Xuất thống kê doanh thu";
                dialog.Filter = "Tệp Excel (*.xlsx)|*.xlsx";
                dialog.DefaultExt = "xlsx";
                dialog.AddExtension = true;
                dialog.FileName = "ThongKeDoanhThu_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx";
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

                MessageBox.Show("Đã xuất " + soDong + " dòng thống kê ra file Excel.", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void XuatDanhSachExcel(string filePath)
        {
            using (var workbook = new XLWorkbook())
            {
                IXLWorksheet sheet = workbook.Worksheets.Add("Thống kê");
                int excelCol = 1;

                foreach (DataGridViewColumn column in dgvThongKe.Columns)
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
                foreach (DataGridViewRow row in dgvThongKe.Rows)
                {
                    if (row == null || row.IsNewRow)
                        continue;

                    excelCol = 1;
                    foreach (DataGridViewColumn column in dgvThongKe.Columns)
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
            if (column.Name == "colNgay")
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

            if (column.Name == "colDoanhThu" || column.Name == "colSoDon" || column.Name == "colHoanThanh" || column.Name == "colDaHuy")
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

    }
}