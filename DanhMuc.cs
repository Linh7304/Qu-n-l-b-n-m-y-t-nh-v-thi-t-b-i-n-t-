using System;
using System.Windows.Forms;
using System.Data;
using Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử.Data;

namespace Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử
{
    public partial class DanhMuc : Form
    {
        private string maDangSua;

        public DanhMuc()
        {
            InitializeComponent();
            dgvDanhMuc.CellClick += dgvDanhMuc_CellClick;
            Load += (sender, args) => TaiDanhSach();
        }

        private void dgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string ma = Convert.ToString(dgvDanhMuc.Rows[e.RowIndex].Cells[0].Value);
            try
            {
                DataTable result = Database.Query(
                    "SELECT MaDanhMuc, TenDanhMuc, MoTa FROM dbo.DanhMuc WHERE MaDanhMuc = @Ma",
                    parameters => parameters.Add("@Ma", SqlDbType.NVarChar, 30).Value = ma);
                if (result.Rows.Count == 0)
                {
                    MessageBox.Show("Danh mục này không còn trong database.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LamMoi();
                    return;
                }

                DataRow row = result.Rows[0];
                maDangSua = ma;
                txtMaDanhMuc.Text = ma;
                txtTenDanhMuc.Text = Convert.ToString(row["TenDanhMuc"]);
                txtMoTa.Text = Convert.ToString(row["MoTa"]);
                txtMaDanhMuc.ReadOnly = true;
            }
            catch (Exception error)
            {
                MessageBox.Show("Không thể đọc danh mục: " + error.Message, "Lỗi dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (maDangSua != null)
            {
                return;
            }

            string ma, ten, moTa;
            if (!InputValidation.Required(txtMaDanhMuc, "mã danh mục", 30, out ma)
                || !InputValidation.Required(txtTenDanhMuc, "tên danh mục", 150, out ten)
                || !InputValidation.Optional(txtMoTa, "mô tả", 500, out moTa))
                return;

            try
            {
                Database.Execute(
                    "INSERT INTO dbo.DanhMuc (MaDanhMuc, TenDanhMuc, MoTa) VALUES (@Ma, @Ten, @MoTa)",
                    parameters =>
                    {
                        parameters.Add("@Ma", SqlDbType.NVarChar, 30).Value = ma;
                        parameters.Add("@Ten", SqlDbType.NVarChar, 150).Value = ten;
                        parameters.Add("@MoTa", SqlDbType.NVarChar, 500).Value =
                            moTa.Length == 0 ? (object)DBNull.Value : moTa;
                    });
            }
            catch (Exception error)
            {
                MessageBox.Show(Database.SaveError(error, "danh mục"), "Lỗi lưu dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtMaDanhMuc.Clear();
            txtTenDanhMuc.Clear();
            txtMoTa.Clear();
            TaiDanhSach();
            MessageBox.Show("Đã thêm danh mục.", "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtMaDanhMuc.Focus();
        }

        private void TaiDanhSach()
        {
            try
            {
                Database.LoadGrid(dgvDanhMuc,
                    "SELECT MaDanhMuc, TenDanhMuc, MoTa FROM dbo.DanhMuc ORDER BY MaDanhMuc");
            }
            catch (Exception error)
            {
                MessageBox.Show("Không thể tải danh mục: " + error.Message, "Lỗi dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (maDangSua == null)
            {
                return;
            }

            string ten, moTa;
            if (!InputValidation.Required(txtTenDanhMuc, "tên danh mục", 150, out ten)
                || !InputValidation.Optional(txtMoTa, "mô tả", 500, out moTa))
                return;

            int updated;
            try
            {
                updated = Database.Execute(
                    "UPDATE dbo.DanhMuc SET TenDanhMuc = @Ten, MoTa = @MoTa WHERE MaDanhMuc = @Ma",
                    parameters =>
                    {
                        parameters.Add("@Ma", SqlDbType.NVarChar, 30).Value = maDangSua;
                        parameters.Add("@Ten", SqlDbType.NVarChar, 150).Value = ten;
                        parameters.Add("@MoTa", SqlDbType.NVarChar, 500).Value =
                            moTa.Length == 0 ? (object)DBNull.Value : moTa;
                    });
            }
            catch (Exception error)
            {
                MessageBox.Show(Database.SaveError(error, "danh mục"), "Lỗi sửa dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LamMoi();
            MessageBox.Show(updated == 0 ? "Danh mục đã không còn trong database." : "Đã sửa danh mục.",
                updated == 0 ? "Thông báo" : "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Database.DeleteSelected(dgvDanhMuc, "danh mục",
                "DELETE FROM dbo.DanhMuc WHERE MaDanhMuc = @Ma", LamMoi);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void LamMoi()
        {
            maDangSua = null;
            txtMaDanhMuc.ReadOnly = false;
            txtMaDanhMuc.Clear();
            txtTenDanhMuc.Clear();
            txtMoTa.Clear();
            txtTimMa.Clear();
            txtTimTen.Clear();
            TaiDanhSach();
            txtMaDanhMuc.Focus();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }
    }
}
