using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProblemsStore.Domain.Entities;

namespace MyWebPageApp.Models
{
    public class ProblemsViewModel
    {
        public List<Problems> Problems { get; set; }
        public List<DataStructure> DS { get; set; }
        public DateTime date { get; set; }

    }
}