using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProblemsStore.Domain.Entities
{
    public class Video : Entity
    {
        [StringLength(250)]
        public string VideoUrl { get; set; }

        [StringLength(500)]
        public string Caption { get; set; }

        public string Description { get; set; }

        //Nullable Blog Id as a ForeignKey
        public int? BlogContentId { get; set; }
        public virtual BlogContent BlogContent { get; set; }
    }
}
