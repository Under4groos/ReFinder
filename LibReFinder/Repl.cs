using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibReFinder
{
    public struct Repl
    {
        public int index;
    }
    public struct InString
    {
        public string value;
        public int start;
        public int end;
        public override string ToString()
        {
            return $"{value}, Start:{start}, End:{end}"; 
        }
    }
}
