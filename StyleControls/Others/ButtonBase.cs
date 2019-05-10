using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmartHome.StyleControls
{
    public class ButtonBase : Control
    {
        /// <summary>
        /// 建構函式
        /// </summary>
        public ButtonBase() : base()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.Selectable, true);
            this.Font = Helper.Style.Font;
            this.Size = new Size(128, 48);
            this.Margin = new Padding(8);
            this.ImeMode = ImeMode.Off;
        }

        protected override void OnClick(EventArgs e)
        {
            if (Helper.SoundPlayer != null) { Helper.SoundPlayer.Play(Helper.ClickSound); }
            base.OnClick(e);
            this.Focus();
        }

        /// <summary>
        /// 邊線顏色
        /// </summary>
        public Color BorderColor
        {
            get { return _borderColor; }
            set { _borderColor = value; Invalidate(); }
        }
        private Color _borderColor = Color.White;

        private bool _pressed = false;
        protected bool Pressed
        {
            get { return _pressed; }
        }
        private bool _overed = false;
        protected bool Overed
        {
            get { return _overed; }
        }
        protected override void OnMouseHover(EventArgs e)
        {
            base.OnMouseHover(e);
            _overed = true; Invalidate();
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _overed = false; Invalidate();
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (e.Button == MouseButtons.Left)
            {
                this.Focus();
                _pressed = false;
                Invalidate();
            }
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                _pressed = true;
                Invalidate();
            }
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Space)
            {
                _pressed = true;
                Invalidate();
                OnClick(e);
            }
        }
        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            if (e.KeyCode == Keys.Space)
            {
                _pressed = false;
                Invalidate();
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

    }
}
