using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProblemsStore.Domain.Entities;
using ProblemsStore.Domain.Repository;

namespace MyWebPageApp.Controllers
{
    public class ZipDataController : Controller
    { 
        //
        // GET: /ZipData/

        public ActionResult Index(string zipcode)
        {
            IQueryable<ZipData> zipData = null;
            if (!String.IsNullOrEmpty(zipcode))
            {
                 //zipData = new MyDBContext().ZipDatas.Where(m => m.ZipCode == zipcode);
            }

            return View(zipData.ToList());
        }

        public ActionResult GetCity(string zipcode)
        {
             ZipData zipData = new ZipData();
             zipData.CityName = ZipHelper.WhatsMyCity(zipcode);
             return View(zipData);
        }

        public ActionResult GetState(string zipcode)
        {
            ZipData zipData = new ZipData();
            zipData.StateName = ZipHelper.WhatsMyState(zipcode);
            return View(zipData);
        }

    }
}
