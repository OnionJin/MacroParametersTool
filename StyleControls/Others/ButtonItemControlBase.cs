using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SmartHome.StyleControls
{
    public abstract class ButtonItemControlBase : ButtonBase
    {
        protected delegate void EventCallback(object sender, EventArgs e);

        protected virtual int ColumnInterval
        {
            get { return 8; }
        }

        protected Size ImageSize
        {
            get { return new Size(Height - ColumnInterval * 2, Height - ColumnInterval * 2); }
        }

        abstract public bool SearchKeyword(string keyword);

        private bool _selected = false;
        public bool Selected
        {
            get { return _selected; }
            set
            {
                if (_selected != value)
                {
                    _selected = value;
                    Invalidate();
                }
            }
        }

        protected Color FontColor
        {
            get
            {
                StyleModeData smd = Helper.GetStyleModeData(StyleMode.LowChroma);
                if (Selected == true) { smd = Helper.GetStyleModeData(StyleMode.HighChroma); }
                return smd.ForeColor;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.SmoothingMode = SmoothingMode.HighQuality;

            StyleModeData smd = Helper.GetStyleModeData(StyleMode.LowChroma);
            if (Selected == true) { smd = Helper.GetStyleModeData(StyleMode.HighChroma); }

            Rectangle rect = new Rectangle(0, 0, Width, Height);
            SolidBrush brush = new SolidBrush(smd.BorderColor);
            g.FillRectangle(brush, rect);

            if (this.Focused == true)
            {
                rect = new Rectangle(Helper.FocusedControlBorderWidth, Helper.FocusedControlBorderWidth, Width - Helper.FocusedControlBorderWidth * 2, Height - Helper.FocusedControlBorderWidth * 2);
            }
            else
            {
                rect = new Rectangle(Helper.ControlBorderWidth, Helper.ControlBorderWidth, Width - Helper.ControlBorderWidth * 2, Height - Helper.ControlBorderWidth * 2);
            }
            if (Pressed == true)
            {
                brush = new SolidBrush(Helper.GetLightLightColor(smd.BackColor));
            }
            else if (Overed == true || Focused == true)
            {
                brush = new SolidBrush(Helper.GetLightColor(smd.BackColor));
            }
            else
            {
                brush = new SolidBrush(smd.BackColor);
            }
            g.FillRectangle(brush, rect);
        }

    }
}
