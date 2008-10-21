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
    public partial class FrmLotteryData : Form
    {
        public FrmLotteryData()
        {
            InitializeComponent();
        }

        private void FrmLotteryData_Load(object sender, EventArgs e)
        {
            DgvAwardDataGridInit();
            DgvRangeDataGridInit();
            TextControlInit1(0);
            TextControlInit1(2);
        }

        private void DgvAwardDataGridInit()
        {
            this.dgvAwardData.DataSource = SystemCommon.GetAwardDataTable();

            /* 相关属性设置 */
            dgvAwardData.Columns[0].HeaderText = "彩票期号";
            dgvAwardData.Columns[1].HeaderText = "开奖时间";
            dgvAwardData.Columns[2].HeaderText = "开奖结果";
            dgvAwardData.Columns[3].HeaderText = "蓝球";
            dgvAwardData.Columns[4].HeaderText = "销售金额";
            dgvAwardData.Columns[5].HeaderText = "一等奖";
            dgvAwardData.Columns[6].HeaderText = "奖金";
            dgvAwardData.Columns[7].HeaderText = "二等奖";
            dgvAwardData.Columns[8].HeaderText = "奖金";

            /* 不排序 */
            dgvAwardData.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvAwardData.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvAwardData.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvAwardData.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvAwardData.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvAwardData.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvAwardData.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvAwardData.Columns[7].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvAwardData.Columns[8].SortMode = DataGridViewColumnSortMode.NotSortable;

            dgvAwardData.Columns[0].Width = 60;
            dgvAwardData.Columns[1].Width = 70;
            dgvAwardData.Columns[2].Width = 110;
            dgvAwardData.Columns[3].Width = 36;
            dgvAwardData.Columns[4].Width = 62;
            dgvAwardData.Columns[5].Width = 50;
            dgvAwardData.Columns[6].Width = 58;
            dgvAwardData.Columns[7].Width = 50;
            dgvAwardData.Columns[8].Width = 58;

            dgvAwardData.RowHeadersWidth = 25;
            dgvAwardData.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            dgvAwardData.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            for (int i = 0; i < dgvAwardData.Rows.Count; i++)
            {
                dgvAwardData.Rows[i].Height = 19;
                dgvAwardData.Rows[i].Resizable = DataGridViewTriState.False;
                
            }



        }

        private void DgvRangeDataGridInit()
        {
            dgvRangeData.DataSource = SystemCommon.GetRangeDataTable();

            /* 相关属性设置 */
            dgvRangeData.Columns[0].HeaderText = "彩票期号";
            dgvRangeData.Columns[1].HeaderText = "开奖结果";
            dgvRangeData.Columns[2].HeaderText = "最近五期";
            dgvRangeData.Columns[3].HeaderText = "01-03";
            dgvRangeData.Columns[4].HeaderText = "中奖号码";
            dgvRangeData.Columns[5].HeaderText = "中奖数";
            dgvRangeData.Columns[6].HeaderText = "04-07";
            dgvRangeData.Columns[7].HeaderText = "中奖号码";
            dgvRangeData.Columns[8].HeaderText = "中奖数";
            dgvRangeData.Columns[9].HeaderText = "08-12";
            dgvRangeData.Columns[10].HeaderText = "中奖号码";
            dgvRangeData.Columns[11].HeaderText = "中奖数";
            dgvRangeData.Columns[12].HeaderText = "13-20";
            dgvRangeData.Columns[13].HeaderText = "中奖号码";
            dgvRangeData.Columns[14].HeaderText = "中奖数";
            dgvRangeData.Columns[15].HeaderText = "21-33";
            dgvRangeData.Columns[16].HeaderText = "中奖号码";
            dgvRangeData.Columns[17].HeaderText = "中奖数";

            /* 不排序 */
            dgvRangeData.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvRangeData.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvRangeData.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvRangeData.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvRangeData.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvRangeData.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvRangeData.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvRangeData.Columns[7].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvRangeData.Columns[8].SortMode = DataGridViewColumnSortMode.NotSortable;

            dgvRangeData.Columns[0].Width = 60;
            dgvRangeData.Columns[1].Width = 70;
            dgvRangeData.Columns[2].Width = 210;
            dgvRangeData.Columns[3].Width = 36;
            dgvRangeData.Columns[4].Width = 62;
            dgvRangeData.Columns[5].Width = 50;
            dgvRangeData.Columns[6].Width = 58;
            dgvRangeData.Columns[7].Width = 50;
            dgvRangeData.Columns[8].Width = 58;

            dgvRangeData.RowHeadersWidth = 25;
            dgvRangeData.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            dgvRangeData.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            for (int i = 0; i < dgvRangeData.Rows.Count; i++)
            {
                dgvRangeData.Rows[i].Height = 19;
                dgvRangeData.Rows[i].Resizable = DataGridViewTriState.False;

            }



        }

        private void TextControlInit1(int row)
        {
            row = row < 0 ? 0 : row;

            txtLotteryNum.Text = dgvAwardData.Rows[row].Cells[0].Value.ToString().Trim();
            txtAwardData.Text = dgvAwardData.Rows[row].Cells[2].Value.ToString().Trim();
            txtBlueData.Text = dgvAwardData.Rows[row].Cells[3].Value.ToString().Trim();
            txtFirstAward.Text = dgvAwardData.Rows[row].Cells[6].Value.ToString().Trim();
            txtSecondAward.Text = dgvAwardData.Rows[row].Cells[8].Value.ToString().Trim();
        }

        private void TextControlInit2(int row)
        {
            row = row < 0 ? 0 : row;
            txtLotteryNumber.Text = dgvRangeData.Rows[row].Cells[0].Value.ToString().Trim();
            txtRedData.Text = dgvRangeData.Rows[row].Cells[1].Value.ToString().Trim();
            txtLastFiveData.Text = dgvRangeData.Rows[row].Cells[2].Value.ToString().Trim();
            txtRange1.Text = dgvRangeData.Rows[row].Cells[3].Value.ToString().Trim();
            txtRange1.Text = dgvRangeData.Rows[row].Cells[3].Value.ToString().Trim();
            txtRange2.Text = dgvRangeData.Rows[row].Cells[6].Value.ToString().Trim();
            txtRange3.Text = dgvRangeData.Rows[row].Cells[9].Value.ToString().Trim();
            txtRange4.Text = dgvRangeData.Rows[row].Cells[12].Value.ToString().Trim();
            txtRange5.Text = dgvRangeData.Rows[row].Cells[15].Value.ToString().Trim();
        }

        private void dgvAwardData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            TextControlInit1(row);
        }

        private void dgvAwardData_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            TextControlInit1(row);
        }

        private void FrmLotteryData_Resize(object sender, EventArgs e)
        {
            tabLotteryData.Height = this.Height - 80;
            tabLotteryData.Width = this.Width - 30;

            dgvAwardData.Height = tabLotteryData.Height - 240;
            dgvAwardData.Width = tabLotteryData.Width - 40;
            //dgvAwardData.ScrollBars = ScrollBars.Both;
        }

        private void dgvRangeData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            TextControlInit2(row);

        }

        private void dgvRangeData_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            TextControlInit2(row);
        }
    }
}
