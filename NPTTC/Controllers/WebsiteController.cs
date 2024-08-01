using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NPTTC.Controllers
{
    public class WebsiteController : Controller
    {
        // GET: Website
        public ActionResult Index()
        {
            return View();
        }
    }
}