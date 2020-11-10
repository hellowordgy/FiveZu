using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //反馈表
    public class Feedback
    {
        //反馈表ID
        public Guid ID       { get; set; }
        //排车计划表ID
        public Guid Pid      { get; set; }
        //反馈类型
        public string FType    { get; set; }
        //反馈时间
        public DateTime FTime    { get; set; }
        //反馈内容
        public string FRemark  { get; set; }
        //反馈状态
        public string FState   { get; set; }
        //回复人员
        public string HFName   { get; set; }
        //回复内容
        public string HFRemark { get; set; }
    }
}
