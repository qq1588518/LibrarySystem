namespace 图书馆管理系统
{
    partial class frmUpdateBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateBook));
            this.cbBookGrade = new System.Windows.Forms.ComboBox();
            this.dtpPDate = new System.Windows.Forms.DateTimePicker();
            this.lbRDate = new System.Windows.Forms.Label();
            this.btnUpdateBookClose = new System.Windows.Forms.Button();
            this.tbSortExplanation = new System.Windows.Forms.TextBox();
            this.cbSortId = new System.Windows.Forms.ComboBox();
            this.btnUpdateBookOK = new System.Windows.Forms.Button();
            this.tbRQuantity = new System.Windows.Forms.TextBox();
            this.lbRQuantity = new System.Windows.Forms.Label();
            this.lbBookGrade = new System.Windows.Forms.Label();
            this.lbPDate = new System.Windows.Forms.Label();
            this.tbBookMark = new System.Windows.Forms.TextBox();
            this.lbBookMark = new System.Windows.Forms.Label();
            this.tbBookPrice = new System.Windows.Forms.TextBox();
            this.lbBookPrice = new System.Windows.Forms.Label();
            this.tbBookPress = new System.Windows.Forms.TextBox();
            this.lbBookPress = new System.Windows.Forms.Label();
            this.tbBookAuthor = new System.Windows.Forms.TextBox();
            this.lbBookAuthor = new System.Windows.Forms.Label();
            this.lbBookISBN = new System.Windows.Forms.Label();
            this.tbBookName = new System.Windows.Forms.TextBox();
            this.lbSortExplanation = new System.Windows.Forms.Label();
            this.lbBookName = new System.Windows.Forms.Label();
            this.lbSortId = new System.Windows.Forms.Label();
            this.dtpPutDate = new System.Windows.Forms.DateTimePicker();
            this.tbBookISBN = new System.Windows.Forms.TextBox();
            this.tbBookPage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTsSortId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // cbBookGrade
            // 
            this.cbBookGrade.FormattingEnabled = true;
            this.cbBookGrade.Items.AddRange(new object[] {
            "一级",
            "二级",
            "三级"});
            this.cbBookGrade.Location = new System.Drawing.Point(107, 238);
            this.cbBookGrade.Name = "cbBookGrade";
            this.cbBookGrade.Size = new System.Drawing.Size(132, 20);
            this.cbBookGrade.TabIndex = 10;
            // 
            // dtpPDate
            // 
            this.dtpPDate.Location = new System.Drawing.Point(392, 194);
            this.dtpPDate.Name = "dtpPDate";
            this.dtpPDate.Size = new System.Drawing.Size(135, 21);
            this.dtpPDate.TabIndex = 9;
            // 
            // lbRDate
            // 
            this.lbRDate.AutoSize = true;
            this.lbRDate.Location = new System.Drawing.Point(47, 285);
            this.lbRDate.Name = "lbRDate";
            this.lbRDate.Size = new System.Drawing.Size(53, 12);
            this.lbRDate.TabIndex = 58;
            this.lbRDate.Text = "入库日期";
            // 
            // btnUpdateBookClose
            // 
            this.btnUpdateBookClose.Location = new System.Drawing.Point(317, 420);
            this.btnUpdateBookClose.Name = "btnUpdateBookClose";
            this.btnUpdateBookClose.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateBookClose.TabIndex = 15;
            this.btnUpdateBookClose.Text = "取消";
            this.btnUpdateBookClose.UseVisualStyleBackColor = true;
            this.btnUpdateBookClose.Click += new System.EventHandler(this.btnUpdateBookClose_Click);
            // 
            // tbSortExplanation
            // 
            this.tbSortExplanation.Enabled = false;
            this.tbSortExplanation.Location = new System.Drawing.Point(392, 63);
            this.tbSortExplanation.Name = "tbSortExplanation";
            this.tbSortExplanation.Size = new System.Drawing.Size(135, 21);
            this.tbSortExplanation.TabIndex = 3;
            // 
            // cbSortId
            // 
            this.cbSortId.FormattingEnabled = true;
            this.cbSortId.Location = new System.Drawing.Point(107, 63);
            this.cbSortId.Name = "cbSortId";
            this.cbSortId.Size = new System.Drawing.Size(132, 20);
            this.cbSortId.TabIndex = 2;
            this.cbSortId.DropDown += new System.EventHandler(this.cbSortId_DropDown);
            this.cbSortId.SelectedIndexChanged += new System.EventHandler(this.cbSortId_SelectedIndexChanged);
            // 
            // btnUpdateBookOK
            // 
            this.btnUpdateBookOK.Location = new System.Drawing.Point(194, 420);
            this.btnUpdateBookOK.Name = "btnUpdateBookOK";
            this.btnUpdateBookOK.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateBookOK.TabIndex = 14;
            this.btnUpdateBookOK.Text = "保存";
            this.btnUpdateBookOK.UseVisualStyleBackColor = true;
            this.btnUpdateBookOK.Click += new System.EventHandler(this.btnUpdateBookOK_Click);
            // 
            // tbRQuantity
            // 
            this.tbRQuantity.Location = new System.Drawing.Point(392, 238);
            this.tbRQuantity.Name = "tbRQuantity";
            this.tbRQuantity.Size = new System.Drawing.Size(135, 21);
            this.tbRQuantity.TabIndex = 11;
            // 
            // lbRQuantity
            // 
            this.lbRQuantity.AutoSize = true;
            this.lbRQuantity.Location = new System.Drawing.Point(333, 242);
            this.lbRQuantity.Name = "lbRQuantity";
            this.lbRQuantity.Size = new System.Drawing.Size(53, 12);
            this.lbRQuantity.TabIndex = 57;
            this.lbRQuantity.Text = "入库数量";
            // 
            // lbBookGrade
            // 
            this.lbBookGrade.AutoSize = true;
            this.lbBookGrade.Location = new System.Drawing.Point(47, 242);
            this.lbBookGrade.Name = "lbBookGrade";
            this.lbBookGrade.Size = new System.Drawing.Size(53, 12);
            this.lbBookGrade.TabIndex = 56;
            this.lbBookGrade.Text = "可借等级";
            // 
            // lbPDate
            // 
            this.lbPDate.AutoSize = true;
            this.lbPDate.Location = new System.Drawing.Point(333, 198);
            this.lbPDate.Name = "lbPDate";
            this.lbPDate.Size = new System.Drawing.Size(53, 12);
            this.lbPDate.TabIndex = 55;
            this.lbPDate.Text = "出版日期";
            // 
            // tbBookMark
            // 
            this.tbBookMark.Location = new System.Drawing.Point(107, 325);
            this.tbBookMark.Multiline = true;
            this.tbBookMark.Name = "tbBookMark";
            this.tbBookMark.Size = new System.Drawing.Size(420, 55);
            this.tbBookMark.TabIndex = 13;
            // 
            // lbBookMark
            // 
            this.lbBookMark.AutoSize = true;
            this.lbBookMark.Location = new System.Drawing.Point(48, 346);
            this.lbBookMark.Name = "lbBookMark";
            this.lbBookMark.Size = new System.Drawing.Size(53, 12);
            this.lbBookMark.TabIndex = 54;
            this.lbBookMark.Text = "图书简介";
            // 
            // tbBookPrice
            // 
            this.tbBookPrice.Location = new System.Drawing.Point(392, 150);
            this.tbBookPrice.Name = "tbBookPrice";
            this.tbBookPrice.Size = new System.Drawing.Size(135, 21);
            this.tbBookPrice.TabIndex = 7;
            // 
            // lbBookPrice
            // 
            this.lbBookPrice.AutoSize = true;
            this.lbBookPrice.Location = new System.Drawing.Point(357, 154);
            this.lbBookPrice.Name = "lbBookPrice";
            this.lbBookPrice.Size = new System.Drawing.Size(29, 12);
            this.lbBookPrice.TabIndex = 52;
            this.lbBookPrice.Text = "价格";
            // 
            // tbBookPress
            // 
            this.tbBookPress.Location = new System.Drawing.Point(107, 150);
            this.tbBookPress.Name = "tbBookPress";
            this.tbBookPress.Size = new System.Drawing.Size(132, 21);
            this.tbBookPress.TabIndex = 6;
            // 
            // lbBookPress
            // 
            this.lbBookPress.AutoSize = true;
            this.lbBookPress.Location = new System.Drawing.Point(59, 154);
            this.lbBookPress.Name = "lbBookPress";
            this.lbBookPress.Size = new System.Drawing.Size(41, 12);
            this.lbBookPress.TabIndex = 49;
            this.lbBookPress.Text = "出版社";
            // 
            // tbBookAuthor
            // 
            this.tbBookAuthor.Location = new System.Drawing.Point(392, 106);
            this.tbBookAuthor.Name = "tbBookAuthor";
            this.tbBookAuthor.Size = new System.Drawing.Size(135, 21);
            this.tbBookAuthor.TabIndex = 5;
            // 
            // lbBookAuthor
            // 
            this.lbBookAuthor.AutoSize = true;
            this.lbBookAuthor.Location = new System.Drawing.Point(333, 110);
            this.lbBookAuthor.Name = "lbBookAuthor";
            this.lbBookAuthor.Size = new System.Drawing.Size(53, 12);
            this.lbBookAuthor.TabIndex = 45;
            this.lbBookAuthor.Text = "图书作者";
            // 
            // lbBookISBN
            // 
            this.lbBookISBN.AutoSize = true;
            this.lbBookISBN.Location = new System.Drawing.Point(72, 23);
            this.lbBookISBN.Name = "lbBookISBN";
            this.lbBookISBN.Size = new System.Drawing.Size(29, 12);
            this.lbBookISBN.TabIndex = 43;
            this.lbBookISBN.Text = "ISBN";
            // 
            // tbBookName
            // 
            this.tbBookName.Location = new System.Drawing.Point(107, 106);
            this.tbBookName.Name = "tbBookName";
            this.tbBookName.Size = new System.Drawing.Size(132, 21);
            this.tbBookName.TabIndex = 4;
            // 
            // lbSortExplanation
            // 
            this.lbSortExplanation.AutoSize = true;
            this.lbSortExplanation.Location = new System.Drawing.Point(333, 67);
            this.lbSortExplanation.Name = "lbSortExplanation";
            this.lbSortExplanation.Size = new System.Drawing.Size(53, 12);
            this.lbSortExplanation.TabIndex = 39;
            this.lbSortExplanation.Text = "类别说明";
            // 
            // lbBookName
            // 
            this.lbBookName.AutoSize = true;
            this.lbBookName.Location = new System.Drawing.Point(47, 110);
            this.lbBookName.Name = "lbBookName";
            this.lbBookName.Size = new System.Drawing.Size(53, 12);
            this.lbBookName.TabIndex = 37;
            this.lbBookName.Text = "图书名称";
            // 
            // lbSortId
            // 
            this.lbSortId.AutoSize = true;
            this.lbSortId.Location = new System.Drawing.Point(48, 67);
            this.lbSortId.Name = "lbSortId";
            this.lbSortId.Size = new System.Drawing.Size(53, 12);
            this.lbSortId.TabIndex = 34;
            this.lbSortId.Text = "类别编号";
            // 
            // dtpPutDate
            // 
            this.dtpPutDate.Location = new System.Drawing.Point(107, 281);
            this.dtpPutDate.Name = "dtpPutDate";
            this.dtpPutDate.Size = new System.Drawing.Size(132, 21);
            this.dtpPutDate.TabIndex = 12;
            // 
            // tbBookISBN
            // 
            this.tbBookISBN.Enabled = false;
            this.tbBookISBN.Location = new System.Drawing.Point(107, 19);
            this.tbBookISBN.Name = "tbBookISBN";
            this.tbBookISBN.Size = new System.Drawing.Size(230, 21);
            this.tbBookISBN.TabIndex = 1;
            // 
            // tbBookPage
            // 
            this.tbBookPage.Location = new System.Drawing.Point(107, 194);
            this.tbBookPage.Name = "tbBookPage";
            this.tbBookPage.Size = new System.Drawing.Size(132, 21);
            this.tbBookPage.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 64;
            this.label1.Text = "页码";
            // 
            // tbSQuantity
            // 
            this.tbSQuantity.Location = new System.Drawing.Point(392, 281);
            this.tbSQuantity.Name = "tbSQuantity";
            this.tbSQuantity.Size = new System.Drawing.Size(135, 21);
            this.tbSQuantity.TabIndex = 100;
            this.tbSQuantity.Enter += new System.EventHandler(this.tbSQuantity_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 66;
            this.label2.Text = "在馆数量";
            // 
            // lbTsSortId
            // 
            this.lbTsSortId.AutoSize = true;
            this.lbTsSortId.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTsSortId.ForeColor = System.Drawing.Color.Red;
            this.lbTsSortId.Location = new System.Drawing.Point(357, 25);
            this.lbTsSortId.Name = "lbTsSortId";
            this.lbTsSortId.Size = new System.Drawing.Size(135, 10);
            this.lbTsSortId.TabIndex = 67;
            this.lbTsSortId.Text = "提示:ISBN是唯一的,不能修改";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(392, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 10);
            this.label3.TabIndex = 68;
            this.label3.Text = "提示:不建议修改此文本框值";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 392);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(13, 403);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 47);
            this.groupBox2.TabIndex = 102;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作";
            // 
            // frmUpdateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTsSortId);
            this.Controls.Add(this.tbSQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbBookPage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBookISBN);
            this.Controls.Add(this.dtpPutDate);
            this.Controls.Add(this.cbBookGrade);
            this.Controls.Add(this.dtpPDate);
            this.Controls.Add(this.lbRDate);
            this.Controls.Add(this.btnUpdateBookClose);
            this.Controls.Add(this.tbSortExplanation);
            this.Controls.Add(this.cbSortId);
            this.Controls.Add(this.btnUpdateBookOK);
            this.Controls.Add(this.tbRQuantity);
            this.Controls.Add(this.lbRQuantity);
            this.Controls.Add(this.lbBookGrade);
            this.Controls.Add(this.lbPDate);
            this.Controls.Add(this.tbBookMark);
            this.Controls.Add(this.lbBookMark);
            this.Controls.Add(this.tbBookPrice);
            this.Controls.Add(this.lbBookPrice);
            this.Controls.Add(this.tbBookPress);
            this.Controls.Add(this.lbBookPress);
            this.Controls.Add(this.tbBookAuthor);
            this.Controls.Add(this.lbBookAuthor);
            this.Controls.Add(this.lbBookISBN);
            this.Controls.Add(this.tbBookName);
            this.Controls.Add(this.lbSortExplanation);
            this.Controls.Add(this.lbBookName);
            this.Controls.Add(this.lbSortId);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmUpdateBook";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "图书管理(修改)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBookGrade;
        private System.Windows.Forms.DateTimePicker dtpPDate;
        private System.Windows.Forms.Label lbRDate;
        private System.Windows.Forms.Button btnUpdateBookClose;
        private System.Windows.Forms.TextBox tbSortExplanation;
        private System.Windows.Forms.ComboBox cbSortId;
        private System.Windows.Forms.Button btnUpdateBookOK;
        private System.Windows.Forms.TextBox tbRQuantity;
        private System.Windows.Forms.Label lbRQuantity;
        private System.Windows.Forms.Label lbBookGrade;
        private System.Windows.Forms.Label lbPDate;
        private System.Windows.Forms.TextBox tbBookMark;
        private System.Windows.Forms.Label lbBookMark;
        private System.Windows.Forms.TextBox tbBookPrice;
        private System.Windows.Forms.Label lbBookPrice;
        private System.Windows.Forms.TextBox tbBookPress;
        private System.Windows.Forms.Label lbBookPress;
        private System.Windows.Forms.TextBox tbBookAuthor;
        private System.Windows.Forms.Label lbBookAuthor;
        private System.Windows.Forms.Label lbBookISBN;
        private System.Windows.Forms.TextBox tbBookName;
        private System.Windows.Forms.Label lbSortExplanation;
        private System.Windows.Forms.Label lbBookName;
        private System.Windows.Forms.Label lbSortId;
        private System.Windows.Forms.DateTimePicker dtpPutDate;
        private System.Windows.Forms.TextBox tbBookISBN;
        private System.Windows.Forms.TextBox tbBookPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTsSortId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}