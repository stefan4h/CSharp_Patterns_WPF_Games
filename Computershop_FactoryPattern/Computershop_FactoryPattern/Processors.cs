using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computershop_FactoryPattern
{
    class i7_Processors : IProcessor
    {
        public void PerformOperation()
        {
            Console.WriteLine("Pew Pew Pew");
        }
    }
    class i5_Processor : IProcessor
    {
        public void PerformOperation()
        {
            Console.WriteLine("Pew Pew");
        }
    }
    class i3_Processor : IProcessor
    {
        public void PerformOperation()
        {
            Console.WriteLine("Pew");
        }
    }
}
