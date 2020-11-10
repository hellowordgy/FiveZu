using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //排车计划表
    public class Plans
    {
        //排车计划表ID
        public Guid ID      { get; set; }
        //排车流水号
        public string PSerial { get; set; }
        //仓库ID
        public Guid EID     { get; set; }
        //物流ID
        public Guid LId     { get; set; }
        //排表人
        public string PName { get; set; }
    }
}
