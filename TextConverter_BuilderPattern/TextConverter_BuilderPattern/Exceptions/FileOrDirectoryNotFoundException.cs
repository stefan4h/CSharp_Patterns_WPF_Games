using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextConverter_BuilderPattern.Exceptions
{
    class FileOrDirectoryNotFoundException:Exception
    {
        public FileOrDirectoryNotFoundException(string message):base(message)  { }
        public FileOrDirectoryNotFoundException() : base() { }
    }
}
