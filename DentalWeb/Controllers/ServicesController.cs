using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DentalWeb.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TeethWhitening()
        {
            return View();
        }
        public ActionResult GeneralDentistry()
        {
            return View();
        }
        public ActionResult Filling()
        {
            return View();
        }
        public ActionResult Crowns()
        {
            return View();
        }
        public ActionResult RCT()
        {
            return View();
        }
    }
}