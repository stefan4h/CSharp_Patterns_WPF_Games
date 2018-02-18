using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Threading_Semaphoren_Daffert_Exercise
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static SemaphoreSlim _sem=new SemaphoreSlim(1);
        Thread thread1,thread2,thread3;
        Action writeInTextblock;

        public MainWindow()
        {
            InitializeComponent();

            thread1 = new Thread(WriteOne);
            thread2 = new Thread(WriteTwo);
            thread3 = new Thread(WriteThree);

            thread1.Start();
            thread2.Start();
            thread3.Start();

            
        }

        private void WriteOne()
        {
            while (true)
            {
                _sem.Wait();
                writeInTextblock = () => textblock.Text += " One";
                Dispatcher.Invoke(writeInTextblock);
                _sem.Release();
                Thread.Sleep(TimeSpan.FromSeconds(1));
            }
        }
        private void WriteTwo()
        {
            while (true)
            {
                _sem.Wait();
                writeInTextblock = () => textblock.Text += " Two";
                Dispatcher.Invoke(writeInTextblock);
                _sem.Release();
                Thread.Sleep(TimeSpan.FromSeconds(1));
            }
        }
        private void WriteThree()
        {
            while (true)
            {
                _sem.Wait();
                writeInTextblock = () => textblock.Text += " Three";
                Dispatcher.Invoke(writeInTextblock);
                _sem.Release();
                Thread.Sleep(TimeSpan.FromSeconds(1));
            }
        }
    }
}
