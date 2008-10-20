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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuData = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataAwardUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataLotteryUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataLotteryRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataHistoryUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataGraph = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataGraphStatisLastFive = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataGraphRange = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbarLotteryDataMaintenance = new System.Windows.Forms.ToolStripButton();
            this.mnuMain.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.mnuData,
            this.mnuDataGraph});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(593, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "mnuMain";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(41, 20);
            this.menuFile.Text = "文件";
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.Size = new System.Drawing.Size(152, 22);
            this.menuFileExit.Text = "退出";
            this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
            // 
            // mnuData
            // 
            this.mnuData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDataAwardUpdate,
            this.mnuDataLotteryUpdate,
            this.mnuDataLotteryRefresh,
            this.mnuDataHistoryUpdate});
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
            // mnuDataGraph
            // 
            this.mnuDataGraph.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDataGraphStatisLastFive,
            this.mnuDataGraphRange});
            this.mnuDataGraph.Name = "mnuDataGraph";
            this.mnuDataGraph.Size = new System.Drawing.Size(65, 20);
            this.mnuDataGraph.Text = "数据图表";
            // 
            // mnuDataGraphStatisLastFive
            // 
            this.mnuDataGraphStatisLastFive.Name = "mnuDataGraphStatisLastFive";
            this.mnuDataGraphStatisLastFive.Size = new System.Drawing.Size(142, 22);
            this.mnuDataGraphStatisLastFive.Text = "统计最近五期";
            this.mnuDataGraphStatisLastFive.Click += new System.EventHandler(this.mnuDataGraphStatisLastFive_Click);
            // 
            // mnuDataGraphRange
            // 
            this.mnuDataGraphRange.Name = "mnuDataGraphRange";
            this.mnuDataGraphRange.Size = new System.Drawing.Size(142, 22);
            this.mnuDataGraphRange.Text = "红球数据分区";
            this.mnuDataGraphRange.Click += new System.EventHandler(this.mnuDataGraphRange_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbarLotteryDataMaintenance});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(593, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbarLotteryDataMaintenance
            // 
            this.tbarLotteryDataMaintenance.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbarLotteryDataMaintenance.Image = ((System.Drawing.Image)(resources.GetObject("tbarLotteryDataMaintenance.Image")));
            this.tbarLotteryDataMaintenance.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbarLotteryDataMaintenance.Name = "tbarLotteryDataMaintenance";
            this.tbarLotteryDataMaintenance.Size = new System.Drawing.Size(23, 22);
            this.tbarLotteryDataMaintenance.Text = "数据维护";
            this.tbarLotteryDataMaintenance.Click += new System.EventHandler(this.tbarData_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 348);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mnuMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMain";
            this.Text = "双色球";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbarLotteryDataMaintenance;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuDataGraph;
        private System.Windows.Forms.ToolStripMenuItem mnuDataGraphStatisLastFive;
        private System.Windows.Forms.ToolStripMenuItem mnuDataGraphRange;
    }
}

