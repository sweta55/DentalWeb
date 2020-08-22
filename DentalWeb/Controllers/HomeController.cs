using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DentalWeb.Models;

namespace DentalWeb.Controllers
{
    public class HomeController : Controller
    {
   
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "25 years of great oral health experience journey";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Feel free to contant us";

            return View();
        }

        public ActionResult Service()
        { 
            return View();
        }

        public ActionResult GoogleMap()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Appointment()
        {
            return View();
        }  
    }
}