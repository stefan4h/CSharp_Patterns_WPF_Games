using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Persom_To_Customer
{
    class PersonToCustomer : ICustomer
    {
        private string firstName;
        private string lastName;

        public string GetFirstName()
        {
            return firstName;
        }

        public string GetLastName()
        {
            return lastName;
        }

        public PersonToCustomer(Person person)
        {
            firstName = person.Name.Split(' ')[0];
            lastName = person.Name.Split(' ')[1];
        }
    }
}
