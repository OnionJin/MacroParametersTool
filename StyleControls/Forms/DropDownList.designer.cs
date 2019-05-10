namespace SmartHome.StyleControls
{
    partial class DropDownList
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
            this.button_Clear = new SmartHome.StyleControls.Button();
            this.button_Down = new SmartHome.StyleControls.Button();
            this.SuspendLayout();
            // 
            // textBox_Text
            // 
            this.textBox_Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Text.Location = new System.Drawing.Point(0, 0);
            this.textBox_Text.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_Text.Name = "textBox_Text";
            this.textBox_Text.ReadOnly = true;
            this.textBox_Text.Size = new System.Drawing.Size(80, 43);
            this.textBox_Text.TabIndex = 2;
            // 
            // button_Clear
            // 
            this.button_Clear.BorderColor = System.Drawing.Color.White;
            this.button_Clear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_Clear.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button_Clear.Image = global::SmartHome.StyleControls.Properties.Resources.DropDownList_Clear;
            this.button_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_Clear.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.button_Clear.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.button_Clear.Location = new System.Drawing.Point(84, 0);
            this.button_Clear.Margin = new System.Windows.Forms.Padding(0);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Radiuses = new System.Windows.CornerRadius(0D, 0D, 0D, 0D);
            this.button_Clear.Size = new System.Drawing.Size(48, 48);
            this.button_Clear.StyleMode = SmartHome.StyleControls.StyleMode.LowChroma;
            this.button_Clear.TabIndex = 1;
            this.button_Clear.Tag = "Clear";
            this.button_Clear.Text = "Clear";
            this.button_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_Clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Clear.ToolTipText = "";
            // 
            // button_Down
            // 
            this.button_Down.BorderColor = System.Drawing.Color.White;
            this.button_Down.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_Down.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button_Down.Image = global::SmartHome.StyleControls.Properties.Resources.DropDownList_Down;
            this.button_Down.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_Down.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.button_Down.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.button_Down.Location = new System.Drawing.Point(132, 0);
            this.button_Down.Margin = new System.Windows.Forms.Padding(0);
            this.button_Down.Name = "button_Down";
            this.button_Down.Radiuses = new System.Windows.CornerRadius(0D, 0D, 0D, 0D);
            this.button_Down.Size = new System.Drawing.Size(48, 48);
            this.button_Down.StyleMode = SmartHome.StyleControls.StyleMode.LowChroma;
            this.button_Down.TabIndex = 0;
            this.button_Down.Tag = "Down";
            this.button_Down.Text = "Down";
            this.button_Down.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_Down.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Down.ToolTipText = "";
            // 
            // DropDownList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.textBox_Text);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Down);
            this.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DropDownList";
            this.Size = new System.Drawing.Size(180, 48);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StyleControls.Button button_Down;
        private StyleControls.Button button_Clear;
        private System.Windows.Forms.TextBox textBox_Text;
    }
}
