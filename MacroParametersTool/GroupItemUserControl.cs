using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroParametersTool
{
    public partial class GroupItemUserControl : UserControl
    {
        public GroupItemUserControl(string text)
        {
            InitializeComponent();
            label_Text.Text = text;
        }
    }
}
