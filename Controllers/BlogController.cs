using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnleashedBlog.Models;
using UnleashedBlog.Models.EntityFramework;

namespace UnleashedBlog.Controllers
{
    public class BlogController : Controller
    {
        //
        // GET: /Blog/
        //private List<BlogEntry> _blogEntries = new List<BlogEntry>();

        private BlogRepositoryBase _repository;
       // private FakeBlogRepository repository;

        public BlogController()
       // {
            :this(new EntityFrameworkBlogRepository()){}
        //}

        public BlogController(BlogRepositoryBase repository)
        {
            // TODO: Complete member initialization
            _repository = repository;
        }

        public ActionResult Index()
        {
            // returns list of the blog entries 
            return View(_repository.ListBlogEntries());
           // return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(BlogEntry blogEntryToCreate)
        {
            //_blogEntries.Add(blogEntryToCreate);
            //return RedirectToAction("Index");

            // creating new blog entry 
            _repository.CreateBlogEntry(blogEntryToCreate);
            return RedirectToAction("Index");
            
        }
    }
}
