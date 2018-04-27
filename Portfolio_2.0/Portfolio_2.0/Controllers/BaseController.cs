using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio_2._0.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {

            base.OnActionExecuted(filterContext);
            /// Here I have fetch value as static but you can take if from your entity framework or db.
            List<SelectListItem> oList = new List<SelectListItem>();
            SelectListItem oItem = new SelectListItem();
            oItem.Text = "Polski";
            oItem.Value = "1";

            oList.Add(oItem);
            SelectListItem oItem1 = new SelectListItem();
            oItem1.Text = "English";
            oItem1.Value = "2";
            oList.Add(oItem1);

            ViewBag.LanguageList = oList;
        }

        protected override void ExecuteCore()
        {

            base.ExecuteCore();
        }
    }
}