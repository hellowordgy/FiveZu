using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClientBLL:ALLBLL<Client>
    {
        public object ClientDeng(string clientname,string password)
        {
            string sql = $"select * from Client where CAccount='{clientname}' and CPwd='{password}'";
            return DBHelper.ExecuteScalar(sql);
        }
    }
}
