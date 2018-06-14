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
    public enum EStudentFilter {FIRSTNAME,LASTNAME,HAIRCOLOUR}

    public partial class StudentView : UserControl
    {
        private bool doubleClick = false;
        private EStudentFilter filter;
        private Student selectedStudent;

        public StudentView()
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
                Student s = (Student)studentDataGrid.SelectedItem;
                if (s != null)
                    EnableUpdateAndDelete(s);
            }
        }

        private void StudentViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = new StudentViewModel();
        }

        private void cbx_filter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbx_filter.SelectedIndex == 0)
                filter = EStudentFilter.FIRSTNAME;
            else if (cbx_filter.SelectedIndex == 1)
                filter = EStudentFilter.LASTNAME;
            else
                filter = EStudentFilter.HAIRCOLOUR;
        }

        private void txb_filter_TextChanged(object sender, TextChangedEventArgs e)
        {
            ViewModel.StudentViewModel s = (ViewModel.StudentViewModel)this.DataContext;
            if (txb_filter.Text != null || txb_filter.Text != "")
                s.Filter(filter, txb_filter.Text);
            else
                s.Refresh();
        }

        private void EnableUpdateAndDelete(Student s) {
            btn_delete.Visibility = Visibility.Visible;
            btn_update.Visibility = Visibility.Visible;
            txb_update_firstname.Text = s.firstname;
            txb_update_lastname.Text = s.lastname;
            txb_update_haircolour.Text = s.haircolour;
            txb_update_age.Text = s.age.ToString();
            selectedStudent = s;
        }

        private void btn_delete_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.StudentViewModel s = (ViewModel.StudentViewModel)this.DataContext;
            s.Delete(selectedStudent);
            btn_delete.Visibility = Visibility.Collapsed;
            btn_update.Visibility = Visibility.Collapsed;
        }

        private void btn_update_Click(object sender, RoutedEventArgs e)
        {
            Student updateStudent = selectedStudent;
            updateStudent.lastname = txb_update_lastname.Text;
            updateStudent.firstname = txb_update_firstname.Text;
            updateStudent.haircolour = txb_update_haircolour.Text;
            updateStudent.age = Convert.ToInt32(txb_update_age.Text);
            ViewModel.StudentViewModel s = (ViewModel.StudentViewModel)this.DataContext;
            s.Update(updateStudent);

            btn_delete.Visibility = Visibility.Collapsed;
            btn_update.Visibility = Visibility.Collapsed;
            txb_update_firstname.Text = "";
            txb_update_lastname.Text = "";
            txb_update_haircolour.Text = "";
            txb_update_age.Text = "";
        }

        
    }
}
