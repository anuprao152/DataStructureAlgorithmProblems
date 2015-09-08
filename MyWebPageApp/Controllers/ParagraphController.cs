using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProblemsStore.Domain.Entities;
using ProblemsStore.Domain.Repository;

namespace MyWebPageApp.Controllers
{
    public class ParagraphController : Controller
    {
        MyDBContext MyDB;

        public ParagraphController()
        {
            MyDB = new MyDBContext();
        }
        //
        // GET: /Paragraph/

        //public 

        public ActionResult Index(int? Id=0)
        {
            Paragraph paragraph=new Paragraph();
            if (Id > 0)
            {
                paragraph = MyDB.Paragraphs.SingleOrDefault(m => m.Id == Id);
            }
            return PartialView("ParagraphView",paragraph);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Paragraph paragraph)
        {
            try
            {
                //if (ModelState.IsValid)
                //{
                MyDB.Paragraphs.Add(paragraph);
                MyDB.SaveChanges();
                //}
            }
            catch
            {
            }
            return PartialView();
        }
    }
}
