using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasta_AbstractFactory
{
    public interface INoodles
    {
        void ShowName();
    }
    public class Spaghetti : INoodles
    {
        public void ShowName()
        {
            Console.WriteLine("Spaghetti");
        }
    }
    public class Fusilli : INoodles
    {
        public void ShowName()
        {
            Console.WriteLine("Fusilli");
        }
    }
    public class Penne : INoodles
    {
        public void ShowName()
        {
            Console.WriteLine("Penne");
        }
    }
}
