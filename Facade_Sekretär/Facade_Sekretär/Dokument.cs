using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Sekretär
{
    class Dokument
    {
        public string Inhalt { get; set; }

        public Dokument(string inhalt)
        {
            this.Inhalt = inhalt;
        }
    }
}
