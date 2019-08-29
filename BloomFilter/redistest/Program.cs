using FrameworkCore.Utils;
using GCHeritagePlatform.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace redistest
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConnectDb();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        /// <summary>
        /// 连接数据库
        /// </summary>
        static void ConnectDb()
        {
            try
            {
                string dbDllPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "FrameworkDB.MySQL.dll");
                string dbConnStr = System.Configuration.ConfigurationManager.AppSettings["dbConnStr"];
                string provideName = "FrameworkDB.MySQL.MySQLDBHelper";
                DBHelperPool.Instance.Add("mySQL", dbDllPath, dbConnStr, provideName);
                DBHelperPool.Instance.Add("2", dbDllPath, dbConnStr, provideName);
                SystemLogger.getLogger().Info("数据库初始化成功");
            }
            catch (Exception ex)
            {
                SystemLogger.getLogger().Error("数据库初始化失败", ex);
            }
        }
        public static void addId()
        {

        }
    }
}
