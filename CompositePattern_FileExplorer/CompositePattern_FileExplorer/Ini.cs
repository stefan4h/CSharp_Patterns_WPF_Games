using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern_FileExplorer
{
    class Ini:AFile
    {
        public Ini(string name)
        {
            Name = name;
            Extension = "ini";
        }
    }
}
