using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentsOrdersBooks4.Model
{
    class FillDatabase
    {
        //https://msdn.microsoft.com/en-us/library/jj200620(v=vs.113).aspx
        private DBContext db = new DBContext();
        private List<Order> orders;
        private string studentsSQL;
        private XElement booksXML;


        //constructor initialises variables for later filling 
        public FillDatabase()
        {
            orders = new List<Order>() { new Order {Id = 0, s_id=1, b_id=1, date=new DateTime(2018, 5, 4) }, new Order { Id = 1,s_id=2, b_id=4, date=new DateTime(2008, 1, 6) },
                                        new Order {Id = 2, s_id=1, b_id=5,date= new DateTime(2007, 3, 14) },new Order { Id = 3,s_id=3, b_id=1, date=new DateTime(2012, 10, 18) },
                                        new Order { Id = 4,s_id=2, b_id=3, date= new DateTime(2015, 2, 12) },new Order {Id = 5,s_id= 4, b_id=3, date=new DateTime(2013, 3, 19) },
                                        new Order {Id = 6, s_id=2, b_id=4, date=new DateTime(2011, 1, 7) },new Order {Id = 7,s_id= 1, b_id=2,date= new DateTime(2011, 9, 20) } };


            studentsSQL = System.IO.File.ReadAllText(@"sql\studentinserts.sql");
            booksXML = XElement.Load(@"xml\books.xml");
        }

        //all tables get filled with data
        //if an error occures while filling the tabledata gets deleted
        public void Fill()
        {
            try
            {
                db.Database.ExecuteSqlCommand(studentsSQL);

                var books = from book in booksXML.Elements()
                            select new Book
                            {
                                title = (string)book.Element("title"),
                                author = (string)book.Element("author"),
                                price = (string)book.Element("price")
                            };
                db.Books.AddRange(books.ToList());

                db.Orders.AddRange(orders);

                db.SaveChanges();
            }
            catch (Exception e)
            {
                TruncateTables();
                MainWindow.ShowMessage($"An Error occured when inserting Data.\nError Message: {e.Message}");
            }
        }

        //deletes the data of all tables 
        public void TruncateTables()
        {
            db.Books.RemoveRange(db.Books);
            db.Students.RemoveRange(db.Students);
            db.Orders.RemoveRange(db.Orders);
            db.SaveChanges();
        }

    }
}
