namespace SmartHome.StyleControls
{
    partial class TextBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextBox));
            this.panel_Content = new System.Windows.Forms.Panel();
            this.textBox_Text = new System.Windows.Forms.TextBox();
            this.panel_Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Content
            // 
            this.panel_Content.Controls.Add(this.textBox_Text);
            resources.ApplyResources(this.panel_Content, "panel_Content");
            this.panel_Content.Name = "panel_Content";
            // 
            // textBox_Text
            // 
            this.textBox_Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox_Text, "textBox_Text");
            this.textBox_Text.Name = "textBox_Text";
            // 
            // TextBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel_Content);
            resources.ApplyResources(this, "$this");
            this.Name = "TextBox";
            this.panel_Content.ResumeLayout(false);
            this.panel_Content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Content;
        private System.Windows.Forms.TextBox textBox_Text;
    }
}
