using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ALLBLL<T>
        {
            /// <summary>
            /// 查询
            /// </summary>
            /// <param name="biao">表名</param>
            /// <returns></returns>
            public List<T> TShow(string biao)
            {
                string sql = $"select * from {biao}";
                return DBHelper.GetToList<T>(sql);
            }
            /// <summary>
            /// 添加
            /// </summary>
            /// <param name="t"></param>
            /// <returns></returns>
            public int TAdd(T t)
            {
                Type type = t.GetType();
                PropertyInfo[] pro = type.GetProperties();
                string biao = type.Name;
                string ziduan = "";
                string zhi = "";
                foreach (var item in pro)
                {
                    if (item.Name.ToLower() != "id")
                    {
                        ziduan += item.Name + ",";
                        zhi += "'" + item.GetValue(t).ToString() + "',";
                    }

                }
                ziduan = ziduan.Trim(',');
                zhi = zhi.Trim(',');
                string sql = $"insert into {biao}({ziduan}) values({zhi})";
                int i = DBHelper.ExecuteNonQuery(sql);
                return i;

            }
            /// <summary>
            /// 删除
            /// </summary>
            /// <param name="biao">表名</param>
            /// <param name="id">要删除的id</param>
            /// <returns></returns>
            public int delete(string biao, string id)
            {
                string sql = $"delete {biao} where id={id}";
                return DBHelper.ExecuteNonQuery(sql);
            }
            /// <summary>
            /// 反填
            /// </summary>
            /// <param name="biao"></param>
            /// <param name="id"></param>
            /// <returns></returns>
            public T Fan(string biao, int id)
            {
                string sql = $"select * from {biao} where id={id}";
                return DBHelper.GetToList<T>(sql)[0];
            }
        }
    
}
