namespace Lottery
{
    partial class FrmLotteryData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLotteryData = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAwardData = new System.Windows.Forms.TabPage();
            this.tabLastFiveData = new System.Windows.Forms.TabPage();
            this.pnlLotteryData.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLotteryData
            // 
            this.pnlLotteryData.Controls.Add(this.tabControl1);
            this.pnlLotteryData.Location = new System.Drawing.Point(12, 12);
            this.pnlLotteryData.Name = "pnlLotteryData";
            this.pnlLotteryData.Size = new System.Drawing.Size(592, 430);
            this.pnlLotteryData.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAwardData);
            this.tabControl1.Controls.Add(this.tabLastFiveData);
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(516, 383);
            this.tabControl1.TabIndex = 0;
            // 
            // tabAwardData
            // 
            this.tabAwardData.Location = new System.Drawing.Point(4, 21);
            this.tabAwardData.Name = "tabAwardData";
            this.tabAwardData.Padding = new System.Windows.Forms.Padding(3);
            this.tabAwardData.Size = new System.Drawing.Size(508, 358);
            this.tabAwardData.TabIndex = 0;
            this.tabAwardData.Text = "彩票期号与开奖";
            this.tabAwardData.UseVisualStyleBackColor = true;
            // 
            // tabLastFiveData
            // 
            this.tabLastFiveData.Location = new System.Drawing.Point(4, 21);
            this.tabLastFiveData.Name = "tabLastFiveData";
            this.tabLastFiveData.Padding = new System.Windows.Forms.Padding(3);
            this.tabLastFiveData.Size = new System.Drawing.Size(547, 379);
            this.tabLastFiveData.TabIndex = 1;
            this.tabLastFiveData.Text = "最近五期数据统计";
            this.tabLastFiveData.UseVisualStyleBackColor = true;
            // 
            // FrmLotteryData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 454);
            this.Controls.Add(this.pnlLotteryData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmLotteryData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "彩票数据维护";
            this.pnlLotteryData.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLotteryData;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAwardData;
        private System.Windows.Forms.TabPage tabLastFiveData;
    }
}