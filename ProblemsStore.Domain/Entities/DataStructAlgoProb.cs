using System.ComponentModel.DataAnnotations;  
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProblemsStore.Domain.Entities
{
    [Table ("Problems")]
    public class Problems : Blog
    {
        // you don't follow convention of code first ( Id or ProblemsId ) that you need to write Key attribute 
        // Id Attribut Inherits from Entity Type
        public string Title { get; set; }
        public string SolutionUrl { get; set; }
        //public ICollection<Paragraph> Paragraphs { get; set; }

        public int? TagId { get; set; }
        public Tag Tagged { get; set; }

        //FK Nullable
        public int? DataStructureId { get; set; }
        public virtual DataStructure DataStructure { get; set; }

        //Nullable Blog Id as a ForeignKey and Nullable
        //public int? BlogId { get; set; }
        //public virtual Blog Blog { get; set; }
    }
}
