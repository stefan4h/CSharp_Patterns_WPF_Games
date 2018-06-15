using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsOrdersBooks4.Model.Repository
{
    class OrderRepository : IOrderRepository, IDisposable
    {
        private DBContext context;

        public OrderRepository()
        {
            context = new DBContext();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }


        public Order GetOrderByID(int orderID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetOrders()
        {
            return context.Orders.Select(o => o) as IEnumerable<Order>;
        }

        public void InsertOrder(Order order)
        {
            context.Orders.Add(order);
            Save();
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateOrder(Order order)
        {
            context.Entry(order).State = System.Data.Entity.EntityState.Modified;
            Save();
        }

        public void DeleteOrder(Order order)
        {
            if (order != null)
            {
                context.Orders.Attach(order);
                context.Orders.Remove(order);
                context.SaveChanges();
            }
        }
    }
}
