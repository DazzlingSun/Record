using FrameworkCore.DBInterface;
using GCHeritagePlatform.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace redistest
{
    public partial class Form1 : Form
    {
        private IDBHelper dBHelper;
        public BloomFilter<string> bf;

        public Form1()
        {
            dBHelper = DBHelperPool.Instance.GetDbHelper("2");
            InitializeComponent();
        }
        /// <summary>
        /// 最优m
        /// </summary>
        /// <param name="n"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        private int OptionNumberofM(int n, double p)
        {
            var double2 = Math.Log(2) * Math.Log(2);
            return (int)Math.Ceiling(-1 * n * Math.Log(p) / double2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var content = this.textBoxContent.Text;
            //var gail = bf.FalsePositiveProbability();
            var res = bf.Contains(content);
            textBoxIsExist.Text = res.ToString();
        }
        private void bloomFilterFirst()
        {
            var falsepositi = 0.00001;
            var sqlCount = "select count(*) from jieru_aqi_mintue_data";
            var count = Convert.ToInt32(dBHelper.executeScalar(sqlCount).ToString());
            var m = OptionNumberofM(count, falsepositi);
            bf = new BloomFilter<string>(m, count);
            var sqlId = "select so2_density from jieru_aqi_mintue_data";
            var idlist = dBHelper.executeSingleFieldValueList(sqlId);
            foreach (string id in idlist)
            {
                bf.Add(id);
            }
            //textBoxMemory.Text = Memory(count, falsepositi);
            //一个服务对应一个过滤器   启动的时候进行加载，添加的时候想字典里添加，删除的时候字典进行删除
            //散片加载路径下全部数据的名称   mongodb加载  x_y_l  
            //Dictionary<string, BloomFilter<string>> pairs = new Dictionary<string, BloomFilter<string>>();
            //pairs.Add("key1", bf);
            //var kk = pairs["key1"];
            //pairs.Remove("key1");
            //var dir = @" C:/工作空间/data";//    C:/工作空间/data
            //DirectoryInfo directoryInfo = new DirectoryInfo(dir);
            ////var sss = Directory.GetFiles(dir, "(*.zip|*.rar)", SearchOption.AllDirectories);
            ////var filelist1 = directoryInfo.GetFiles("(*.zip|*.rar)", SearchOption.AllDirectories);
            //var filelist = directoryInfo.GetFiles("*.*", SearchOption.AllDirectories);
            //var count = filelist.Length;
            //var m = OptionNumberofM(count, falsepositi);
            //bf = new BloomFilter<string>(m, count);
            //foreach (FileInfo file in filelist)
            //{
            //    bf.Add(file.Name);
            //}
            textBoxMemory.Text = Memory(count, falsepositi);
            textBoxCount.Text = count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bloomFilterFirst();
            MessageBox.Show("初始化完成。");
        }
        /// <summary>
        /// bit转M
        /// </summary>
        /// <param name="n"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public string Memory(int n, double p)
        {
            var memory = Convert.ToDouble(OptionNumberofM(n, p)) / 1048576 / 8;
            return memory.ToString("0.00");
        }
    }
}
