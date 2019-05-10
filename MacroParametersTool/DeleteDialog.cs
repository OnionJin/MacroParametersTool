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
    public partial class DeleteDialog : SmartHome.StyleControls.MessageBoxBase
    {
        private Storage _storage = null;
        private string _id = "";
        public DeleteDialog(Storage storage, string id)
        {
            InitializeComponent();
            _storage = storage;
            _id = id;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            if (_storage.MacroParameters_Delete(_id) == true)
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
