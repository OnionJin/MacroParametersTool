namespace SmartHome.StyleControls
{
    partial class MessageBoxBase
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_ImageFrame = new System.Windows.Forms.Panel();
            this.pictureBox_Image = new System.Windows.Forms.PictureBox();
            this.label_Message = new System.Windows.Forms.Label();
            this.panel_Content.SuspendLayout();
            this.panel_ImageFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.Size = new System.Drawing.Size(624, 64);
            // 
            // panel_Bottom
            // 
            this.panel_Bottom.Location = new System.Drawing.Point(8, 202);
            this.panel_Bottom.Size = new System.Drawing.Size(624, 64);
            // 
            // panel_Content
            // 
            this.panel_Content.Controls.Add(this.label_Message);
            this.panel_Content.Controls.Add(this.panel_ImageFrame);
            this.panel_Content.Size = new System.Drawing.Size(624, 136);
            // 
            // panel_ImageFrame
            // 
            this.panel_ImageFrame.Controls.Add(this.pictureBox_Image);
            this.panel_ImageFrame.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_ImageFrame.Location = new System.Drawing.Point(4, 4);
            this.panel_ImageFrame.Margin = new System.Windows.Forms.Padding(0);
            this.panel_ImageFrame.Name = "panel_ImageFrame";
            this.panel_ImageFrame.Size = new System.Drawing.Size(128, 128);
            this.panel_ImageFrame.TabIndex = 1;
            // 
            // pictureBox_Image
            // 
            this.pictureBox_Image.Location = new System.Drawing.Point(16, 16);
            this.pictureBox_Image.Margin = new System.Windows.Forms.Padding(16);
            this.pictureBox_Image.Name = "pictureBox_Image";
            this.pictureBox_Image.Size = new System.Drawing.Size(96, 96);
            this.pictureBox_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Image.TabIndex = 0;
            this.pictureBox_Image.TabStop = false;
            // 
            // label_Message
            // 
            this.label_Message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Message.Location = new System.Drawing.Point(132, 4);
            this.label_Message.Name = "label_Message";
            this.label_Message.Padding = new System.Windows.Forms.Padding(16);
            this.label_Message.Size = new System.Drawing.Size(488, 128);
            this.label_Message.TabIndex = 2;
            this.label_Message.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MessageBoxBase
            // 
            this.ClientSize = new System.Drawing.Size(640, 268);
            this.Name = "MessageBoxBase";
            this.panel_Content.ResumeLayout(false);
            this.panel_ImageFrame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.Label label_Message;
        private System.Windows.Forms.Panel panel_ImageFrame;
        protected internal System.Windows.Forms.PictureBox pictureBox_Image;
    }
}
