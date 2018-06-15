using StudentsOrdersBooks4.Model;
using StudentsOrdersBooks4.Model.Repository;
using StudentsOrdersBooks4.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// Interaktionslogik für ControllOrderView.xaml
    /// </summary>
    public partial class ControllOrderView : UserControl
    {
        List<Book> books;
        List<Student> students;

        public ControllOrderView()
        {
            InitializeComponent();
            StudentRepository sr = new StudentRepository();
            students = sr.GetStudents().ToList();
            BookRepository br = new BookRepository();
            books = br.GetBooks().ToList();

            foreach (Book book in books)
            {
                cbx_book.Items.Add(book.Id.ToString());
            }
            foreach (Student student in students)
            {
                cbx_student.Items.Add(student.Id.ToString());
            }
        }

        private void btn_addOrder_Click(object sender, RoutedEventArgs e)
        {
            int book_id = Convert.ToInt16(cbx_book.SelectedValue);
            int student_id = Convert.ToInt16(cbx_student.SelectedValue);
            Order order = new Order {b_id=book_id,s_id=student_id };
            ViewModel.OrderViewModel o = (ViewModel.OrderViewModel)this.DataContext;
            o.Insert(order);
        }


    }
}

