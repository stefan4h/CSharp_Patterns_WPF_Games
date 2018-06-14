using StudentsOrdersBooks4.Model;
using StudentsOrdersBooks4.Model.Repository;
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
    /// Interaktionslogik für ControllBookView.xaml
    /// </summary>
    public partial class ControllBookView : UserControl
    {

        public ControllBookView()
        {
            InitializeComponent();
        }

        private void btn_addBook_Click(object sender, RoutedEventArgs e)
        {
            Book book = new Book { title=txb_title.Text,author=txb_author.Text,price=txb_price.Text};
            ViewModel.BookViewModel b = (ViewModel.BookViewModel)this.DataContext;
            b.Insert(book);
            
            Clear();
        }

        private void txb_TextChanged(object sender, TextChangedEventArgs e)
        {
            btn_addBook.IsEnabled = false;
            btn_clearBook.IsEnabled = false;
            if ((txb_author.Text != "" && txb_author.Text != null) || (txb_price.Text != "" && txb_price.Text != null) || (txb_title.Text != "" && txb_title.Text != null))
                btn_clearBook.IsEnabled = true;
            if ((txb_author.Text != "" && txb_author.Text != null) && (txb_price.Text != "" && txb_price.Text != null) && (txb_title.Text != "" && txb_title.Text != null))
                btn_addBook.IsEnabled = true;
        }


        private void Clear()
        {
            txb_author.Text = "";
            txb_price.Text = "";
            txb_title.Text = "";
        }

        private void btn_clearBook_Click(object sender, RoutedEventArgs e)
        {
            Clear();
        }
    }
}
