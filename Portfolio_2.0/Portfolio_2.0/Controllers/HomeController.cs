using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio_2._0.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Portfolio()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpGet]
        public ActionResult _LanguageList()
        {
            //    SelectList SL = new SelectList(new[]
            //{
            //    new SelectListItem { Text = "Polski", Value = "pol", Selected = true },
            //    new SelectListItem { Text = "English", Value = "eng"}, }
            //, "Value", "Text");

            ViewData["LanguageList"] = new SelectList(
                new SelectList(new[]
            {
                new SelectListItem { Text = "Polski", Value = "pol", Selected = true },
                new SelectListItem { Text = "English", Value = "eng"} })
                , "Text", "Value");

            //ViewData["LanguageList"] =l;
            return View();
        }

    }
}