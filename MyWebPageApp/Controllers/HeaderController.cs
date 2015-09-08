using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProblemsStore.Domain.Entities;
using ProblemsStore.Domain.Repository;

namespace MyWebPageApp.Controllers
{
    public class HeaderController : Controller
    {
        MyDBContext MyDB;

        public HeaderController()
        {
            MyDB = new MyDBContext();
        }
        //
        // GET: /Header/

        public ActionResult Index(int? Id)
        {
            Header Heading = new Header();
            if (Id > 0)
            {
                Heading = MyDB.Headers.SingleOrDefault(m => m.Id == Id);
            }
            return PartialView(Heading);
        }

    }
}
