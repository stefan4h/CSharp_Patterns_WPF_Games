using StudentsOrdersBooks4.Model;
using StudentsOrdersBooks4.Model.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsOrdersBooks4.ViewModel
{
    public class OrderViewModel : INotifyPropertyChanged
    {
        public OrderViewModel()
        {
            Orders = GetOrderList();
        }

        ObservableCollection<Order> GetOrderList()
        {
            OrderRepository or = new OrderRepository();
            List<Order> olist = or.GetOrders().ToList();
            ObservableCollection<Order> ob = new ObservableCollection<Order>();
            foreach (Order o in olist)
            {
                ob.Add(o);
            }
            return ob;
        }

        public void Refresh()
        {
            Orders = GetOrderList();
        }
        public void Delete(Order o)
        {
            OrderRepository or = new OrderRepository();
            or.DeleteOrder(o);
            List<Order> olist = or.GetOrders().ToList();
            ObservableCollection<Order> ob = new ObservableCollection<Order>();
            foreach (Order ot in olist)
            {
                ob.Add(ot);
            }
            Orders = ob;
        }
        public void Insert(Order o)
        {
            OrderRepository or = new OrderRepository();
            or.InsertOrder(o);
            List<Order> blist = or.GetOrders().ToList();
            ObservableCollection<Order> ob = new ObservableCollection<Order>();
            foreach (Order ot in blist)
            {
                ob.Add(ot);
            }
            Orders = ob;
        }


        private ObservableCollection<Order> orders;
        public ObservableCollection<Order> Orders
        {
            get { return orders; }
            set
            {
                orders = value;
                RaiseChange("Orders");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaiseChange(string PropertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}
