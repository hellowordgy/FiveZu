using System;

namespace Model
{
    //客户表
    public class Client
    {
        //客户id
        public Guid ID { get; set; }
        //客户姓名
        public string CName { get; set; }
        //客户手机号
        public string CPhone { get; set; }
        //客户头像
        public string CImg { get; set; }
        //注册日期
        public DateTime CTime { get; set; }
        //账号
        public string CAccount { get; set; }
        //密码
        public string CPwd { get; set; }

    }
}
