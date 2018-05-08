using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern_Firma
{
    abstract class AEmployee
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }


        public virtual int GetEmployeeCount() {
            return 1;
        }

        public virtual List<string> GetEmployeeDiagram() {
            List<string> lines = new List<string>();
            lines.Add(Name);
            return lines;
        }

    }
}
