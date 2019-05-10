using System.Drawing;
using System.Windows.Forms;

namespace SmartHome.StyleControls
{
    /// <summary>
    /// 文字控制項
    /// </summary>
    public class Word : Control
    {
        /// <summary>
        /// 文字
        /// </summary>
        public Word() : base()
        {
            this.SetStyle(ControlStyles.Selectable, false);
            this.Font = Helper.Style.Font;
            this.BackColor = Helper.Style.Normal.BackColor;
            this.ForeColor = Helper.Style.Normal.ForeColor;
            this.Size = new Size(240, 48);
            this.Margin = new Padding(4);
            this.Padding = new Padding(4);
            this.Visible = false;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Helper.DrawString(e.Graphics, Text, Enabled, new Rectangle(new Point(Padding.Left, Padding.Top), new Size(Width - Padding.Left - Padding.Right, Height - Padding.Top - Padding.Bottom)), Font, ForeColor, ContentAlignment.MiddleLeft);
        }
    }
}
