using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextConverter_BuilderPattern
{
    class CSV_Builder : IConvertBuilder
    {
        private IFileRepresentation newFile;
        
        public CSV_Builder(IFileRepresentation f)
        {
            newFile = ReformatFile(f);
        }

        public IFileRepresentation GetFileRepresentation()
        {
            return newFile;
        }

        public IFileRepresentation ReformatFile(IFileRepresentation oldFile)
        {
            List<string> csvList=new List<string>();
            string newPath=oldFile.GetPath().Split('.')[0]+".csv";

            foreach (string x in oldFile.GetList())
            {
                csvList.Add(x.Split(' ')[0]+";"+ x.Split(' ')[1] + ";" + x.Split(' ')[2] + ";" + x.Split(' ')[3] + ";");
            }

            return new CSVFileRepresentation(csvList,newPath);
        }
    }
}
