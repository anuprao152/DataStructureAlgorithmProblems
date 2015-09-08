using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebPageApp.Controllers
{
    public class ErrorController : Controller
    {
        //
        // GET: /Error/

        public ActionResult HttpError404()
        {
            return View();
        }

    }
}
