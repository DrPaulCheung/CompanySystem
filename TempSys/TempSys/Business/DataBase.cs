using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempSys.Business
{
    class DataBase
    {
        public static SqlConnection Camcon()
        {
            return new SqlConnection("Data Source=(local);Initial Catalog=DBCMS;User ID=sa;Password=123456");
        }  
    }
}
