using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //货物表
    public class Goods
    {
        //货物ID
        public Guid ID       { get; set; }
        //要求发货时间
        public DateTime GTime    { get; set; }
        //货物名称
        public string GName    { get; set; }
        //货物图片
        public string GImg     { get; set; }
        //货物详情
        public string GDetails { get; set; }
        //客户ID
        public Guid CId      { get; set; }
    }
}
