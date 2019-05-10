namespace SmartHome.StyleControls
{
    partial class DialogBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Bottom = new System.Windows.Forms.Panel();
            this.panel_Content = new System.Windows.Forms.Panel();
            this.label_Title = new SmartHome.StyleControls.Label();
            this.SuspendLayout();
            // 
            // panel_Bottom
            // 
            this.panel_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Bottom.Location = new System.Drawing.Point(8, 358);
            this.panel_Bottom.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Bottom.Name = "panel_Bottom";
            this.panel_Bottom.Size = new System.Drawing.Size(584, 64);
            this.panel_Bottom.TabIndex = 1;
            // 
            // panel_Content
            // 
            this.panel_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Content.Location = new System.Drawing.Point(8, 66);
            this.panel_Content.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Content.Name = "panel_Content";
            this.panel_Content.Padding = new System.Windows.Forms.Padding(4);
            this.panel_Content.Size = new System.Drawing.Size(584, 292);
            this.panel_Content.TabIndex = 2;
            // 
            // label_Title
            // 
            this.label_Title.BorderColor = System.Drawing.Color.White;
            this.label_Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_Title.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.label_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Title.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_Title.Image = null;
            this.label_Title.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Title.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.label_Title.Location = new System.Drawing.Point(8, 2);
            this.label_Title.Margin = new System.Windows.Forms.Padding(0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Radiuses = new System.Windows.CornerRadius(0D, 0D, 0D, 0D);
            this.label_Title.Size = new System.Drawing.Size(584, 64);
            this.label_Title.StyleMode = SmartHome.StyleControls.StyleMode.LowChroma;
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "標題";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Title.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // DialogBase
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(600, 424);
            this.Controls.Add(this.panel_Content);
            this.Controls.Add(this.panel_Bottom);
            this.Controls.Add(this.label_Title);
            this.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "DialogBase";
            this.Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DialogBase";
            this.ResumeLayout(false);

        }

        #endregion

        protected internal StyleControls.Label label_Title;
        protected internal System.Windows.Forms.Panel panel_Bottom;
        protected internal System.Windows.Forms.Panel panel_Content;
    }
}