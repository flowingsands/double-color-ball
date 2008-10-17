namespace Lottery
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuData = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataAwardUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataLotteryUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataLotteryRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataHistoryUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataOnlineUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuData});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(593, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "mnuMain";
            // 
            // mnuData
            // 
            this.mnuData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDataAwardUpdate,
            this.mnuDataLotteryUpdate,
            this.mnuDataLotteryRefresh,
            this.mnuDataHistoryUpdate,
            this.mnuDataOnlineUpdate});
            this.mnuData.Name = "mnuData";
            this.mnuData.Size = new System.Drawing.Size(65, 20);
            this.mnuData.Text = "数据更新";
            // 
            // mnuDataAwardUpdate
            // 
            this.mnuDataAwardUpdate.Name = "mnuDataAwardUpdate";
            this.mnuDataAwardUpdate.Size = new System.Drawing.Size(142, 22);
            this.mnuDataAwardUpdate.Text = "开奖数据下载";
            this.mnuDataAwardUpdate.Click += new System.EventHandler(this.mnuDataAwardUpdate_Click);
            // 
            // mnuDataLotteryUpdate
            // 
            this.mnuDataLotteryUpdate.Name = "mnuDataLotteryUpdate";
            this.mnuDataLotteryUpdate.Size = new System.Drawing.Size(142, 22);
            this.mnuDataLotteryUpdate.Text = "彩票期号下载";
            this.mnuDataLotteryUpdate.Click += new System.EventHandler(this.mnuDataLotteryUpdate_Click);
            // 
            // mnuDataLotteryRefresh
            // 
            this.mnuDataLotteryRefresh.Name = "mnuDataLotteryRefresh";
            this.mnuDataLotteryRefresh.Size = new System.Drawing.Size(142, 22);
            this.mnuDataLotteryRefresh.Text = "刷新彩票期号";
            // 
            // mnuDataHistoryUpdate
            // 
            this.mnuDataHistoryUpdate.Name = "mnuDataHistoryUpdate";
            this.mnuDataHistoryUpdate.Size = new System.Drawing.Size(142, 22);
            this.mnuDataHistoryUpdate.Text = "历史数据更新";
            // 
            // mnuDataOnlineUpdate
            // 
            this.mnuDataOnlineUpdate.Name = "mnuDataOnlineUpdate";
            this.mnuDataOnlineUpdate.Size = new System.Drawing.Size(142, 22);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 348);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMain";
            this.Text = "双色球";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuData;
        private System.Windows.Forms.ToolStripMenuItem mnuDataAwardUpdate;
        private System.Windows.Forms.ToolStripMenuItem mnuDataLotteryUpdate;
        private System.Windows.Forms.ToolStripMenuItem mnuDataLotteryRefresh;
        private System.Windows.Forms.ToolStripMenuItem mnuDataHistoryUpdate;
        private System.Windows.Forms.ToolStripMenuItem mnuDataOnlineUpdate;
    }
}

