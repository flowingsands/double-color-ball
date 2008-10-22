using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace Lottery
{
    public partial class FrmTestProgress : Form
    {
        public static int uu = 0;
        public FrmTestProgress()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //用子线程工作
            uu = 1;

        }

         //开始下载
        public void StartDownload()
        {
            onDownLoadProgress += new dDownloadProgress(downloader_onDownLoadProgress);
            Start();
        }
        //同步更新ui
        void downloader_onDownLoadProgress(long total, long current)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new dDownloadProgress(downloader_onDownLoadProgress), new object[] { total, current });
            }
            else
            {
                this.progressBar1.Maximum = (int)total;
                this.progressBar1.Value = (int)current;
                label1.Text = current.ToString() + "%";
            }
        }

        //委托
        public delegate void dDownloadProgress(long total, long current);
        //事件
        public event dDownloadProgress onDownLoadProgress;
        //开始模拟工作
        public void Start()
        {
            for (int i = 0; i < 101; i++)
            {
                if (onDownLoadProgress != null)
                {
                    if (uu == 1)
                    {
                        i = 100;
                    }
                    onDownLoadProgress(100, i);
                }

                System.Threading.Thread.Sleep(100);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           new System.Threading.Thread(new System.Threading.ThreadStart(StartDownload)).Start();
            Thread.Sleep(5000);
            //注意，这里程序里是做程序更新任务的，为了模拟用 Sleep(5000),问题是用了以后，进度条没返应了，一直到五秒过了才动，这就不合要求了，请问一下，是什么原困，谢谢!
        }

  
      


    }
}
