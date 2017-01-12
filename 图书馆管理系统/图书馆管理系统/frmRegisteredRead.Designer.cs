namespace 图书馆管理系统
{
    partial class frmRegisteredRead
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisteredRead));
            this.lbUserId = new System.Windows.Forms.Label();
            this.tbReadId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPassWord = new System.Windows.Forms.TextBox();
            this.lbPassWordOK = new System.Windows.Forms.Label();
            this.tbPassWordOK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbReadLevel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.tbClass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbIDNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btOK = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.lbTsPassWord = new System.Windows.Forms.Label();
            this.lbTsId = new System.Windows.Forms.Label();
            this.tbMemo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpRegistration = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lbUserId
            // 
            this.lbUserId.AutoSize = true;
            this.lbUserId.Location = new System.Drawing.Point(23, 29);
            this.lbUserId.Name = "lbUserId";
            this.lbUserId.Size = new System.Drawing.Size(59, 12);
            this.lbUserId.TabIndex = 0;
            this.lbUserId.Text = "学号/工号";
            // 
            // tbReadId
            // 
            this.tbReadId.Location = new System.Drawing.Point(88, 25);
            this.tbReadId.MaxLength = 9;
            this.tbReadId.Name = "tbReadId";
            this.tbReadId.Size = new System.Drawing.Size(121, 21);
            this.tbReadId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "密码";
            // 
            // tbPassWord
            // 
            this.tbPassWord.Location = new System.Drawing.Point(88, 68);
            this.tbPassWord.MaxLength = 6;
            this.tbPassWord.Name = "tbPassWord";
            this.tbPassWord.PasswordChar = '*';
            this.tbPassWord.Size = new System.Drawing.Size(121, 21);
            this.tbPassWord.TabIndex = 3;
            // 
            // lbPassWordOK
            // 
            this.lbPassWordOK.AutoSize = true;
            this.lbPassWordOK.Location = new System.Drawing.Point(234, 72);
            this.lbPassWordOK.Name = "lbPassWordOK";
            this.lbPassWordOK.Size = new System.Drawing.Size(53, 12);
            this.lbPassWordOK.TabIndex = 4;
            this.lbPassWordOK.Text = "确认密码";
            // 
            // tbPassWordOK
            // 
            this.tbPassWordOK.Location = new System.Drawing.Point(298, 68);
            this.tbPassWordOK.MaxLength = 6;
            this.tbPassWordOK.Name = "tbPassWordOK";
            this.tbPassWordOK.PasswordChar = '*';
            this.tbPassWordOK.Size = new System.Drawing.Size(121, 21);
            this.tbPassWordOK.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "读者级别";
            // 
            // cbReadLevel
            // 
            this.cbReadLevel.FormattingEnabled = true;
            this.cbReadLevel.Items.AddRange(new object[] {
            "三级",
            "二级",
            "一级"});
            this.cbReadLevel.Location = new System.Drawing.Point(298, 25);
            this.cbReadLevel.Name = "cbReadLevel";
            this.cbReadLevel.Size = new System.Drawing.Size(121, 20);
            this.cbReadLevel.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "姓名";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(88, 111);
            this.tbName.MaxLength = 10;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(121, 21);
            this.tbName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "系别";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "性别";
            // 
            // cbSex
            // 
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbSex.Location = new System.Drawing.Point(298, 111);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(121, 20);
            this.cbSex.TabIndex = 6;
            // 
            // tbClass
            // 
            this.tbClass.Location = new System.Drawing.Point(298, 154);
            this.tbClass.MaxLength = 10;
            this.tbClass.Name = "tbClass";
            this.tbClass.Size = new System.Drawing.Size(121, 21);
            this.tbClass.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(258, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "班级";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(88, 197);
            this.tbPhone.MaxLength = 11;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(121, 21);
            this.tbPhone.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "联系电话";
            // 
            // tbIDNumber
            // 
            this.tbIDNumber.Location = new System.Drawing.Point(298, 197);
            this.tbIDNumber.MaxLength = 18;
            this.tbIDNumber.Name = "tbIDNumber";
            this.tbIDNumber.Size = new System.Drawing.Size(121, 21);
            this.tbIDNumber.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(234, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "身份证号";
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(138, 327);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 11;
            this.btOK.Text = "注册";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(236, 327);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 12;
            this.btClose.Text = "取消";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // cbDepartment
            // 
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Items.AddRange(new object[] {
            "材料工程系",
            "管理工程系",
            "机电工程系",
            "建筑工程系",
            "计算机科学系",
            "人文科学系",
            "信息工程系",
            "艺术系"});
            this.cbDepartment.Location = new System.Drawing.Point(88, 154);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(121, 20);
            this.cbDepartment.TabIndex = 7;
            // 
            // lbTsPassWord
            // 
            this.lbTsPassWord.AutoSize = true;
            this.lbTsPassWord.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTsPassWord.ForeColor = System.Drawing.Color.Red;
            this.lbTsPassWord.Location = new System.Drawing.Point(298, 93);
            this.lbTsPassWord.Name = "lbTsPassWord";
            this.lbTsPassWord.Size = new System.Drawing.Size(105, 10);
            this.lbTsPassWord.TabIndex = 19;
            this.lbTsPassWord.Text = "提示：两次密码不相同";
            this.lbTsPassWord.Visible = false;
            // 
            // lbTsId
            // 
            this.lbTsId.AutoSize = true;
            this.lbTsId.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTsId.ForeColor = System.Drawing.Color.Red;
            this.lbTsId.Location = new System.Drawing.Point(86, 49);
            this.lbTsId.Name = "lbTsId";
            this.lbTsId.Size = new System.Drawing.Size(125, 10);
            this.lbTsId.TabIndex = 20;
            this.lbTsId.Text = "提示：该学号或工号已存在";
            this.lbTsId.Visible = false;
            // 
            // tbMemo
            // 
            this.tbMemo.Location = new System.Drawing.Point(89, 234);
            this.tbMemo.MaxLength = 18;
            this.tbMemo.Multiline = true;
            this.tbMemo.Name = "tbMemo";
            this.tbMemo.Size = new System.Drawing.Size(330, 45);
            this.tbMemo.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 24;
            this.label2.Text = "备注";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 23;
            this.label10.Text = "登记日期";
            this.label10.Visible = false;
            // 
            // dtpRegistration
            // 
            this.dtpRegistration.Location = new System.Drawing.Point(89, 239);
            this.dtpRegistration.Name = "dtpRegistration";
            this.dtpRegistration.Size = new System.Drawing.Size(120, 21);
            this.dtpRegistration.TabIndex = 25;
            this.dtpRegistration.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 292);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 56);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作";
            // 
            // frmRegisteredRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 376);
            this.Controls.Add(this.dtpRegistration);
            this.Controls.Add(this.tbMemo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbTsId);
            this.Controls.Add(this.lbTsPassWord);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.tbIDNumber);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbClass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbReadLevel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPassWordOK);
            this.Controls.Add(this.lbPassWordOK);
            this.Controls.Add(this.tbPassWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbReadId);
            this.Controls.Add(this.lbUserId);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRegisteredRead";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUserId;
        private System.Windows.Forms.TextBox tbReadId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPassWord;
        private System.Windows.Forms.Label lbPassWordOK;
        private System.Windows.Forms.TextBox tbPassWordOK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbReadLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.TextBox tbClass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbIDNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label lbTsPassWord;
        private System.Windows.Forms.Label lbTsId;
        private System.Windows.Forms.TextBox tbMemo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpRegistration;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}