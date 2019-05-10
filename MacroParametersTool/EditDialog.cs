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
    public partial class EditDialog : SmartHome.StyleControls.DialogBase
    {
        private MacroParameter _data = null;
        private Storage _storage = null;
        public EditDialog(Storage  storage ,MacroParameter data)
        {
            InitializeComponent();
            _storage = storage;
            _data = data.Clone();
            label_IdText.Text = _data.Id;
            label_DirectoryText.Text = _data.Directory;
            label_FileNameText.Text = _data.FileName;
            label_ImportMarkText.Text = _data.ImportMark;
            label_KindText.Text = _data.Kind;
            label_LineText.Text = _data.Line.ToString();
            label_NumberText.Text = _data.Number.ToString();
            textBox_Description.Text = _data.Description;
            label_Title.Text = "修改："+ label_KindText.Text + label_NumberText.Text;
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            textBox_Description.Focus();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            _data.Description = textBox_Description.Text;
            if (_storage.MacroParameters_Edit(_data) == true)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
