namespace MacroParametersTool
{
    partial class ImportDialog
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
            this.button_Executer = new SmartHome.StyleControls.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label_Directory = new SmartHome.StyleControls.Label();
            this.dropDownList_Directory = new SmartHome.StyleControls.DropDownList();
            this.label_Kind = new SmartHome.StyleControls.Label();
            this.textBox_Kind = new SmartHome.StyleControls.TextBox();
            this.label_ImportMark = new SmartHome.StyleControls.Label();
            this.textBox_ImportMark = new SmartHome.StyleControls.TextBox();
            this.toggleButton_Clear = new SmartHome.StyleControls.ToggleButton();
            this.textBox_Message = new SmartHome.StyleControls.TextBox();
            this.button_Close = new SmartHome.StyleControls.Button();
            this.panel_Bottom.SuspendLayout();
            this.panel_Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.Size = new System.Drawing.Size(784, 64);
            this.label_Title.Text = "匯入";
            // 
            // panel_Bottom
            // 
            this.panel_Bottom.Controls.Add(this.button_Close);
            this.panel_Bottom.Location = new System.Drawing.Point(8, 534);
            this.panel_Bottom.Size = new System.Drawing.Size(784, 64);
            // 
            // panel_Content
            // 
            this.panel_Content.Controls.Add(this.textBox_Message);
            this.panel_Content.Controls.Add(this.button_Executer);
            this.panel_Content.Controls.Add(this.toggleButton_Clear);
            this.panel_Content.Controls.Add(this.textBox_ImportMark);
            this.panel_Content.Controls.Add(this.label_ImportMark);
            this.panel_Content.Controls.Add(this.textBox_Kind);
            this.panel_Content.Controls.Add(this.label_Kind);
            this.panel_Content.Controls.Add(this.dropDownList_Directory);
            this.panel_Content.Controls.Add(this.label_Directory);
            this.panel_Content.Size = new System.Drawing.Size(784, 468);
            // 
            // button_Executer
            // 
            this.button_Executer.BorderColor = System.Drawing.Color.White;
            this.button_Executer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.button_Executer.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button_Executer.Image = null;
            this.button_Executer.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_Executer.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.button_Executer.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.button_Executer.Location = new System.Drawing.Point(648, 176);
            this.button_Executer.Margin = new System.Windows.Forms.Padding(8);
            this.button_Executer.Name = "button_Executer";
            this.button_Executer.Radiuses = new System.Windows.CornerRadius(0D, 0D, 0D, 0D);
            this.button_Executer.Size = new System.Drawing.Size(128, 48);
            this.button_Executer.StyleMode = SmartHome.StyleControls.StyleMode.LowChroma;
            this.button_Executer.TabIndex = 21;
            this.button_Executer.Tag = "Confirm";
            this.button_Executer.Text = "執行";
            this.button_Executer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_Executer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Executer.ToolTipText = "";
            this.button_Executer.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // label_Directory
            // 
            this.label_Directory.BorderColor = System.Drawing.Color.White;
            this.label_Directory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_Directory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.label_Directory.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_Directory.Image = null;
            this.label_Directory.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Directory.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.label_Directory.Location = new System.Drawing.Point(8, 8);
            this.label_Directory.Margin = new System.Windows.Forms.Padding(4);
            this.label_Directory.Name = "label_Directory";
            this.label_Directory.Padding = new System.Windows.Forms.Padding(4);
            this.label_Directory.Radiuses = new System.Windows.CornerRadius(0D, 0D, 0D, 0D);
            this.label_Directory.Size = new System.Drawing.Size(180, 48);
            this.label_Directory.StyleMode = SmartHome.StyleControls.StyleMode.LowChroma;
            this.label_Directory.TabIndex = 32;
            this.label_Directory.Text = "目錄夾";
            this.label_Directory.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label_Directory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // dropDownList_Directory
            // 
            this.dropDownList_Directory.BackColor = System.Drawing.Color.Transparent;
            this.dropDownList_Directory.ClearButtonToolTipText = "";
            this.dropDownList_Directory.DownButtonToolTipText = "";
            this.dropDownList_Directory.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dropDownList_Directory.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dropDownList_Directory.Location = new System.Drawing.Point(196, 8);
            this.dropDownList_Directory.Margin = new System.Windows.Forms.Padding(4);
            this.dropDownList_Directory.Name = "dropDownList_Directory";
            this.dropDownList_Directory.Padding = new System.Windows.Forms.Padding(4);
            this.dropDownList_Directory.Size = new System.Drawing.Size(580, 48);
            this.dropDownList_Directory.TabIndex = 33;
            this.dropDownList_Directory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dropDownList_Directory.Warning = false;
            this.dropDownList_Directory.ClearButtonClick += new System.EventHandler<System.EventArgs>(this.dropDownList_Directory_ClearButtonClick);
            this.dropDownList_Directory.DownButtonClick += new System.EventHandler<System.EventArgs>(this.dropDownList_Directory_DownButtonClick);
            // 
            // label_Kind
            // 
            this.label_Kind.BorderColor = System.Drawing.Color.White;
            this.label_Kind.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_Kind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.label_Kind.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_Kind.Image = null;
            this.label_Kind.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Kind.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.label_Kind.Location = new System.Drawing.Point(8, 64);
            this.label_Kind.Margin = new System.Windows.Forms.Padding(4);
            this.label_Kind.Name = "label_Kind";
            this.label_Kind.Padding = new System.Windows.Forms.Padding(4);
            this.label_Kind.Radiuses = new System.Windows.CornerRadius(0D, 0D, 0D, 0D);
            this.label_Kind.Size = new System.Drawing.Size(180, 48);
            this.label_Kind.StyleMode = SmartHome.StyleControls.StyleMode.LowChroma;
            this.label_Kind.TabIndex = 34;
            this.label_Kind.Text = "參數種類";
            this.label_Kind.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label_Kind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // textBox_Kind
            // 
            this.textBox_Kind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox_Kind.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBox_Kind.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBox_Kind.Location = new System.Drawing.Point(196, 64);
            this.textBox_Kind.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Kind.MaxLength = 32767;
            this.textBox_Kind.Multiline = false;
            this.textBox_Kind.Name = "textBox_Kind";
            this.textBox_Kind.Padding = new System.Windows.Forms.Padding(2);
            this.textBox_Kind.PasswordChar = '\0';
            this.textBox_Kind.ReadOnly = false;
            this.textBox_Kind.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_Kind.Size = new System.Drawing.Size(580, 48);
            this.textBox_Kind.TabIndex = 35;
            this.textBox_Kind.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox_Kind.Warning = false;
            // 
            // label_ImportMark
            // 
            this.label_ImportMark.BorderColor = System.Drawing.Color.White;
            this.label_ImportMark.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_ImportMark.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.label_ImportMark.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_ImportMark.Image = null;
            this.label_ImportMark.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_ImportMark.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.label_ImportMark.Location = new System.Drawing.Point(8, 120);
            this.label_ImportMark.Margin = new System.Windows.Forms.Padding(4);
            this.label_ImportMark.Name = "label_ImportMark";
            this.label_ImportMark.Padding = new System.Windows.Forms.Padding(4);
            this.label_ImportMark.Radiuses = new System.Windows.CornerRadius(0D, 0D, 0D, 0D);
            this.label_ImportMark.Size = new System.Drawing.Size(180, 48);
            this.label_ImportMark.StyleMode = SmartHome.StyleControls.StyleMode.LowChroma;
            this.label_ImportMark.TabIndex = 36;
            this.label_ImportMark.Text = "匯入註解";
            this.label_ImportMark.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label_ImportMark.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // textBox_ImportMark
            // 
            this.textBox_ImportMark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox_ImportMark.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBox_ImportMark.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBox_ImportMark.Location = new System.Drawing.Point(196, 120);
            this.textBox_ImportMark.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ImportMark.MaxLength = 32767;
            this.textBox_ImportMark.Multiline = false;
            this.textBox_ImportMark.Name = "textBox_ImportMark";
            this.textBox_ImportMark.Padding = new System.Windows.Forms.Padding(2);
            this.textBox_ImportMark.PasswordChar = '\0';
            this.textBox_ImportMark.ReadOnly = false;
            this.textBox_ImportMark.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_ImportMark.Size = new System.Drawing.Size(580, 48);
            this.textBox_ImportMark.TabIndex = 37;
            this.textBox_ImportMark.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox_ImportMark.Warning = false;
            // 
            // toggleButton_Clear
            // 
            this.toggleButton_Clear.Checked = false;
            this.toggleButton_Clear.CheckedImage = null;
            this.toggleButton_Clear.CheckedText = "清除之前匯入資料";
            this.toggleButton_Clear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.toggleButton_Clear.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.toggleButton_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toggleButton_Clear.Location = new System.Drawing.Point(8, 176);
            this.toggleButton_Clear.Margin = new System.Windows.Forms.Padding(4);
            this.toggleButton_Clear.Name = "toggleButton_Clear";
            this.toggleButton_Clear.Size = new System.Drawing.Size(319, 48);
            this.toggleButton_Clear.Style = SmartHome.StyleControls.ToggleButtonStyle.CheckBox;
            this.toggleButton_Clear.StyleMode = SmartHome.StyleControls.StyleMode.Normal;
            this.toggleButton_Clear.TabIndex = 38;
            this.toggleButton_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toggleButton_Clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toggleButton_Clear.UncheckedImage = null;
            this.toggleButton_Clear.UncheckedText = "清除之前匯入資料";
            // 
            // textBox_Message
            // 
            this.textBox_Message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox_Message.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBox_Message.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBox_Message.Location = new System.Drawing.Point(8, 236);
            this.textBox_Message.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Message.MaxLength = 32767;
            this.textBox_Message.Multiline = true;
            this.textBox_Message.Name = "textBox_Message";
            this.textBox_Message.Padding = new System.Windows.Forms.Padding(2);
            this.textBox_Message.PasswordChar = '\0';
            this.textBox_Message.ReadOnly = true;
            this.textBox_Message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Message.Size = new System.Drawing.Size(768, 224);
            this.textBox_Message.TabIndex = 39;
            this.textBox_Message.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox_Message.Warning = false;
            // 
            // button_Close
            // 
            this.button_Close.BorderColor = System.Drawing.Color.White;
            this.button_Close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.button_Close.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button_Close.Image = null;
            this.button_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_Close.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.button_Close.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.button_Close.Location = new System.Drawing.Point(656, 8);
            this.button_Close.Margin = new System.Windows.Forms.Padding(8);
            this.button_Close.Name = "button_Close";
            this.button_Close.Radiuses = new System.Windows.CornerRadius(0D, 0D, 0D, 0D);
            this.button_Close.Size = new System.Drawing.Size(128, 48);
            this.button_Close.StyleMode = SmartHome.StyleControls.StyleMode.LowChroma;
            this.button_Close.TabIndex = 22;
            this.button_Close.Text = "關閉";
            this.button_Close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Close.ToolTipText = "";
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // ImportDialog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "ImportDialog";
            this.Text = "ImportDialog";
            this.Title = "匯入";
            this.panel_Bottom.ResumeLayout(false);
            this.panel_Content.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SmartHome.StyleControls.Button button_Executer;
        private SmartHome.StyleControls.Label label_Directory;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private SmartHome.StyleControls.Label label_Kind;
        private SmartHome.StyleControls.DropDownList dropDownList_Directory;
        private SmartHome.StyleControls.Label label_ImportMark;
        private SmartHome.StyleControls.TextBox textBox_Kind;
        private SmartHome.StyleControls.ToggleButton toggleButton_Clear;
        private SmartHome.StyleControls.TextBox textBox_ImportMark;
        private SmartHome.StyleControls.TextBox textBox_Message;
        private SmartHome.StyleControls.Button button_Close;
    }
}