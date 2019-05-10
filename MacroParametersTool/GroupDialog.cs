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
    public partial class GroupDialog : SmartHome.StyleControls.DialogBase
    {
        private Storage _storage = null;
        public GroupDialog(Storage storage)
        {
            InitializeComponent();
            _storage = storage;
            Reload();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private List<GroupItemUserControl> _items = new List<GroupItemUserControl>();
        private void Reload()
        {
            foreach (GroupItemUserControl item in _items)
            {
                flowLayoutPanel.Controls.Remove(item);
            }
            _items.Clear();

            GroupItemUserControl newItem = null;
            Data.Paging paging = new Data.Paging( 50, navigator.Index);
            Data.SearchResult<MacroParameterItem> result = _storage.MacroParameters_SearchItems(toolStripTextBox_Kind.Text.Trim(), paging);
            for (int index=0;index < result.Data.Count; index++)
            {
                newItem = new GroupItemUserControl(result.Data[index].ToString());
                flowLayoutPanel.Controls.Add(newItem);
                _items.Add(newItem);
            }
            navigator.SetData(result.Paging.PageCount, result.Paging.Index);
        }

        private void toolStripTextBox_Kind_TextChanged(object sender, EventArgs e)
        {
            Reload();
        }

        private void navigator_IndexChanged(object sender, EventArgs e)
        {
            Reload();
        }
    }
}
