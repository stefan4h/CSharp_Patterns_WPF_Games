using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextConverter_BuilderPattern.Checking
{
    public class CheckFileFormat
    {
        private string referenceOne;
        private string referenceTwo;
        private List<string> linesToCheck;
        public CheckFileFormat(string refOne, string path)
        {
            referenceOne = refOne;
            referenceTwo = MakePathToReference(path);
        }
        public CheckFileFormat(string path)
        {
            linesToCheck = PutFileInList(path);
        }
        private string MakePathToReference(string path) {
            return path.Split('.')[1];
        }
        private List<string> PutFileInList(string path) {
            List<string> stringList = new List<string>();
            using (StreamReader sr = new StreamReader(path, Encoding.Default))
            {
                while (sr.Peek() != -1)
                    stringList.Add(sr.ReadLine());
            }
            return stringList;
        }
        public bool CheckIfSameFormat()
        {
            char[] charsToTrim = { ' ' };
            return referenceOne.ToLower().Trim(charsToTrim) == referenceTwo.ToLower().Trim(charsToTrim);
        }
        public bool CheckIfFormattedRight() {

            foreach (string x in linesToCheck)
            {
                string[] checkArry = x.Split(' ');
                if (checkArry.Length != 4)
                    return false;
            }
            return true;
        }
    }
}
