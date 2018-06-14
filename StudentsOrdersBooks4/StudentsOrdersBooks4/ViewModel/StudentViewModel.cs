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
    class StudentViewModel:INotifyPropertyChanged
    {
        public StudentViewModel()
        {
            Students = GetStudentList();
        }

        ObservableCollection<Student> GetStudentList()
        {
            StudentRepository sr = new StudentRepository();
            List<Student> slist = sr.GetStudents().ToList();
            ObservableCollection<Student> ob = new ObservableCollection<Student>();
            foreach (Student s in slist)
            {
                ob.Add(s);
            }
            return ob;
        }

        public void Refresh()
        {
            Students = GetStudentList();
        }
        public void Delete(Student s) {
            StudentRepository sr = new StudentRepository();
            sr.DeleteStudent(s);
            List<Student> slist = sr.GetStudents().ToList();
            ObservableCollection<Student> ob = new ObservableCollection<Student>();
            foreach (Student st in slist)
            {
                ob.Add(st);
            }
            Students= ob;
        }
        public void Insert(Student s) {
            StudentRepository sr = new StudentRepository();
            sr.InsertStudent(s);
            List<Student> slist = sr.GetStudents().ToList();
            ObservableCollection<Student> ob = new ObservableCollection<Student>();
            foreach (Student st in slist)
            {
                ob.Add(st);
            }
            Students = ob;
        }
        public void Update(Student s) {
            StudentRepository sr = new StudentRepository();
            sr.UpdateStudent(s);
            List<Student> slist = sr.GetStudents().ToList();
            ObservableCollection<Student> ob = new ObservableCollection<Student>();
            foreach (Student st in slist)
            {
                ob.Add(st);
            }
            Students = ob;
        }

        public void Filter(EStudentFilter filter, string value) {
            StudentRepository sr = new StudentRepository();
            List<Student> slist=new List<Student>();
            if (filter == EStudentFilter.FIRSTNAME)
                slist = sr.GetStudentByFirstName(value).ToList();
            else if (filter == EStudentFilter.LASTNAME)
                slist = sr.GetStudentByLastName(value).ToList();
            else if (filter == EStudentFilter.HAIRCOLOUR)
                slist = sr.GetStudentByHaircolour(value).ToList();

            if (slist.Count > 0)
            {
                ObservableCollection<Student> ob = new ObservableCollection<Student>();
                foreach (Student s in slist)
                {
                    ob.Add(s);
                }
                Students = ob;
            }
            else
                Students = GetStudentList();

        }

        private ObservableCollection<Student> students;
        public ObservableCollection<Student> Students
        {
            get { return students; }
            set
            {
                students = value;
                RaiseChange("Students");
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
