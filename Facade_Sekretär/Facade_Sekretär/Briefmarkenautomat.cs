using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Sekretär
{
    class Briefmarkenautomat:AGeraet
    {
        public void BriefmarkeBezahlen(Dokument dokument, float bezahlung) {
            Console.WriteLine($"Briefmarke für Dokument wird mit {bezahlung} € bezahlt");
        }
    }
}
