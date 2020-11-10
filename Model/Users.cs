using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //用户表
    public class Users
    {
        //用户表ID
        public Guid ID    { get; set; }
        //用户名
        public string UName { get; set; }
        //用户密码
        public string UPwd { get; set; }
    }
}
