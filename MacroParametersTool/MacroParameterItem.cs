using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroParametersTool
{
    public class MacroParameterItem
    {
        private string _kind = "";
        public string Kind { get { return _kind; } set { _kind = value; } }

        private int _number = 0;
        public int Number { get { return _number; } set { _number = value; } }

        public MacroParameterItem Clone() { return MemberwiseClone() as MacroParameterItem; }

        public override string ToString()
        {
            return Kind + Number.ToString();
        }
    }
}
