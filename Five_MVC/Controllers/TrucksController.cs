using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Five_MVC.Controllers
{
    public class TrucksController : Controller
    {
        // GET: Trucks
        public ActionResult Index()
        {
            return View();
        }
    }
}