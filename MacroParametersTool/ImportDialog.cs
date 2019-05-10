using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroParametersTool
{
    public partial class ImportDialog : SmartHome.StyleControls.DialogBase
    {

        public ImportDialog()
        {
            InitializeComponent();
            dropDownList_Directory.SetData("", "");
        }
        private Storage _storage = null;
        public Storage Storage { set { _storage = value; } }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            bool r = true;
            if (dropDownList_Directory.Value + "" == "")
            {
                dropDownList_Directory.Warning = true;
                r = false;
            }
            else
            {
                dropDownList_Directory.Warning = false;
            }
            if (textBox_Kind.Text.Trim() == "")
            {
                textBox_Kind.Warning = true;
                r = false;
            }
            else
            {
                textBox_Kind.Warning = false;
            }

            if (r == true)
            {
                ButtonsState(false);
                Task.Run(() =>
                {
                    if (toggleButton_Clear.Checked == true) { _storage.MacroParameters_Clear(); }
                    DirectoryInfo info = new DirectoryInfo(dropDownList_Directory.Value.ToString());
                    DirectoryHandler(info, textBox_Kind.Text.Trim());
                    ButtonsState(true);
                });
            }
        }
        private delegate void ButtonsStateCallback(bool enabled);
        private void ButtonsState(bool enabled)
        {
            try
            {
                if (this.InvokeRequired == true)
                {
                    ButtonsStateCallback callback = new ButtonsStateCallback(ButtonsState);
                    this.Invoke(callback, new object[] { enabled });
                }
                else
                {
                    button_Close.Enabled = enabled;
                    button_Executer.Enabled = enabled;
                }
            }
            catch { }
        }
        private void DirectoryHandler(DirectoryInfo dir, string kind)
        {
            StreamReader file = null;
            string line;
            int index = 0;
            int lineIndex = 0;
            string text = "";
            string textBefore = "";
            int textIndex = 0;
            int textValue = 0;
            foreach (FileInfo fileInfo in dir.GetFiles())
            {
                try
                {
                    Task.Run(() => { AppendMessage(fileInfo.FullName); });
                    file = new StreamReader(fileInfo.FullName);
                    MacroParameter param = null;
                    lineIndex = 0;
                    while ((line = file.ReadLine()) != null)
                    {
                        lineIndex = lineIndex + 1;
                        index = line.IndexOf(kind);
                        while (index > -1)
                        {
                            line = line.Substring(index);
                            if (line.Length > 0)
                            {
                                textBefore = "";
                                textIndex = 1;
                                while (line.Length > textIndex)
                                {
                                    text = line.Substring(1, textIndex);
                                    if (int.TryParse(text, out textValue) == true)
                                    {
                                        textBefore = text;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                    textIndex = textIndex + 1;
                                }
                                if (int.TryParse(textBefore, out textValue) == true)
                                {
                                    param = new MacroParameter();
                                    param.Id = Guid.NewGuid().ToString();
                                    param.Directory = fileInfo.Directory.FullName;
                                    param.FileName = fileInfo.Name;
                                    param.Kind = kind;
                                    param.ImportMark = textBox_ImportMark.Text.Trim();
                                    param.Number = textValue;
                                    param.Line = lineIndex;
                                    _storage.MacroParameters_Insert(param);
                                }
                            }
                            line = line.Substring(textIndex);
                            index = line.IndexOf(kind);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Task.Run(() => { AppendMessage(string.Format("{0} Fail({1})", fileInfo.Name, ex.Message)); });
                }
            }
            foreach (DirectoryInfo child in dir.GetDirectories())
            {
                DirectoryHandler(child, kind);
            }
        }
        private delegate void AppendMessageCallback(string message);
        private void AppendMessage(string message)
        {
            try
            {
                if (this.InvokeRequired == true)
                {
                    AppendMessageCallback callback = new AppendMessageCallback(AppendMessage);
                    this.Invoke(callback, new object[] { message });
                }
                else
                {
                    if (textBox_Message.Text != "") { textBox_Message.Text = textBox_Message.Text + "\r\n"; }
                    textBox_Message.Text = textBox_Message.Text + message;
                }
            }
            catch { }
        }

        private void dropDownList_Directory_DownButtonClick(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                dropDownList_Directory.SetData(folderBrowserDialog.SelectedPath, folderBrowserDialog.SelectedPath);
            }
        }

        private void dropDownList_Directory_ClearButtonClick(object sender, EventArgs e)
        {
            dropDownList_Directory.SetData("", "");
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
