using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace tamrin.Controllers
{
    public class magController : Controller
    {
        // GET: mag
        public ActionResult Index(string family)
        {
            ViewBag.family = family;
            return View();
        }
    }
}