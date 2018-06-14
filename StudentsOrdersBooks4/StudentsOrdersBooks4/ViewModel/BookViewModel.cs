using StudentsOrdersBooks4.Model;
using StudentsOrdersBooks4.Model.Repository;
using StudentsOrdersBooks4.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsOrdersBooks4.ViewModel
{
    class BookViewModel:INotifyPropertyChanged
    {
        public BookViewModel()
        {
            Books = GetBookList();
        }

        ObservableCollection<Book> GetBookList()
        {
            BookRepository br = new BookRepository();
            List<Book> blist = br.GetBooks().ToList();
            ObservableCollection<Book> ob = new ObservableCollection<Book>();
            foreach (Book b in blist)
            {
                ob.Add(b);
            }
            return ob;
        }

        public void Refresh()
        {
            Books = GetBookList();
        }
        public void Delete(Book b)
        {
            BookRepository br = new BookRepository();
            br.DeleteBook(b);
            List<Book> blist = br.GetBooks().ToList();
            ObservableCollection<Book> ob = new ObservableCollection<Book>();
            foreach (Book bt in blist)
            {
                ob.Add(bt);
            }
            Books = ob;
        }
        public void Insert(Book b) {
            BookRepository br = new BookRepository();
            br.InsertBook(b);
            List<Book> blist = br.GetBooks().ToList();
            ObservableCollection<Book> ob = new ObservableCollection<Book>();
            foreach (Book bt in blist)
            {
                ob.Add(bt);
            }
            Books = ob;
        }
        public void Update(Book b)
        {
            BookRepository br = new BookRepository();
            br.UpdateBook(b);
            List<Book> blist = br.GetBooks().ToList();
            ObservableCollection<Book> ob = new ObservableCollection<Book>();
            foreach (Book bt in blist)
            {
                ob.Add(bt);
            }
            Books = ob;
        }

        public void Filter(EBookFilter filter, string value)
        {
            BookRepository br = new BookRepository();
            List<Book> blist = new List<Book>();
            if (filter == EBookFilter.AUTHOR)
                blist = br.GetBooksByAuthor(value).ToList();
            else
                blist = br.GetBooksByTitle(value).ToList();

            if (blist.Count > 0)
            {
                ObservableCollection<Book> ob = new ObservableCollection<Book>();
                foreach (Book b in blist)
                {
                    ob.Add(b);
                }
                Books = ob;
            }
            else
                Books = GetBookList();

        }

        private ObservableCollection<Book> books;
        public ObservableCollection<Book> Books
        {
            get { return books; }
            set
            {
                books = value;
                RaiseChange("Books");
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
