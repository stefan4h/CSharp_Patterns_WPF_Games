using StudentsOrdersBooks4.Model;
using StudentsOrdersBooks4.ViewModel;
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

namespace StudentsOrdersBooks4.View
{
    /// <summary>
    /// Interaktionslogik für OrderView.xaml
    /// </summary>
    public partial class OrderView : UserControl
    {
        private bool doubleClick = false;
        private Order selectedOrder;

        public OrderView()
        {
            InitializeComponent();
        }

        private void orderDataGrid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (!doubleClick)
            {
                doubleClick = true;
                new Task(delegate ()
                {
                    Thread.Sleep(100);
                    Dispatcher.Invoke(() => doubleClick = false);
                }).Start();
            }
            if (doubleClick)
            {
                Order o = (Order)orderDataGrid.SelectedItem;
                if (o != null)
                    EnableUpdateAndDelete(o);
            }
        }

        private void StudentViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = new OrderViewModel();
        }


        private void EnableUpdateAndDelete(Order o)
        {
            btn_delete.Visibility = Visibility.Visible;
            selectedOrder = o;
        }

        private void btn_delete_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.OrderViewModel o = (ViewModel.OrderViewModel)this.DataContext;
            o.Delete(selectedOrder);
            btn_delete.Visibility = Visibility.Collapsed;
        }

        


    }
}

