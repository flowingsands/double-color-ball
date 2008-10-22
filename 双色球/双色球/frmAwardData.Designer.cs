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
            this.labAddSign = new System.Windows.Forms.Label();
            this.txtBlueData = new System.Windows.Forms.TextBox();
            this.txtSecondAward = new System.Windows.Forms.TextBox();
            this.tabLotteryData = new System.Windows.Forms.TabControl();
            this.tabAwardData = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstAward = new System.Windows.Forms.TextBox();
            this.labFirstAward = new System.Windows.Forms.Label();
            this.txtAwardData = new System.Windows.Forms.TextBox();
            this.labAwardData = new System.Windows.Forms.Label();
            this.txtLotteryNum = new System.Windows.Forms.TextBox();
            this.labLotterNumber = new System.Windows.Forms.Label();
            this.dgvAwardData = new System.Windows.Forms.DataGridView();
            this.tabLastFiveData = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.labLotteryNumber = new System.Windows.Forms.Label();
            this.txtRange5 = new System.Windows.Forms.TextBox();
            this.txtRange4 = new System.Windows.Forms.TextBox();
            this.txtRange3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRange2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRedData = new System.Windows.Forms.TextBox();
            this.txtLotteryNumber = new System.Windows.Forms.TextBox();
            this.txtRange1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastFiveData = new System.Windows.Forms.TextBox();
            this.labRange2 = new System.Windows.Forms.Label();
            this.labRange1 = new System.Windows.Forms.Label();
            this.labLastFiveData = new System.Windows.Forms.Label();
            this.dgvRangeData = new System.Windows.Forms.DataGridView();
            this.tabLotteryData.SuspendLayout();
            this.tabAwardData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAwardData)).BeginInit();
            this.tabLastFiveData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRangeData)).BeginInit();
            this.SuspendLayout();
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
            // tabLotteryData
            // 
            this.tabLotteryData.Controls.Add(this.tabAwardData);
            this.tabLotteryData.Controls.Add(this.tabLastFiveData);
            this.tabLotteryData.Location = new System.Drawing.Point(12, 12);
            this.tabLotteryData.Name = "tabLotteryData";
            this.tabLotteryData.SelectedIndex = 0;
            this.tabLotteryData.Size = new System.Drawing.Size(602, 402);
            this.tabLotteryData.TabIndex = 1;
            // 
            // tabAwardData
            // 
            this.tabAwardData.BackColor = System.Drawing.SystemColors.Control;
            this.tabAwardData.Controls.Add(this.labAddSign);
            this.tabAwardData.Controls.Add(this.txtBlueData);
            this.tabAwardData.Controls.Add(this.txtSecondAward);
            this.tabAwardData.Controls.Add(this.label2);
            this.tabAwardData.Controls.Add(this.txtFirstAward);
            this.tabAwardData.Controls.Add(this.labFirstAward);
            this.tabAwardData.Controls.Add(this.txtAwardData);
            this.tabAwardData.Controls.Add(this.labAwardData);
            this.tabAwardData.Controls.Add(this.txtLotteryNum);
            this.tabAwardData.Controls.Add(this.labLotterNumber);
            this.tabAwardData.Controls.Add(this.dgvAwardData);
            this.tabAwardData.Location = new System.Drawing.Point(4, 21);
            this.tabAwardData.Name = "tabAwardData";
            this.tabAwardData.Padding = new System.Windows.Forms.Padding(3);
            this.tabAwardData.Size = new System.Drawing.Size(594, 377);
            this.tabAwardData.TabIndex = 0;
            this.tabAwardData.Text = "彩票期号与开奖";
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
            this.dgvAwardData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAwardData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAwardData.Location = new System.Drawing.Point(-1, 129);
            this.dgvAwardData.Margin = new System.Windows.Forms.Padding(12);
            this.dgvAwardData.Name = "dgvAwardData";
            this.dgvAwardData.RowTemplate.Height = 23;
            this.dgvAwardData.Size = new System.Drawing.Size(590, 248);
            this.dgvAwardData.TabIndex = 0;
            this.dgvAwardData.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAwardData_RowHeaderMouseClick);
            this.dgvAwardData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAwardData_CellContentClick);
            // 
            // tabLastFiveData
            // 
            this.tabLastFiveData.BackColor = System.Drawing.SystemColors.Control;
            this.tabLastFiveData.Controls.Add(this.label5);
            this.tabLastFiveData.Controls.Add(this.labLotteryNumber);
            this.tabLastFiveData.Controls.Add(this.txtRange5);
            this.tabLastFiveData.Controls.Add(this.txtRange4);
            this.tabLastFiveData.Controls.Add(this.txtRange3);
            this.tabLastFiveData.Controls.Add(this.label4);
            this.tabLastFiveData.Controls.Add(this.txtRange2);
            this.tabLastFiveData.Controls.Add(this.label3);
            this.tabLastFiveData.Controls.Add(this.txtRedData);
            this.tabLastFiveData.Controls.Add(this.txtLotteryNumber);
            this.tabLastFiveData.Controls.Add(this.txtRange1);
            this.tabLastFiveData.Controls.Add(this.label1);
            this.tabLastFiveData.Controls.Add(this.txtLastFiveData);
            this.tabLastFiveData.Controls.Add(this.labRange2);
            this.tabLastFiveData.Controls.Add(this.labRange1);
            this.tabLastFiveData.Controls.Add(this.labLastFiveData);
            this.tabLastFiveData.Controls.Add(this.dgvRangeData);
            this.tabLastFiveData.Location = new System.Drawing.Point(4, 21);
            this.tabLastFiveData.Name = "tabLastFiveData";
            this.tabLastFiveData.Padding = new System.Windows.Forms.Padding(3);
            this.tabLastFiveData.Size = new System.Drawing.Size(594, 377);
            this.tabLastFiveData.TabIndex = 1;
            this.tabLastFiveData.Text = "最近五期数据统计";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "开奖结果：";
            // 
            // labLotteryNumber
            // 
            this.labLotteryNumber.AutoSize = true;
            this.labLotteryNumber.Location = new System.Drawing.Point(7, 45);
            this.labLotteryNumber.Name = "labLotteryNumber";
            this.labLotteryNumber.Size = new System.Drawing.Size(65, 12);
            this.labLotteryNumber.TabIndex = 5;
            this.labLotteryNumber.Text = "彩票期号：";
            // 
            // txtRange5
            // 
            this.txtRange5.Location = new System.Drawing.Point(245, 140);
            this.txtRange5.Name = "txtRange5";
            this.txtRange5.Size = new System.Drawing.Size(193, 21);
            this.txtRange5.TabIndex = 4;
            // 
            // txtRange4
            // 
            this.txtRange4.Location = new System.Drawing.Point(245, 115);
            this.txtRange4.Name = "txtRange4";
            this.txtRange4.Size = new System.Drawing.Size(193, 21);
            this.txtRange4.TabIndex = 4;
            // 
            // txtRange3
            // 
            this.txtRange3.Location = new System.Drawing.Point(245, 90);
            this.txtRange3.Name = "txtRange3";
            this.txtRange3.Size = new System.Drawing.Size(100, 21);
            this.txtRange3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "21-33：";
            // 
            // txtRange2
            // 
            this.txtRange2.Location = new System.Drawing.Point(245, 65);
            this.txtRange2.Name = "txtRange2";
            this.txtRange2.Size = new System.Drawing.Size(100, 21);
            this.txtRange2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "13-20：";
            // 
            // txtRedData
            // 
            this.txtRedData.Location = new System.Drawing.Point(72, 65);
            this.txtRedData.Name = "txtRedData";
            this.txtRedData.Size = new System.Drawing.Size(121, 21);
            this.txtRedData.TabIndex = 4;
            // 
            // txtLotteryNumber
            // 
            this.txtLotteryNumber.Location = new System.Drawing.Point(72, 40);
            this.txtLotteryNumber.Name = "txtLotteryNumber";
            this.txtLotteryNumber.Size = new System.Drawing.Size(121, 21);
            this.txtLotteryNumber.TabIndex = 4;
            // 
            // txtRange1
            // 
            this.txtRange1.Location = new System.Drawing.Point(245, 40);
            this.txtRange1.Name = "txtRange1";
            this.txtRange1.Size = new System.Drawing.Size(100, 21);
            this.txtRange1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "08-12：";
            // 
            // txtLastFiveData
            // 
            this.txtLastFiveData.Location = new System.Drawing.Point(72, 13);
            this.txtLastFiveData.Name = "txtLastFiveData";
            this.txtLastFiveData.Size = new System.Drawing.Size(501, 21);
            this.txtLastFiveData.TabIndex = 4;
            // 
            // labRange2
            // 
            this.labRange2.AutoSize = true;
            this.labRange2.Location = new System.Drawing.Point(199, 68);
            this.labRange2.Name = "labRange2";
            this.labRange2.Size = new System.Drawing.Size(47, 12);
            this.labRange2.TabIndex = 3;
            this.labRange2.Text = "04-07：";
            // 
            // labRange1
            // 
            this.labRange1.AutoSize = true;
            this.labRange1.Location = new System.Drawing.Point(199, 43);
            this.labRange1.Name = "labRange1";
            this.labRange1.Size = new System.Drawing.Size(47, 12);
            this.labRange1.TabIndex = 2;
            this.labRange1.Text = "01-03：";
            // 
            // labLastFiveData
            // 
            this.labLastFiveData.AutoSize = true;
            this.labLastFiveData.Location = new System.Drawing.Point(8, 18);
            this.labLastFiveData.Name = "labLastFiveData";
            this.labLastFiveData.Size = new System.Drawing.Size(65, 12);
            this.labLastFiveData.TabIndex = 1;
            this.labLastFiveData.Text = "最近五期：";
            // 
            // dgvRangeData
            // 
            this.dgvRangeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRangeData.Location = new System.Drawing.Point(3, 168);
            this.dgvRangeData.Name = "dgvRangeData";
            this.dgvRangeData.RowTemplate.Height = 23;
            this.dgvRangeData.Size = new System.Drawing.Size(585, 206);
            this.dgvRangeData.TabIndex = 0;
            this.dgvRangeData.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRangeData_RowHeaderMouseClick);
            this.dgvRangeData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRangeData_CellContentClick);
            // 
            // FrmLotteryData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 458);
            this.Controls.Add(this.tabLotteryData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmLotteryData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "彩票数据维护";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmLotteryData_Load);
            this.Resize += new System.EventHandler(this.FrmLotteryData_Resize);
            this.tabLotteryData.ResumeLayout(false);
            this.tabAwardData.ResumeLayout(false);
            this.tabAwardData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAwardData)).EndInit();
            this.tabLastFiveData.ResumeLayout(false);
            this.tabLastFiveData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRangeData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labAddSign;
        private System.Windows.Forms.TextBox txtBlueData;
        private System.Windows.Forms.TextBox txtSecondAward;
        private System.Windows.Forms.TabControl tabLotteryData;
        private System.Windows.Forms.TabPage tabAwardData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstAward;
        private System.Windows.Forms.Label labFirstAward;
        private System.Windows.Forms.TextBox txtAwardData;
        private System.Windows.Forms.Label labAwardData;
        private System.Windows.Forms.TextBox txtLotteryNum;
        private System.Windows.Forms.Label labLotterNumber;
        private System.Windows.Forms.DataGridView dgvAwardData;
        private System.Windows.Forms.TabPage tabLastFiveData;
        private System.Windows.Forms.DataGridView dgvRangeData;
        private System.Windows.Forms.Label labRange1;
        private System.Windows.Forms.Label labLastFiveData;
        private System.Windows.Forms.Label labRange2;
        private System.Windows.Forms.TextBox txtLastFiveData;
        private System.Windows.Forms.TextBox txtRange2;
        private System.Windows.Forms.TextBox txtRange1;
        private System.Windows.Forms.TextBox txtRange3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRange4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRange5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labLotteryNumber;
        private System.Windows.Forms.TextBox txtLotteryNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRedData;


    }
}