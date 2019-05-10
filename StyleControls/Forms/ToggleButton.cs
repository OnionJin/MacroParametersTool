using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SmartHome.StyleControls
{
    /// <summary>
    /// 切換按鍵控制項
    /// </summary>
    public class ToggleButton : System.Windows.Forms.Control
    {
        /// <summary>
        /// 建構函式
        /// </summary>
        public ToggleButton() : base()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.Selectable, true);
            this.Font = Helper.Style.Font;
            this.Size = new Size(48, 48);
            this.Margin = new Padding(4);

        }

        /// <summary>
        /// 樣式模式
        /// </summary>
        public StyleMode StyleMode
        {
            get { return _styleMode; }
            set { _styleMode = value; Invalidate(); }
        }
        private StyleMode _styleMode = StyleMode.Normal;

        /// <summary>
        /// 顯示樣式
        /// </summary>
        public ToolStripItemDisplayStyle DisplayStyle
        {
            get { return _displayStyle; }
            set { _displayStyle = value; Invalidate(); }
        }
        private ToolStripItemDisplayStyle _displayStyle = ToolStripItemDisplayStyle.Image;

        /// <summary>
        /// 文字圖形位置關係
        /// </summary>
        public TextImageRelation TextImageRelation
        {
            get { return _textImageRelation; }
            set { _textImageRelation = value; Invalidate(); }
        }
        private TextImageRelation _textImageRelation = TextImageRelation.ImageBeforeText;

        /// <summary>
        /// 圖形對齊
        /// </summary>
        public ContentAlignment ImageAlign
        {
            get { return _imageAlign; }
            set { _imageAlign = value; Invalidate(); }
        }
        private ContentAlignment _imageAlign = ContentAlignment.MiddleLeft;

        /// <summary>
        /// 文字對齊
        /// </summary>
        public ContentAlignment TextAlign
        {
            get { return _textAlign; }
            set { _textAlign = value; Invalidate(); }
        }
        private ContentAlignment _textAlign = ContentAlignment.MiddleLeft;

        /// <summary>
        /// 選取改變事件
        /// </summary>
        [Browsable(true)]
        public event EventHandler<EventArgs> CheckedChanged;

        /// <summary>
        /// 選取
        /// </summary>
        public bool Checked
        {
            get { return _checked; }
            set
            {
                if (!(_checked == value))
                {
                    _checked = value;
                    Invalidate();
                }
            }
        }
        private bool _checked = false;

        /// <summary>
        /// 選取圖
        /// </summary>
        public Image CheckedImage
        {
            get { return _checkedImage; }
            set { _checkedImage = value; }
        }
        private Image _checkedImage = null;

        /// <summary>
        /// 選取文字
        /// </summary>
        [Localizable(true)]
        public string CheckedText
        {
            get { return _checkedText; }
            set { _checkedText = value; }
        }
        private string _checkedText = "";

        /// <summary>
        /// 未選取圖形
        /// </summary>
        public Image UncheckedImage
        {
            get { return _uncheckedImage; }
            set { _uncheckedImage = value; }
        }
        private Image _uncheckedImage = null;

        /// <summary>
        /// 未選取文字
        /// </summary>
        [Localizable(true)]
        public string UncheckedText
        {
            get { return _uncheckedText; }
            set { _uncheckedText = value; }
        }
        private string _uncheckedText = "";

        /// <summary>
        /// 樣式
        /// </summary>
        public ToggleButtonStyle Style
        {
            get { return _style; }
            set { _style = value; Invalidate(); }
        }
        private ToggleButtonStyle _style = ToggleButtonStyle.CheckBox;

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Space)
            {
                OnClick(e);
            }
        }
        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            Invalidate();
        }
        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            Invalidate();
        }

        protected override void OnClick(EventArgs e)
        {
            if (Helper.SoundPlayer != null) { Helper.SoundPlayer.Play(Helper.ClickSound); }
            Checked = Checked ^ true;
            if (CheckedChanged != null) { CheckedChanged(this, e); }
            base.OnClick(e);
            this.Focus();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            StyleModeData smd = Helper.GetStyleModeData(StyleMode, BackColor, ForeColor, BackColor);
            Graphics g = e.Graphics;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.FillRectangle(new SolidBrush(smd.BackColor), e.ClipRectangle);

            string text = "";
            Image img = null;
            if (Checked == true) { text = CheckedText; }
            else { text = UncheckedText; }
            switch (Style)
            {
                case ToggleButtonStyle.CheckBox:
                    if (Checked == true) { img = Properties.Resources.ToggleButton_CheckBox_Checked; }
                    else { img = Properties.Resources.ToggleButton_CheckBox_Unchecked; }
                    break;
                case ToggleButtonStyle.RadioButton:
                    if (Checked == true) { img = Properties.Resources.ToggleButton_RadioButton_Checked; }
                    else { img = Properties.Resources.ToggleButton_RadioButton_Unchecked; }
                    break;
                case ToggleButtonStyle.Switch:
                    if (Checked == true) { img = Properties.Resources.ToggleButton_Switch_Checked; }
                    else { img = Properties.Resources.ToggleButton_Switch_Unchecked; }
                    break;
                default:
                    if (Checked == true) { img = CheckedImage; }
                    else { img = UncheckedImage; }
                    break;
            }

            if (Focused == true)
            {
                ControlPaint.DrawBorder(g, e.ClipRectangle, Color.Black, ButtonBorderStyle.Dotted);
            }

            Size imageSize = new Size(48, 48);
            imageSize.Height = Height - Padding.Top - Padding.Bottom;
            imageSize.Width = imageSize.Height;
            if (img != null) { imageSize.Width = img.Width * imageSize.Height / img.Height; }
            Rectangle rect = new Rectangle(Padding.Left + Helper.FocusedControlBorderWidth, Padding.Top + Helper.FocusedControlBorderWidth, Width - Padding.Left - Padding.Right - Helper.FocusedControlBorderWidth * 2, Height - Padding.Top - Padding.Bottom - Helper.FocusedControlBorderWidth * 2);
            Dictionary<string, Rectangle> rects = Helper.GetTextImageRelationRectangles(DisplayStyle, TextImageRelation, rect, imageSize);
            if (img != null && (DisplayStyle == ToolStripItemDisplayStyle.Image | DisplayStyle == ToolStripItemDisplayStyle.ImageAndText))
            {
                Point pt = new Point(0);
                Helper.DrawImage(g, img, Enabled, rects["Image"], imageSize, ImageAlign, pt);
            }
            if (text != "" && (DisplayStyle == ToolStripItemDisplayStyle.ImageAndText | DisplayStyle == ToolStripItemDisplayStyle.Text))
            {
                Helper.DrawString(g, text, Enabled, rects["Text"], Font, smd.ForeColor, TextAlign);
            }
        }
    }
}
