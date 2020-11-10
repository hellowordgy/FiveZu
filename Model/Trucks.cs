using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //货车表
    public class Trucks
    {
        //货车ID
        public Guid ID      { get; set; }
        //货车品牌
        public string TBrand  { get; set; }
        //货车类型
        public string TType   { get; set; }
        //车牌号
        public string TPlate  { get; set; }
        //车载限额
        public float TQuota  { get; set; }
        //油耗系数
        public float TConsum { get; set; }
        //货车状态
        public string TState  { get; set; }
    }
}
