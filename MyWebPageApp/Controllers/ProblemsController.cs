using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProblemsStore.Domain.Entities;
using ProblemsStore.Domain.Repository;
using System.Text;
using System.IO;
using MyWebPageApp.Infrastructure;
using MyWebPageApp.Models;

namespace MvcApplication1.Controllers
{
    public class ProblemController : Controller
    {
        public MyDBContext MyDb;
        private IQueryable<Problems> fakeDataSet { get; set;}
        //private UnitofWork unitofWork= new UnitofWork();

        public ProblemController()
        {
            MyDb = new MyDBContext();
        }

        public ViewResult Index1(int? id)
        {

            //Get Sub-Navigation Content ( DataStructure Names)

            var distinctDataStruct = (from Problems prob in MyDb.Problems
                                      join DataStructure dataStruct in MyDb.DatatStructures on prob.DataStructureId equals dataStruct.Id
                                      select new { DataStructure = dataStruct }).Distinct();


            List<Problems> probDataStruct = distinctDataStruct.ToList().Select(DataStruct => new Problems { DataStructure = DataStruct.DataStructure }).ToList();

            foreach (Problems p in probDataStruct)
            {
                string s = p.DataStructure.DataStructName;
            }

            return View(distinctDataStruct);
        }

        //[CustomRoleBaseAuth("CustomerRep")]
        public ViewResult Index(int? Pid=1, int? Did=null)
        {
            //Always Print Data Structure in As a Menu
            #region Print Sub-Navigation DS
            //var distinctDataStruct = (from Problems prob in MyDb.Problems
            //                          join DataStructure dataStruct in MyDb.DatatStructures on prob.DataStructureId equals dataStruct.Id
            //                          select new { DataStructure = dataStruct }).Distinct();


            //List<Problems> probDs = distinctDataStruct.ToList().Select(DataStruct => new Problems { DataStructure = DataStruct.DataStructure }).ToList();

            //foreach (Problems p in probDs)
            //{
            //    string s = p.DataStructure.DataStructName;
            //}

            List<DataStructure> DS = MyDb.DatatStructures.ToList();


            #endregion 

           
            //Display All Problems Titles

            IQueryable<Problems> Problems;
            if (Did == null)
                Problems = ProblemsRepository.ProblemRepository.GetALL();
            else
                Problems = ProblemsRepository.ProblemRepository.GetALL().Where(p => p.DataStructureId== Did);

            if (Pid != null)
                @ViewBag.ChildId = Pid;
            else
            {
                var prob = Problems.FirstOrDefault();
                if (prob != null)
                    @ViewBag.ChildId = prob.Id;
            }

               // return View(Problems);
                return View(new ProblemsViewModel { Problems = Problems.ToList(), DS = DS });
        }

        //this action is always called within View
        [ChildActionOnly]
        public ActionResult ProblemSolutionPartialView(int? id=1)
        {
            Problems probSol = new Problems();
            //Get By Id
            if (id != null)
            {
                probSol = ProblemsRepository.ProblemRepository.GetByID(id);
                probSol.PostDate = DateTime.Now;
                //@ViewBag.PostDate = probSol.PostDate.ToString("D");
                @ViewBag.CodeSnippet = DisplayCodeSnippet(probSol.SolutionUrl);
            }
            return PartialView(probSol);
        }
        
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public ViewResult ProblemsForm(Problems dataStructProb)
        {
            ProblemsRepository.ProblemRepository.insert(dataStructProb); //myDbContext.Problems.Add(dataStructProb);
            ProblemsRepository.ProblemRepository.save(); //myDbContext.SaveChanges();
            return View(dataStructProb);
        }

        public string DisplayCodeSnippet(string url)
        {
            StringBuilder sb = new StringBuilder();
            //String path = Server.MapPath("C:\\Users\\arao\\Documents\\visual studio 2012\\Projects\\MyWebPageApp\\Programs\\Programs\\") + url ;
            String path = Server.MapPath("\\Programs\\Programs\\") + url;
            using (StreamReader sr = new StreamReader(path))
            {
                String line = sr.ReadToEnd();
                sb.Append(line);
                   
                //Console.WriteLine(line);
            }
            sb.ToString();
                 
            return sb.ToString(); 
        }

    }
}
