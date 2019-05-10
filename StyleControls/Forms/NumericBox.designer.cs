namespace SmartHome.StyleControls
{
    partial class NumericBox
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            this.textBox_Text = new System.Windows.Forms.TextBox();
            this.button_Plus = new SmartHome.StyleControls.Button();
            this.button_Minus = new SmartHome.StyleControls.Button();
            this.panel_TextContent = new System.Windows.Forms.Panel();
            this.panel_TextFrame = new System.Windows.Forms.Panel();
            this.panel_TextContent.SuspendLayout();
            this.panel_TextFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Text
            // 
            this.textBox_Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Text.Location = new System.Drawing.Point(0, 0);
            this.textBox_Text.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_Text.Name = "textBox_Text";
            this.textBox_Text.Size = new System.Drawing.Size(76, 64);
            this.textBox_Text.TabIndex = 5;
            this.textBox_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_Plus
            // 
            this.button_Plus.BorderColor = System.Drawing.Color.White;
            this.button_Plus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_Plus.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button_Plus.Image = global::SmartHome.StyleControls.Properties.Resources.NumericBox__Plus;
            this.button_Plus.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_Plus.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.button_Plus.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.button_Plus.Location = new System.Drawing.Point(84, 0);
            this.button_Plus.Margin = new System.Windows.Forms.Padding(0);
            this.button_Plus.Name = "button_Plus";
            this.button_Plus.Radiuses = new System.Windows.CornerRadius(0D, 0D, 0D, 0D);
            this.button_Plus.Size = new System.Drawing.Size(48, 48);
            this.button_Plus.StyleMode = SmartHome.StyleControls.StyleMode.LowChroma;
            this.button_Plus.TabIndex = 4;
            this.button_Plus.Tag = "Plus";
            this.button_Plus.Text = "Plus";
            this.button_Plus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_Plus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Plus.ToolTipText = "";
            // 
            // button_Minus
            // 
            this.button_Minus.BorderColor = System.Drawing.Color.White;
            this.button_Minus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_Minus.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button_Minus.Image = global::SmartHome.StyleControls.Properties.Resources.NumericBox__Minus;
            this.button_Minus.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_Minus.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.button_Minus.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.button_Minus.Location = new System.Drawing.Point(132, 0);
            this.button_Minus.Margin = new System.Windows.Forms.Padding(0);
            this.button_Minus.Name = "button_Minus";
            this.button_Minus.Radiuses = new System.Windows.CornerRadius(0D, 0D, 0D, 0D);
            this.button_Minus.Size = new System.Drawing.Size(48, 48);
            this.button_Minus.StyleMode = SmartHome.StyleControls.StyleMode.LowChroma;
            this.button_Minus.TabIndex = 3;
            this.button_Minus.Tag = "Minus";
            this.button_Minus.Text = "Minus";
            this.button_Minus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_Minus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Minus.ToolTipText = "";
            // 
            // panel_TextContent
            // 
            this.panel_TextContent.Controls.Add(this.textBox_Text);
            this.panel_TextContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_TextContent.Location = new System.Drawing.Point(2, 2);
            this.panel_TextContent.Margin = new System.Windows.Forms.Padding(0);
            this.panel_TextContent.Name = "panel_TextContent";
            this.panel_TextContent.Size = new System.Drawing.Size(76, 44);
            this.panel_TextContent.TabIndex = 6;
            // 
            // panel_TextFrame
            // 
            this.panel_TextFrame.Controls.Add(this.panel_TextContent);
            this.panel_TextFrame.Location = new System.Drawing.Point(0, 0);
            this.panel_TextFrame.Margin = new System.Windows.Forms.Padding(0);
            this.panel_TextFrame.Name = "panel_TextFrame";
            this.panel_TextFrame.Padding = new System.Windows.Forms.Padding(2);
            this.panel_TextFrame.Size = new System.Drawing.Size(80, 48);
            this.panel_TextFrame.TabIndex = 7;
            // 
            // NumericBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel_TextFrame);
            this.Controls.Add(this.button_Plus);
            this.Controls.Add(this.button_Minus);
            this.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NumericBox";
            this.Size = new System.Drawing.Size(180, 48);
            this.panel_TextContent.ResumeLayout(false);
            this.panel_TextContent.PerformLayout();
            this.panel_TextFrame.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Text;
        private Button button_Plus;
        private Button button_Minus;
        private System.Windows.Forms.Panel panel_TextContent;
        private System.Windows.Forms.Panel panel_TextFrame;
    }
}
