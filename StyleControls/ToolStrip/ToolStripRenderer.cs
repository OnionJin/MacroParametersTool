using System.Drawing;
using System.Windows.Forms;

namespace SmartHome.StyleControls
{
    /// <remarks>工具列繪製器</remarks>
    public class ToolStripRenderer : System.Windows.Forms.ToolStripSystemRenderer
    {
        private StyleModeData _smd = Helper.Style.LowChroma;
        public ToolStripRenderer() : base() { _smd = Helper.Style.LowChroma; }
        public ToolStripRenderer(StyleModeData styleModeData) : base() { _smd = styleModeData; }

        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            base.OnRenderToolStripBackground(e);
            e.Graphics.FillRectangle(new SolidBrush(_smd.BackColor), e.AffectedBounds);
        }

        /// <summary>
        /// 底線
        /// </summary>
        public bool Bottomline
        {
            get { return _bottomline; }
            set { _bottomline = value; }
        }
        private bool _bottomline = false;

        protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
        {
            Rectangle rect = new Rectangle(Point.Empty, e.Item.Size);
            SolidBrush brush = new SolidBrush(_smd.BorderColor);
            e.Graphics.FillRectangle(brush, rect);
            if (e.Item.Enabled == true)
                rect = new Rectangle(Helper.ControlBorderWidth, Helper.ControlBorderWidth, rect.Width - Helper.ControlBorderWidth * 2, rect.Height - Helper.ControlBorderWidth * 2);
            if (e.Item.Pressed == true)
            {
                brush = new SolidBrush(Helper.GetLightLightColor(_smd.BackColor));
            }
            else if (e.Item.Selected == true)
            {
                brush = new SolidBrush(Helper.GetLightColor(_smd.BackColor));
            }
            else
            {
                brush = new SolidBrush(_smd.BackColor);
            }
            e.Graphics.FillRectangle(brush, rect);
        }

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            if (Bottomline == true) base.OnRenderToolStripBorder(e);
        }

        protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(_smd.BorderColor), e.Item.ContentRectangle);
        }

        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            e.Item.ForeColor = StyleControls.Helper.Style.LowChroma.ForeColor;
            Rectangle rect = new Rectangle(Point.Empty, e.Item.Size);
            SolidBrush brush = new SolidBrush(_smd.BorderColor);
            e.Graphics.FillRectangle(brush, rect);
            if (e.Item.Enabled == true)
                rect = new Rectangle(Helper.ControlBorderWidth, Helper.ControlBorderWidth, rect.Width - Helper.ControlBorderWidth * 2, rect.Height - Helper.ControlBorderWidth * 2);
            if (e.Item.Pressed == true)
            {
                brush = new SolidBrush(Helper.GetLightLightColor(_smd.BackColor));
            }
            else if (e.Item.Selected == true)
            {
                brush = new SolidBrush(Helper.GetLightColor(_smd.BackColor));
            }
            else
            {
                brush = new SolidBrush(_smd.BackColor);
            }
            e.Graphics.FillRectangle(brush, rect);
        }

    }
}
