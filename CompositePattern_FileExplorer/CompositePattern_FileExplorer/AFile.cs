using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern_FileExplorer
{
    abstract class AFile
    {
        public string Name { get; set; }
        public string Extension { get; set; }
        public string Content { private get; set;  }

        public virtual string GetFileName() {
            return $"{Name}.{Extension}";
        }
        public virtual void Execute()
        {
            Console.WriteLine($"{this.GetFileName()} wird ausgeführt");
        }

        public virtual string GetContent() {
            return Content;
        }
    }
}
