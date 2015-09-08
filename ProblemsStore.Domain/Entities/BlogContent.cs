using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProblemsStore.Domain.Entities
{
    //This class is just for print Content in order 
    public class BlogContent : Entity
    {
        //public enum CType { Heading, Paragraph, List, Link, Image, video };

        //public Header BlogTitle { get; set; }

        //public virtual ICollection<Header> Headings { get; set; }
        //public virtual ICollection<Paragraph> Paragraphs { get; set; }
        //public virtual ICollection<BulletList> Bullets { get; set; }
        //public virtual ICollection<Image> Images { get; set; }
        //public virtual ICollection<Problems> Problems { get; set; }
        ////public virtual ICollection<Video> Videos { get; set; }

        [StringLength(500)]
        public string Url { get; set; }

        //Nullable Image Id as a ForeignKey
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }

        //Here ParagraphId, BulletListId and Image Id part of my BlogContent Table
        // to manintain Order of contetn.

        public int? HeadingId { get; set; }
        public Header Heading { get; set; }

        public int? ParagraphId { get; set; }
        public Paragraph Paragraph { get; set; }

        public int? BulletId { get; set; }
        public BulletList Bullet { get; set; }

        public int? ImageId { get; set; }
        public Image Image { get; set; }

        public int? ProblemId { get; set; }
        public Problems Problem { get; set; }
        //public virtual ICollection<Video> Videos { get; set; }
       
    }
}
