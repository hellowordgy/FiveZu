using BLL;
using DAL;
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
        public IHttpActionResult ClientAdd(Client c)
        {
            c.CTime = DateTime.Now;
            string sql = $"insert into client(CName,CPhone,CTime,CAccount,CPwd) values('{c.CName}','{c.CPhone}','{c.CTime}','{c.CAccount}','{c.CPwd}')";
            int i = DBHelper.ExecuteNonQuery(sql);
            return Json(new
            {
                mag = i > 0 ? "注册成功" : "注册失败"
            }); 
        }
        //登录
        [HttpPost]
        [Route("denglu")]
        public IHttpActionResult ClientDeng(Client c)
        {

            object i = bll.ClientDeng(c.CAccount, c.CPwd);
            return Json(new { msg = i != null ? "登录成功" : "登录失败,账号或密码错误" });
        }
    }
}
