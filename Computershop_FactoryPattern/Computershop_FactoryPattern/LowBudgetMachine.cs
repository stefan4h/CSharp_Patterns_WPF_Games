using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computershop_FactoryPattern
{
    class LowBudgetMachine : IMachineFactory
    {
        public IHardDisk GetHardDisk()
        {
            return new SmallHDD();
        }

        public IMonitor GetMonitor()
        {
            return new HDMonitor();
        }

        public IProcessor GetSpeed()
        {
            return new i3_Processor();
        }
    }
}
