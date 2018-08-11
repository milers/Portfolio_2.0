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
            
                
            return View(pc.Translations.ToList());
        }
        [HttpPost]
        public ActionResult getLang(int lang)
        {
            PortfolioContext db = new PortfolioContext();
            
            var returnList = db.Translations.Where(l => l.LanguageId == lang).Select(r => new { r.ObjectId, r.Name }).ToList();
            var model = new
            {
                AboutMenu = returnList.Where(r => r.ObjectId == "AboutMenu").Select(s => s.Name).FirstOrDefault(),
                ContactMenu = returnList.Where(r => r.ObjectId == "ContactMenu").Select(s => s.Name).FirstOrDefault(),
                PortfolioMenu = returnList.Where(r => r.ObjectId == "PortfolioMenu").Select(s => s.Name).FirstOrDefault()
                //mAbout = returnList.Where(r => r.ObjectId == "ContactMenu").Select(s => s.Name).FirstOrDefault(),
                //mAbout = returnList.Where(r => r.ObjectId == "ContactMenu").Select(s => s.Name).FirstOrDefault(),
                //mAbout = returnList.Where(r => r.ObjectId == "ContactMenu").Select(s => s.Name).FirstOrDefault(),
            };
            return Json(model);
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