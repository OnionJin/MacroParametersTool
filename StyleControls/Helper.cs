using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.IO;
using System.Windows;

namespace SmartHome.StyleControls
{
    /// <summary>
    /// 小幫手類別
    /// </summary>
    public class Helper
    {
        /// <summary>
        /// 樣式
        /// </summary>
        public static IStyle Style
        {
            get
            {
                if (_style == null) _style = new DefaultStyle();
                return _style;
            }
            set { _style = value; }
        }
        private static IStyle _style = null;

        /// <summary>
        /// 控制器邊線寬度
        /// </summary>
        public const int ControlBorderWidth = 2;

        /// <summary>
        /// 取得焦點控制器邊線寬度
        /// </summary>
        public const int FocusedControlBorderWidth = 3;

        /// <summary>
        /// 高彩色
        /// </summary>
        /// <param name="baseColor">基礎色</param>
        public static Color GetLightColor(Color baseColor)
        {
            return ControlPaint.Light(baseColor, 0.3F);
        }

        /// <summary>
        /// 高高彩色
        /// </summary>
        /// <param name="baseColor">基礎色</param>
        public static Color GetLightLightColor(Color baseColor)
        {
            return ControlPaint.Light(baseColor, 0.6F);
        }

        /// <summary>
        /// 文字格式
        /// </summary>
        /// <param name="textAlign">文字對齊</param>
        public static StringFormat GetStringFormat(ContentAlignment textAlign)
        {
            StringFormat r = new StringFormat();
            switch (textAlign)
            {
                case ContentAlignment.BottomCenter:
                    r.Alignment = StringAlignment.Center;
                    r.LineAlignment = StringAlignment.Far;
                    break;
                case ContentAlignment.BottomLeft:
                    r.Alignment = StringAlignment.Near;
                    r.LineAlignment = StringAlignment.Far;
                    break;
                case ContentAlignment.BottomRight:
                    r.Alignment = StringAlignment.Far;
                    r.LineAlignment = StringAlignment.Far;
                    break;
                case ContentAlignment.MiddleCenter:
                    r.Alignment = StringAlignment.Center;
                    r.LineAlignment = StringAlignment.Center;
                    break;
                case ContentAlignment.MiddleLeft:
                    r.Alignment = StringAlignment.Near;
                    r.LineAlignment = StringAlignment.Center;
                    break;
                case ContentAlignment.MiddleRight:
                    r.Alignment = StringAlignment.Far;
                    r.LineAlignment = StringAlignment.Center;
                    break;
                case ContentAlignment.TopCenter:
                    r.Alignment = StringAlignment.Center;
                    r.LineAlignment = StringAlignment.Near;
                    break;
                case ContentAlignment.TopLeft:
                    r.Alignment = StringAlignment.Near;
                    r.LineAlignment = StringAlignment.Near;
                    break;
                case ContentAlignment.TopRight:
                    r.Alignment = StringAlignment.Far;
                    r.LineAlignment = StringAlignment.Near;
                    break;
            }
            return r;
        }

        /// <summary>
        /// 圓角矩形路徑
        /// </summary>
        /// <param name="rect">範圍</param>
        /// <param name="radiuses">圓角</param>
        public static GraphicsPath GetRoundRectanglePath(Rectangle rect, CornerRadius radiuses)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            //左上角
            Point pt1 = new Point(rect.X, rect.Y);
            Point pt2 = new Point(rect.X, rect.Y);
            if (!(radiuses.TopLeft == 0))
            {
                pt1.Y = rect.Y + (int)radiuses.TopLeft * 2;
                path.AddArc(new Rectangle(pt2.X, pt2.Y, (int)radiuses.TopLeft * 2, (int)radiuses.TopLeft * 2), 180, 90);
                pt2.X = rect.X + (int)radiuses.TopLeft * 2;
            }
            //右上角
            if (radiuses.TopRight == 0)
            {
                path.AddLine(new Point(pt2.X, pt2.Y), new Point(rect.Right, rect.Y));
                pt2.X = rect.Right;
            }
            else
            {
                path.AddLine(new Point(pt2.X, pt2.Y), new Point(rect.Right - (int)radiuses.TopRight * 2, rect.Y));
                path.AddArc(new Rectangle(rect.Right - (int)radiuses.TopRight * 2, rect.Y, (int)radiuses.TopRight * 2, (int)radiuses.TopRight * 2), 270, 90);
                pt2.X = rect.Right;
                pt2.Y = rect.Y + (int)radiuses.TopRight * 2;
            }
            //右下角
            if (radiuses.BottomRight == 0)
            {
                path.AddLine(new Point(pt2.X, pt2.Y), new Point(rect.Right, rect.Bottom));
                pt2.Y = rect.Bottom;
            }
            else
            {
                path.AddLine(new Point(pt2.X, pt2.Y), new Point(rect.Right, rect.Bottom - (int)radiuses.BottomRight * 2));
                path.AddArc(new Rectangle(rect.Right - (int)radiuses.BottomRight * 2, rect.Bottom - (int)radiuses.BottomRight * 2, (int)radiuses.BottomRight * 2, (int)radiuses.BottomRight * 2), 0, 90);
                pt2.X = rect.Right - (int)radiuses.BottomRight * 2;
                pt2.Y = rect.Bottom;
            }
            //左下角
            if (radiuses.BottomLeft == 0)
            {
                path.AddLine(new Point(pt2.X, pt2.Y), new Point(rect.X, rect.Bottom));
                pt2.X = rect.X;
            }
            else
            {
                path.AddLine(new Point(pt2.X, pt2.Y), new Point(rect.X + (int)radiuses.BottomLeft * 2, rect.Bottom));
                path.AddArc(new Rectangle(rect.X, rect.Bottom - (int)radiuses.BottomLeft * 2, (int)radiuses.BottomLeft * 2, (int)radiuses.BottomLeft * 2), 90, 90);
                pt2.X = rect.X;
                pt2.Y = rect.Bottom - (int)radiuses.BottomLeft * 2;
            }
            path.AddLine(new Point(pt2.X, pt2.Y), new Point(pt1.X, pt1.Y));
            path.CloseFigure();
            return path;
        }

        /// <summary>
        /// 文字與圖形範圍
        /// </summary>
        /// <param name="display">顯示</param>
        /// <param name="relation">位置關係</param>
        /// <param name="rect">範圍</param>
        /// <param name="imageSize">圖形大小</param>
        public static Dictionary<string, Rectangle> GetTextImageRelationRectangles(ToolStripItemDisplayStyle display, TextImageRelation relation, Rectangle rect, Size imageSize)
        {
            Dictionary<string, Rectangle> r = new Dictionary<string, Rectangle>();
            r.Add("Image", new Rectangle(0, 0, 0, 0));
            r.Add("Text", new Rectangle(0, 0, 0, 0));
            switch (display)
            {
                case ToolStripItemDisplayStyle.Image:
                    r["Image"] = new Rectangle(rect.Location, rect.Size);
                    break;
                case ToolStripItemDisplayStyle.Text:
                    r["Text"] = new Rectangle(rect.Location, rect.Size);
                    break;
                case ToolStripItemDisplayStyle.ImageAndText:
                    switch (relation)
                    {
                        case System.Windows.Forms.TextImageRelation.ImageAboveText:
                            r["Image"] = new Rectangle(rect.X, rect.Y, rect.Width, imageSize.Height);
                            r["Text"] = new Rectangle(rect.X, rect.Y + r["Image"].Height, rect.Width, rect.Height - imageSize.Height);
                            break;
                        case System.Windows.Forms.TextImageRelation.ImageBeforeText:
                            r["Image"] = new Rectangle(rect.X, rect.Y, imageSize.Width, rect.Height);
                            r["Text"] = new Rectangle(rect.X + imageSize.Width, rect.Y, rect.Width - imageSize.Width, rect.Height);
                            break;
                        case System.Windows.Forms.TextImageRelation.Overlay:
                            r["Image"] = new Rectangle(rect.Location, rect.Size);
                            r["Text"] = new Rectangle(rect.Location, rect.Size);
                            break;
                        case System.Windows.Forms.TextImageRelation.TextAboveImage:
                            r["Image"] = new Rectangle(rect.X, rect.Bottom - imageSize.Height, rect.Width, imageSize.Height);
                            r["Text"] = new Rectangle(rect.X, rect.Y, rect.Width, rect.Height - imageSize.Height);
                            break;
                        case System.Windows.Forms.TextImageRelation.TextBeforeImage:
                            r["Image"] = new Rectangle(rect.Right - imageSize.Width, rect.Y, imageSize.Width, rect.Height);
                            r["Text"] = new Rectangle(rect.X, rect.Y, rect.Width - imageSize.Width, rect.Height);
                            break;
                    }
                    break;
            }
            return r;
        }

        /// <summary>
        /// 放大圖
        /// </summary>
        /// <param name="source">來源</param>
        /// <param name="size">大小</param>
        public static Image GetZoomImage(Image source, Size size)
        {
            Bitmap r = new Bitmap(size.Width, size.Height);
            Graphics g = Graphics.FromImage(r);
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.DrawImage(source, new Rectangle(0, 0, size.Width, size.Height));
            return r;
        }

        /// <summary>
        /// 畫圖形
        /// </summary>
        /// <param name="g">圖像繪製器</param>
        /// <param name="image">圖檔</param>
        /// <param name="enabled">啟用</param>
        /// <param name="rect">範圍</param>
        /// <param name="scalingSize">圖檔大小</param>
        /// <param name="align">對齊</param>
        /// <param name="offset">位移</param>
        public static void DrawImage(Graphics g, Image image, bool enabled, Rectangle rect, Size scalingSize, ContentAlignment align, Point offset)
        {
            Point pt = new Point(0, 0);
            switch (align)
            {
                case ContentAlignment.BottomCenter:
                case ContentAlignment.MiddleCenter:
                case ContentAlignment.TopCenter:
                    pt.X = rect.X + ((rect.Width - scalingSize.Width) / 2);
                    break;
                case ContentAlignment.BottomLeft:
                case ContentAlignment.MiddleLeft:
                case ContentAlignment.TopLeft:
                    pt.X = rect.X;
                    break;
                case ContentAlignment.BottomRight:
                case ContentAlignment.MiddleRight:
                case ContentAlignment.TopRight:
                    pt.X = rect.X + (rect.Width - scalingSize.Width);
                    break;
            }
            switch (align)
            {
                case ContentAlignment.BottomCenter:
                case ContentAlignment.BottomLeft:
                case ContentAlignment.BottomRight:
                    pt.Y = rect.Y + (rect.Height - scalingSize.Height);
                    break;
                case ContentAlignment.MiddleCenter:
                case ContentAlignment.MiddleLeft:
                case ContentAlignment.MiddleRight:
                    pt.Y = rect.Y + ((rect.Height - scalingSize.Height) / 2);
                    break;
                case ContentAlignment.TopCenter:
                case ContentAlignment.TopLeft:
                case ContentAlignment.TopRight:
                    pt.Y = rect.Y;
                    break;
            }
            pt.Offset(offset);
            if (enabled == true)
            {
                g.DrawImage(image, new Rectangle(pt, scalingSize));
            }
            else
            {
                ControlPaint.DrawImageDisabled(g, GetZoomImage(image, scalingSize), pt.X, pt.Y, Color.Transparent);
            }
        }

        /// <summary>
        /// 畫文字
        /// </summary>
        /// <param name="g">圖像繪製器</param>
        /// <param name="text">文字</param>
        /// <param name="enabled">啟用</param>
        /// <param name="rect">範圍</param>
        /// <param name="font">字型</param>
        /// <param name="color">顏色</param>
        /// <param name="align">對齊</param>
        public static void DrawString(Graphics g, string text, bool enabled, Rectangle rect, Font font, Color color, ContentAlignment align)
        {

            if (enabled == true)
            {
                g.DrawString(text, font, new SolidBrush(color), rect, GetStringFormat(align));
            }
            else
            {
                g.DrawString(text, font, new SolidBrush(Color.FromArgb(color.R / 2, color.G / 2, color.B / 2)), rect, GetStringFormat(align));
            }
        }

        /// <summary>
        /// 樣式模式資料
        /// </summary>
        /// <param name="mode">模式</param>
        public static StyleModeData GetStyleModeData(StyleMode mode)
        {
            StyleModeData r = null;
            switch (mode)
            {
                case StyleMode.Control:
                    r = Style.Control;
                    break;
                case StyleMode.HighChroma:
                    r = Style.HighChroma;
                    break;
                case StyleMode.LowChroma:
                    r = Style.LowChroma;
                    break;
                case StyleMode.Normal:
                    r = Style.Normal;
                    break;
                case StyleMode.Warning:
                    r = Style.Warning;
                    break;
            }

            return r;
        }

        /// <summary>
        /// 樣式模式資料
        /// </summary>
        /// <param name="mode">模式</param>
        /// <param name="backColor">背景色</param>
        /// <param name="foreColor">前景色</param>
        /// <param name="borderColor">邊線顏色</param>
        public static StyleModeData GetStyleModeData(StyleMode mode, Color backColor, Color foreColor, Color borderColor)
        {
            StyleModeData r = GetStyleModeData(mode);
            if (r == null) { r = new StyleModeData(backColor, foreColor, borderColor); }
            return r;
        }

        private static SoundPlayer _soundPlayer = null;
        /// <summary>
        /// 聲音撥放器
        /// </summary>
        public static SoundPlayer SoundPlayer
        {
            get { return _soundPlayer; }
            set { _soundPlayer = value; }
        }

        private static Stream _clickSound = null;
        /// <summary>
        /// 點擊聲音
        /// </summary>
        public static Stream ClickSound
        {
            get { if (_clickSound == null) { return StyleControls.Properties.Resources.Click; } else { return _clickSound; } }
            set { _clickSound = value; }
        }

    }
}
