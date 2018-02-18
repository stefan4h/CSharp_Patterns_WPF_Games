using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTimer_Exercise_Weidenauer
{
    class NoMethodeException:Exception
    {
        public NoMethodeException(string message) : base(message) { }
        public NoMethodeException() : base() { }

    }
}
