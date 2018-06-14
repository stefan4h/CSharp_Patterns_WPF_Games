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
    /// Interaktionslogik für ControllStudentViewn.xaml
    /// </summary>
    public partial class ControllStudentView : UserControl
    {
        public ControllStudentView()
        {
            InitializeComponent();
        }

        private void btn_addStudent_Click(object sender, RoutedEventArgs e)
        {
            Student student = new Student { firstname = txb_firstName.Text, lastname = txb_lastName.Text, age = Convert.ToInt32(txb_age.Text), haircolour = txb_hairColour.Text };
            ViewModel.StudentViewModel s = (ViewModel.StudentViewModel)this.DataContext;
            s.Insert(student);
            Clear();
        }

        private void txb_TextChanged(object sender, TextChangedEventArgs e)
        {
            btn_addStudent.IsEnabled = false;
            btn_clearStudent.IsEnabled = false;
            if ((txb_firstName.Text != "" && txb_firstName.Text != null) || (txb_lastName.Text != "" && txb_lastName.Text != null) || (txb_hairColour.Text != "" && txb_hairColour.Text != null) || (txb_age.Text != "" && txb_age.Text != null))
                btn_clearStudent.IsEnabled = true;
            if ((txb_firstName.Text != "" && txb_firstName.Text != null) && (txb_lastName.Text != "" && txb_lastName.Text != null) && (txb_hairColour.Text != "" && txb_hairColour.Text != null) && (txb_age.Text != "" && txb_age.Text != null))
                btn_addStudent.IsEnabled = true;
        }


        private void Clear() {
            txb_firstName.Text = "";
            txb_lastName.Text = "";
            txb_hairColour.Text = "";
            txb_age.Text = "";
        }

        private void btn_clearStudent_Click(object sender, RoutedEventArgs e)
        {
            Clear();
        }
    }
}
