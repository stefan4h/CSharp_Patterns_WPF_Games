using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Sekretär
{
    class Drucker:AGeraet
    {
        public Dokument zuletztGedrucktesDokument { get; set; }
        
        public void Konfigurieren() {
            Console.WriteLine("Drucker wird konfiguriert");
        }
        public void PapierNachfuellen() {
            Console.WriteLine("Papier wird im Drucker nachgefüllt");
        }
        public void Drucken(Dokument dokument) {
            Console.WriteLine("Das Dokument wird gedruckt");
            zuletztGedrucktesDokument = dokument;
        }
    }
}
