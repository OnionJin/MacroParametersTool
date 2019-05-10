using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroParametersTool
{
    public class MacroParameter
    {
        private string _id = "";
        public string Id { get { return _id; } set { _id = value; } }

        private string _kind = "";
        public string Kind { get { return _kind; } set { _kind = value; } }

        private int _number = 0;
        public int Number { get { return _number; } set { _number = value; } }

        private int _line = 0;
        public int Line { get { return _line; } set { _line = value; } }

        private string _fileName = "";
        public string FileName { get { return _fileName; } set { _fileName = value; } }

        private string _directory = "";
        public string Directory { get { return _directory; } set { _directory = value; } }

        private string _description = "";
        public string Description { get { return _description; } set { _description = value; } }

        private string _importMark = "";
        public string ImportMark { get { return _importMark; } set { _importMark = value; } }

        public MacroParameter Clone() { return MemberwiseClone() as MacroParameter; }
    }
}
