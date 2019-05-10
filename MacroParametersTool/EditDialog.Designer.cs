namespace MacroParametersTool
{
    partial class EditDialog
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
            this.label_Kind = new SmartHome.StyleControls.Label();
            this.label_KindText = new SmartHome.StyleControls.Label();
            this.label_Number = new SmartHome.StyleControls.Label();
            this.label_NumberText = new SmartHome.StyleControls.Label();
            this.label_Directory = new SmartHome.StyleControls.Label();
            this.label_DirectoryText = new SmartHome.StyleControls.Label();
            this.label_FileName = new SmartHome.StyleControls.Label();
            this.label_FileNameText = new SmartHome.StyleControls.Label();
            this.label_Line = new SmartHome.StyleControls.Label();
            this.label_LineText = new SmartHome.StyleControls.Label();
            this.label_ImportMark = new SmartHome.StyleControls.Label();
            this.label_ImportMarkText = new SmartHome.StyleControls.Label();
            this.label_Description = new SmartHome.StyleControls.Label();
            this.textBox_Description = new SmartHome.StyleControls.TextBox();
            this.label_IdText = new SmartHome.StyleControls.Label();
            this.label_Id = new SmartHome.StyleControls.Label();
            this.panel_Bottom.SuspendLayout();
            this.panel_Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.Size = new System.Drawing.Size(784, 64);
            // 
            // panel_Bottom
            // 
            this.panel_Bottom.Controls.Add(this.button_Confirm);
            this.panel_Bottom.Controls.Add(this.button_Cancel);
            this.panel_Bottom.Location = new System.Drawing.Point(8, 534);
            this.panel_Bottom.Size = new System.Drawing.Size(784, 64);
            // 
            // panel_Content
            // 
            this.panel_Content.Controls.Add(this.label_IdText);
            this.panel_Content.Controls.Add(this.label_Id);
            this.panel_Content.Controls.Add(this.textBox_Description);
            this.panel_Content.Controls.Add(this.label_Description);
            this.panel_Content.Controls.Add(this.label_ImportMarkText);
            this.panel_Content.Controls.Add(this.label_ImportMark);
            this.panel_Content.Controls.Add(this.label_LineText);
            this.panel_Content.Controls.Add(this.label_Line);
            this.panel_Content.Controls.Add(this.label_FileNameText);
            this.panel_Content.Controls.Add(this.label_FileName);
            this.panel_Content.Controls.Add(this.label_DirectoryText);
            this.panel_Content.Controls.Add(this.label_Directory);
            this.panel_Content.Controls.Add(this.label_NumberText);
            this.panel_Content.Controls.Add(this.label_Number);
            this.panel_Content.Controls.Add(this.label_KindText);
            this.panel_Content.Controls.Add(this.label_Kind);
            this.panel_Content.Size = new System.Drawing.Size(784, 468);
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
            this.button_Confirm.Location = new System.Drawing.Point(512, 8);
            this.button_Confirm.Margin = new System.Windows.Forms.Padding(8);
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.Radiuses = new System.Windows.CornerRadius(0D, 0D, 0D, 0D);
            this.button_Confirm.Size = new System.Drawing.Size(128, 48);
            this.button_Confirm.StyleMode = SmartHome.StyleControls.StyleMode.LowChroma;
            this.button_Confirm.TabIndex = 15;
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
            this.button_Cancel.Location = new System.Drawing.Point(656, 8);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(8);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Radiuses = new System.Windows.CornerRadius(0D, 0D, 0D, 0D);
            this.button_Cancel.Size = new System.Drawing.Size(128, 48);
            this.button_Cancel.StyleMode = SmartHome.StyleControls.StyleMode.LowChroma;
            this.button_Cancel.TabIndex = 14;
            this.button_Cancel.Tag = "Cancel";
            this.button_Cancel.Text = "取消";
            this.button_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Cancel.ToolTipText = "";
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
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
            this.label_Kind.TabIndex = 21;
            this.label_Kind.Text = "種類";
            this.label_Kind.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label_Kind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // label_KindText
            // 
            this.label_KindText.BorderColor = System.Drawing.Color.White;
            this.label_KindText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_KindText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.label_KindText.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_KindText.Image = null;
            this.label_KindText.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_KindText.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.label_KindText.Location = new System.Drawing.Point(196, 64);
            this.label_KindText.Margin = new System.Windows.Forms.Padding(4);
            this.label_KindText.Name = "label_KindText";
            this.label_KindText.Padding = new System.Windows.Forms.Padding(4);
            this.label_KindText.Radiuses = new System.Windows.CornerRadius(0D, 0D, 0D, 0D);
            this.label_KindText.Size = new System.Drawing.Size(190, 48);
            this.label_KindText.StyleMode = SmartHome.StyleControls.StyleMode.Control;
            this.label_KindText.TabIndex = 31;
            this.label_KindText.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label_KindText.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // label_Number
            // 
            this.label_Number.BorderColor = System.Drawing.Color.White;
            this.label_Number.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_Number.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.label_Number.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_Number.Image = null;
            this.label_Number.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Number.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.label_Number.Location = new System.Drawing.Point(398, 64);
            this.label_Number.Margin = new System.Windows.Forms.Padding(4);
            this.label_Number.Name = "label_Number";
            this.label_Number.Padding = new System.Windows.Forms.Padding(4);
            this.label_Number.Radiuses = new System.Windows.CornerRadius(0D, 0D, 0D, 0D);
            this.label_Number.Size = new System.Drawing.Size(180, 48);
            this.label_Number.StyleMode = SmartHome.StyleControls.StyleMode.LowChroma;
            this.label_Number.TabIndex = 32;
            this.label_Number.Text = "編號";
            this.label_Number.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label_Number.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // label_NumberText
            // 
            this.label_NumberText.BorderColor = System.Drawing.Color.White;
            this.label_NumberText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_NumberText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.label_NumberText.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_NumberText.Image = null;
            this.label_NumberText.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_NumberText.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.label_NumberText.Location = new System.Drawing.Point(586, 64);
            this.label_NumberText.Margin = new System.Windows.Forms.Padding(4);
            this.label_NumberText.Name = "label_NumberText";
            this.label_NumberText.Padding = new System.Windows.Forms.Padding(4);
            this.label_NumberText.Radiuses = new System.Windows.CornerRadius(0D, 0D, 0D, 0D);
            this.label_NumberText.Size = new System.Drawing.Size(190, 48);
            this.label_NumberText.StyleMode = SmartHome.StyleControls.StyleMode.Control;
            this.label_NumberText.TabIndex = 33;
            this.label_NumberText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_NumberText.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.label_Directory.Location = new System.Drawing.Point(8, 120);
            this.label_Directory.Margin = new System.Windows.Forms.Padding(4);
            this.label_Directory.Name = "label_Directory";
            this.label_Directory.Padding = new System.Windows.Forms.Padding(4);
            this.label_Directory.Radiuses = new System.Windows.CornerRadius(0D, 0D, 0D, 0D);
            this.label_Directory.Size = new System.Drawing.Size(180, 48);
            this.label_Directory.StyleMode = SmartHome.StyleControls.StyleMode.LowChroma;
            this.label_Directory.TabIndex = 34;
            this.label_Directory.Text = "目錄夾";
            this.label_Directory.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label_Directory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // label_DirectoryText
            // 
            this.label_DirectoryText.BorderColor = System.Drawing.Color.White;
            this.label_DirectoryText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_DirectoryText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.label_DirectoryText.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_DirectoryText.Image = null;
            this.label_DirectoryText.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_DirectoryText.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.label_DirectoryText.Location = new System.Drawing.Point(196, 120);
            this.label_DirectoryText.Margin = new System.Windows.Forms.Padding(4);
            this.label_DirectoryText.Name = "label_DirectoryText";
            this.label_DirectoryText.Padding = new System.Windows.Forms.Padding(4);
            this.label_DirectoryText.Radiuses = new System.Windows.CornerRadius(0D, 0D, 0D, 0D);
            this.label_DirectoryText.Size = new System.Drawing.Size(580, 114);
            this.label_DirectoryText.StyleMode = SmartHome.StyleControls.StyleMode.Control;
            this.label_DirectoryText.TabIndex = 35;
            this.label_DirectoryText.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label_DirectoryText.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // label_FileName
            // 
            this.label_FileName.BorderColor = System.Drawing.Color.White;
            this.label_FileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_FileName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.label_FileName.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_FileName.Image = null;
            this.label_FileName.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_FileName.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.label_FileName.Location = new System.Drawing.Point(8, 242);
            this.label_FileName.Margin = new System.Windows.Forms.Padding(4);
            this.label_FileName.Name = "label_FileName";
            this.label_FileName.Padding = new System.Windows.Forms.Padding(4);
            this.label_FileName.Radiuses = new System.Windows.CornerRadius(0D, 0D, 0D, 0D);
            this.label_FileName.Size = new System.Drawing.Size(180, 48);
            this.label_FileName.StyleMode = SmartHome.StyleControls.StyleMode.LowChroma;
            this.label_FileName.TabIndex = 36;
            this.label_FileName.Text = "檔案";
            this.label_FileName.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label_FileName.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // label_FileNameText
            // 
            this.label_FileNameText.BorderColor = System.Drawing.Color.White;
            this.label_FileNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_FileNameText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.label_FileNameText.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_FileNameText.Image = null;
            this.label_FileNameText.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_FileNameText.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.label_FileNameText.Location = new System.Drawing.Point(196, 242);
            this.label_FileNameText.Margin = new System.Windows.Forms.Padding(4);
            this.label_FileNameText.Name = "label_FileNameText";
            this.label_FileNameText.Padding = new System.Windows.Forms.Padding(4);
            this.label_FileNameText.Radiuses = new System.Windows.CornerRadius(0D, 0D, 0D, 0D);
            this.label_FileNameText.Size = new System.Drawing.Size(190, 48);
            this.label_FileNameText.StyleMode = SmartHome.StyleControls.StyleMode.Control;
            this.label_FileNameText.TabIndex = 37;
            this.label_FileNameText.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label_FileNameText.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // label_Line
            // 
            this.label_Line.BorderColor = System.Drawing.Color.White;
            this.label_Line.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_Line.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.label_Line.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_Line.Image = null;
            this.label_Line.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Line.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.label_Line.Location = new System.Drawing.Point(394, 242);
            this.label_Line.Margin = new System.Windows.Forms.Padding(4);
            this.label_Line.Name = "label_Line";
            this.label_Line.Padding = new System.Windows.Forms.Padding(4);
            this.label_Line.Radiuses = new System.Windows.CornerRadius(0D, 0D, 0D, 0D);
            this.label_Line.Size = new System.Drawing.Size(180, 48);
            this.label_Line.StyleMode = SmartHome.StyleControls.StyleMode.LowChroma;
            this.label_Line.TabIndex = 38;
            this.label_Line.Text = "行號";
            this.label_Line.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label_Line.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // label_LineText
            // 
            this.label_LineText.BorderColor = System.Drawing.Color.White;
            this.label_LineText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_LineText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.label_LineText.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_LineText.Image = null;
            this.label_LineText.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_LineText.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.label_LineText.Location = new System.Drawing.Point(586, 242);
            this.label_LineText.Margin = new System.Windows.Forms.Padding(4);
            this.label_LineText.Name = "label_LineText";
            this.label_LineText.Padding = new System.Windows.Forms.Padding(4);
            this.label_LineText.Radiuses = new System.Windows.CornerRadius(0D, 0D, 0D, 0D);
            this.label_LineText.Size = new System.Drawing.Size(190, 48);
            this.label_LineText.StyleMode = SmartHome.StyleControls.StyleMode.Control;
            this.label_LineText.TabIndex = 39;
            this.label_LineText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_LineText.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.label_ImportMark.Location = new System.Drawing.Point(8, 298);
            this.label_ImportMark.Margin = new System.Windows.Forms.Padding(4);
            this.label_ImportMark.Name = "label_ImportMark";
            this.label_ImportMark.Padding = new System.Windows.Forms.Padding(4);
            this.label_ImportMark.Radiuses = new System.Windows.CornerRadius(0D, 0D, 0D, 0D);
            this.label_ImportMark.Size = new System.Drawing.Size(180, 48);
            this.label_ImportMark.StyleMode = SmartHome.StyleControls.StyleMode.LowChroma;
            this.label_ImportMark.TabIndex = 40;
            this.label_ImportMark.Text = "匯入註解";
            this.label_ImportMark.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label_ImportMark.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // label_ImportMarkText
            // 
            this.label_ImportMarkText.BorderColor = System.Drawing.Color.White;
            this.label_ImportMarkText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_ImportMarkText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.label_ImportMarkText.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_ImportMarkText.Image = null;
            this.label_ImportMarkText.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_ImportMarkText.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.label_ImportMarkText.Location = new System.Drawing.Point(196, 298);
            this.label_ImportMarkText.Margin = new System.Windows.Forms.Padding(4);
            this.label_ImportMarkText.Name = "label_ImportMarkText";
            this.label_ImportMarkText.Padding = new System.Windows.Forms.Padding(4);
            this.label_ImportMarkText.Radiuses = new System.Windows.CornerRadius(0D, 0D, 0D, 0D);
            this.label_ImportMarkText.Size = new System.Drawing.Size(580, 48);
            this.label_ImportMarkText.StyleMode = SmartHome.StyleControls.StyleMode.Control;
            this.label_ImportMarkText.TabIndex = 41;
            this.label_ImportMarkText.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label_ImportMarkText.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // label_Description
            // 
            this.label_Description.BorderColor = System.Drawing.Color.White;
            this.label_Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_Description.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.label_Description.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_Description.Image = null;
            this.label_Description.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Description.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.label_Description.Location = new System.Drawing.Point(8, 354);
            this.label_Description.Margin = new System.Windows.Forms.Padding(4);
            this.label_Description.Name = "label_Description";
            this.label_Description.Padding = new System.Windows.Forms.Padding(4);
            this.label_Description.Radiuses = new System.Windows.CornerRadius(0D, 0D, 0D, 0D);
            this.label_Description.Size = new System.Drawing.Size(180, 48);
            this.label_Description.StyleMode = SmartHome.StyleControls.StyleMode.LowChroma;
            this.label_Description.TabIndex = 42;
            this.label_Description.Text = "說明";
            this.label_Description.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label_Description.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // textBox_Description
            // 
            this.textBox_Description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox_Description.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBox_Description.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBox_Description.Location = new System.Drawing.Point(196, 354);
            this.textBox_Description.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Description.MaxLength = 32767;
            this.textBox_Description.Multiline = false;
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Padding = new System.Windows.Forms.Padding(2);
            this.textBox_Description.PasswordChar = '\0';
            this.textBox_Description.ReadOnly = false;
            this.textBox_Description.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_Description.Size = new System.Drawing.Size(580, 48);
            this.textBox_Description.TabIndex = 43;
            this.textBox_Description.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox_Description.Warning = false;
            // 
            // label_IdText
            // 
            this.label_IdText.BorderColor = System.Drawing.Color.White;
            this.label_IdText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_IdText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.label_IdText.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_IdText.Image = null;
            this.label_IdText.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_IdText.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.label_IdText.Location = new System.Drawing.Point(196, 8);
            this.label_IdText.Margin = new System.Windows.Forms.Padding(4);
            this.label_IdText.Name = "label_IdText";
            this.label_IdText.Padding = new System.Windows.Forms.Padding(4);
            this.label_IdText.Radiuses = new System.Windows.CornerRadius(0D, 0D, 0D, 0D);
            this.label_IdText.Size = new System.Drawing.Size(580, 48);
            this.label_IdText.StyleMode = SmartHome.StyleControls.StyleMode.Control;
            this.label_IdText.TabIndex = 45;
            this.label_IdText.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label_IdText.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // label_Id
            // 
            this.label_Id.BorderColor = System.Drawing.Color.White;
            this.label_Id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_Id.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.label_Id.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_Id.Image = null;
            this.label_Id.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Id.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.label_Id.Location = new System.Drawing.Point(8, 8);
            this.label_Id.Margin = new System.Windows.Forms.Padding(4);
            this.label_Id.Name = "label_Id";
            this.label_Id.Padding = new System.Windows.Forms.Padding(4);
            this.label_Id.Radiuses = new System.Windows.CornerRadius(0D, 0D, 0D, 0D);
            this.label_Id.Size = new System.Drawing.Size(180, 48);
            this.label_Id.StyleMode = SmartHome.StyleControls.StyleMode.LowChroma;
            this.label_Id.TabIndex = 44;
            this.label_Id.Text = "代號";
            this.label_Id.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label_Id.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // EditDialog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "EditDialog";
            this.Text = "EditDialog";
            this.panel_Bottom.ResumeLayout(false);
            this.panel_Content.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SmartHome.StyleControls.Button button_Confirm;
        private SmartHome.StyleControls.Button button_Cancel;
        private SmartHome.StyleControls.Label label_KindText;
        private SmartHome.StyleControls.Label label_Kind;
        private SmartHome.StyleControls.Label label_NumberText;
        private SmartHome.StyleControls.Label label_Number;
        private SmartHome.StyleControls.Label label_DirectoryText;
        private SmartHome.StyleControls.Label label_Directory;
        private SmartHome.StyleControls.Label label_LineText;
        private SmartHome.StyleControls.Label label_Line;
        private SmartHome.StyleControls.Label label_FileNameText;
        private SmartHome.StyleControls.Label label_FileName;
        private SmartHome.StyleControls.Label label_Description;
        private SmartHome.StyleControls.Label label_ImportMarkText;
        private SmartHome.StyleControls.Label label_ImportMark;
        private SmartHome.StyleControls.TextBox textBox_Description;
        private SmartHome.StyleControls.Label label_IdText;
        private SmartHome.StyleControls.Label label_Id;
    }
}