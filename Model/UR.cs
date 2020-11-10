using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //用户角色表
    public class UR
    {
        //用户角色表ID
        public Guid ID  { get; set; }
        //用户表ID
        public Guid UId { get; set; }
        //角色表ID
        public Guid RId { get; set; }
    }
}
