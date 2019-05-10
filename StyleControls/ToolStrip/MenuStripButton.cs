using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmartHome.StyleControls
{
    public class MenuStripButton : System.Windows.Forms.ToolStripMenuItem
    {
        public MenuStripButton() : base()
        {
            this.Size = new Size(320, 80);
            this.Margin = new Padding(4);
            this.Padding = new Padding(8);
            this.AutoSize = false;
        }

        protected override void OnClick(EventArgs e)
        {
            if (Helper.SoundPlayer != null) { Helper.SoundPlayer.Play(Helper.ClickSound); }
            base.OnClick(e);
        }

    }
}
