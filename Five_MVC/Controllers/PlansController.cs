using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Five_MVC.Controllers
{
    //排车计划表控制器
    public class PlansController : Controller
    {
        // GET: Plans
        public ActionResult Index()
        {
            return View();
        }
    }
}