using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SchiffHafenSemaphore
{

    class Program
    {
        static void Main(string[] args)
        {
            Harbor.Do();
        }
    }
    class Harbor
    {
        
        public static Semaphore SEM_HARBOR = new Semaphore(1,1);
        public static Semaphore SEM_SIGNAL = new Semaphore(0,1);
        public static void Do()
        {
            //Create Ships
            int ships = 10;
            for (int i = 0; i < ships; i++)
            {
                Thread s = new Thread(new Ship().Run);
                s.Name = "Ship" + (i + 1);
                s.Start();
            }
            Ship.SEM_SHIP.Release(); //-> Release 3 statt nur 1
                                //Create Harbor
            Thread h = new Thread(new Harbor().Run);
            h.Name = "Harbor";
            h.Start();
        }
        public void Run()
        {
            while (true)
            {
                Ship.SEM_SHIP.WaitOne();
                SEM_HARBOR.WaitOne();

                Signal();
                Unload();

                Ship.SEM_SHIP.Release();
            }
        }
        public void Signal()
        {
            Console.WriteLine("{0} signal", Thread.CurrentThread.Name);
            SEM_SIGNAL.Release();
        }
        public void Unload()
        {
            Console.WriteLine("{0} unloads", Thread.CurrentThread.Name);
            Thread.Sleep(2000);
        }
    }
    public class Ship
    {
        public static Semaphore SEM_SHIP = new Semaphore(0, 1);
        public void Run()
        {
            Harbor.SEM_SIGNAL.WaitOne();
            Unload();
            Leave();
            Harbor.SEM_HARBOR.Release();
        }
        public void Unload()
        {
            Console.WriteLine("{0} unloads", Thread.CurrentThread.Name);
            Thread.Sleep(2000);
        }
        public void Leave()
        {
            Console.WriteLine("{0} leaves", Thread.CurrentThread.Name);
        }
    }
}
