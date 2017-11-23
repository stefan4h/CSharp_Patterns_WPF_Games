using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasta_AbstractFactory
{
    public interface ISauce
    {
        void ShowName();
    }
    public class Bolognese : ISauce
    {
        public void ShowName()
        {
            Console.WriteLine("Bolognese");
        }
    }
    public class Carbonara : ISauce
    {
        public void ShowName()
        {
            Console.WriteLine("Carbonara");
        }
    }
    public class AlTonno : ISauce
    {
        public void ShowName()
        {
            Console.WriteLine("al Tonno");
        }
    }
}
