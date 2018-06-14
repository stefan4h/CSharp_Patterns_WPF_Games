using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsOrdersBooks4.Model
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        public string firstname { get; set; }

        public string lastname { get; set; }

        public int age { get; set; }

        public string haircolour { get; set; }

    }
}
