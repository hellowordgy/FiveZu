using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //调车表
    public class Shunt
    {
        //调车表ID
        public Guid ID    { get; set; }
        //排车计划表ID
        public Guid Pid   { get; set; }
        //调车人
        public string SName { get; set; }
    }
}
