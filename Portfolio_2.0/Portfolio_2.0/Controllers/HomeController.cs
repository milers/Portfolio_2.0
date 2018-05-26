using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfolio_2._0.DAL;

namespace Portfolio_2._0.Controllers
{
    public class HomeController : BaseController
    {
        PortfolioContext pc = new PortfolioContext();

        public ActionResult Index()
        {
            
                
            return View(pc.Translations);
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


    }
}