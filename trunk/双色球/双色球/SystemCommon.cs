using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace Lottery
{

    class SystemCommon
    {
        public static void UpdateAwardData()
        {
            string rutData = WebData.GetAwardData();
            using (TableFlIssue tabFlIssue = new TableFlIssue())
            {
                tabFlIssue.DataUpdate(rutData);
            }
            MessageBox.Show("数据更新成功！" , "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public static void UpdateLotteryData()
        {
            string rutData = WebData.GetLotteryData();
            using (TableFlIssue tabFlIssue = new TableFlIssue())
            {
                tabFlIssue.DataUpdate(rutData);
            }
            MessageBox.Show("数据更新成功！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}