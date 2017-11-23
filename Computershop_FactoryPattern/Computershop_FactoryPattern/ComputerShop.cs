using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computershop_FactoryPattern
{
    class ComputerShop
    {
        IMachineFactory category;
        public ComputerShop(IMachineFactory _category)
        {
            category = _category;
        }
        public void AssembleMachine()
        {
            IProcessor processor = category.GetSpeed();
            IHardDisk hdd = category.GetHardDisk();
            IMonitor monitor = category.GetMonitor();

            processor.PerformOperation();
            hdd.StoreData();
            monitor.DisplayPicture();
        }
    }
}
