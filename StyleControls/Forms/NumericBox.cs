using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SmartHome.StyleControls
{
    /// <summary>
    /// 數字盒控制項
    /// </summary>
    public partial class NumericBox : UserControl
    {
        /// <summary>
        /// 建構函式
        /// </summary>
        public NumericBox()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.Selectable, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.Font = Helper.Style.Font;
            this.BackColor = Color.Transparent;
            this.Size = new Size(180, 48);
            this.Margin = new Padding(4);
            panel_TextFrame.BackColor = Helper.Style.Control.BackColor;
            ChangeSize();
            Format();

            button_Minus.GotFocus += button_Minus_GotFocus;
            button_Minus.LostFocus += button_Minus_LostFocus;
            button_Minus.Click += button_Minus_Click;
            button_Plus.GotFocus += button_Plus_GotFocus;
            button_Plus.LostFocus += button_Plus_LostFocus;
            button_Plus.Click += button_Plus_Click;
            textBox_Text.GotFocus += textBox_Text_Style;
            textBox_Text.LostFocus += textBox_Text_Style;
            textBox_Text.TextChanged += textBox_TextChanged;
        }

        private void ChangeSize()
        {
            button_Minus.ImageScalingSize = new Size(Height, Height);
            button_Minus.Size = new Size(Height, Height);
            button_Minus.Location = new Point(Width - button_Minus.Width, 0);
            button_Plus.ImageScalingSize = new Size(Height, Height);
            button_Plus.Size = new Size(Height, Height);
            button_Plus.Location = new Point(Width - button_Minus.Width - Helper.ControlBorderWidth * 2 - button_Plus.Width, 0);
            int buttonsWidth = Helper.ControlBorderWidth * 2 + button_Plus.Width + Helper.ControlBorderWidth * 2 + button_Minus.Width;
            panel_TextFrame.Width = Width - buttonsWidth - Helper.ControlBorderWidth;
            panel_TextFrame.Height = Height;
            textBox_Text.Width = panel_TextContent.Width - 8;
            textBox_Text.Height = panel_TextContent.Height - 8;
            textBox_Text.Location = new Point(4, (panel_TextContent.Height - textBox_Text.Height) / 2);
        }

        private void button_Minus_GotFocus(object sender, EventArgs e)
        {
            button_Minus.StyleMode = StyleMode.HighChroma;
        }
        private void button_Minus_LostFocus(object sender, EventArgs e)
        {
            button_Minus.StyleMode = StyleMode.LowChroma;
        }
        private void button_Plus_GotFocus(object sender, EventArgs e)
        {
            button_Plus.StyleMode = StyleMode.HighChroma;
        }
        private void button_Plus_LostFocus(object sender, EventArgs e)
        {
            button_Plus.StyleMode = StyleMode.LowChroma;
        }
        private void textBox_Text_Style(object sender, EventArgs e)
        {
            StyleModeData smd = Helper.Style.Control;
            if (_warning == true)
            {
                smd = Helper.Style.Warning;
                panel_TextFrame.Padding = new Padding(Helper.ControlBorderWidth);
            }
            else if (textBox_Text.Focused == true)
            {
                panel_TextFrame.Padding = new Padding(Helper.FocusedControlBorderWidth);
                smd = Helper.Style.HighChroma;
            }
            else
            {
                panel_TextFrame.Padding = new Padding(Helper.ControlBorderWidth);
            }
            panel_TextContent.BackColor = smd.BackColor;
            textBox_Text.BackColor = smd.BackColor;
            textBox_Text.ForeColor = smd.ForeColor;
        }
        private void button_Minus_Click(object sender, EventArgs e)
        {
            decimal value = _value;
            _value = value - Interval;
            Format();
            if (value != _value && ValueChanged != null) { ValueChanged(this, EventArgs.Empty); }
        }
        private void button_Plus_Click(object sender, EventArgs e)
        {
            decimal value = _value;
            _value = value + Interval;
            Format();
            if (value != _value && ValueChanged != null) { ValueChanged(this, EventArgs.Empty); }
        }
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            bool flag = false;
            try
            {
                Decimal value = Math.Round(Convert.ToDecimal(textBox_Text.Text), DecimalPlaces);
                if (_value != value)
                {
                    _value = value;
                    if (ValueChanged != null) { flag = true; }
                }
                Format();
            }
            catch { Format(); }
            if (flag == true) { ValueChanged(this, EventArgs.Empty); }
        }
        private void Format()
        {
            if (_value > Maximum) { _value = Maximum; }
            if (_value < Minimum) { _value = Minimum; }
            _value = Math.Round(_value, DecimalPlaces);
            //if (textBox_Text.Focused == true)
            //{
            //    textBox_Text.Text = _Value.ToString("N" + DecimalPlaces.ToString());
            //}
            //else { textBox_Text.Text = _Value.ToString(); }
            textBox_Text.Text = _value.ToString("N" + DecimalPlaces.ToString());
            // button_Minus.Enabled = (_Value > Minimum);
            //button_Plus.Enabled= (_Value < Maximum);
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

        /// <summary>
        /// 填充
        /// </summary>
        [Browsable(false)]
        public new Padding Padding
        {
            get { return base.Padding; }
            set { base.Padding = value; }
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
                    textBox_Text_Style(textBox_Text, EventArgs.Empty);
                }
            }
        }
        private bool _warning = false;

        /// <summary>
        /// 小數點
        /// </summary>
        public int DecimalPlaces
        {
            get { return _decimalPlaces; }
            set
            {
                if (value < 0 | value > 99)
                    throw new ArgumentOutOfRangeException();
                _decimalPlaces = value;
                Format();
            }
        }
        private int _decimalPlaces = 0;

        /// <summary>
        /// 最大
        /// </summary>
        public decimal Maximum
        {
            get { return _maximum; }
            set
            {
                _maximum = value;
                Format();
            }
        }
        private decimal _maximum = 1000;

        /// <summary>
        /// 最小
        /// </summary>
        public decimal Minimum
        {
            get { return _minimum; }
            set
            {
                _minimum = value;
                Format();
            }
        }
        private decimal _minimum = 0;

        /// <summary>
        /// 間格
        /// </summary>
        public decimal Interval
        {
            get { return _interval; }
            set
            {
                if (value > 0) { _interval = value; }
            }
        }
        private decimal _interval = 1;

        /// <summary>
        /// 增加按鍵提示文字
        /// </summary>
        [Localizable(true)]
        public string PlusButtonToolTipText
        {
            get { return button_Plus.ToolTipText; }
            set { button_Plus.ToolTipText = value; }
        }

        /// <summary>
        /// 減少按鍵提示文字
        /// </summary>
        [Localizable(true)]
        public string MinusButtonToolTipText
        {
            get { return button_Minus.ToolTipText; }
            set { button_Minus.ToolTipText = value; }
        }

        /// <summary>
        /// 值改變事件
        /// </summary>
        [Browsable(true)]
        public event EventHandler<EventArgs> ValueChanged;

        /// <summary>
        /// 值
        /// </summary>
        public decimal Value
        {
            get { return _value; }
            set
            {
                if (_value != value)
                {
                    _value = value;
                    Format();
                }
            }
        }
        private decimal _value = 0;
    }
}
