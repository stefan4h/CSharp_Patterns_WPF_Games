using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextConverter_BuilderPattern.Checking;
using TextConverter_BuilderPattern.Exceptions;

namespace TextConverter_BuilderPattern
{
    class TxtFileRepresentation:IFileRepresentation
    {
        private List<string> txtFileFormat;
        private string path;
        public TxtFileRepresentation(string path)
        {
            txtFileFormat = PutIntoList(path);
            this.path = path;
        }

        public void ShowDataInConsole()
        {
            foreach (string x in txtFileFormat)
            {
                Console.WriteLine(x);
            }
        }

        private List<string> PutIntoList(string path) {
            //checking if file is valid
            List<string> listOfStrings = new List<string>();
            if (!File.Exists(path))
                throw new FileNotFoundException("File doesn't exist");
            if (!new CheckFileFormat("txt", path).CheckIfSameFormat())
                throw new WrongFileFormatException("Wrong file format!");
            if (!new CheckFileFormat(path).CheckIfFormattedRight())
                throw new FileFormattedWrongException("The file is not formatted right");
            
            //putting file into List
            using (StreamReader sr = new StreamReader(path, Encoding.Default))
            {
                while (sr.Peek() != -1)
                    listOfStrings.Add(sr.ReadLine());
            }
            return listOfStrings;
        }

        public string GetPath()
        {
            return path;
        }

        public List<string> GetList()
        {
            return txtFileFormat;
        }

        public void MakeFile()
        {
            if (File.Exists(path))
                throw new FileAlreadyExistsException("This File is already there!");
            using (TextWriter tw = new StreamWriter(path))
            {
                foreach (String s in txtFileFormat)
                    tw.WriteLine(s);
            }
        }
    }
}
