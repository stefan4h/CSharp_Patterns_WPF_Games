using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Sekretär
{
    class Computer:AGeraet
    {
        private Textverarbeitungsprogramm textverarbeitungsprogramm;

        public void Drucke(Dokument dokument) {
            Console.WriteLine($"Das Dokument '{dokument.Name}' wird gedruckt");
        }
        public Textverarbeitungsprogramm getTextverarbeitungsprogramm() {
            textverarbeitungsprogramm = new Textverarbeitungsprogramm();
            return textverarbeitungsprogramm;

        }

    }
}
