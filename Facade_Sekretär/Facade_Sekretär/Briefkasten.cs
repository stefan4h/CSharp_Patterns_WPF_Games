using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Sekretär
{
    class Briefkasten
    {
        public void briefEinwerfen(Dokument dokument) {
            Console.WriteLine("Das Dokument wird in den Briefkasten eingeworfen");
        }
    }
}
