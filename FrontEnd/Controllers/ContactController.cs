using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FrontEnd.Controllers
{
    public class ContactController : Controller
    {
        // GET: All Active Contact Requests
        public ActionResult Index()
        {
            return View();
        }

        [HttpDelete]
        public void RemoveContactRequest()
        {

        }

        [HttpPost]
        public void PostToTestimonials()
        {

        }
    }
}