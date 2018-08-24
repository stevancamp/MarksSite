﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FrontEnd.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() => View();

        public ActionResult AboutMark() => View();

        public ActionResult Services() => View();

        public ActionResult Insurance() => View();

        public ActionResult Blog()
        {
            return View();
        }

        public ActionResult ViewBlogEntry(int BlogID)
        {

            return View();
        }


        public ActionResult SearchBlogEntries(string SearchTerm)
        {
            return View();
        }

        [HttpPost]
        public void PostBlogComment()
        {

        }

        public ActionResult ContactMark()
        {
            return View();
        }

        [HttpPost]
        public void PostContactForm()
        {


        }

        protected override void OnException(ExceptionContext filterContext)
        {
            filterContext.ExceptionHandled = true;

            //Log the error!!
            //_Logger.Error(filterContext.Exception);

            //Redirect or return a view, but not both.
            filterContext.Result = RedirectToAction("Error");
            // OR 
            filterContext.Result = new ViewResult
            {
                ViewName = "~/Views/Shared/Error.cshtml"
            };
        }
    }
}