using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern_FileExplorer
{
    class Txt:AFile
    {
        public Txt(string name)
        {
            Name = name;
            Extension = "txt";
        }
        public override void Execute()
        {
            Console.WriteLine($"{this.GetFileName()} wird geöffnet");
        }
    }
}
