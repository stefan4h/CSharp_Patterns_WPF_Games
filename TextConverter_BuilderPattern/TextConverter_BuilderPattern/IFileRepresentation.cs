using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextConverter_BuilderPattern
{
    interface IFileRepresentation
    {
        void ShowDataInConsole();
        string GetPath();
        List<string> GetList();
        void MakeFile();
    }
}
