using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsOrdersBooks4.Model.Repository
{
    public interface IStudentRepository : IDisposable
    {
        IEnumerable<Student> GetStudents();
        Student GetStudentByID(int studentId);
        IEnumerable<Order> GetOrdersForStudentID(int studentID);
        void InsertStudent(Student student);
        void DeleteStudent(Student s);
        void UpdateStudent(Student student);
        void Save();
    }
    public interface IBookRepository : IDisposable
    {
        IEnumerable<Book> GetBooks();
        Book GetBookByID(int bookID);
        IEnumerable<Order> GetOrdersForBookID(int bookID);
        void InsertBook(Book book);
        void UpdateBook(Book book);
        void Save();
    }
    public interface IOrderRepository : IDisposable
    {
        IEnumerable<Order> GetOrders();
        Order GetOrderByID(int orderID);
        void InsertOrder(Order order);
        void DeleteOrder(Order order);
        void UpdateOrder(Order order);
        void Save();
    }
}
