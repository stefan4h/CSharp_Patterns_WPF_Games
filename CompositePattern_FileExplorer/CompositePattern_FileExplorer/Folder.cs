using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern_FileExplorer
{
    class Folder:AFile
    {
        List<AFile> fileList;

        public Folder()
        {
            fileList = new List<AFile>();
        }
        public Folder(string name)
        {
            fileList = new List<AFile>();
            Name = name;
        }
        public Folder(string name,List<AFile> fileList)
        {
            fileList = new List<AFile>();
            Name = name;
            this.fileList = fileList;
        }
        public Folder(List<AFile> fileList)
        {
            fileList = new List<AFile>();
            this.fileList = fileList;
        }

        public override string GetFileName()
        {
            return Name;
        }

        public override void Execute()
        {
            Console.WriteLine($"{this.GetFileName()} wird geöffnet");
        }

        public override string GetContent()
        {
            string content="--"+this.GetFileName()+"--\n";
            foreach (AFile f in fileList)
            {
                if (!(f is Folder))
                    content += "+" + f.GetFileName() + "\n";
                else
                    content += f.GetContent();
            }
            return GetContent();
        }
    }
}
