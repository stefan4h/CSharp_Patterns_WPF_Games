using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computershop_FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IMachineFactory factory = new HighBudgetMachine();
            ComputerShop shop = new ComputerShop(factory);
            shop.AssembleMachine();
        }
    }
}
