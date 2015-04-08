using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutcomASPMVCTemplate.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Examples()
        {
            return View();
        }

        public ActionResult APage()
        {
            return View();
        }

        public ActionResult AnotherPage()
        {
            return View();
        }

        public ActionResult ContactUs()
        {
            return View();
        }
    }
}