using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computershop_FactoryPattern
{
    class FourKMonitor : IMonitor
    {
        public void DisplayPicture()
        {
            Console.WriteLine("Show sharp picture");
        }
    }
    class TwoKMonitor : IMonitor
    {
        public void DisplayPicture()
        {
            Console.WriteLine("Show not as sharp picture");
        }
    }
    class HDMonitor : IMonitor
    {
        public void DisplayPicture()
        {
            Console.WriteLine("Show not very sharp picture");
        }
    }
}
