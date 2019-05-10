namespace MacroParametersTool
{
    partial class GroupItemUserControl
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Text = new SmartHome.StyleControls.Label();
            this.SuspendLayout();
            // 
            // label_Text
            // 
            this.label_Text.BorderColor = System.Drawing.Color.White;
            this.label_Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_Text.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.label_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Text.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_Text.Image = null;
            this.label_Text.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Text.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.label_Text.Location = new System.Drawing.Point(2, 2);
            this.label_Text.Margin = new System.Windows.Forms.Padding(4);
            this.label_Text.Name = "label_Text";
            this.label_Text.Padding = new System.Windows.Forms.Padding(4);
            this.label_Text.Radiuses = new System.Windows.CornerRadius(0D, 0D, 0D, 0D);
            this.label_Text.Size = new System.Drawing.Size(188, 52);
            this.label_Text.StyleMode = SmartHome.StyleControls.StyleMode.LowChroma;
            this.label_Text.TabIndex = 0;
            this.label_Text.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_Text.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // GroupItemUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label_Text);
            this.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "GroupItemUserControl";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(192, 56);
            this.ResumeLayout(false);

        }

        #endregion

        private SmartHome.StyleControls.Label label_Text;
    }
}
