using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new QuanLyBanMayTinh());
        }
    }

    public class RoundedButton : Button
    {
        private int borderRadius = 20;
        private bool isHovered;
        private bool isPressed;

        public RoundedButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            UseVisualStyleBackColor = false;
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.UserPaint |
                     ControlStyles.ResizeRedraw, true);
        }

        [Category("Appearance")]
        [DefaultValue(20)]
        [Description("Độ bo góc của nút.")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = Math.Max(0, value);
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.Clear(Parent != null ? Parent.BackColor : SystemColors.Control);

            Rectangle bounds = new Rectangle(0, 0, Width - 1, Height - 1);
            if (bounds.Width <= 0 || bounds.Height <= 0) return;

            using (GraphicsPath path = CreateRoundedPath(bounds))
            using (SolidBrush brush = new SolidBrush(GetFillColor()))
            {
                graphics.FillPath(brush, path);
            }

            if (Image == null)
            {
                TextRenderer.DrawText(graphics, Text, Font, bounds, Enabled ? ForeColor : SystemColors.GrayText,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter |
                    TextFormatFlags.SingleLine | TextFormatFlags.NoPadding);
                return;
            }

            Size textSize = TextRenderer.MeasureText(graphics, Text, Font,
                new Size(bounds.Width, bounds.Height), TextFormatFlags.SingleLine | TextFormatFlags.NoPadding);
            int gap = string.IsNullOrEmpty(Text) ? 0 : 8;
            int contentWidth = Image.Width + gap + textSize.Width;
            int x = Math.Max(0, (Width - contentWidth) / 2);
            graphics.DrawImage(Image, x, (Height - Image.Height) / 2, Image.Width, Image.Height);
            Rectangle textBounds = new Rectangle(x + Image.Width + gap, 0,
                Math.Max(0, Width - x - Image.Width - gap), Height);
            TextRenderer.DrawText(graphics, Text, Font, textBounds, Enabled ? ForeColor : SystemColors.GrayText,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter |
                TextFormatFlags.SingleLine | TextFormatFlags.NoPadding);
        }

        private GraphicsPath CreateRoundedPath(Rectangle bounds)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = Math.Min(borderRadius, Math.Min(bounds.Width, bounds.Height) / 2);
            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            int diameter = radius * 2;
            path.AddArc(bounds.Left, bounds.Top, diameter, diameter, 180, 90);
            path.AddArc(bounds.Right - diameter, bounds.Top, diameter, diameter, 270, 90);
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(bounds.Left, bounds.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            return path;
        }

        private Color GetFillColor()
        {
            if (!Enabled) return ControlPaint.Light(BackColor);
            if (isPressed) return ControlPaint.Dark(BackColor);
            if (isHovered) return ControlPaint.Light(BackColor);
            return BackColor;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            isHovered = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            isHovered = false;
            isPressed = false;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            isPressed = true;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            isPressed = false;
            Invalidate();
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            Invalidate();
        }
    }
}
