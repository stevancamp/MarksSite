using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FrontEnd.Controllers
{
    public class TestimonialController : Controller
    {
        [Authorize]
        // GET: All Active Testimonials
        public ActionResult Index()
        {
            return View();
        }

        [HttpDelete]
        public void RemoveTestimonial()
        {

        }
    }
}