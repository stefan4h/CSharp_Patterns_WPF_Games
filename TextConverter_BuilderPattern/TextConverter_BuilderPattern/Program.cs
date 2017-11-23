using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextConverter_BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IFileRepresentation csvFile = new CSV_Builder(new TxtFileRepresentation(@"C:\Users\Stefan\Desktop\txtFile.txt")).GetFileRepresentation();
            csvFile.ShowDataInConsole();
            csvFile.MakeFile();
            Console.ReadKey();
        }
    }
}
