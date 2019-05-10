using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SmartHome.StyleControls
{
    /// <summary>
    /// 標籤控制項
    /// </summary>
    public class Label : Control
    {
        /// <summary>
        /// 建構函式
        /// </summary>
        public Label() : base()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.Selectable, false);
            this.Font = Helper.Style.Font;
            this.Size = new Size(180, 48);
            this.Margin = new Padding(4);
            this.Padding = new Padding(4);
        }

        private ToolStripItemDisplayStyle _displayStyle = ToolStripItemDisplayStyle.Text;
        /// <summary>
        /// 顯示樣式
        /// </summary>
        public ToolStripItemDisplayStyle DisplayStyle
        {
            get { return _displayStyle; }
            set { _displayStyle = value; Invalidate(); }
        }

        private TextImageRelation _textImageRelation = TextImageRelation.ImageBeforeText;
        /// <summary>
        /// 文字圖形相關位置
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

        private ContentAlignment _textAlign = ContentAlignment.TopLeft;
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

        private StyleMode _styleMode = StyleMode.LowChroma;
        /// <summary>
        /// 樣式模式
        /// </summary>
        public StyleMode StyleMode
        {
            get { return _styleMode; }
            set { _styleMode = value; Invalidate(); }
        }

        private BorderStyle _borderStyle = BorderStyle.None;
        /// <summary>
        /// 邊線樣式
        /// </summary>
        public BorderStyle BorderStyle
        {
            get { return _borderStyle; }
            set { _borderStyle = value; }
        }

        private Color _borderColor = Color.White;
        /// <summary>
        /// 邊線顏色
        /// </summary>
        public Color BorderColor
        {
            get { return _borderColor; }
            set { _borderColor = value; Invalidate(); }
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
            switch (BorderStyle)
            {
                case BorderStyle.None:
                    path = Helper.GetRoundRectanglePath(new Rectangle(0, 0, Width, Height), Radiuses);
                    break;
                default:
                    path = Helper.GetRoundRectanglePath(new Rectangle(Helper.ControlBorderWidth, Helper.ControlBorderWidth, Width - Helper.ControlBorderWidth * 2, Height - Helper.ControlBorderWidth * 2), Radiuses);
                    break;
            }
            SolidBrush brush = new SolidBrush(smd.BackColor);
            g.FillPath(brush, path);

            Rectangle rect = new Rectangle(Padding.Left + Helper.ControlBorderWidth, Padding.Top + Helper.ControlBorderWidth, Width - Padding.Left - Padding.Right - Helper.ControlBorderWidth * 2, Height - Padding.Top - Padding.Bottom - Helper.ControlBorderWidth * 2);
            Dictionary<string, Rectangle> rects = Helper.GetTextImageRelationRectangles(DisplayStyle, TextImageRelation, rect, ImageScalingSize);
            if (Image != null && (DisplayStyle == ToolStripItemDisplayStyle.Image | DisplayStyle == ToolStripItemDisplayStyle.ImageAndText))
            {
                Point pt = new Point(0);
                Helper.DrawImage(g, Image, Enabled, rects["Image"], ImageScalingSize, ImageAlign, pt);
            }
            if (Text != "" && (DisplayStyle == ToolStripItemDisplayStyle.ImageAndText | DisplayStyle == ToolStripItemDisplayStyle.Text))
            {
                Helper.DrawString(g, Text, true, rects["Text"], Font, smd.ForeColor, TextAlign);
            }
        }

    }
}
