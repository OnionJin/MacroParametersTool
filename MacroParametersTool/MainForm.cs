using MacroParametersTool.Data;
using SmartHome.StyleControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroParametersTool
{
    public partial class MainForm : Form
    {
        private Storage _storage = null;
        public MainForm()
        {
            InitializeComponent();
            this.Font = Helper.Style.Font;
            this.BackColor = Helper.Style.Control.BackColor;
            this.ForeColor = Helper.Style.Control.ForeColor;
            this.Width = 1366;
            this.Height = 952;
            Helper.SoundPlayer = new SoundPlayer();

            panel_Condition.BackColor = Helper.Style.Normal.BackColor;
            panel_Condition.ForeColor = Helper.Style.Normal.ForeColor;
            gridView.AddTextColumn("Kind", "種類", false, "Kind", 160, DataGridViewContentAlignment.MiddleLeft, "");
            gridView.AddTextColumn("Number", "編號", false, "Number", 160, DataGridViewContentAlignment.MiddleRight, "N0");
            gridView.AddTextColumn("FileName", "檔案", false, "File", 240, DataGridViewContentAlignment.MiddleLeft, "");
            gridView.AddTextColumn("Line", "行號", false, "Line", 160, DataGridViewContentAlignment.MiddleRight, "N0");
            gridView.AddTextColumn("Description", "說明", false, "", 638, DataGridViewContentAlignment.MiddleLeft, "");
            gridView.AddHiddenColumn("Id");
            gridView.AddHiddenColumn("Directory");
            gridView.AddHiddenColumn("ImportMark");
            navigator.SetData(1, 1);

            _storage = new Storage();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            ReloadData();
        }
        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder3D(e.Graphics, e.ClipRectangle, Border3DStyle.RaisedOuter);
        }
        private Point _movePoint = new Point(0);
        private void toolStripLabel_Title_MouseDown(object sender, MouseEventArgs e)
        {
            _movePoint = new Point(-e.X + SystemInformation.FrameBorderSize.Width, -e.Y - SystemInformation.FrameBorderSize.Height);
        }

        private void toolStripLabel_Title_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.SizeAll;
        }

        private void toolStripLabel_Title_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void toolStripLabel_Title_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                //新視窗的位置
                mousePos.Offset(_movePoint.X, _movePoint.Y);
                //改變視窗位置
                Location = mousePos;
            }
        }

        private void toolStripButton_WindowClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void toolStripButton_WindowMinimiz_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void toolStripButton_Import_Click(object sender, EventArgs e)
        {
            ImportDialog dialog = new ImportDialog();
            dialog.Storage = _storage;
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                ReloadData();
            }
        }
        private void ReloadData()
        {
            Data.Paging paging = new Data.Paging(gridView.DisplayRowsCount, navigator.Index);
            SearchResult<MacroParameter> result = _storage.MacroParameters_Search("", textBox_Kind.Text.Trim(), textBox_Keyword.Text.Trim(), paging);
            gridView.DataSource = result.Data.ToArray();
            navigator.SetData(result.Paging.PageCount, result.Paging.Index);
            ButtonsState();
        }
        private void ButtonsState()
        {

            Dictionary<string, object> data = gridView.SelectedRowData;
            if (data == null)
            {
                toolStripButton_Edit.Enabled = false;
                toolStripButton_Delete.Enabled = false;
            }
            else
            {
                toolStripButton_Edit.Enabled = true;
                toolStripButton_Delete.Enabled = true;
            }
        }

        private void textBox_Kind_TextChanged(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void textBox_Keyword_TextChanged(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void navigator_IndexChanged(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void toolStripButton_Edit_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> row = gridView.SelectedRowData;
            MacroParameter data = new MacroParameter();
            data.Description = row["Description"].ToString();
            data.Directory = row["Directory"].ToString();
            data.FileName = row["FileName"].ToString();
            data.Id = row["Id"].ToString();
            data.ImportMark = row["ImportMark"].ToString();
            data.Kind = row["Kind"].ToString();
            data.Line = Convert.ToInt32( row["Line"]) ;
            data.Number = Convert.ToInt32(row["Number"]);

            EditDialog dialog = new EditDialog(_storage, data);
            if (dialog.ShowDialog(this)== DialogResult.OK)
            {
                ReloadData();
            }
        }

        private void gridView_RowDoubleClick(object sender, EventArgs e)
        {
            toolStripButton_Edit_Click(sender,e);
        }

        private void toolStripButton_Delete_Click(object sender, EventArgs e)
        {
            DeleteDialog dialog = new DeleteDialog(_storage, gridView.SelectedRowData["Id"].ToString());
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                ReloadData();
            }
        }

        private void toolStripButton_Group_Click(object sender, EventArgs e)
        {
            GroupDialog dialog = new GroupDialog(_storage);
            dialog.ShowDialog(this);
        }
    }
}
