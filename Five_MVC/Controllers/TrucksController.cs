using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using Model;

namespace Five_MVC.Controllers
{
    public class TrucksController : Controller
    {
        // 货车显示
        public ActionResult Index()
        {
            string sql = $"select * from Trucks";
            List<Trucks> trucks = DAL.DBHelper.GetToList<Trucks>(sql);
            return View(trucks);

        }

        ////货车添加
        //public ActionResult Add(Trucks t)
        //{
        //    string sql = $"insert into Trucks(TBrand,TType,TPlate,TQuota,TConsum) values('江淮','大型货车','粤B70CZ9','15','0.13')";
        //    DAL.DBHelper.ExecuteNonQuery(sql);
        //    return RedirectToAction("Index");
        //}

        ////货车删除
        //public ActionResult Delete()
        //{
        //    return View();
        //}

        ////货车修改
        //public ActionResult Edit()
        //{
        //    return View();
        //}


    }
}