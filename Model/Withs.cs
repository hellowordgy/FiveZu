using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //跟车员表
    public class Withs
    {
        //跟车员表ID
        public Guid ID        { get; set; }
        //跟车员名称
        public string WName     { get; set; }
        //籍贯
        public string WNative   { get; set; }
        //身份证
        public string WIdentity { get; set; }
        //联系方式
        public string WPhone    { get; set; }
        //家庭住址
        public string WSite     { get; set; }
        //备注
        public string WRemark   { get; set; }
    }
}
