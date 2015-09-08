using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProblemsStore.Domain.Entities;
using ProblemsStore.Domain.Repository;

namespace MyWebPageApp.Controllers
{
    public class BulletController : Controller
    {
        MyDBContext MyDB;

        public BulletController()
        {
            MyDB = new MyDBContext();
        }
        //
        // GET: /Bullet/

        public ActionResult Index(int Id=0)
        {
            BulletList bullet = new BulletList();

            if (Id > 0)
            {
                bullet = MyDB.BulletLists.SingleOrDefault(m => m.Id == Id);
            }

            return PartialView(bullet);
        }

        public ActionResult Create()
        {
           
            return View();
        }

        [HttpPost]
        public ActionResult Create(BulletList bullet)
        {
            try
            {
                //if (ModelState.IsValid)
                //{
                    MyDB.BulletLists.Add(bullet);
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
