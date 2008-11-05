using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lottery
{
    public partial class FrmLastFive : Form
    {
        public FrmLastFive()
        {
            InitializeComponent();
        }
        private void FrmLastFive_Load(object sender, EventArgs e)
        {
            DgvDataGridLastFiveDataInit();
        }


        private void DgvDataGridLastFiveDataInit()
        {
            dgvRLastFiveData.DataSource = SystemCommon.GetLastFiveDataTable();



            /* 相关属性设置 */
            dgvRLastFiveData.Columns[0].HeaderText = "彩票期号";
            dgvRLastFiveData.Columns[1].HeaderText = "红球";
            dgvRLastFiveData.Columns[2].HeaderText = "蓝球";
            dgvRLastFiveData.Columns[3].HeaderText = "最近五期";

            dgvRLastFiveData.Columns[4].HeaderText = "最近一期";
            dgvRLastFiveData.Columns[5].HeaderText = "红球";
            dgvRLastFiveData.Columns[6].HeaderText = "蓝球";
            dgvRLastFiveData.Columns[7].HeaderText = "中奖号码";
            dgvRLastFiveData.Columns[8].HeaderText = "中奖数";

            dgvRLastFiveData.Columns[9].HeaderText = "最近二期";
            dgvRLastFiveData.Columns[10].HeaderText = "红球";
            dgvRLastFiveData.Columns[11].HeaderText = "蓝球";
            dgvRLastFiveData.Columns[12].HeaderText = "中奖号码";
            dgvRLastFiveData.Columns[13].HeaderText = "中奖数";
        
            dgvRLastFiveData.Columns[14].HeaderText = "最近三期";
            dgvRLastFiveData.Columns[15].HeaderText = "红球";
            dgvRLastFiveData.Columns[16].HeaderText = "蓝球";
            dgvRLastFiveData.Columns[17].HeaderText = "中奖号码";
            dgvRLastFiveData.Columns[18].HeaderText = "中奖数";

            dgvRLastFiveData.Columns[19].HeaderText = "最近四期";
            dgvRLastFiveData.Columns[20].HeaderText = "红球";
            dgvRLastFiveData.Columns[21].HeaderText = "蓝球";
            dgvRLastFiveData.Columns[22].HeaderText = "中奖号码";
            dgvRLastFiveData.Columns[23].HeaderText = "中奖数";

            dgvRLastFiveData.Columns[24].HeaderText = "最近五期";
            dgvRLastFiveData.Columns[25].HeaderText = "红球";
            dgvRLastFiveData.Columns[26].HeaderText = "蓝球";
            dgvRLastFiveData.Columns[27].HeaderText = "中奖号码";
            dgvRLastFiveData.Columns[28].HeaderText = "中奖数";

            dgvRLastFiveData.Columns[29].HeaderText = "01-03";
            dgvRLastFiveData.Columns[30].HeaderText = "中奖号码";
            dgvRLastFiveData.Columns[31].HeaderText = "中奖数";

            dgvRLastFiveData.Columns[32].HeaderText = "04-07";
            dgvRLastFiveData.Columns[33].HeaderText = "中奖号码";
            dgvRLastFiveData.Columns[34].HeaderText = "中奖数";

            dgvRLastFiveData.Columns[35].HeaderText = "08-12";
            dgvRLastFiveData.Columns[36].HeaderText = "中奖号码";
            dgvRLastFiveData.Columns[37].HeaderText = "中奖数";

            dgvRLastFiveData.Columns[38].HeaderText = "13-20";
            dgvRLastFiveData.Columns[39].HeaderText = "中奖号码";
            dgvRLastFiveData.Columns[40].HeaderText = "中奖数";

            dgvRLastFiveData.Columns[41].HeaderText = "21-33";
            dgvRLastFiveData.Columns[42].HeaderText = "中奖号码";
            dgvRLastFiveData.Columns[43].HeaderText = "中奖数";


            /* 不排序 */
            dgvRLastFiveData.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvRLastFiveData.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvRLastFiveData.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvRLastFiveData.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvRLastFiveData.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvRLastFiveData.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvRLastFiveData.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvRLastFiveData.Columns[7].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvRLastFiveData.Columns[8].SortMode = DataGridViewColumnSortMode.NotSortable;

            dgvRLastFiveData.Columns[0].Width = 60;
            dgvRLastFiveData.Columns[1].Width = 110;
            dgvRLastFiveData.Columns[2].Width = 36;
            dgvRLastFiveData.Columns[3].Width = 210;

            dgvRLastFiveData.Columns[4].Width = 60;
            dgvRLastFiveData.Columns[5].Width = 110;
            dgvRLastFiveData.Columns[6].Width = 36;
            dgvRLastFiveData.Columns[7].Width = 72;
            dgvRLastFiveData.Columns[8].Width = 26;


            dgvRLastFiveData.Columns[4].Width = 60;
            dgvRLastFiveData.Columns[5].Width = 110;
            dgvRLastFiveData.Columns[6].Width = 36;
            dgvRLastFiveData.Columns[7].Width = 80;
            dgvRLastFiveData.Columns[8].Width = 26;

            dgvRLastFiveData.Columns[9].Width = 60;
            dgvRLastFiveData.Columns[10].Width = 110;
            dgvRLastFiveData.Columns[11].Width = 36;
            dgvRLastFiveData.Columns[12].Width = 90;
            dgvRLastFiveData.Columns[13].Width = 26;

            dgvRLastFiveData.Columns[14].Width = 60;
            dgvRLastFiveData.Columns[15].Width = 110;
            dgvRLastFiveData.Columns[16].Width = 36;
            dgvRLastFiveData.Columns[17].Width = 100;
            dgvRLastFiveData.Columns[18].Width = 26;

            dgvRLastFiveData.Columns[19].Width = 60;
            dgvRLastFiveData.Columns[20].Width = 110;
            dgvRLastFiveData.Columns[21].Width = 36;
            dgvRLastFiveData.Columns[22].Width = 110;
            dgvRLastFiveData.Columns[23].Width = 26;

            dgvRLastFiveData.Columns[24].Width = 60;
            dgvRLastFiveData.Columns[25].Width = 110;
            dgvRLastFiveData.Columns[26].Width = 36;
            dgvRLastFiveData.Columns[27].Width = 110;
            dgvRLastFiveData.Columns[28].Width = 26;



            dgvRLastFiveData.RowHeadersWidth = 25;
            dgvRLastFiveData.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            dgvRLastFiveData.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            for (int i = 0; i < dgvRLastFiveData.Rows.Count; i++)
            {
                dgvRLastFiveData.Rows[i].Height = 19;
                dgvRLastFiveData.Rows[i].Resizable = DataGridViewTriState.False;

            }



        }

        private void TextControlInit(int row)
        {
            row = row < 0 ? 0 : row;
            /*
            txtLotteryNumber.Text = dgvRangeData.Rows[row].Cells[0].Value.ToString().Trim();
            txtRedData.Text = dgvRangeData.Rows[row].Cells[1].Value.ToString().Trim();
            txtLastFiveData.Text = dgvRangeData.Rows[row].Cells[2].Value.ToString().Trim();
            txtRange1.Text = dgvRangeData.Rows[row].Cells[3].Value.ToString().Trim();
            txtRange1.Text = dgvRangeData.Rows[row].Cells[3].Value.ToString().Trim();
            txtRange2.Text = dgvRangeData.Rows[row].Cells[6].Value.ToString().Trim();
            txtRange3.Text = dgvRangeData.Rows[row].Cells[9].Value.ToString().Trim();
            txtRange4.Text = dgvRangeData.Rows[row].Cells[12].Value.ToString().Trim();
            txtRange5.Text = dgvRangeData.Rows[row].Cells[15].Value.ToString().Trim();
            */
        }


    }



}
