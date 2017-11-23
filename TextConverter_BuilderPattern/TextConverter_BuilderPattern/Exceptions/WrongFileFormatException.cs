using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextConverter_BuilderPattern.Exceptions
{
    class WrongFileFormatException:Exception
    {
        public WrongFileFormatException(string message):base(message)  { }
        public WrongFileFormatException() : base() { }
    }
}
