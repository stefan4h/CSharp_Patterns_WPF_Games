using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsOrdersBooks4.Model
{
    public class Book
    {

        [Key]
        public int Id { get; set; }

        public string title { get; set; }

        public string author { get; set; }

        public string price { get; set; }
    }
}
