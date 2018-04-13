using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Sekretär
{
    class Textverarbeitungsprogramm
    {

        public Dokument GetDokument(string text) {
            return new Dokument(text);
        }

        public void Oeffnen() {
            Console.WriteLine("Textverarbeitungsprogramm wird geöffnet");
        }

    }
}
