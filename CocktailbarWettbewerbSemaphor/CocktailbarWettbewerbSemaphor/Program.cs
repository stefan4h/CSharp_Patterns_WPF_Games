using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CocktailbarWettbewerbSemaphor
{
    public class Program
    {
        public static SemaphoreSlim s = new SemaphoreSlim(3);
        static void Main(string[] args)
        {  
            for (int i = 0; i< 10; i++)
            {
                Thread t = new Thread(CreateCocktail);
                t.Name = $"Kellner {i}";
                t.Start();
            }
        }

        private static void CreateCocktail()
        {
            s.Wait();
            Console.WriteLine($"{Thread.CurrentThread.Name} betritt die Bar");
            MixCocktail();
            Console.WriteLine($"{Thread.CurrentThread.Name} verlässt die Bar");
            s.Release();
        }
        private static void MixCocktail()
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} mixt Cocktail");
            Thread.Sleep(500);
        }
    }
}
