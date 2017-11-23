using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TextConverter_BuilderPattern.Exceptions;

namespace TextConverter_BuilderPattern
{
    class CSVFileRepresentation : IFileRepresentation
    {
        private List<string> csvFileFormat;
        private string path;
        public CSVFileRepresentation(List<string> csvFileFormat, string path)
        {
            this.csvFileFormat = csvFileFormat;
            this.path = path;
        }

        public void MakeFile() {
            if (File.Exists(path))
                throw new FileAlreadyExistsException("This File is already there!");
            using (StreamWriter tw = new StreamWriter(path))
            {
                foreach (String s in csvFileFormat)
                    tw.WriteLine(s);
            }
        }

        public List<string> GetList()
        {
            return csvFileFormat;
        }

        public string GetPath()
        {
            return path;
        }

        public void ShowDataInConsole()
        {
            foreach (string x in csvFileFormat)
            {
                Console.WriteLine(x);
            }
        }
    }
}
