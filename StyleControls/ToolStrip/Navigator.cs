using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SmartHome.StyleControls
{
    /// <summary>
    /// 導引器元件
    /// </summary>
    public class Navigator : System.ComponentModel.Component
    {
        private void SetButtonStyle(ToolStripButton button)
        {
            button.Font = Helper.Style.Font;
            button.AutoSize = false;
            button.AutoToolTip = true;
            button.CheckState = CheckState.Unchecked;
            button.DoubleClickEnabled = false;
            button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            button.ImageAlign = ContentAlignment.MiddleCenter;
            button.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            button.Margin = new Padding(4);
            button.Visible = true;
        }

        private SmartHome.StyleControls.ToolStripButton _firstButton = null;
        private SmartHome.StyleControls.ToolStripButton _previousButton = null;
        private SmartHome.StyleControls.ToolStripButton _lastButton = null;
        private SmartHome.StyleControls.ToolStripButton _nextButton = null;
        private ToolStripTextBox _indexTextBox = null;
        private ToolStripLabel _countLabel = null;
        private void changeStyle()
        {
            if (_index == 1 | _count == 1)
            {
                if (_firstButton != null) { _firstButton.Enabled = false; }
                if (_previousButton != null) { _previousButton.Enabled = false; }
            }
            else
            {
                if (_firstButton != null) { _firstButton.Enabled = true; }
                if (_previousButton != null) { _previousButton.Enabled = true; }
            }
            if (_index == _count | _count == 1)
            {
                if (_lastButton != null) { _lastButton.Enabled = false; }
                if (_nextButton != null) { _nextButton.Enabled = false; }
            }
            else
            {
                if (_lastButton != null) { _lastButton.Enabled = true; }
                if (_nextButton != null) { _nextButton.Enabled = true; }
            }
            if (_indexTextBox != null)
            {
                _indexTextBox.Text = _index.ToString() + " ";
                _indexTextBox.Enabled = (_count != 1);
            }
            if (_countLabel != null) { _countLabel.Text = "/" + _count.ToString(); }
        }

        private void buttons_Click(object sender, EventArgs e)
        {
            ToolStripButton button = (ToolStripButton)sender;
            switch (button.Tag.ToString())
            {
                case "First":
                    if (_index > 1)
                    {
                        _index = 1;
                        changeStyle();
                        if (IndexChanged != null) { IndexChanged(this, EventArgs.Empty); }
                    }
                    break;
                case "Previous":
                    if (_index > 1)
                    {
                        _index = _index - 1;
                        changeStyle();
                        if (IndexChanged != null) { IndexChanged(this, EventArgs.Empty); }
                    }
                    break;
                case "Next":
                    if (_index < _count)
                    {
                        _index = _index + 1;
                        changeStyle();
                        if (IndexChanged != null) { IndexChanged(this, EventArgs.Empty); }
                    }
                    break;
                case "Last":
                    if (_index < _count)
                    {
                        _index = _count;
                        changeStyle();
                        if (IndexChanged != null) { IndexChanged(this, EventArgs.Empty); }
                    }
                    break;
            }
        }

        [Browsable(true)]
        public event EventHandler<EventArgs> IndexChanged;
        private int _index = 1;
        /// <summary>
        /// 次序
        /// </summary>
        public int Index
        {
            get { return _index; }
        }

        private int _count = 1;
        /// <summary>
        /// 設定資料
        /// </summary>
        /// <param name="count">數量</param>
        /// <param name="index">次序</param>
        public void SetData(int count, int index)
        {
            _index = index;
            _count = count;
            if (_count < 1) { _count = 1; }
            if (_index > _count) { _index = _count; }
            if (_index < 1) { _index = 1; }
            changeStyle();
        }

        /// <summary>
        /// 第一按鍵
        /// </summary>
        public SmartHome.StyleControls.ToolStripButton FirstButton
        {
            get { return _firstButton; }
            set
            {
                if (_firstButton != null) { _firstButton.Click -= buttons_Click; }

                _firstButton = value;
                if (_firstButton != null)
                {
                    SetButtonStyle(_firstButton);
                    _firstButton.Image = Properties.Resources.Navigator_First;
                    _firstButton.Tag = "First";
                    _firstButton.Click += buttons_Click;
                    _firstButton.Visible = Visible;
                    changeStyle();
                }
            }
        }

        /// <summary>
        /// 上一個按鍵
        /// </summary>
        public SmartHome.StyleControls.ToolStripButton PreviousButton
        {
            get { return _previousButton; }
            set
            {
                if (_previousButton != null) { _previousButton.Click -= buttons_Click; }

                _previousButton = value;
                if (_previousButton != null)
                {
                    SetButtonStyle(_previousButton);
                    _previousButton.Image = Properties.Resources.Navigator_Previous;
                    _previousButton.Tag = "Previous";
                    _previousButton.Click += buttons_Click;
                    _previousButton.Visible = Visible;
                    changeStyle();
                }
            }
        }

        /// <summary>
        /// 最後按鍵
        /// </summary>
        public SmartHome.StyleControls.ToolStripButton LastButton
        {
            get { return _lastButton; }
            set
            {
                if (_lastButton != null) { _lastButton.Click -= buttons_Click; }

                _lastButton = value;
                if (_lastButton != null)
                {
                    SetButtonStyle(_lastButton);
                    _lastButton.Image = Properties.Resources.Navigator_Last;
                    _lastButton.Tag = "Last";
                    _lastButton.Click += buttons_Click;
                    _lastButton.Visible = Visible;
                    changeStyle();
                }
            }
        }

        /// <summary>
        /// 下一個按鍵
        /// </summary>
        public SmartHome.StyleControls.ToolStripButton NextButton
        {
            get { return _nextButton; }
            set
            {
                if (_nextButton != null) { _nextButton.Click -= buttons_Click; }

                _nextButton = value;
                if (_nextButton != null)
                {
                    SetButtonStyle(_nextButton);
                    _nextButton.Image = Properties.Resources.Navigator_Next;
                    _nextButton.Tag = "Next";
                    _nextButton.Click += buttons_Click;
                    _nextButton.Visible = Visible;
                    changeStyle();
                }
            }
        }

        /// <summary>
        /// 次序文字盒
        /// </summary>
        public ToolStripTextBox IndexTextBox
        {
            get { return _indexTextBox; }
            set
            {
                if (_indexTextBox != null)
                {
                    _indexTextBox.Validated -= indexTextBox_TextChanged;
                    _indexTextBox.KeyDown -= indexTextBox_KeyDown;
                }
                _indexTextBox = value;
                if ((_indexTextBox != null))
                {
                    _indexTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    _indexTextBox.Font = Helper.Style.Font;
                    _indexTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                    _indexTextBox.AutoSize = false;
                    _indexTextBox.Text = "1 ";
                    _indexTextBox.Enabled = false;
                    _indexTextBox.Size = new Size(80,64);
                    _indexTextBox.Margin = new Padding(0);
                    _indexTextBox.TextChanged += indexTextBox_TextChanged;
                    _indexTextBox.KeyDown += indexTextBox_KeyDown;
                    _indexTextBox.Visible = Visible;
                    changeStyle();
                }
            }
        }

        private void indexTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                indexTextBox_TextChanged(_indexTextBox, EventArgs.Empty);
            }
        }
        private void indexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int value = Convert.ToInt32(_indexTextBox.Text);
                if (value > _count) { value = _count; }
                if (value < 1) { value = 1; }
                if (_index != value)
                {
                    _index = value;
                    changeStyle();
                    if (IndexChanged != null) { IndexChanged(this, EventArgs.Empty); }
                }
                else
                {
                    changeStyle();
                }
            }
            catch {   changeStyle(); }
        }

        /// <summary>
        /// 數量標籤
        /// </summary>
        public ToolStripLabel CountLabel
        {
            get { return _countLabel; }
            set
            {
                _countLabel = value;
                if (_countLabel != null)
                {
                    _countLabel.Font = Helper.Style.Font;
                    _countLabel.AutoSize = true;
                    _countLabel.Margin = new Padding(0);
                    _countLabel.Visible = Visible;
                    changeStyle();
                }
            }
        }

        private bool _visible = true;
        public bool Visible
        {
            get { return _visible; }
            set
            {
                if (_visible != value)
                {
                    _visible = value;
                    if (_firstButton != null) { _firstButton.Visible = _visible; }
                    if (_previousButton != null) { _previousButton.Visible = _visible; }
                    if (_lastButton != null) { _lastButton.Visible = _visible; }
                    if (_nextButton != null) { _nextButton.Visible = _visible; }
                    if (_indexTextBox != null) { _indexTextBox.Visible = _visible; }
                    if (_countLabel != null) { _countLabel.Visible = _visible; }
                }
            }
        }

    }
}
