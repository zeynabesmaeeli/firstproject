using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace tamrin.Controllers
{
    public class asliController : Controller
    {

        // GET: asli
        public ActionResult Index(string name, string family)
        {
           
            ViewBag.name = name;
            ViewBag.family = family;
            return View();
        }
    }
}