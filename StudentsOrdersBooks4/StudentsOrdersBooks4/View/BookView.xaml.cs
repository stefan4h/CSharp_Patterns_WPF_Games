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
    public enum EBookFilter { TITLE, AUTHOR }

    public partial class BookView : UserControl
    {
        private bool doubleClick = false;
        private EBookFilter filter;
        private Book selectedBook;

        public BookView()
        {
            InitializeComponent();
        }




        private void studentDataGrid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
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
                Book b = (Book)bookDataGrid.SelectedItem;
                if (b != null)
                    EnableUpdateAndDelete(b);
            }
        }

        private void StudentViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = new BookViewModel();
        }

        private void cbx_filter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbx_filter.SelectedIndex == 0)
                filter = EBookFilter.TITLE;
            else 
                filter = EBookFilter.AUTHOR;

        }

        private void txb_filter_TextChanged(object sender, TextChangedEventArgs e)
        {
            ViewModel.BookViewModel b = (ViewModel.BookViewModel)this.DataContext;
            if (txb_filter.Text != null || txb_filter.Text != "")
                b.Filter(filter, txb_filter.Text);
            else
                b.Refresh();
        }

        private void EnableUpdateAndDelete(Book b)
        {
            btn_delete.Visibility = Visibility.Visible;
            btn_update.Visibility = Visibility.Visible;
            txb_update_author.Text = b.author;
            txb_update_title.Text = b.title;
            txb_update_price.Text = b.price;
            selectedBook = b;
        }

        private void btn_delete_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.BookViewModel b = (ViewModel.BookViewModel)this.DataContext;
            b.Delete(selectedBook);
            btn_delete.Visibility = Visibility.Collapsed;
            btn_update.Visibility = Visibility.Collapsed;
        }

        public void Refresh() {
            ViewModel.BookViewModel b = (ViewModel.BookViewModel)this.DataContext;
            b.Refresh();
        }

        private void btn_update_Click(object sender, RoutedEventArgs e)
        {
            Book updatedBook = selectedBook;
            updatedBook.title = txb_update_title.Text;
            updatedBook.author = txb_update_author.Text;
            updatedBook.price = txb_update_price.Text;
            ViewModel.BookViewModel b = (ViewModel.BookViewModel)this.DataContext;
            b.Update(updatedBook);

            btn_delete.Visibility = Visibility.Collapsed;
            btn_update.Visibility = Visibility.Collapsed;
            updatedBook.title = "";
            updatedBook.author = "";
            updatedBook.price = "";
        }
    }
}
