using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Lottery;

namespace Lottery
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuDataAwardUpdate_Click(object sender, EventArgs e)
        {
            SystemCommon.UpdateAwardData();
        }

        private void mnuDataLotteryUpdate_Click(object sender, EventArgs e)
        {
            SystemCommon.UpdateLotteryData();
        }

        private void mnuDataGraphStatisLastFive_Click(object sender, EventArgs e)
        {
            SystemCommon.StatisticLastFiveData();
        }

        private void mnuDataGraphRange_Click(object sender, EventArgs e)
        {
            SystemCommon.StatisticRangeData();
        }

        private void tbarData_Click(object sender, EventArgs e)
        {
            FrmLotteryData frmLotterData = new FrmLotteryData();
            frmLotterData.MdiParent = this.MdiParent;
            frmLotterData.Show();
        }

        private void menuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbarTest_Click(object sender, EventArgs e)
        {
            FrmTestProgress frm = new FrmTestProgress();
            frm.MdiParent = this.MdiParent;
            frm.ShowDialog();
        }

        
    }
}
