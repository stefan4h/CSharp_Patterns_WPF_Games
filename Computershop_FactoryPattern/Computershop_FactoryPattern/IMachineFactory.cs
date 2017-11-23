using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computershop_FactoryPattern
{
    interface IMachineFactory
    {
        IProcessor GetSpeed();
        IHardDisk GetHardDisk();
        IMonitor GetMonitor();
    }
}
