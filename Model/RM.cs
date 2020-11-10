using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //用户菜单表
    public class RM
    {
        //用户菜单表ID
        public Guid ID  { get; set; }
        //角色表ID
        public Guid RId { get; set; }
        //菜单表ID
        public Guid MId { get; set; }
    }
}
