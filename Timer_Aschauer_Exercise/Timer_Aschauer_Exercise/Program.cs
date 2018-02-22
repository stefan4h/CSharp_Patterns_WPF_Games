using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace Timer_Aschauer_Exercise
{
    class Program
    {
        public double counter = 1;
        public static void Main(string[] args)
        {
            Timer t1 = new Timer(1000);
            Timer t2 = new Timer(1000);
            t1.Elapsed += new Program().timer1task;
            t2.Elapsed += new Program().timer2task;

            t1.Start();
            t2.Start();
            Console.ReadKey();
        }

        public void timer1task(Object source,ElapsedEventArgs e)
        {
            Console.WriteLine("Timer 1 meldet sich zum Dienst");
        }
        public void timer2task(Object source, ElapsedEventArgs e)
        {
            counter = Math.Sqrt(counter * (78 / counter));
            Console.WriteLine($"Timer 2 meldet sich mit {counter}");
            counter++;
        }
    }
}
