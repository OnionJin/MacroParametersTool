using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace SmartHome.StyleControls
{
    /// <summary>
    /// 下拉式清單控制項
    /// </summary>
    public partial class DropDownList : UserControl
    {
        /// <summary>
        /// 建構函式
        /// </summary>
        public DropDownList()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.Selectable, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.Font = Helper.Style.Font;
            this.BackColor = Color.Transparent;
            this.Size = new Size(180, 48);
            this.Margin = new Padding(4);
            base.Padding = new Padding(4);
            ChangeSize();
            ChangeStyle();
            button_Down.GotFocus += ChildControls_FocusChanged;
            button_Down.LostFocus += ChildControls_FocusChanged;
            button_Down.Click += button_Down_Click;
            button_Clear.GotFocus += ChildControls_FocusChanged;
            button_Clear.LostFocus += ChildControls_FocusChanged;
            button_Clear.Click += button_Clear_Click;
        }

        private void ChangeSize()
        {
            button_Down.ImageScalingSize = new Size(Height, Height);
            button_Down.Size = new Size(Height, Height);
            button_Down.Location = new Point(Width - button_Down.Width, 0);
            button_Clear.ImageScalingSize = new Size(Height, Height);
            button_Clear.Size = new Size(Height, Height);
            button_Clear.Location = new Point(Width - button_Down.Width - Helper.ControlBorderWidth * 2 - button_Clear.Width, 0);
            int buttonsWidth = Helper.ControlBorderWidth * 2 + button_Clear.Width + Helper.ControlBorderWidth * 2 + button_Down.Width;
            textBox_Text.Width = Width - buttonsWidth - Helper.FocusedControlBorderWidth * 2 - Helper.ControlBorderWidth * 2 * 2;
            textBox_Text.Location = new Point(Helper.FocusedControlBorderWidth + Helper.ControlBorderWidth * 2, (Height - textBox_Text.Height) / 2);
        }
        private void ChangeStyle()
        {
            StyleModeData smd = Helper.GetStyleModeData(StyleMode.Control);
            if (Focused == true)
            {
                if (button_Down.Focused == true)
                {
                    button_Down.StyleMode = StyleMode.HighChroma;
                }
                else { button_Down.StyleMode = StyleMode.LowChroma; }
                if (button_Clear.Focused == true)
                {
                    button_Clear.StyleMode = StyleMode.HighChroma;
                }
                else { button_Clear.StyleMode = StyleMode.LowChroma; }
                smd = Helper.GetStyleModeData(StyleMode.HighChroma);
            }
            else
            {
                button_Down.StyleMode = StyleMode.LowChroma;
                button_Clear.StyleMode = StyleMode.LowChroma;
                smd = Helper.GetStyleModeData(StyleMode.Control);
            }
            if (Warning == true)
            {
                smd = Helper.GetStyleModeData(StyleMode.Warning);
            }
            textBox_Text.BackColor = smd.BackColor;
            textBox_Text.ForeColor = smd.ForeColor;
            Invalidate();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            ChangeSize();
        }
        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            ChangeSize();
        }

        private void ChildControls_FocusChanged(object sender, EventArgs e)
        {
            ChangeStyle();
        }

        /// <summary>
        /// 取得焦點
        /// </summary>
        public override bool Focused
        {
            get
            {
                return !(textBox_Text.Focused == false && button_Clear.Focused == false && button_Down.Focused == false);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.SmoothingMode = SmoothingMode.HighQuality;

            int buttonsWidth = Helper.ControlBorderWidth * 2 + button_Clear.Width + Helper.ControlBorderWidth * 2 + button_Down.Width;
            Rectangle rect = new Rectangle(0, 0, Width - buttonsWidth, Height);
            StyleModeData smd = default(StyleModeData);
            if (Warning == true)
            {
                smd = Helper.GetStyleModeData(StyleMode.Warning);
            }
            else if (Focused == true)
            {
                smd = Helper.GetStyleModeData(StyleMode.HighChroma);
            }
            else
            {
                smd = Helper.GetStyleModeData(StyleMode.Control);
            }

            g.FillRectangle(new SolidBrush(smd.BorderColor), rect);
            if (Focused == true)
            {
                rect = new Rectangle(rect.X + Helper.FocusedControlBorderWidth, rect.Y + Helper.FocusedControlBorderWidth, rect.Width - Helper.FocusedControlBorderWidth * 2, rect.Height - Helper.FocusedControlBorderWidth * 2);
            }
            else
            {
                rect = new Rectangle(rect.X + Helper.ControlBorderWidth, rect.Y + Helper.ControlBorderWidth, rect.Width - Helper.ControlBorderWidth * 2, rect.Height - Helper.ControlBorderWidth * 2);
            }
            g.FillRectangle(new SolidBrush(smd.BackColor), rect);
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            if (ClearButtonClick != null) { ClearButtonClick(this, e); }
        }
        private void button_Down_Click(object sender, EventArgs e)
        {
            if (DownButtonClick != null) { DownButtonClick(this, e); }
        }

        /// <summary>
        /// 清除按鍵點擊事件
        /// </summary>
        public event EventHandler<EventArgs> ClearButtonClick;

        /// <summary>
        /// 向下按鍵點擊事件
        /// </summary>
        public event EventHandler<EventArgs> DownButtonClick;

        /// <summary>
        /// 值
        /// </summary>
        public object Value
        {
            get { return _value; }
        }
        private object _value = null;

        /// <summary>
        /// 文字
        /// </summary>
        public new string Text
        {
            get { return textBox_Text.Text; }
        }

        /// <summary>
        /// 設定資料
        /// </summary>
        /// <param name="text">文字</param>
        /// <param name="value">值</param>
        public void SetData(string text, object value)
        {
            _value = value;
            textBox_Text.Text = text;
        }

        /// <summary>
        /// 文字對齊
        /// </summary>
        public HorizontalAlignment TextAlign
        {
            get { return textBox_Text.TextAlign; }
            set { textBox_Text.TextAlign = value; }
        }

        /// <summary>
        /// 警告
        /// </summary>
        public bool Warning
        {
            get { return _warning; }
            set
            {
                if (_warning != value)
                {
                    _warning = value;
                    ChangeStyle();
                }
            }
        }
        private bool _warning = false;

        /// <summary>
        /// 清除按鍵提示文字
        /// </summary>
        [Localizable(true)]
        public string ClearButtonToolTipText
        {
            get { return button_Clear.ToolTipText; }
            set { button_Clear.ToolTipText = value; }
        }

        /// <summary>
        /// 向下按鍵提示文字
        /// </summary>
        [Localizable(true)]
        public string DownButtonToolTipText
        {
            get { return button_Down.ToolTipText; }
            set { button_Down.ToolTipText = value; }
        }
    }
}
