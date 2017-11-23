using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasta_SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            PastaFactory pastaMaschine = new PastaFactory();
            Pasta essen=pastaMaschine.CreatePasta("SB");
            Console.WriteLine(essen.GetNoodles()+", "+essen.GetSauce());
            Console.ReadKey();
        }
    }
}
