using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextConverter_BuilderPattern.Exceptions
{
    class FileAlreadyExistsException:Exception
    {
        public FileAlreadyExistsException(string message) : base(message) { }
        public FileAlreadyExistsException() : base() { }
    }
}
