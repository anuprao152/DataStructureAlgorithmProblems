using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProblemsStore.Domain.Entities;
using ProblemsStore.Domain.Repository;

namespace MyWebPageApp.Controllers
{
    public class ImageController : Controller
    {
        MyDBContext MyDB;

        public ImageController()
        {
            MyDB = new MyDBContext();
        }
        //
        // GET: /Image/

        public ActionResult Index(int? Id=0)
        {
            Image image;
            if (Id > 0)
            {
                // Using primary key so SingleorDefault, Get Image
                image = MyDB.Images.SingleOrDefault(m => m.Id == Id);
            }
            else
            {
                //Create New Image
                image = new Image();
                //image.Id = 0;
            }

            return View("ImageView",image);
        }

        public ActionResult Save()
        {
            return View("ImageView");
        }

        [HttpPost]
        public ActionResult Save(Image Image)
        {
            MyDB.Images.Add(Image);
            MyDB.SaveChanges();
            return View("ImageView");
        }


    }
}
