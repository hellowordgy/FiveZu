using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //延期申请表
    public class Postpone
    {
        //延期申请表ID
        public Guid ID      { get; set; }
        //排车计划表ID
        public Guid Pid     { get; set; }
        //延期原因
        public string PRemark { get; set; }
    }
}
