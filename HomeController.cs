using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lecture1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Guest()
        {
            return View();
        }

        public ActionResult Main()
        {
            return View();
        }

        public ActionResult Blank()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Access()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Access(FormCollection form)
        {
            ViewBag.Gender = form["sex"];
            ViewBag.Something = form["Something"];
            ViewBag.Text = form["text"];
            return View();
        }
        public ActionResult Comment()
        {
            return View();
        }
    }
}