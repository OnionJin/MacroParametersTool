using System.Windows.Forms;

namespace SmartHome.StyleControls
{
    /// <summary>
    /// 工具列控制項
    /// </summary>
    public class ToolStrip : System.Windows.Forms.ToolStrip
    {
        private ToolStripRenderer _renderer = new ToolStripRenderer();
        /// <summary>
        /// 建構函式
        /// </summary>
        public ToolStrip() : base()
        {
            this.Font = Helper.Style.Font;
            this.BackColor = Helper.Style.LowChroma.BackColor;
            this.ForeColor = Helper.Style.LowChroma.ForeColor;
            this.AutoSize = false;
            this.Renderer = _renderer;
            this.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.Text = "";
            this.Padding = new Padding(0);
        }

        /// <summary>
        /// 底線
        /// </summary>
        public bool Bottomline
        {
            get
            {
                if (_renderer == null)
                {
                    return false;
                }
                else
                {
                    return _renderer.Bottomline;
                }
            }
            set
            {
                if (_renderer != null) { _renderer.Bottomline = value; }
            }
        }

    }
}
