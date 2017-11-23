using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasta_AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IPastaFactory pf = new SpaghettiAlTonno();
            PastaCreater lol = new PastaCreater(pf);
            lol.MakePasta();
        }
    }
}
