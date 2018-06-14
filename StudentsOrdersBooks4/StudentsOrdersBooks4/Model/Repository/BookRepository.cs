using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsOrdersBooks4.Model.Repository
{
    class BookRepository : IBookRepository, IDisposable
    {
        private DBContext context;

        public BookRepository()
        {
            context = new DBContext();
        }

        public void DeleteBook(Book b)
        {
            if (b != null)
            {
                context.Books.Attach(b);
                context.Books.Remove(b);
                context.SaveChanges();
            }
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

        public Book GetBookByID(int bookID)
        {
            return context.Books.Where(b => b.Id == bookID).Select(b => b) as Book;
        }

        public IEnumerable<Book> GetBooks()
        {
            return context.Books.Select(b => b) as IEnumerable<Book>;
        }

        public IEnumerable<Order> GetOrdersForBookID(int bookID)
        {
            return context.Orders.Where(o => o.b_id == bookID).Select(o => o) as IEnumerable<Order>;
        }

        public void InsertBook(Book book)
        {
            context.Books.Add(book);
            Save();
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateBook(Book book)
        {
            context.Entry(book).State = System.Data.Entity.EntityState.Modified;
            Save();
        }

        public IEnumerable<Book> GetBooksByAuthor(string author) {
            return context.Books.Where(b => b.author == author).Select(b => b) as IEnumerable<Book>; 
        }

        public IEnumerable<Book> GetBooksByTitle(string title)
        {
            return context.Books.Where(b => b.title == title).Select(b => b) as IEnumerable<Book>;
        }
    }
}
