using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MyTimer_Exercise_Weidenauer
{
    delegate void MyTimerDelegate();

    class MyTimer
    {
        private Action m;
        private MyTimerDelegate d;

        public TimeSpan Time { get; set; }
        private Thread t;

        private bool stop = false;


        public MyTimer(Action _m,TimeSpan seconds)
        {
            m = _m;
            Time = seconds;
        }
        public MyTimer(MyTimerDelegate _d, TimeSpan seconds)
        {
            d = _d;
            Time = seconds;
        }

        public void Start()
        {
            if (m == null && d == null)
                throw new NoMethodeException("No methode was found");
            t = new Thread(Work);
            t.Start();
        }

        public void Stop()
        {
            stop = true;
        }

        private void Work()
        {
            do {
                if (d == null)
                    m();
                else
                    d();
                Thread.Sleep(Time);
            } while (!stop);
        }
    }
}
