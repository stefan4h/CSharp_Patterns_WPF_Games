using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasta_SimpleFactory
{
    class PastaFactory
    {       
        public Pasta CreatePasta(string pastaSwitch)
        {
            Pasta p;
            switch (pastaSwitch)
            {
                case "SB":
                    p = new SpaghettiBolognese();
                    break;
                case "SC":
                    p = new SpaghettiCarbonara();
                    break;
                case "PC":
                    p = new PenneCarbonara();
                    break;
                default:
                    throw new Exceptions.WrongInputException("Falscher Buchstabe");
                    break;
            }
            return p;
        }
    }
}
