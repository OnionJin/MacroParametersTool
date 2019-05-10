using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SmartHome.StyleControls
{
    public class Button : ButtonBase
    {
        private StyleMode _styleMode = StyleMode.LowChroma;
        /// <summary>
        /// 樣式模式
        /// </summary>
        public StyleMode StyleMode
        {
            get { return _styleMode; }
            set { _styleMode = value; Invalidate(); }
        }

        private ToolTip _toolTip = null;
        /// <summary>
        /// 建構函式
        /// </summary>
        public Button() : base()
        {
            _toolTip = new ToolTip();
            _toolTip.SetToolTip(this, "");
        }

        /// <summary>
        /// 提示文字
        /// </summary>
        [Localizable(true)]
        public string ToolTipText
        {
            get { return _toolTip.GetToolTip(this); }
            set { _toolTip.SetToolTip(this, value); }
        }

        private ToolStripItemDisplayStyle _displayStyle = ToolStripItemDisplayStyle.Text;
        /// <summary>
        /// 顯示的樣式
        /// </summary>
        public ToolStripItemDisplayStyle DisplayStyle
        {
            get { return _displayStyle; }
            set { _displayStyle = value; Invalidate(); }
        }

         private TextImageRelation _textImageRelation = TextImageRelation.ImageBeforeText;
       /// <summary>
        /// 文字圖形相對位置
        /// </summary>
        public TextImageRelation TextImageRelation
        {
            get { return _textImageRelation; }
            set { _textImageRelation = value; Invalidate(); }
        }

        private Image _image = null;
        /// <summary>
        /// 圖形
        /// </summary>
        public Image Image
        {
            get { return _image; }
            set { _image = value; Invalidate(); }
        }

        private Size _imageScalingSize = new Size(64, 64);
        /// <summary>
        /// 圖形大小
        /// </summary>
        public Size ImageScalingSize
        {
            get { return _imageScalingSize; }
            set { _imageScalingSize = value; Invalidate(); }
        }

        private ContentAlignment _imageAlign = ContentAlignment.MiddleCenter;
        /// <summary>
        /// 圖形對齊
        /// </summary>
        public ContentAlignment ImageAlign
        {
            get { return _imageAlign; }
            set { _imageAlign = value; Invalidate(); }
        }

        private ContentAlignment _textAlign = ContentAlignment.MiddleCenter;
        /// <summary>
        /// 文字對齊
        /// </summary>
        public ContentAlignment TextAlign
        {
            get { return _textAlign; }
            set { _textAlign = value; Invalidate(); }
        }

        /// <summary>
        /// 文字
        /// </summary>
        [Localizable(true)]
        public override string Text
        {
            get { return base.Text; }
            set { base.Text = value; Invalidate(); }
        }

        private bool _regionChanged = true;
        protected System.Windows.CornerRadius _radiuses = new System.Windows.CornerRadius(0);
        /// <summary>
        /// 圓角
        /// </summary>
        [TypeConverter(typeof(System.Windows.CornerRadiusConverter))]
        public System.Windows.CornerRadius Radiuses
        {
            get { return _radiuses; }
            set { _radiuses = value; _regionChanged = true; Invalidate(); }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            _regionChanged = true; Invalidate();
        }
        private void CheckRegion()
        {
            if (_regionChanged == true)
            {
                this.Region = new Region(Helper.GetRoundRectanglePath(new Rectangle(0, 0, Width, Height), Radiuses));
                _regionChanged = false;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            CheckRegion();
            StyleModeData smd = Helper.GetStyleModeData(StyleMode, BackColor, ForeColor, BorderColor);
            Graphics g = e.Graphics;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.FillRectangle(new SolidBrush(smd.BorderColor), e.ClipRectangle);

            GraphicsPath path;
            if (this.Enabled == false)
            {
                path = Helper.GetRoundRectanglePath(new Rectangle(0, 0, Width, Height), Radiuses);
            }
            else if (this.Focused == true)
            {
                path = Helper.GetRoundRectanglePath(new Rectangle(Helper.FocusedControlBorderWidth, Helper.FocusedControlBorderWidth, Width - Helper.FocusedControlBorderWidth * 2, Height - Helper.FocusedControlBorderWidth * 2), Radiuses);
            }
            else
            {
                path = Helper.GetRoundRectanglePath(new Rectangle(Helper.ControlBorderWidth, Helper.ControlBorderWidth, Width - Helper.ControlBorderWidth * 2, Height - Helper.ControlBorderWidth * 2), Radiuses);
            }
            SolidBrush brush;
            if (Pressed == true)
            {
                brush = new SolidBrush(Helper.GetLightLightColor(smd.BackColor));
            }
            else if (Overed == true)
            {
                brush = new SolidBrush(Helper.GetLightColor(smd.BackColor));
            }
            else
            {
                brush = new SolidBrush(smd.BackColor);
            }
            g.FillPath(brush, path);

            Rectangle rect = new Rectangle(Padding.Left + Helper.FocusedControlBorderWidth, Padding.Top + Helper.FocusedControlBorderWidth, Width - Padding.Left - Padding.Right - Helper.FocusedControlBorderWidth * 2, Height - Padding.Top - Padding.Bottom - Helper.FocusedControlBorderWidth * 2);
            Dictionary<string, Rectangle> rects = Helper.GetTextImageRelationRectangles(DisplayStyle, TextImageRelation, rect, ImageScalingSize);
            if (Image != null && (DisplayStyle == ToolStripItemDisplayStyle.Image | DisplayStyle == ToolStripItemDisplayStyle.ImageAndText))
            {
                Point pt = new Point(0);
                if (Pressed == true) { pt = new Point(1, 0); }
                Helper.DrawImage(g, Image, Enabled, rects["Image"], ImageScalingSize, ImageAlign, pt);
            }
            if (Text != "" && (DisplayStyle == ToolStripItemDisplayStyle.ImageAndText | DisplayStyle == ToolStripItemDisplayStyle.Text))
            {
                Helper.DrawString(g, Text, Enabled, rects["Text"], Font, smd.ForeColor, TextAlign);
            }
        }

    }
}
