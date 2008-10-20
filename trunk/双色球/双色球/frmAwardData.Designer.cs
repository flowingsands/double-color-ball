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
            this.tabLotteryData = new System.Windows.Forms.TabControl();
            this.tabRedData = new System.Windows.Forms.TabPage();
            this.labAddSign = new System.Windows.Forms.Label();
            this.txtBlueData = new System.Windows.Forms.TextBox();
            this.txtSecondAward = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstAward = new System.Windows.Forms.TextBox();
            this.labFirstAward = new System.Windows.Forms.Label();
            this.txtAwardData = new System.Windows.Forms.TextBox();
            this.labAwardData = new System.Windows.Forms.Label();
            this.txtLotteryNum = new System.Windows.Forms.TextBox();
            this.labLotterNumber = new System.Windows.Forms.Label();
            this.dgvAwardData = new System.Windows.Forms.DataGridView();
            this.tabLastFiveData = new System.Windows.Forms.TabPage();
            this.pnlLotteryData.SuspendLayout();
            this.tabLotteryData.SuspendLayout();
            this.tabRedData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAwardData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLotteryData
            // 
            this.pnlLotteryData.Controls.Add(this.tabLotteryData);
            this.pnlLotteryData.Location = new System.Drawing.Point(12, 12);
            this.pnlLotteryData.Name = "pnlLotteryData";
            this.pnlLotteryData.Size = new System.Drawing.Size(603, 435);
            this.pnlLotteryData.TabIndex = 0;
            // 
            // tabLotteryData
            // 
            this.tabLotteryData.Controls.Add(this.tabRedData);
            this.tabLotteryData.Controls.Add(this.tabLastFiveData);
            this.tabLotteryData.Location = new System.Drawing.Point(3, 0);
            this.tabLotteryData.Name = "tabLotteryData";
            this.tabLotteryData.SelectedIndex = 0;
            this.tabLotteryData.Size = new System.Drawing.Size(600, 435);
            this.tabLotteryData.TabIndex = 0;
            // 
            // tabRedData
            // 
            this.tabRedData.BackColor = System.Drawing.SystemColors.Control;
            this.tabRedData.Controls.Add(this.labAddSign);
            this.tabRedData.Controls.Add(this.txtBlueData);
            this.tabRedData.Controls.Add(this.txtSecondAward);
            this.tabRedData.Controls.Add(this.label2);
            this.tabRedData.Controls.Add(this.txtFirstAward);
            this.tabRedData.Controls.Add(this.labFirstAward);
            this.tabRedData.Controls.Add(this.txtAwardData);
            this.tabRedData.Controls.Add(this.labAwardData);
            this.tabRedData.Controls.Add(this.txtLotteryNum);
            this.tabRedData.Controls.Add(this.labLotterNumber);
            this.tabRedData.Controls.Add(this.dgvAwardData);
            this.tabRedData.Location = new System.Drawing.Point(4, 21);
            this.tabRedData.Name = "tabRedData";
            this.tabRedData.Padding = new System.Windows.Forms.Padding(3);
            this.tabRedData.Size = new System.Drawing.Size(592, 410);
            this.tabRedData.TabIndex = 0;
            this.tabRedData.Text = "彩票期号与开奖";
            // 
            // labAddSign
            // 
            this.labAddSign.AutoSize = true;
            this.labAddSign.Location = new System.Drawing.Point(206, 50);
            this.labAddSign.Name = "labAddSign";
            this.labAddSign.Size = new System.Drawing.Size(11, 12);
            this.labAddSign.TabIndex = 5;
            this.labAddSign.Text = "+";
            // 
            // txtBlueData
            // 
            this.txtBlueData.Location = new System.Drawing.Point(222, 45);
            this.txtBlueData.Name = "txtBlueData";
            this.txtBlueData.Size = new System.Drawing.Size(21, 21);
            this.txtBlueData.TabIndex = 4;
            // 
            // txtSecondAward
            // 
            this.txtSecondAward.Location = new System.Drawing.Point(78, 99);
            this.txtSecondAward.Name = "txtSecondAward";
            this.txtSecondAward.Size = new System.Drawing.Size(165, 21);
            this.txtSecondAward.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "二等奖金：";
            // 
            // txtFirstAward
            // 
            this.txtFirstAward.Location = new System.Drawing.Point(78, 72);
            this.txtFirstAward.Name = "txtFirstAward";
            this.txtFirstAward.Size = new System.Drawing.Size(165, 21);
            this.txtFirstAward.TabIndex = 4;
            // 
            // labFirstAward
            // 
            this.labFirstAward.AutoSize = true;
            this.labFirstAward.Location = new System.Drawing.Point(10, 77);
            this.labFirstAward.Name = "labFirstAward";
            this.labFirstAward.Size = new System.Drawing.Size(65, 12);
            this.labFirstAward.TabIndex = 3;
            this.labFirstAward.Text = "一等奖金：";
            // 
            // txtAwardData
            // 
            this.txtAwardData.Location = new System.Drawing.Point(78, 45);
            this.txtAwardData.Name = "txtAwardData";
            this.txtAwardData.Size = new System.Drawing.Size(121, 21);
            this.txtAwardData.TabIndex = 4;
            // 
            // labAwardData
            // 
            this.labAwardData.AutoSize = true;
            this.labAwardData.Location = new System.Drawing.Point(10, 50);
            this.labAwardData.Name = "labAwardData";
            this.labAwardData.Size = new System.Drawing.Size(65, 12);
            this.labAwardData.TabIndex = 3;
            this.labAwardData.Text = "开奖结果：";
            // 
            // txtLotteryNum
            // 
            this.txtLotteryNum.Location = new System.Drawing.Point(78, 18);
            this.txtLotteryNum.Name = "txtLotteryNum";
            this.txtLotteryNum.Size = new System.Drawing.Size(121, 21);
            this.txtLotteryNum.TabIndex = 2;
            // 
            // labLotterNumber
            // 
            this.labLotterNumber.AutoSize = true;
            this.labLotterNumber.Location = new System.Drawing.Point(10, 23);
            this.labLotterNumber.Name = "labLotterNumber";
            this.labLotterNumber.Size = new System.Drawing.Size(65, 12);
            this.labLotterNumber.TabIndex = 1;
            this.labLotterNumber.Text = "彩票期号：";
            // 
            // dgvAwardData
            // 
            this.dgvAwardData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAwardData.Location = new System.Drawing.Point(0, 161);
            this.dgvAwardData.Name = "dgvAwardData";
            this.dgvAwardData.RowTemplate.Height = 23;
            this.dgvAwardData.Size = new System.Drawing.Size(590, 249);
            this.dgvAwardData.TabIndex = 0;
            this.dgvAwardData.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAwardData_RowHeaderMouseClick);
            this.dgvAwardData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAwardData_CellContentClick);
            // 
            // tabLastFiveData
            // 
            this.tabLastFiveData.BackColor = System.Drawing.SystemColors.Control;
            this.tabLastFiveData.Location = new System.Drawing.Point(4, 21);
            this.tabLastFiveData.Name = "tabLastFiveData";
            this.tabLastFiveData.Padding = new System.Windows.Forms.Padding(3);
            this.tabLastFiveData.Size = new System.Drawing.Size(592, 410);
            this.tabLastFiveData.TabIndex = 1;
            this.tabLastFiveData.Text = "最近五期数据统计";
            // 
            // FrmLotteryData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 458);
            this.Controls.Add(this.pnlLotteryData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmLotteryData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "彩票数据维护";
            this.Load += new System.EventHandler(this.FrmLotteryData_Load);
            this.pnlLotteryData.ResumeLayout(false);
            this.tabLotteryData.ResumeLayout(false);
            this.tabRedData.ResumeLayout(false);
            this.tabRedData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAwardData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLotteryData;
        private System.Windows.Forms.TabControl tabLotteryData;
        private System.Windows.Forms.TabPage tabRedData;
        private System.Windows.Forms.TabPage tabLastFiveData;
        private System.Windows.Forms.DataGridView dgvAwardData;
        private System.Windows.Forms.Label labLotterNumber;
        private System.Windows.Forms.TextBox txtLotteryNum;
        private System.Windows.Forms.TextBox txtAwardData;
        private System.Windows.Forms.Label labAwardData;
        private System.Windows.Forms.TextBox txtBlueData;
        private System.Windows.Forms.Label labAddSign;
        private System.Windows.Forms.TextBox txtFirstAward;
        private System.Windows.Forms.Label labFirstAward;
        private System.Windows.Forms.TextBox txtSecondAward;
        private System.Windows.Forms.Label label2;
    }
}