using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WeatherApplication.Models;

namespace WeatherApplication.Controllers
{
    
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NameGame()
        {
            return View();
        }


        public ActionResult WeatherOrNot()
        {
            return View();
        }

        public JsonResult GetWeather()
        {
            RainingMen rainman = new RainingMen();
            return Json(rainman.getForcast(), JsonRequestBehavior.AllowGet);

        }

    }
}
