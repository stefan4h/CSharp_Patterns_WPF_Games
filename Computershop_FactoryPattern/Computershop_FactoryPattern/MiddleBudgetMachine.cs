using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computershop_FactoryPattern
{
    class MiddleBudgetMachine : IMachineFactory
    {
        public IHardDisk GetHardDisk()
        {
            return new MediumHDD();
        }

        public IMonitor GetMonitor()
        {
            return new TwoKMonitor();
        }

        public IProcessor GetSpeed()
        {
            return new i5_Processor();
        }
    }
}
