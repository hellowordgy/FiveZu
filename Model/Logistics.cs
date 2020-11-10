using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //物流表
    public class Logistics
    {
        //物流表ID
        public Guid ID      { get; set; }
        //发货单号
        public string LID     { get; set; }
        //货物重量
        public float LWeight { get; set; }
        //单价（元/吨）
        public int LPrice  { get; set; }
        //金额
        public float LMoney  { get; set; }
        //实际发车时间
        public DateTime LTime   { get; set; }
        //预计到达时间
        public DateTime YJTime  { get; set; }
        //实际到达时间
        public DateTime SJTime  { get; set; }
        //确定卸货时间
        public DateTime XHTime  { get; set; }
        //到达状态
        public string LState  { get; set; }
        //司机ID
        public Guid DId     { get; set; }
        //跟车员ID
        public Guid WId     { get; set; }
        //货车ID
        public Guid TId     { get; set; }
        //客户ID
        public Guid CId     { get; set; }
        //仓库ID
        public Guid EID     { get; set; }
    }
}
