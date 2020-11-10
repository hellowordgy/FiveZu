using DAL;
using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    //排车计划表
    public class PlansBLL
    {
        //显示
        public List<Plans> ShowPlans()
        {
            string sql = $"";
            return DBHelper.GetToList<Plans>(sql);
        }
        //添加
        public int AddPlans(Plans p)
        {
            string sql = $"insert into Plans values()";
            return DBHelper.ExecuteNonQuery(sql);
        }
        //删除
        public int DelPlans(int id)
        {
            string sql = $"delete from Plans where ID in ({id})";
            return DBHelper.ExecuteNonQuery(sql);
        }
        //反填
        public Plans GetStudents(int id)
        {
            string sql = $"select * from Students where SId ={id}";
            var dt = DBHelper.GetToList<Plans>(sql);
            string json = JsonConvert.SerializeObject(dt);
            Plans s = JsonConvert.DeserializeObject<List<Plans>>(json).FirstOrDefault();
            return s;
        }
        //修改
        public int UpdPlans(Plans q)
        {
            string sql = $"update Plans set ";
            return DBHelper.ExecuteNonQuery(sql);
        }
    }
}
