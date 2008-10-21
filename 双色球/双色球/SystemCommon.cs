using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Linq;
using System.Data;


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

        public static void StatisticLastFiveData()
        {
            IList<FlIssue> listFlIssue = null;

            using (TableFlIssue tabFlIssue = new TableFlIssue())
            {
                listFlIssue = tabFlIssue.GetTableDataToList();
            }
            
            /* 统计最近五期的数据 */            
            IList<LastFiveIssue> lastfiveList = new List<LastFiveIssue>();
            int count = listFlIssue.Count;

            for (int i = 0; i < count; i++)
            {
                string nRutString = string.Empty;
                string[] lotIssue = new string[]{"","","","","",""};
                string[] redResult = new string[]{ "", "", "", "", "", "" };
                string[] countResult = new string[]{ "", "", "", "", "", "" };
                int[] coutRed = new int[]{0,0,0,0,0,0};

                for (int j = 0; j < 5; j++)
                {
                    if (i + j + 1 >= count) break;

                    lotIssue[j] = listFlIssue[i + j + 1].LotIssue;
                    redResult[j] = listFlIssue[i + j + 1].Result1;
                    nRutString += redResult[j] + " ";
                    AwardNumber awardNumber = new AwardNumber();
                    awardNumber.Anlysis(nRutString, listFlIssue[i].Result1);
                    countResult[j] = awardNumber.GetResult();
                    coutRed[j] = awardNumber.GetCount();

                }

                lastfiveList.Add(new LastFiveIssue(listFlIssue[i].LotIssue, listFlIssue[i].Result1,
                                                   lotIssue[0], redResult[0], countResult[0], coutRed[0],
                                                   lotIssue[1], redResult[1], countResult[1], coutRed[1],
                                                   lotIssue[2], redResult[2], countResult[2], coutRed[2],
                                                   lotIssue[3], redResult[3], countResult[3], coutRed[3],
                                                   lotIssue[4], redResult[4], countResult[4], coutRed[4]
                                                   )
                                 );
                                                   
            }

            string insertString = string.Empty;
            for (int i = 0; i < count; i++)
            {
                //insertString += lastfiveList[i].InsertMysqlString + "\r\n";
                insertString += lastfiveList[i].UpdateMysqlString + "\r\n";
            }

            /* 理新到数据库　*/
            using (TableLastFiveIssue tabIssue = new TableLastFiveIssue())
            {
                tabIssue.DataUpdate(insertString);
            }
 
        }

        public static void StatisticRangeData()
        {
            IList<FlIssue> listFlIssue = null;

            using (TableFlIssue tabFlIssue = new TableFlIssue())
            {
                listFlIssue = tabFlIssue.GetTableDataToList();
            }

            /* 统计最近五期的数据 */
            IList<RangeIssue> rangeList = new List<RangeIssue>();
            int count = listFlIssue.Count;

            for (int i = 0; i < count; i++)
            {
                string nRutString = string.Empty;
                for (int j = 0; j < 5; j++)
                {
                    if (i + j + 1 >= count) break;
                    if (listFlIssue[i + j + 1].Result1 != "")
                    {
                        nRutString += listFlIssue[i + j + 1].Result1 + " ";
                    }
                }
                RangeNumber rangNumber = new RangeNumber();
                rangNumber.Anlysis(nRutString);
                string[] redData = rangNumber.GetResult();
                //int[] redCount = rangNumber.GetCount();

                rangeList.Add(new RangeIssue(listFlIssue[i].LotIssue, listFlIssue[i].Result1, redData[0],
                                            redData[1], "", 0,
                                            redData[2], "", 0,
                                            redData[3], "", 0,
                                            redData[4], "", 0,
                                            redData[5], "", 0
                                              )
                              );

            }

            string insertString = string.Empty;
            for (int i = 0; i < count; i++)
            {
                insertString += rangeList[i].UpdateMysqlString + "\r\n";
            }

            /* 理新到数据库　*/
            using (TableRangeIssue tabIssue = new TableRangeIssue())
            {
                tabIssue.DataUpdate(insertString);
            }

        }

        public static DataTable GetAwardDataTable()
        {
            DataTable dataTable = null;

            using (TableFlIssue tabFlIssue = new TableFlIssue())
            {
                dataTable = tabFlIssue.GetTableDataForMaintenceForm();
            }

            return dataTable;
        }
     
        public static DataTable GetRangeDataTable()
        {
            DataTable dataTable = null;

            using (TableRangeIssue tabRangeIssue = new TableRangeIssue())
            {
                dataTable = tabRangeIssue.GetTableDataForMaintenceForm();
            }

            return dataTable;
        }
      
        public static void ExitApp()
        {
            if (MessageBox.Show("确定关闭系统吗？", "关闭确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        } 

    }
}