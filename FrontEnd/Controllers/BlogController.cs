using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FrontEnd.Controllers
{
    public class BlogController : Controller
    {
        [Authorize]
        // GET: All Currently Active Blogs
        public ActionResult Index()
        {
            return View();
        }

        [HttpPut]
        public void ApproveBlogComment()
        {

        }

        [HttpPost]
        public void PostBlogEntry()
        {

        }

        [HttpPost]
        public void RemoveBlogEntry()
        {

        }
    }
}