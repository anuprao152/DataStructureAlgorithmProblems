using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProblemsStore.Domain.Entities
{
    public class Image : Entity
    {
        [StringLength(500)]
        public string ImageUrl { get; set; }

        [StringLength(500)]
        public string Caption { get; set; }

        
        public string Description { get; set; }

        //Nullable Blog Id as a ForeignKey
        public int? BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
