using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SmartHome.StyleControls
{
    /// <summary>
    /// 文字盒控制項
    /// </summary>
    public partial class TextBox : UserControl
    {
        /// <summary>
        /// 建構函式
        /// </summary>
        public TextBox()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.Selectable, true);
            this.Font = Helper.Style.Font;
            this.Size = new Size(180, 48);
            this.BackColor = Helper.Style.Control.BorderColor;
            panel_Content.Padding = new Padding(0);
            textBox_Text.TextChanged += textBox_Text_TextChanged;
            textBox_Text.KeyDown += textBox_Text_KeyDown;
            textBox_Text.GotFocus += textBox_Text_FocusChanged;
            textBox_Text.LostFocus += textBox_Text_FocusChanged;
            ChangeStyle();
            ChangeLocation();
        }

        /// <summary>
        /// 文字改變事件
        /// </summary>
        [Browsable(true)]
        public new event EventHandler<EventArgs> TextChanged;

        /// <summary>
        /// 最大長度
        /// </summary>
        public int MaxLength
        {
            get { return textBox_Text.MaxLength; }
            set { textBox_Text.MaxLength = value; }
        }

        /// <summary>
        /// 唯讀
        /// </summary>
        public bool ReadOnly
        {
            get { return textBox_Text.ReadOnly; }
            set { textBox_Text.ReadOnly = value; }
        }

        /// <summary>
        /// 文字
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [Localizable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public override string Text
        {
            get { return textBox_Text.Text; }
            set
            {
                cancelTextChanged = true;
                textBox_Text.Text = value;
                cancelTextChanged = false;
            }
        }

        /// <summary>
        /// 多行
        /// </summary>
        public bool Multiline
        {
            get { return textBox_Text.Multiline; }
            set
            {
                textBox_Text.Multiline = value;
                ChangeLocation();
            }
        }

        /// <summary>
        /// 滑動條
        /// </summary>
        public ScrollBars ScrollBars
        {
            get { return textBox_Text.ScrollBars; }
            set { textBox_Text.ScrollBars = value; }
        }

        /// <summary>
        /// 密碼字元
        /// </summary>
        public char PasswordChar
        {
            get { return textBox_Text.PasswordChar; }
            set { textBox_Text.PasswordChar = value; }
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
                _warning = value;
                ChangeStyle();
            }
        }
        private bool _warning = false;

        private void ChangeStyle()
        {
            StyleModeData smd = Helper.GetStyleModeData(StyleMode.Control);
            if (Warning == true)
            {
                smd = Helper.GetStyleModeData(StyleMode.Warning);
                this.Padding = new Padding(Helper.ControlBorderWidth);
            }
            else if (textBox_Text.Focused == true)
            {
                smd = Helper.GetStyleModeData(StyleMode.HighChroma);
                this.Padding = new Padding(Helper.FocusedControlBorderWidth);
            }
            else
            {
                this.Padding = new Padding(Helper.ControlBorderWidth);
            }
            panel_Content.BackColor = smd.BackColor;
            textBox_Text.BackColor = smd.BackColor;
            textBox_Text.ForeColor = smd.ForeColor;
            Invalidate();
        }
        private void ChangeLocation()
        {
            textBox_Text.Width = panel_Content.Width - 8;
            textBox_Text.Height = panel_Content.Height - 8;
            textBox_Text.Location = new Point(4, (panel_Content.Height - textBox_Text.Height) / 2);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            ChangeLocation();
        }

        private bool cancelTextChanged = false;
        private void textBox_Text_TextChanged(object sender, EventArgs e)
        {
            if (cancelTextChanged == false)
            {
                if (TextChanged != null) { TextChanged(this, e); }
            }
        }

        private void textBox_Text_FocusChanged(object sender, EventArgs e)
        {
            ChangeStyle();
        }
        private void textBox_Text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox_Text.Multiline == false && ReadOnly == false && Enabled == true)
                {
                    SendKeys.Send("{TAB}");
                }
            }
            OnKeyDown(e);
        }

    }
}
