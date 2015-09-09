using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProblemsStore.Domain.Entities
{
    public class Blog : Entity
    {
        public string blogName { get; set; }

        public virtual ICollection<BlogContent> Contents { get; set; }
        public virtual ICollection<Header> Headings { get; set; }
        public virtual ICollection<Paragraph> Paragraphs { get; set; }
        public virtual ICollection<BulletList> Bullets { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<Problems> Problems { get; set; }

        public DateTime EnterDate { get; set; }
        //public virtual ICollection<Video> Videos { get; set; }
    }
}
