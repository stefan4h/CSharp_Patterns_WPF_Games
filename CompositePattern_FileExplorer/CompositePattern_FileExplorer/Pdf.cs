using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern_FileExplorer
{
    class Pdf:AFile
    {
        public Pdf(string name)
        {
            Name = name;
            Extension = "pdf";
        }
        public override void Execute()
        {
            Console.WriteLine($"{this.GetFileName()} wird geöffnet");
        }
    }
}
