using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MyTimer_Exercise_Weidenauer
{
    
   
    class Program
    {
        static void Main(string[] args)
        {
            MyTimer t;
            Stuff stuff = new Stuff();

            Action action=new Action(stuff.AnotherThing);
            MyTimerDelegate myDelegate =new MyTimerDelegate(stuff.DoSomething);
            
            
            t = new MyTimer(myDelegate,TimeSpan.FromSeconds(1));

            t.Start();
            Thread.Sleep(10000);
            t.Stop();

            t = new MyTimer(action, TimeSpan.FromSeconds(0.5));
            t.Start();
            Thread.Sleep(10000);
            t.Stop();



        }

    }
}
