namespace MacroParametersTool
{
    partial class DeleteDialog
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
            this.button_Confirm = new SmartHome.StyleControls.Button();
            this.button_Cancel = new SmartHome.StyleControls.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).BeginInit();
            this.panel_Bottom.SuspendLayout();
            this.panel_Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Message
            // 
            this.label_Message.Text = "你確定要刪除這筆資料嗎？";
            // 
            // pictureBox_Image
            // 
            this.pictureBox_Image.Image = global::MacroParametersTool.Properties.Resources.MessageBox_Warning;
            // 
            // label_Title
            // 
            this.label_Title.Text = "刪除";
            // 
            // panel_Bottom
            // 
            this.panel_Bottom.Controls.Add(this.button_Confirm);
            this.panel_Bottom.Controls.Add(this.button_Cancel);
            // 
            // button_Confirm
            // 
            this.button_Confirm.BorderColor = System.Drawing.Color.White;
            this.button_Confirm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.button_Confirm.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button_Confirm.Image = null;
            this.button_Confirm.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_Confirm.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.button_Confirm.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.button_Confirm.Location = new System.Drawing.Point(352, 8);
            this.button_Confirm.Margin = new System.Windows.Forms.Padding(8);
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.Radiuses = new System.Windows.CornerRadius(0D, 0D, 0D, 0D);
            this.button_Confirm.Size = new System.Drawing.Size(128, 48);
            this.button_Confirm.StyleMode = SmartHome.StyleControls.StyleMode.LowChroma;
            this.button_Confirm.TabIndex = 5;
            this.button_Confirm.Tag = "Confirm";
            this.button_Confirm.Text = "確認";
            this.button_Confirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_Confirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Confirm.ToolTipText = "";
            this.button_Confirm.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.BorderColor = System.Drawing.Color.White;
            this.button_Cancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.button_Cancel.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button_Cancel.Image = null;
            this.button_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_Cancel.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.button_Cancel.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.button_Cancel.Location = new System.Drawing.Point(496, 8);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(8);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Radiuses = new System.Windows.CornerRadius(0D, 0D, 0D, 0D);
            this.button_Cancel.Size = new System.Drawing.Size(128, 48);
            this.button_Cancel.StyleMode = SmartHome.StyleControls.StyleMode.LowChroma;
            this.button_Cancel.TabIndex = 4;
            this.button_Cancel.Tag = "Cancel";
            this.button_Cancel.Text = "取消";
            this.button_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Cancel.ToolTipText = "";
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // DeleteDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 268);
            this.Name = "DeleteDialog";
            this.Text = "DeleteDialog";
            this.Title = "刪除";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).EndInit();
            this.panel_Bottom.ResumeLayout(false);
            this.panel_Content.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SmartHome.StyleControls.Button button_Confirm;
        private SmartHome.StyleControls.Button button_Cancel;
    }
}