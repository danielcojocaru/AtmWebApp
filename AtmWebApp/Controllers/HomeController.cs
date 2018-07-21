using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AtmMvcWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Default()
        {
            return RedirectToAction("Contact");
        }

        public ActionResult Index()
        {
            var a = ViewBag.Browser;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return RedirectToAction("Contact");
        }

        public ActionResult GetIban(string input)
        {
            return Content(input + " and Co.");
        }

        [HttpGet]
        public ActionResult Contact()
        {
            string a = string.Format("{0:c} Euro", -2);
            string b = string.Format("{0:c} Euro", 3);


            ViewBag.Message = "In [HttpGet]";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(string messageInTextArea)
        {
            ViewBag.Message = messageInTextArea;
            var a = ViewBag.Browser;

            return View();
        }
    }
}