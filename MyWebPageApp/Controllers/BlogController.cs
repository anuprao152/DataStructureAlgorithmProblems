using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProblemsStore.Domain.Entities;
using ProblemsStore.Domain.Repository;
using ProblemsStore.Domain.ViewModel;

namespace MyWebPageApp.Controllers
{
    public class BlogController : Controller
    {
        //
        // GET: /Blog/
        MyDBContext myDBContext;


        public BlogController()
        {
            myDBContext = new MyDBContext();
        }

        public ActionResult Index(int? Id=1)
        {

            Blog Blog = new Blog();
            if (Id > 0)
            {
                Blog = myDBContext.Blogs.SingleOrDefault(m => m.Id == Id);
                ViewBag.BlogName = Blog.blogName;
            }

            var  blogContentQuery = from BlogContent blog in myDBContext.BlogContents
                              join Paragraph par in myDBContext.Paragraphs on blog.ParagraphId equals par.Id into ParagraphTbl
                              from Paragraph p in ParagraphTbl.DefaultIfEmpty()
                              join BulletList bullet in myDBContext.BulletLists on blog.BulletId equals bullet.Id into BulletTbl
                              from BulletList b in BulletTbl.DefaultIfEmpty()
                              join Header header in myDBContext.Headers on blog.HeadingId equals header.Id into HeaderTbl
                              from Header h in HeaderTbl.DefaultIfEmpty()
                              join Problems problem in myDBContext.Problems on blog.ProblemId equals problem.Id into ProblemTbl
                              from Problems pr in ProblemTbl.DefaultIfEmpty()
                              join Image img in myDBContext.Images on blog.ImageId equals img.Id into ImageTbl
                              from Image pic in ImageTbl.DefaultIfEmpty()
                                    where blog.BlogId == Blog.Id
                              select new { Paragraph = p, Bullet = b, Heading = h, Problem = pr, Image = pic };


            List<BlogContent> blogcontents = blogContentQuery.ToList().Select(blog => new BlogContent
            {
                Paragraph = blog.Paragraph,
                Bullet = blog.Bullet,
                Heading = blog.Heading,
                Problem = blog.Problem,
                Image = blog.Image
            }).ToList();
            return View("BlogView", blogcontents);

            //foreach (var v in blogcontent)
            //{
            //    if ( v is Paragraph)
            //    string a = "anup";
            //    //string pheading = v.pHeading;
            //    //string pContent = v.pContent;
            //    //string bHeading = v.bHeading;
            //}
            //BlogContent instructor = myDBContext.BlogContents
            //    .Select(i => i.Paragraph.Where(p => p.Id == i.ParagraphId))
                
            //    .Where(i => i.PersonID == id)
            //    .Single();

            //return View("CreateBlog");
        }

        //
        // GET: /Blog/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Blog/Create

        public ActionResult Create()
        {
            //Get All Blogs and populate the dropDown using select List
            IEnumerable<Blog> selectList = myDBContext.Blogs.ToList<Blog>();
            //SelectList blogsList = new SelectList(blogs,"Id","blogName");
           // ViewData["selectList"] = blogsList;

            BlogCreateViewModel blogsList = new BlogCreateViewModel { blogs = selectList };

            return View(blogsList);
        }

        //
        // POST: /Blog/Create

        [HttpPost]
        public ActionResult Create(Blog blog)
        {
          try
            {
                if (ModelState.IsValid)
                {
                    myDBContext.Blogs.Add(blog);
                    myDBContext.SaveChanges();
                }
            }
            catch
            {
            }

          IEnumerable<Blog> selectList = myDBContext.Blogs.ToList<Blog>();
          BlogCreateViewModel blogsList = new BlogCreateViewModel { blogs = selectList, blog = blog };

          return View(blogsList);
        }

        //
        // GET: /Blog/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Blog/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}
