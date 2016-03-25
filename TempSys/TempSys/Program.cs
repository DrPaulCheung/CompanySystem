using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TempSys.Forms;
using XLuSharpLibrary.DbAccess;

namespace TempSys
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DbConfig.DbConnection = @"Data Source=.;Initial Catalog=DBCMS;User ID=sa;Password=123456";
            DbConfig.DbType = DBType.SQLServer;
           
            Application.Run(new SystemForm());
        }


    }
}
