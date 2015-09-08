using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProblemsStore.Domain.Entities
{
    public class Header : Entity
    {
        [StringLength(500)]
        public string Heading { get; set; }
        //public int size { get; set; }
    }
}
