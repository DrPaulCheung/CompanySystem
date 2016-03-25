using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempSys.Business
{
    class User
    {

        #region 属性
        //用户名
        private string username;
        public string UserName
        {
            get { return username;}
            set { username = value; }
        }
        //密码
        private string password;
        public string PassWord
        {
            get { return password; }
            set { password = value; }
        }

        #endregion

        //登录用户验证 是否存在该用户 
        public bool isExistsUser()
        {
            string sql = "select count(*) from Users where (cms_username= '"+UserName+"') and (cms_password='"+PassWord+"') " ;
            SqlConnection conn = DataBase.Camcon();
            conn.Open(); 
            SqlCommand cmd = new SqlCommand(sql,conn);


            if(Convert.ToInt32( cmd.ExecuteScalar() ) > 0)
            {
                return true;
            }
            return false;
        }

    }
}
