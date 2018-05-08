using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern_Firma
{
    class DepartmentManager : AEmployee
    {
        public List<AEmployee> employeeList;

        public DepartmentManager()
        {
            employeeList = new List<AEmployee>();
        }

        public override int GetEmployeeCount()
        {
            int count = 1;
            foreach (AEmployee e in employeeList)
            {
                count += e.GetEmployeeCount();
            }
            return count;
        }

        public override List<string> GetEmployeeDiagram()
        {
            List<string> lines = new List<string>();
            lines.Add("--"+this.Name+"--");
            lines.Add("Mitarbeiter: ");
            foreach (AEmployee e in employeeList)
            {
                if(!(e is DepartmentManager)&&(e is AEmployee))
                        lines.Add("+"+e.GetEmployeeDiagram()[0]);
            }
            foreach (AEmployee d in employeeList)
            {
                if (d is DepartmentManager)
                {
                    foreach (string s in d.GetEmployeeDiagram())
                    {
                        lines.Add(s);
                    }
                }
            }
            return lines;
        }
        public void AddEmployee(AEmployee e) {
            employeeList.Add(e);
        }
        public void RemoveEmployee(AEmployee e) {
            employeeList.Remove(e);
        }
        public void RemoveEmployeeByIndex(int index) {
            employeeList.RemoveAt(index);
        }
        public void RemoveAllEmployees()
        {
            employeeList.RemoveRange(0, employeeList.Count);
        }
        public void AddEmployeeList(List<AEmployee> el) {
            employeeList.AddRange(el);
        }

    }
}
