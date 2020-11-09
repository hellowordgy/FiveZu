using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Five_MVC.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        //注册
        public ActionResult ClientAdd()
        {
            return View();
        }
    }
}