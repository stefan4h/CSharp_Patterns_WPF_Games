using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Persom_To_Customer
{
    class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            this.Name = name;  
        }
    }
}
