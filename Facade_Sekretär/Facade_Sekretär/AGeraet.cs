using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Sekretär
{
    abstract class AGeraet
    {
        public bool Eingeschaltet { get; set; }
        public void An()
        {
            Console.WriteLine("Drucker ist eingeschaltet");
            Eingeschaltet = true;
        }
        public void Aus()
        {
            Console.WriteLine("Drucker ist ausgeschaltet");
            Eingeschaltet = false;
        }
    }
}
