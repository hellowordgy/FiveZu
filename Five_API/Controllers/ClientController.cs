using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Five_API.Controllers
{
    [RoutePrefix("Five")]
    public class ClientController : ApiController
    {
        ClientBLL bll = new ClientBLL();
        //注册
        [HttpPost]
        [Route("zhuce")]
        public IHttpActionResult ClientAdd()
        {
            string path = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "img/";
            //用户提交的数据
            var Data = System.Web.HttpContext.Current.Request.Form;
            string filesrc = string.Empty;
            string src = string.Empty;
            //获取上传的文件
            var httpPostedFile = HttpContext.Current.Request.Files;
            //int i = bll.TAdd(c);
            //return Json(new { msg = i > 0 ? "注册成功" : "注册失败" });
            return Json(1);
        }
        //登录
        public IHttpActionResult ClientDeng(string username,string password)
        {
            object i = bll.ClientDeng(username, password);
            return Json(new { msg = i != null ? "1" : "0" });
        }
    }
}
