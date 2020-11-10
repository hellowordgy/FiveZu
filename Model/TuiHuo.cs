using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //退货表
    public class TuiHuo
    {
        //退货表ID
        public Guid ID        { get; set; }
        //退货编码
        public string THSerials { get; set; }
        //拒收ID
        public Guid RId       { get; set; }
        //退货状态
        public string THState   { get; set; }
        //退货申请时间
        public DateTime THTime    { get; set; }
    }
}
