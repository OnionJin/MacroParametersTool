using System;
using System.Windows.Forms;

namespace SmartHome.StyleControls
{
    public partial class IntergerDialog : SmartHome.StyleControls.DialogBase
    {
        public IntergerDialog()
        {
            InitializeComponent();
        }

        private int Format()
        {
            int r = 0;
            try
            {
                r = int.Parse(label_Value.Text);
            }
            catch { }
            if (r > _maximum || r < _minimum) { label_Value.StyleMode = StyleMode.Warning; }
            else { label_Value.StyleMode = StyleMode.Control; }
            return r;
        }

        private int _maximum = 1000;
        /// <summary>
        /// 最大
        /// </summary>
        public int Maximum
        {
            get { return _maximum; }
            set
            {
                if (value > -1)
                {
                    _maximum = value;
                    Format();
                }
            }
        }

        private int _minimum = 0;
        /// <summary>
        /// 最小
        /// </summary>
        public int Minimum
        {
            get { return _minimum; }
            set
            {
                if (value > -1)
                {
                    _minimum = value;
                    Format();
                }
            }
        }

        /// <summary>
        /// 值
        /// </summary>
        public int Value
        {
            get { return Format(); }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            if (label_Value.StyleMode == StyleMode.Control) { DialogResult = DialogResult.OK; }
        }

        private void Buttons__Click(object sender, EventArgs e)
        {
            string dtmf = (string)((Control)sender).Tag;
            if (dtmf == "Backspace")
            {
                if (label_Value.Text.Length > 0) { label_Value.Text = label_Value.Text.Substring(0, label_Value.Text.Length - 1); }
            }
            else
            {
                label_Value.Text = label_Value.Text + dtmf;
            }
            Format();
        }
    }
}
