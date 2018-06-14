using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsOrdersBooks4.Model.Repository
{
    class StudentRepository:IStudentRepository,IDisposable
    {
        private DBContext context;

        public StudentRepository()
        {
            context = new DBContext();
        }

        public void DeleteStudent(Student s)
        {
            if (s != null)
            {
                context.Students.Attach(s);
                context.Students.Remove(s);
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


        public Student GetStudentByID(int studentId)
        {
            return context.Students.Where(s => s.Id == studentId).Select(s => s) as Student;
        }

        public IEnumerable<Student> GetStudents()
        {
            return context.Students.Select(s => s) as IEnumerable<Student>;
        }

        public void InsertStudent(Student student)
        {
            context.Students.Add(student);
            Save();
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateStudent(Student student)
        {
            context.Entry(student).State = System.Data.Entity.EntityState.Modified;
            Save();
        }

        IEnumerable<Student> IStudentRepository.GetStudents()
        {
            return context.Students.Select(s => s) as IEnumerable<Student>;
        }

        Student IStudentRepository.GetStudentByID(int studentId)
        {
            return context.Students.Where(s => s.Id == studentId).Select(s => s) as Student;
        }

        IEnumerable<Order> IStudentRepository.GetOrdersForStudentID(int studentID)
        {
            return context.Orders.Where(o => o.s_id == studentID).Select(o => o) as IEnumerable<Order>;
        }

        public IEnumerable<Student> GetStudentByFirstName(string firstname) {
            return context.Students.Where(s => s.firstname == firstname).Select(s => s) as IEnumerable<Student>;
        }
        public IEnumerable<Student> GetStudentByLastName(string lastname)
        {
            return context.Students.Where(s => s.lastname == lastname).Select(s => s) as IEnumerable<Student>;
        }
        public IEnumerable<Student> GetStudentByHaircolour(string haircolour)
        {
            return context.Students.Where(s => s.haircolour == haircolour).Select(s => s) as IEnumerable<Student>;
        }
    }
}
