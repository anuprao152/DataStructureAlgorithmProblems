using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProblemsStore.Domain.Entities
{
    public class Paragraph : Entity
    {
        public Header Heading { get; set; }
        public int? HeaderId { get; set; }

        [DataType(DataType.MultilineText)]
        public string Content { get; set; }

        //Nullable Blog Id as a ForeignKey
        public int? BlogId { get; set; }
        public virtual Blog Blog { get; set; }

        //Nullable Problem Id as a ForeignKey
        
        public int? ProblemId { get; set; }
        public virtual Problems Problem { get; set; }
    }
}
