using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //拒收表
    public class Rejection
    {
        //拒收表ID
        public Guid ID       { get; set; }
        //拒收编码
        public string RSerials { get; set; }
        //排车计划表ID
        public Guid Pid      { get; set; }
        //延期原因
        public string RRemark  { get; set; }
        //拒收状态
        public string RState   { get; set; }
    }
}
