using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern_FileExplorer
{
    class Exe:AFile
    {
        public Exe(string name)
        {
            Name = name;
            Extension = "exe";
        }
    }
}
