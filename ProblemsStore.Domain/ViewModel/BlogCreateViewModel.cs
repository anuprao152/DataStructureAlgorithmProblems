using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemsStore.Domain.Entities;

namespace ProblemsStore.Domain.ViewModel
{
    public class BlogCreateViewModel
    {
        public IEnumerable<Blog> blogs { get; set; }
        public Blog blog { get; set; }
    }
}
