using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử.Data
{
    internal static class Database
    {
        internal static int Execute(string sql, Action<SqlParameterCollection> setParameters)
        {
            using (var connection = OpenConnection())
            using (var command = new SqlCommand(sql, connection))
            {
                setParameters(command.Parameters);
                return command.ExecuteNonQuery();
            }
        }

        internal static DataTable Query(string sql, Action<SqlParameterCollection> setParameters = null)
        {
            using (var connection = OpenConnection())
            using (var command = new SqlCommand(sql, connection))
            using (var adapter = new SqlDataAdapter(command))
            {
                if (setParameters != null)
                    setParameters(command.Parameters);

                var result = new DataTable();
                adapter.Fill(result);
                return result;
            }
        }

        internal static void LoadGrid(DataGridView grid, string sql)
        {
            DataTable data = Query(sql);
            if (data.Columns.Count != grid.Columns.Count)
            {
                throw new InvalidOperationException("Số cột dữ liệu không khớp với danh sách hiển thị.");
            }

            grid.Rows.Clear();
            foreach (DataRow row in data.Rows)
            {
                var values = new object[data.Columns.Count];
                for (int index = 0; index < values.Length; index++)
                {
                    values[index] = row.IsNull(index) ? null : row[index];
                }

                grid.Rows.Add(values);
            }

            grid.ClearSelection();
        }

        internal static string SaveError(Exception error, string item)
        {
            var sqlError = error as SqlException;
            if (sqlError != null)
            {
                if (sqlError.Number == 2627 || sqlError.Number == 2601)
                    return "Mã " + item + " đã tồn tại. Hãy nhập mã khác.";

                if (sqlError.Number == 547)
                    return "Dữ liệu liên kết không tồn tại hoặc có giá trị không hợp lệ. Hãy kiểm tra lại thông tin.";
            }

            return "Không thể lưu " + item + ": " + error.Message;
        }

        internal static void DeleteSelected(DataGridView grid, string item, string sql, Action reload)
        {
            if (grid.SelectedRows.Count != 1 || grid.SelectedRows[0].IsNewRow)
            {
                MessageBox.Show("Hãy chọn một " + item + " trong danh sách để xóa.",
                    "Chưa chọn dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                grid.Focus();
                return;
            }

            string code = Convert.ToString(grid.SelectedRows[0].Cells[0].Value);
            if (string.IsNullOrWhiteSpace(code))
            {
                MessageBox.Show("Không tìm thấy mã " + item + " được chọn.",
                    "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa " + item + " có mã " + code + "?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                return;

            int deleted;
            try
            {
                deleted = Execute(sql,
                    parameters => parameters.Add("@Ma", SqlDbType.NVarChar, 30).Value = code);
            }
            catch (SqlException error)
            {
                string message = error.Number == 547
                    ? "Không thể xóa " + item + " vì đang được sử dụng ở dữ liệu khác."
                    : "Không thể xóa " + item + ": " + error.Message;
                MessageBox.Show(message, "Lỗi xóa dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception error)
            {
                MessageBox.Show("Không thể xóa " + item + ": " + error.Message,
                    "Lỗi xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            reload();
            MessageBox.Show(deleted == 0
                    ? "Dữ liệu đã không còn trong database. Danh sách đã được cập nhật."
                    : "Đã xóa " + item + ".",
                deleted == 0 ? "Thông báo" : "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal static SqlConnection OpenConnection()
        {
            ConnectionStringSettings setting = ConfigurationManager.ConnectionStrings["QuanLyBanMayTinh"];

            if (setting == null || string.IsNullOrWhiteSpace(setting.ConnectionString))
            {
                throw new InvalidOperationException("Chưa cấu hình kết nối QuanLyBanMayTinh trong App.config.");
            }

            var connection = new SqlConnection(setting.ConnectionString);
            connection.Open();
            return connection;
        }
    }
}
