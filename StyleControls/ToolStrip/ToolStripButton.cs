using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmartHome.StyleControls
{
    /// <summary>
    /// 工具列按鍵控制項
    /// </summary>
    public class ToolStripButton : System.Windows.Forms.ToolStripButton
    {
        public ToolStripButton() : base()
        {
            this.Size = new Size(64, 64);
            this.Margin = new Padding(4);
            this.AutoSize = false;
            this.Font = Helper.Style.Font;
        }

        protected override void OnClick(EventArgs e)
        {
            if (Helper.SoundPlayer != null) { Helper.SoundPlayer.Play(Helper.ClickSound); }
            base.OnClick(e);
        }
    }
}
