namespace 图书馆管理系统
{
    partial class frmSetUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetUp));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSetUpApp = new System.Windows.Forms.Button();
            this.btnSetUpClose = new System.Windows.Forms.Button();
            this.btnSetUpOK = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudBookNum = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cbReadMaxLevel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbReadLevel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudReadDateNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnFineApp = new System.Windows.Forms.Button();
            this.btnFineClose = new System.Windows.Forms.Button();
            this.btnFineOk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbFineLost = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbFineBook = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbFineDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBookNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReadDateNum)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbFineLost)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(434, 362);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.btnSetUpApp);
            this.tabPage1.Controls.Add(this.btnSetUpClose);
            this.tabPage1.Controls.Add(this.btnSetUpOK);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(426, 336);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本设置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button7);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(8, 236);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(410, 57);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "添加读者级别";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(253, 20);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(95, 23);
            this.button7.TabIndex = 15;
            this.button7.Text = "添加读者级别";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "自定义多个读者级别,便于借阅。";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(8, 167);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(410, 57);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "添加图书级别";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(253, 20);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(95, 23);
            this.button6.TabIndex = 15;
            this.button6.Text = "添加图书级别";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(179, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "自定义多个图书级别,便于借阅。";
            // 
            // btnSetUpApp
            // 
            this.btnSetUpApp.Location = new System.Drawing.Point(342, 305);
            this.btnSetUpApp.Name = "btnSetUpApp";
            this.btnSetUpApp.Size = new System.Drawing.Size(75, 23);
            this.btnSetUpApp.TabIndex = 7;
            this.btnSetUpApp.Text = "应用";
            this.btnSetUpApp.UseVisualStyleBackColor = true;
            this.btnSetUpApp.Click += new System.EventHandler(this.btnSetUpApp_Click);
            // 
            // btnSetUpClose
            // 
            this.btnSetUpClose.Location = new System.Drawing.Point(260, 305);
            this.btnSetUpClose.Name = "btnSetUpClose";
            this.btnSetUpClose.Size = new System.Drawing.Size(75, 23);
            this.btnSetUpClose.TabIndex = 6;
            this.btnSetUpClose.Text = "取消";
            this.btnSetUpClose.UseVisualStyleBackColor = true;
            this.btnSetUpClose.Click += new System.EventHandler(this.btnSetUpClose_Click);
            // 
            // btnSetUpOK
            // 
            this.btnSetUpOK.Location = new System.Drawing.Point(177, 305);
            this.btnSetUpOK.Name = "btnSetUpOK";
            this.btnSetUpOK.Size = new System.Drawing.Size(75, 23);
            this.btnSetUpOK.TabIndex = 5;
            this.btnSetUpOK.Text = "确定";
            this.btnSetUpOK.UseVisualStyleBackColor = true;
            this.btnSetUpOK.Click += new System.EventHandler(this.btnSetUpOK_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.nudBookNum);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.cbReadMaxLevel);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.cbReadLevel);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.nudReadDateNum);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(8, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(410, 146);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "级别设置";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(326, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 12);
            this.label9.TabIndex = 13;
            this.label9.Text = "/本";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "/级";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(326, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "/天";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "/级";
            // 
            // nudBookNum
            // 
            this.nudBookNum.Location = new System.Drawing.Point(202, 108);
            this.nudBookNum.Name = "nudBookNum";
            this.nudBookNum.Size = new System.Drawing.Size(120, 21);
            this.nudBookNum.TabIndex = 9;
            this.nudBookNum.ValueChanged += new System.EventHandler(this.nudBookNum_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "可借本数：";
            // 
            // cbReadMaxLevel
            // 
            this.cbReadMaxLevel.FormattingEnabled = true;
            this.cbReadMaxLevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbReadMaxLevel.Location = new System.Drawing.Point(202, 79);
            this.cbReadMaxLevel.Name = "cbReadMaxLevel";
            this.cbReadMaxLevel.Size = new System.Drawing.Size(120, 20);
            this.cbReadMaxLevel.TabIndex = 7;
            this.cbReadMaxLevel.DropDown += new System.EventHandler(this.cbReadMaxLevel_DropDown);
            this.cbReadMaxLevel.SelectedIndexChanged += new System.EventHandler(this.cbReadMaxLevel_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "可借最高等级：";
            // 
            // cbReadLevel
            // 
            this.cbReadLevel.FormattingEnabled = true;
            this.cbReadLevel.Location = new System.Drawing.Point(202, 21);
            this.cbReadLevel.Name = "cbReadLevel";
            this.cbReadLevel.Size = new System.Drawing.Size(120, 20);
            this.cbReadLevel.TabIndex = 5;
            this.cbReadLevel.DropDown += new System.EventHandler(this.cbReadLevel_DropDown);
            this.cbReadLevel.SelectedIndexChanged += new System.EventHandler(this.cbReadLevel_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "读者级别：";
            // 
            // nudReadDateNum
            // 
            this.nudReadDateNum.Location = new System.Drawing.Point(202, 49);
            this.nudReadDateNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudReadDateNum.Name = "nudReadDateNum";
            this.nudReadDateNum.Size = new System.Drawing.Size(120, 21);
            this.nudReadDateNum.TabIndex = 3;
            this.nudReadDateNum.ValueChanged += new System.EventHandler(this.nudReadDateNum_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "可借天数：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnFineApp);
            this.tabPage2.Controls.Add(this.btnFineClose);
            this.tabPage2.Controls.Add(this.btnFineOk);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(426, 336);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "罚款设置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnFineApp
            // 
            this.btnFineApp.Location = new System.Drawing.Point(342, 305);
            this.btnFineApp.Name = "btnFineApp";
            this.btnFineApp.Size = new System.Drawing.Size(75, 23);
            this.btnFineApp.TabIndex = 8;
            this.btnFineApp.Text = "应用";
            this.btnFineApp.UseVisualStyleBackColor = true;
            this.btnFineApp.Click += new System.EventHandler(this.btnFineApp_Click);
            // 
            // btnFineClose
            // 
            this.btnFineClose.Location = new System.Drawing.Point(260, 305);
            this.btnFineClose.Name = "btnFineClose";
            this.btnFineClose.Size = new System.Drawing.Size(75, 23);
            this.btnFineClose.TabIndex = 4;
            this.btnFineClose.Text = "取消";
            this.btnFineClose.UseVisualStyleBackColor = true;
            this.btnFineClose.Click += new System.EventHandler(this.btnFineClose_Click);
            // 
            // btnFineOk
            // 
            this.btnFineOk.Location = new System.Drawing.Point(177, 305);
            this.btnFineOk.Name = "btnFineOk";
            this.btnFineOk.Size = new System.Drawing.Size(75, 23);
            this.btnFineOk.TabIndex = 3;
            this.btnFineOk.Text = "确定";
            this.btnFineOk.UseVisualStyleBackColor = true;
            this.btnFineOk.Click += new System.EventHandler(this.btnFineOk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbFineLost);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.tbFineBook);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.tbFineDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 273);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "罚款单价";
            // 
            // tbFineLost
            // 
            this.tbFineLost.Location = new System.Drawing.Point(188, 114);
            this.tbFineLost.Name = "tbFineLost";
            this.tbFineLost.Size = new System.Drawing.Size(120, 21);
            this.tbFineLost.TabIndex = 10;
            this.tbFineLost.ValueChanged += new System.EventHandler(this.tbFineLost_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(314, 118);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 12);
            this.label15.TabIndex = 8;
            this.label15.Text = "(倍/本)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(57, 118);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 6;
            this.label16.Text = "丢失罚款：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(314, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 12);
            this.label13.TabIndex = 5;
            this.label13.Text = "(元/级)";
            // 
            // tbFineBook
            // 
            this.tbFineBook.Location = new System.Drawing.Point(188, 83);
            this.tbFineBook.Name = "tbFineBook";
            this.tbFineBook.Size = new System.Drawing.Size(120, 21);
            this.tbFineBook.TabIndex = 4;
            this.tbFineBook.TextChanged += new System.EventHandler(this.tbFineBook_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(57, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 3;
            this.label14.Text = "损坏罚款：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(314, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 12);
            this.label12.TabIndex = 2;
            this.label12.Text = "(元/天)";
            // 
            // tbFineDate
            // 
            this.tbFineDate.Location = new System.Drawing.Point(188, 48);
            this.tbFineDate.Name = "tbFineDate";
            this.tbFineDate.Size = new System.Drawing.Size(120, 21);
            this.tbFineDate.TabIndex = 1;
            this.tbFineDate.TextChanged += new System.EventHandler(this.tbFineDate_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "还书每逾期一天罚款：";
            // 
            // frmSetUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 362);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSetUp";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "设置";
            this.Load += new System.EventHandler(this.frmSetUp_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBookNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReadDateNum)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbFineLost)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbFineDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown nudReadDateNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSetUpApp;
        private System.Windows.Forms.Button btnSetUpClose;
        private System.Windows.Forms.Button btnSetUpOK;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudBookNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbReadMaxLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbReadLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnFineClose;
        private System.Windows.Forms.Button btnFineOk;
        private System.Windows.Forms.Button btnFineApp;
        private System.Windows.Forms.NumericUpDown tbFineLost;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbFineBook;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
    }
}