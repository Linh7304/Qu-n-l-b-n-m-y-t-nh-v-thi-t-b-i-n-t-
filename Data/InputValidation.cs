using System.Globalization;
using System.Windows.Forms;

namespace Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử.Data
{
    internal static class InputValidation
    {
        internal static bool Required(TextBox box, string label, int maxLength, out string value)
        {
            value = box.Text.Trim();
            if (value.Length == 0)
                return Invalid(box, "Vui lòng nhập " + label + ".");

            if (value.Length > maxLength)
                return Invalid(box, label + " tối đa " + maxLength + " ký tự.");

            return true;
        }

        internal static bool Optional(TextBox box, string label, int maxLength, out string value)
        {
            value = box.Text.Trim();
            return value.Length <= maxLength || Invalid(box, label + " tối đa " + maxLength + " ký tự.");
        }

        internal static bool NonNegativeInt(TextBox box, string label, out int value)
        {
            if (int.TryParse(box.Text.Trim(), out value) && value >= 0)
                return true;

            return Invalid(box, label + " phải là số nguyên không âm.");
        }

        internal static bool NonNegativeMoney(TextBox box, string label, out decimal value)
        {
            if (decimal.TryParse(box.Text.Trim(), NumberStyles.Number, CultureInfo.CurrentCulture, out value)
                && value >= 0 && decimal.Round(value, 2) == value)
                return true;

            return Invalid(box, label + " phải là số không âm, tối đa hai chữ số thập phân.");
        }

        internal static bool Invalid(Control control, string message)
        {
            MessageBox.Show(message, "Kiểm tra dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            control.Focus();
            return false;
        }
    }
}
