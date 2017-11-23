using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computershop_FactoryPattern
{
    class HighBudgetMachine : IMachineFactory
    {
        public IHardDisk GetHardDisk()
        {
            return new BigHDD();
        }

        public IMonitor GetMonitor()
        {
            return new FourKMonitor();
        }

        public IProcessor GetSpeed()
        {
            return new i7_Processors();
        }
    }
}
