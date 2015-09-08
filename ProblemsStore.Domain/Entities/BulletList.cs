using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProblemsStore.Domain.Entities
{
    public class BulletList : Entity
    {
        public Header Heading { get; set; }
        public int? HeaderId { get; set; }

        [StringLength(500)]
        [DataType(DataType.MultilineText)]
        public string point { get; set; }

        //Nullable Blog Id as a ForeignKey
        public int? BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
