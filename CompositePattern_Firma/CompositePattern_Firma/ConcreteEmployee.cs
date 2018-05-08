using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern_Firma
{
    class ConcreteEmployee:AEmployee
    {
        public ConcreteEmployee(string name)
        {
            Name = name;
        }
    }
}
