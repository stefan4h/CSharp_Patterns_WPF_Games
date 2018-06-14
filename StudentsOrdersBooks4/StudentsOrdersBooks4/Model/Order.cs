using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsOrdersBooks4.Model
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public int s_id { get; set; }

        public int b_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime date { get; set; }

        public virtual Book Books { get; set; }

        public virtual Student Students { get; set; }
    }
}
