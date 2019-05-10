using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmartHome.StyleControls
{
    public partial class DialogBase : Form
    {
        protected delegate void EventCallback(object sender, EventArgs e);
        public DialogBase()
        {
            InitializeComponent();
            this.Font = Helper.Style.Font;
            this.BackColor = Helper.Style.LowChroma.BackColor;
            label_Title.BackColor = Helper.Style.LowChroma.BackColor;
            label_Title.ForeColor = Helper.Style.LowChroma.ForeColor;
            panel_Content.BackColor = Helper.Style.Normal.BackColor;
            panel_Content.ForeColor = Helper.Style.Normal.ForeColor;
            panel_Bottom.BackColor = Helper.Style.LowChroma.BackColor;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ControlPaint.DrawBorder3D(e.Graphics, e.ClipRectangle, Border3DStyle.Raised);
        }

        /// <summary>
        /// 顯示對話視窗
        /// </summary>
        public new DialogResult ShowDialog(IWin32Window owner)
        {
            DialogResult r = DialogResult.Cancel;
            Form baseForm = owner as Form;
            if (baseForm == null)
            {
                r = base.ShowDialog(owner);
            }
            else
            {
                Form backForm = new Form();
                backForm.FormBorderStyle = FormBorderStyle.None;
                backForm.Opacity = 0.64;
                backForm.Padding = new Padding(0);
                backForm.Location = baseForm.Location;
                backForm.ShowIcon = false;
                backForm.ShowInTaskbar = false;
                backForm.SizeGripStyle = SizeGripStyle.Hide;
                backForm.StartPosition = FormStartPosition.Manual;
                backForm.BackColor = Color.Black;
                backForm.Size = baseForm.Size;
                backForm.Show(owner);
                r = base.ShowDialog(backForm);
                backForm.Close();
                baseForm.Focus();
            }
            return r;
        }

        public string Title
        {
            get { return label_Title.Text; }
            set { label_Title.Text = value; }
        }

    }
}
