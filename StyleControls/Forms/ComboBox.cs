using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SmartHome.StyleControls
{
    /// <summary>
    /// 下拉式方塊控制項
    /// </summary>
    public class ComboBox : System.Windows.Forms.ComboBox
    {
        /// <summary>
        /// 建構函式
        /// </summary>
        public ComboBox() : base()
        {
            this.Font = Helper.Style.Font;
            this.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Margin = new Padding(4);
            this.Size = new Size(180, 48);
            this.ItemHeight = 48 - 6;
            this.DisplayMember = "Text";
            this.ValueMember = "Value";
        }

        /// <summary>
        /// 值改變事件
        /// </summary>
        [Browsable(true)]
        public event EventHandler<EventArgs> ValueChanged;

        /// <summary>
        /// 資料來源
        /// </summary>
        public new ListItems DataSource
        {
            get { return (ListItems)base.DataSource; }
            set
            {
                _cancelValueChanged = true;
                base.DataSource = value;
                _originalValue = SelectedValue;
                _cancelValueChanged = false;
            }
        }

        private object _originalValue = null;
        private bool _cancelValueChanged = false;
        protected override void OnSelectedValueChanged(EventArgs e)
        {
            base.OnSelectedValueChanged(e);
            if ((_originalValue != SelectedValue))
            {
                _originalValue = SelectedValue;
                if (_cancelValueChanged == false)
                    if (ValueChanged != null)
                    {
                        ValueChanged(this, e);
                    }
            }
        }

        /// <summary>
        /// 值
        /// </summary>
        public object Value
        {
            get { return SelectedValue; }
            set
            {
                if ((SelectedValue != value))
                {
                    _cancelValueChanged = true;
                    SelectedValue = value;
                    _cancelValueChanged = false;
                }
            }
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
                Invalidate();
            }
        }
        private bool _warning = false;

        /// <summary>
        /// 文字對齊
        /// </summary>
        public ContentAlignment TextAlign
        {
            get { return _textAlign; }
            set { _textAlign = value; }
        }
        private ContentAlignment _textAlign = ContentAlignment.MiddleLeft;

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = e.Bounds;
            string text = "";
            StyleModeData smd = Helper.GetStyleModeData(StyleMode.Warning);
            if (e.Index > -1)
            {
                text = GetItemText(Items[e.Index]);
                if (Warning == false)
                {
                    if (Convert.ToBoolean(e.State & DrawItemState.Selected) == true)
                    {
                        smd = Helper.GetStyleModeData(StyleMode.HighChroma);
                    }
                    else
                    {
                        smd = Helper.GetStyleModeData(StyleMode.Control);
                    }
                }
            }
            e.Graphics.FillRectangle(new SolidBrush(smd.BackColor), rect);

            if (text != "")
            {
                rect = new Rectangle(rect.X + Padding.Left, rect.Y + Padding.Top, rect.Width - Padding.Left - Padding.Right, rect.Height - Padding.Top - Padding.Bottom);
                Helper.DrawString(g, text, Enabled, rect, Font, smd.ForeColor, TextAlign);
            }

            e.DrawFocusRectangle();
        }
    }
}
