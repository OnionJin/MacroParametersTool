namespace MacroParametersTool
{
    partial class MainForm
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel_Content = new System.Windows.Forms.Panel();
            this.gridView = new SmartHome.StyleControls.GridView();
            this.toolStrip1 = new SmartHome.StyleControls.ToolStrip();
            this.toolStripLabel_PageCount = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox_PageIndex = new System.Windows.Forms.ToolStripTextBox();
            this.panel_Condition = new System.Windows.Forms.Panel();
            this.textBox_Kind = new SmartHome.StyleControls.TextBox();
            this.textBox_Keyword = new SmartHome.StyleControls.TextBox();
            this.label_Keyword = new SmartHome.StyleControls.Label();
            this.label_Kind = new SmartHome.StyleControls.Label();
            this.toolStrip = new SmartHome.StyleControls.ToolStrip();
            this.toolStripLabel_Title = new System.Windows.Forms.ToolStripLabel();
            this.navigator = new SmartHome.StyleControls.Navigator();
            this.toolStripButton_Import = new SmartHome.StyleControls.ToolStripButton();
            this.toolStripButton_LastPage = new SmartHome.StyleControls.ToolStripButton();
            this.toolStripButton_NextPage = new SmartHome.StyleControls.ToolStripButton();
            this.toolStripButton_PreviousPage = new SmartHome.StyleControls.ToolStripButton();
            this.toolStripButton_FirstPage = new SmartHome.StyleControls.ToolStripButton();
            this.toolStripButton_Edit = new SmartHome.StyleControls.ToolStripButton();
            this.toolStripButton_Delete = new SmartHome.StyleControls.ToolStripButton();
            this.toolStripButton_Group = new SmartHome.StyleControls.ToolStripButton();
            this.toolStripButton_WindowClose = new SmartHome.StyleControls.ToolStripButton();
            this.toolStripButton_WindowMinimiz = new SmartHome.StyleControls.ToolStripButton();
            this.panel_Content.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel_Condition.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Content
            // 
            this.panel_Content.Controls.Add(this.gridView);
            this.panel_Content.Controls.Add(this.toolStrip1);
            this.panel_Content.Controls.Add(this.panel_Condition);
            this.panel_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Content.Location = new System.Drawing.Point(2, 82);
            this.panel_Content.Name = "panel_Content";
            this.panel_Content.Padding = new System.Windows.Forms.Padding(2);
            this.panel_Content.Size = new System.Drawing.Size(1362, 816);
            this.panel_Content.TabIndex = 2;
            // 
            // gridView
            // 
            this.gridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView.CellPadding = new System.Windows.Forms.Padding(4);
            this.gridView.ColumnHeaderHeight = 64;
            this.gridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridView.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridView.Location = new System.Drawing.Point(2, 162);
            this.gridView.Margin = new System.Windows.Forms.Padding(4);
            this.gridView.Name = "gridView";
            this.gridView.RowHeight = 64;
            this.gridView.SelectedRowIndex = -1;
            this.gridView.Size = new System.Drawing.Size(1358, 652);
            this.gridView.SortingKey = "";
            this.gridView.SortingOrder = System.Windows.Forms.SortOrder.None;
            this.gridView.TabIndex = 8;
            this.gridView.RowDoubleClick += new System.EventHandler<System.EventArgs>(this.gridView_RowDoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(51)))));
            this.toolStrip1.Bottomline = false;
            this.toolStrip1.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.toolStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Import,
            this.toolStripButton_LastPage,
            this.toolStripButton_NextPage,
            this.toolStripLabel_PageCount,
            this.toolStripTextBox_PageIndex,
            this.toolStripButton_PreviousPage,
            this.toolStripButton_FirstPage,
            this.toolStripButton_Edit,
            this.toolStripButton_Delete,
            this.toolStripButton_Group});
            this.toolStrip1.Location = new System.Drawing.Point(2, 82);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(4);
            this.toolStrip1.Size = new System.Drawing.Size(1358, 80);
            this.toolStrip1.TabIndex = 7;
            // 
            // toolStripLabel_PageCount
            // 
            this.toolStripLabel_PageCount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel_PageCount.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.toolStripLabel_PageCount.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripLabel_PageCount.Name = "toolStripLabel_PageCount";
            this.toolStripLabel_PageCount.Size = new System.Drawing.Size(37, 72);
            this.toolStripLabel_PageCount.Text = "/1";
            // 
            // toolStripTextBox_PageIndex
            // 
            this.toolStripTextBox_PageIndex.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox_PageIndex.AutoSize = false;
            this.toolStripTextBox_PageIndex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBox_PageIndex.Enabled = false;
            this.toolStripTextBox_PageIndex.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.toolStripTextBox_PageIndex.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripTextBox_PageIndex.Name = "toolStripTextBox_PageIndex";
            this.toolStripTextBox_PageIndex.Size = new System.Drawing.Size(80, 64);
            this.toolStripTextBox_PageIndex.Text = "1 ";
            this.toolStripTextBox_PageIndex.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel_Condition
            // 
            this.panel_Condition.Controls.Add(this.textBox_Kind);
            this.panel_Condition.Controls.Add(this.textBox_Keyword);
            this.panel_Condition.Controls.Add(this.label_Keyword);
            this.panel_Condition.Controls.Add(this.label_Kind);
            this.panel_Condition.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Condition.Location = new System.Drawing.Point(2, 2);
            this.panel_Condition.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Condition.Name = "panel_Condition";
            this.panel_Condition.Padding = new System.Windows.Forms.Padding(12);
            this.panel_Condition.Size = new System.Drawing.Size(1358, 80);
            this.panel_Condition.TabIndex = 4;
            // 
            // textBox_Kind
            // 
            this.textBox_Kind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox_Kind.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBox_Kind.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBox_Kind.Location = new System.Drawing.Point(204, 16);
            this.textBox_Kind.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Kind.MaxLength = 32767;
            this.textBox_Kind.Multiline = false;
            this.textBox_Kind.Name = "textBox_Kind";
            this.textBox_Kind.Padding = new System.Windows.Forms.Padding(2);
            this.textBox_Kind.PasswordChar = '\0';
            this.textBox_Kind.ReadOnly = false;
            this.textBox_Kind.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_Kind.Size = new System.Drawing.Size(240, 48);
            this.textBox_Kind.TabIndex = 1;
            this.textBox_Kind.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox_Kind.Warning = false;
            this.textBox_Kind.TextChanged += new System.EventHandler<System.EventArgs>(this.textBox_Kind_TextChanged);
            // 
            // textBox_Keyword
            // 
            this.textBox_Keyword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox_Keyword.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBox_Keyword.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBox_Keyword.Location = new System.Drawing.Point(668, 16);
            this.textBox_Keyword.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Keyword.MaxLength = 32767;
            this.textBox_Keyword.Multiline = false;
            this.textBox_Keyword.Name = "textBox_Keyword";
            this.textBox_Keyword.Padding = new System.Windows.Forms.Padding(2);
            this.textBox_Keyword.PasswordChar = '\0';
            this.textBox_Keyword.ReadOnly = false;
            this.textBox_Keyword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_Keyword.Size = new System.Drawing.Size(240, 48);
            this.textBox_Keyword.TabIndex = 3;
            this.textBox_Keyword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox_Keyword.Warning = false;
            this.textBox_Keyword.TextChanged += new System.EventHandler<System.EventArgs>(this.textBox_Keyword_TextChanged);
            // 
            // label_Keyword
            // 
            this.label_Keyword.BorderColor = System.Drawing.Color.White;
            this.label_Keyword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_Keyword.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.label_Keyword.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_Keyword.Image = null;
            this.label_Keyword.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Keyword.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.label_Keyword.Location = new System.Drawing.Point(480, 16);
            this.label_Keyword.Margin = new System.Windows.Forms.Padding(32, 4, 4, 4);
            this.label_Keyword.Name = "label_Keyword";
            this.label_Keyword.Padding = new System.Windows.Forms.Padding(4);
            this.label_Keyword.Radiuses = new System.Windows.CornerRadius(0D, 0D, 0D, 0D);
            this.label_Keyword.Size = new System.Drawing.Size(180, 48);
            this.label_Keyword.StyleMode = SmartHome.StyleControls.StyleMode.LowChroma;
            this.label_Keyword.TabIndex = 2;
            this.label_Keyword.Text = "關鍵字";
            this.label_Keyword.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label_Keyword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.label_Kind.Location = new System.Drawing.Point(16, 16);
            this.label_Kind.Margin = new System.Windows.Forms.Padding(4);
            this.label_Kind.Name = "label_Kind";
            this.label_Kind.Padding = new System.Windows.Forms.Padding(4);
            this.label_Kind.Radiuses = new System.Windows.CornerRadius(0D, 0D, 0D, 0D);
            this.label_Kind.Size = new System.Drawing.Size(180, 48);
            this.label_Kind.StyleMode = SmartHome.StyleControls.StyleMode.LowChroma;
            this.label_Kind.TabIndex = 0;
            this.label_Kind.Text = "種類";
            this.label_Kind.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label_Kind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(51)))));
            this.toolStrip.Bottomline = false;
            this.toolStrip.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.toolStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel_Title,
            this.toolStripButton_WindowClose,
            this.toolStripButton_WindowMinimiz});
            this.toolStrip.Location = new System.Drawing.Point(2, 2);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip.Size = new System.Drawing.Size(1362, 80);
            this.toolStrip.TabIndex = 1;
            // 
            // toolStripLabel_Title
            // 
            this.toolStripLabel_Title.AutoSize = false;
            this.toolStripLabel_Title.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripLabel_Title.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripLabel_Title.Name = "toolStripLabel_Title";
            this.toolStripLabel_Title.Size = new System.Drawing.Size(240, 64);
            this.toolStripLabel_Title.Text = "Macro 參數工具";
            this.toolStripLabel_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripLabel_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripLabel_Title_MouseDown);
            this.toolStripLabel_Title.MouseLeave += new System.EventHandler(this.toolStripLabel_Title_MouseLeave);
            this.toolStripLabel_Title.MouseHover += new System.EventHandler(this.toolStripLabel_Title_MouseHover);
            this.toolStripLabel_Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolStripLabel_Title_MouseMove);
            // 
            // navigator
            // 
            this.navigator.CountLabel = this.toolStripLabel_PageCount;
            this.navigator.FirstButton = this.toolStripButton_FirstPage;
            this.navigator.IndexTextBox = this.toolStripTextBox_PageIndex;
            this.navigator.LastButton = this.toolStripButton_LastPage;
            this.navigator.NextButton = this.toolStripButton_NextPage;
            this.navigator.PreviousButton = this.toolStripButton_PreviousPage;
            this.navigator.Visible = true;
            this.navigator.IndexChanged += new System.EventHandler<System.EventArgs>(this.navigator_IndexChanged);
            // 
            // toolStripButton_Import
            // 
            this.toolStripButton_Import.AutoSize = false;
            this.toolStripButton_Import.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.toolStripButton_Import.Image = global::MacroParametersTool.Properties.Resources.Button_Import;
            this.toolStripButton_Import.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Import.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripButton_Import.Name = "toolStripButton_Import";
            this.toolStripButton_Import.Size = new System.Drawing.Size(128, 64);
            this.toolStripButton_Import.Tag = "import";
            this.toolStripButton_Import.Text = "匯入";
            this.toolStripButton_Import.Click += new System.EventHandler(this.toolStripButton_Import_Click);
            // 
            // toolStripButton_LastPage
            // 
            this.toolStripButton_LastPage.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton_LastPage.AutoSize = false;
            this.toolStripButton_LastPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_LastPage.Enabled = false;
            this.toolStripButton_LastPage.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.toolStripButton_LastPage.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_LastPage.Image")));
            this.toolStripButton_LastPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_LastPage.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripButton_LastPage.Name = "toolStripButton_LastPage";
            this.toolStripButton_LastPage.Size = new System.Drawing.Size(64, 64);
            this.toolStripButton_LastPage.Tag = "Last";
            this.toolStripButton_LastPage.Text = "toolStripButton5";
            // 
            // toolStripButton_NextPage
            // 
            this.toolStripButton_NextPage.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton_NextPage.AutoSize = false;
            this.toolStripButton_NextPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_NextPage.Enabled = false;
            this.toolStripButton_NextPage.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.toolStripButton_NextPage.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_NextPage.Image")));
            this.toolStripButton_NextPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_NextPage.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripButton_NextPage.Name = "toolStripButton_NextPage";
            this.toolStripButton_NextPage.Size = new System.Drawing.Size(64, 64);
            this.toolStripButton_NextPage.Tag = "Next";
            this.toolStripButton_NextPage.Text = "toolStripButton5";
            // 
            // toolStripButton_PreviousPage
            // 
            this.toolStripButton_PreviousPage.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton_PreviousPage.AutoSize = false;
            this.toolStripButton_PreviousPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_PreviousPage.Enabled = false;
            this.toolStripButton_PreviousPage.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.toolStripButton_PreviousPage.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_PreviousPage.Image")));
            this.toolStripButton_PreviousPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_PreviousPage.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripButton_PreviousPage.Name = "toolStripButton_PreviousPage";
            this.toolStripButton_PreviousPage.Size = new System.Drawing.Size(64, 64);
            this.toolStripButton_PreviousPage.Tag = "Previous";
            this.toolStripButton_PreviousPage.Text = "toolStripButton5";
            // 
            // toolStripButton_FirstPage
            // 
            this.toolStripButton_FirstPage.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton_FirstPage.AutoSize = false;
            this.toolStripButton_FirstPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_FirstPage.Enabled = false;
            this.toolStripButton_FirstPage.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.toolStripButton_FirstPage.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_FirstPage.Image")));
            this.toolStripButton_FirstPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_FirstPage.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripButton_FirstPage.Name = "toolStripButton_FirstPage";
            this.toolStripButton_FirstPage.Size = new System.Drawing.Size(64, 64);
            this.toolStripButton_FirstPage.Tag = "First";
            this.toolStripButton_FirstPage.Text = "toolStripButton5";
            // 
            // toolStripButton_Edit
            // 
            this.toolStripButton_Edit.AutoSize = false;
            this.toolStripButton_Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Edit.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.toolStripButton_Edit.Image = global::MacroParametersTool.Properties.Resources.Button_Edit;
            this.toolStripButton_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripButton_Edit.Name = "toolStripButton_Edit";
            this.toolStripButton_Edit.Size = new System.Drawing.Size(64, 64);
            this.toolStripButton_Edit.Tag = "Edit";
            this.toolStripButton_Edit.Text = "修改";
            this.toolStripButton_Edit.Click += new System.EventHandler(this.toolStripButton_Edit_Click);
            // 
            // toolStripButton_Delete
            // 
            this.toolStripButton_Delete.AutoSize = false;
            this.toolStripButton_Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Delete.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.toolStripButton_Delete.Image = global::MacroParametersTool.Properties.Resources.Button_Delete;
            this.toolStripButton_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripButton_Delete.Name = "toolStripButton_Delete";
            this.toolStripButton_Delete.Size = new System.Drawing.Size(64, 64);
            this.toolStripButton_Delete.Tag = "Delete";
            this.toolStripButton_Delete.Text = "刪除";
            this.toolStripButton_Delete.Click += new System.EventHandler(this.toolStripButton_Delete_Click);
            // 
            // toolStripButton_Group
            // 
            this.toolStripButton_Group.AutoSize = false;
            this.toolStripButton_Group.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Group.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.toolStripButton_Group.Image = global::MacroParametersTool.Properties.Resources.Button_Group;
            this.toolStripButton_Group.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Group.Margin = new System.Windows.Forms.Padding(20, 4, 4, 4);
            this.toolStripButton_Group.Name = "toolStripButton_Group";
            this.toolStripButton_Group.Size = new System.Drawing.Size(64, 64);
            this.toolStripButton_Group.Tag = "Delete";
            this.toolStripButton_Group.Text = "刪除";
            this.toolStripButton_Group.Click += new System.EventHandler(this.toolStripButton_Group_Click);
            // 
            // toolStripButton_WindowClose
            // 
            this.toolStripButton_WindowClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton_WindowClose.AutoSize = false;
            this.toolStripButton_WindowClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_WindowClose.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.toolStripButton_WindowClose.Image = global::MacroParametersTool.Properties.Resources.Button_WindowClose;
            this.toolStripButton_WindowClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_WindowClose.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripButton_WindowClose.Name = "toolStripButton_WindowClose";
            this.toolStripButton_WindowClose.Size = new System.Drawing.Size(64, 64);
            this.toolStripButton_WindowClose.Tag = "WindowClose";
            this.toolStripButton_WindowClose.Text = "關閉";
            this.toolStripButton_WindowClose.Click += new System.EventHandler(this.toolStripButton_WindowClose_Click);
            // 
            // toolStripButton_WindowMinimiz
            // 
            this.toolStripButton_WindowMinimiz.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton_WindowMinimiz.AutoSize = false;
            this.toolStripButton_WindowMinimiz.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_WindowMinimiz.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.toolStripButton_WindowMinimiz.Image = global::MacroParametersTool.Properties.Resources.Button_WindowMinimize;
            this.toolStripButton_WindowMinimiz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_WindowMinimiz.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripButton_WindowMinimiz.Name = "toolStripButton_WindowMinimiz";
            this.toolStripButton_WindowMinimiz.Size = new System.Drawing.Size(64, 64);
            this.toolStripButton_WindowMinimiz.Tag = "WindowMinimiz";
            this.toolStripButton_WindowMinimiz.Text = "最小化";
            this.toolStripButton_WindowMinimiz.Click += new System.EventHandler(this.toolStripButton_WindowMinimiz_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1366, 900);
            this.Controls.Add(this.panel_Content);
            this.Controls.Add(this.toolStrip);
            this.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Macro 參數工具";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.panel_Content.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel_Condition.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SmartHome.StyleControls.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_Title;
        private SmartHome.StyleControls.ToolStripButton toolStripButton_WindowClose;
        private SmartHome.StyleControls.ToolStripButton toolStripButton_WindowMinimiz;
        private System.Windows.Forms.Panel panel_Content;
        private SmartHome.StyleControls.ToolStrip toolStrip1;
        private SmartHome.StyleControls.ToolStripButton toolStripButton_Import;
        private SmartHome.StyleControls.ToolStripButton toolStripButton_LastPage;
        private SmartHome.StyleControls.ToolStripButton toolStripButton_NextPage;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_PageCount;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_PageIndex;
        private SmartHome.StyleControls.ToolStripButton toolStripButton_PreviousPage;
        private SmartHome.StyleControls.ToolStripButton toolStripButton_FirstPage;
        private System.Windows.Forms.Panel panel_Condition;
        private SmartHome.StyleControls.TextBox textBox_Keyword;
        private SmartHome.StyleControls.Label label_Keyword;
        private SmartHome.StyleControls.Label label_Kind;
        private SmartHome.StyleControls.GridView gridView;
        private SmartHome.StyleControls.Navigator navigator;
        private SmartHome.StyleControls.ToolStripButton toolStripButton_Edit;
        private SmartHome.StyleControls.ToolStripButton toolStripButton_Delete;
        private SmartHome.StyleControls.TextBox textBox_Kind;
        private SmartHome.StyleControls.ToolStripButton toolStripButton_Group;
    }
}

