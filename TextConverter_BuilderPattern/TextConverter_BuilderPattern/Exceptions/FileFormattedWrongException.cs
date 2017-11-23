using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextConverter_BuilderPattern.Exceptions
{
    class FileFormattedWrongException:Exception
    {
        public FileFormattedWrongException(string message) : base(message) { }
        public FileFormattedWrongException() : base() { }
    }
}
