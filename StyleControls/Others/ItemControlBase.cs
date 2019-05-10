using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SmartHome.StyleControls
{
    public abstract class ItemControlBase : Control
    {
        protected delegate void EventCallback(object sender, EventArgs e);

        protected virtual int ColumnInterval
        {
            get { return 8; }
        }

        protected Color FontColor
        {
            get
            {
                StyleModeData smd = Helper.GetStyleModeData(StyleMode.LowChroma);
                return smd.ForeColor;
            }
        }

        protected Size ImageSize
        {
            get { return new Size(Height - ColumnInterval * 2, Height - ColumnInterval * 2); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.SmoothingMode = SmoothingMode.HighQuality;

            SolidBrush brush = new SolidBrush(Helper.GetStyleModeData(StyleMode.LowChroma).BackColor);
            g.FillRectangle(brush, new Rectangle(0, 0, Width, Height));
        }
    }
}
