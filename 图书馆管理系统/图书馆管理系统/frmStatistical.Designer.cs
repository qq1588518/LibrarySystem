namespace 图书馆管理系统
{
    partial class frmStatistical
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("统计");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("按图书名称");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("按图书编号");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("按图书类别");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("按图书出版社");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("按绵职院系别");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("借阅统计", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("按图书状态");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("按读者状态");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("状态统计", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("购置图书数量统计");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("借书人数统计");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatistical));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chartSum = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.treeViewtStatistical = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.返回ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNum = new System.Windows.Forms.Label();
            this.nudRankNum = new System.Windows.Forms.NumericUpDown();
            this.btnStatistical = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbStatistical = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSum)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRankNum)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chartSum);
            this.groupBox1.Location = new System.Drawing.Point(163, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(809, 503);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "统计结果";
            // 
            // chartSum
            // 
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.chartSum.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSum.Legends.Add(legend1);
            this.chartSum.Location = new System.Drawing.Point(6, 20);
            this.chartSum.Name = "chartSum";
            this.chartSum.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Red;
            series1.MarkerBorderWidth = 5;
            series1.MarkerColor = System.Drawing.Color.Red;
            series1.MarkerImageTransparentColor = System.Drawing.Color.Black;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star5;
            series1.Name = "SeriesBook";
            this.chartSum.Series.Add(series1);
            this.chartSum.Size = new System.Drawing.Size(797, 477);
            this.chartSum.TabIndex = 0;
            this.chartSum.Text = "chartSum";
            // 
            // treeViewtStatistical
            // 
            this.treeViewtStatistical.Location = new System.Drawing.Point(9, 28);
            this.treeViewtStatistical.Name = "treeViewtStatistical";
            treeNode1.Name = "节点9";
            treeNode1.Text = "统计";
            treeNode2.Name = "节点3";
            treeNode2.Text = "按图书名称";
            treeNode3.Name = "节点5";
            treeNode3.Text = "按图书编号";
            treeNode4.Name = "节点6";
            treeNode4.Text = "按图书类别";
            treeNode5.Name = "节点7";
            treeNode5.Text = "按图书出版社";
            treeNode6.Name = "节点8";
            treeNode6.Text = "按绵职院系别";
            treeNode7.Name = "节点0";
            treeNode7.Text = "借阅统计";
            treeNode8.Name = "节点0";
            treeNode8.Text = "按图书状态";
            treeNode9.Name = "节点5";
            treeNode9.Text = "按读者状态";
            treeNode10.Name = "节点1";
            treeNode10.Text = "状态统计";
            treeNode11.Name = "节点11";
            treeNode11.Text = "购置图书数量统计";
            treeNode12.Name = "节点10";
            treeNode12.Text = "借书人数统计";
            this.treeViewtStatistical.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode7,
            treeNode10,
            treeNode11,
            treeNode12});
            this.treeViewtStatistical.Size = new System.Drawing.Size(145, 572);
            this.treeViewtStatistical.TabIndex = 3;
            this.treeViewtStatistical.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewtStatistical_AfterSelect);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.返回ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 返回ToolStripMenuItem
            // 
            this.返回ToolStripMenuItem.Name = "返回ToolStripMenuItem";
            this.返回ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.返回ToolStripMenuItem.Text = "退出";
            this.返回ToolStripMenuItem.Click += new System.EventHandler(this.返回ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "统计方式：";
            // 
            // lbNum
            // 
            this.lbNum.AutoSize = true;
            this.lbNum.Location = new System.Drawing.Point(155, 5);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(65, 12);
            this.lbNum.TabIndex = 1;
            this.lbNum.Text = "排名位数：";
            // 
            // nudRankNum
            // 
            this.nudRankNum.Location = new System.Drawing.Point(155, 20);
            this.nudRankNum.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nudRankNum.Name = "nudRankNum";
            this.nudRankNum.Size = new System.Drawing.Size(121, 21);
            this.nudRankNum.TabIndex = 3;
            this.nudRankNum.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnStatistical
            // 
            this.btnStatistical.Location = new System.Drawing.Point(324, 19);
            this.btnStatistical.Name = "btnStatistical";
            this.btnStatistical.Size = new System.Drawing.Size(75, 23);
            this.btnStatistical.TabIndex = 4;
            this.btnStatistical.Text = "统计";
            this.btnStatistical.UseVisualStyleBackColor = true;
            this.btnStatistical.Click += new System.EventHandler(this.btnStatistical_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(428, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "退出";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbStatistical
            // 
            this.tbStatistical.Location = new System.Drawing.Point(4, 19);
            this.tbStatistical.Name = "tbStatistical";
            this.tbStatistical.Size = new System.Drawing.Size(119, 21);
            this.tbStatistical.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbStatistical);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnStatistical);
            this.panel1.Controls.Add(this.nudRankNum);
            this.panel1.Controls.Add(this.lbNum);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(163, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 49);
            this.panel1.TabIndex = 2;
            // 
            // frmStatistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 612);
            this.Controls.Add(this.treeViewtStatistical);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmStatistical";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "统计";
            this.Load += new System.EventHandler(this.frmSearchMain_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartSum)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRankNum)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSum;
        private System.Windows.Forms.TreeView treeViewtStatistical;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 返回ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNum;
        private System.Windows.Forms.NumericUpDown nudRankNum;
        private System.Windows.Forms.Button btnStatistical;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbStatistical;
        private System.Windows.Forms.Panel panel1;
    }
}