using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computershop_FactoryPattern
{
    class BigHDD : IHardDisk
    {
        public void StoreData()
        {
            Console.WriteLine("Store Store Store");
        }
    }
    class MediumHDD : IHardDisk
    {
        public void StoreData()
        {
            Console.WriteLine("Store Store");
        }
    }
    class SmallHDD : IHardDisk
    {
        public void StoreData()
        {
            Console.WriteLine("Store");
        }
    }
}
