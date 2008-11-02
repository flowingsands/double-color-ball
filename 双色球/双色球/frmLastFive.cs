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
            dgvRLastFiveData.Columns[1].HeaderText = "开奖结果";
            dgvRLastFiveData.Columns[2].HeaderText = "最近五期";
            dgvRLastFiveData.Columns[3].HeaderText = "01-03";
            dgvRLastFiveData.Columns[4].HeaderText = "中奖号码";
            dgvRLastFiveData.Columns[5].HeaderText = "中奖数";
            dgvRLastFiveData.Columns[6].HeaderText = "04-07";
            dgvRLastFiveData.Columns[7].HeaderText = "中奖号码";
            dgvRLastFiveData.Columns[8].HeaderText = "中奖数";
            dgvRLastFiveData.Columns[9].HeaderText = "08-12";
            dgvRLastFiveData.Columns[10].HeaderText = "中奖号码";
            dgvRLastFiveData.Columns[11].HeaderText = "中奖数";
            dgvRLastFiveData.Columns[12].HeaderText = "13-20";
            dgvRLastFiveData.Columns[13].HeaderText = "中奖号码";
            dgvRLastFiveData.Columns[14].HeaderText = "中奖数";
            dgvRLastFiveData.Columns[15].HeaderText = "21-33";
            dgvRLastFiveData.Columns[16].HeaderText = "中奖号码";
            dgvRLastFiveData.Columns[17].HeaderText = "中奖数";

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
            dgvRLastFiveData.Columns[1].Width = 70;
            dgvRLastFiveData.Columns[2].Width = 210;
            dgvRLastFiveData.Columns[3].Width = 36;
            dgvRLastFiveData.Columns[4].Width = 62;
            dgvRLastFiveData.Columns[5].Width = 50;
            dgvRLastFiveData.Columns[6].Width = 58;
            dgvRLastFiveData.Columns[7].Width = 50;
            dgvRLastFiveData.Columns[8].Width = 58;

            dgvRLastFiveData.RowHeadersWidth = 25;
            dgvRLastFiveData.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            dgvRLastFiveData.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            for (int i = 0; i < dgvRLastFiveData.Rows.Count; i++)
            {
                dgvRLastFiveData.Rows[i].Height = 19;
                dgvRLastFiveData.Rows[i].Resizable = DataGridViewTriState.False;

            }



        }

        

    }



}
