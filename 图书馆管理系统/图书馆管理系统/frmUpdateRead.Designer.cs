namespace 图书馆管理系统
{
    partial class frmUpdateRead
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateRead));
            this.cbbReadDepartment = new System.Windows.Forms.ComboBox();
            this.dtpReadRegister = new System.Windows.Forms.DateTimePicker();
            this.btnAddReadClose = new System.Windows.Forms.Button();
            this.btnAddReadOK = new System.Windows.Forms.Button();
            this.cbbReadSex = new System.Windows.Forms.ComboBox();
            this.tbReadName = new System.Windows.Forms.TextBox();
            this.tbReadId = new System.Windows.Forms.TextBox();
            this.cbbReadPost = new System.Windows.Forms.ComboBox();
            this.lbReadRegisterDate = new System.Windows.Forms.Label();
            this.tbReadNumberId = new System.Windows.Forms.TextBox();
            this.lbReadNumberId = new System.Windows.Forms.Label();
            this.tbReadPhone = new System.Windows.Forms.TextBox();
            this.lbReadPhone = new System.Windows.Forms.Label();
            this.tbReadClass = new System.Windows.Forms.TextBox();
            this.lbReadClass = new System.Windows.Forms.Label();
            this.lbReadDepartment = new System.Windows.Forms.Label();
            this.lbReadName = new System.Windows.Forms.Label();
            this.lbReadsex = new System.Windows.Forms.Label();
            this.lbReadPost = new System.Windows.Forms.Label();
            this.lbReadId = new System.Windows.Forms.Label();
            this.tbReadMark = new System.Windows.Forms.TextBox();
            this.lbBookMark = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPassWord = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // cbbReadDepartment
            // 
            this.cbbReadDepartment.FormattingEnabled = true;
            this.cbbReadDepartment.Items.AddRange(new object[] {
            "材料工程系",
            "管理工程系",
            "机电工程系",
            "建筑工程系",
            "计算机科学系",
            "人文科学系",
            "信息工程系",
            "艺术系"});
            this.cbbReadDepartment.Location = new System.Drawing.Point(122, 149);
            this.cbbReadDepartment.Name = "cbbReadDepartment";
            this.cbbReadDepartment.Size = new System.Drawing.Size(132, 20);
            this.cbbReadDepartment.TabIndex = 28;
            // 
            // dtpReadRegister
            // 
            this.dtpReadRegister.Location = new System.Drawing.Point(122, 256);
            this.dtpReadRegister.Name = "dtpReadRegister";
            this.dtpReadRegister.Size = new System.Drawing.Size(131, 21);
            this.dtpReadRegister.TabIndex = 34;
            // 
            // btnAddReadClose
            // 
            this.btnAddReadClose.Location = new System.Drawing.Point(308, 417);
            this.btnAddReadClose.Name = "btnAddReadClose";
            this.btnAddReadClose.Size = new System.Drawing.Size(75, 22);
            this.btnAddReadClose.TabIndex = 38;
            this.btnAddReadClose.Text = "取消";
            this.btnAddReadClose.UseVisualStyleBackColor = true;
            this.btnAddReadClose.Click += new System.EventHandler(this.btnAddReadClose_Click);
            // 
            // btnAddReadOK
            // 
            this.btnAddReadOK.Location = new System.Drawing.Point(185, 417);
            this.btnAddReadOK.Name = "btnAddReadOK";
            this.btnAddReadOK.Size = new System.Drawing.Size(75, 22);
            this.btnAddReadOK.TabIndex = 37;
            this.btnAddReadOK.Text = "保存";
            this.btnAddReadOK.UseVisualStyleBackColor = true;
            this.btnAddReadOK.Click += new System.EventHandler(this.btnAddReadOK_Click);
            // 
            // cbbReadSex
            // 
            this.cbbReadSex.FormattingEnabled = true;
            this.cbbReadSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbbReadSex.Location = new System.Drawing.Point(390, 95);
            this.cbbReadSex.Name = "cbbReadSex";
            this.cbbReadSex.Size = new System.Drawing.Size(132, 20);
            this.cbbReadSex.TabIndex = 27;
            // 
            // tbReadName
            // 
            this.tbReadName.Location = new System.Drawing.Point(122, 95);
            this.tbReadName.Name = "tbReadName";
            this.tbReadName.Size = new System.Drawing.Size(132, 21);
            this.tbReadName.TabIndex = 25;
            // 
            // tbReadId
            // 
            this.tbReadId.Enabled = false;
            this.tbReadId.Location = new System.Drawing.Point(122, 41);
            this.tbReadId.Name = "tbReadId";
            this.tbReadId.Size = new System.Drawing.Size(132, 21);
            this.tbReadId.TabIndex = 22;
            // 
            // cbbReadPost
            // 
            this.cbbReadPost.FormattingEnabled = true;
            this.cbbReadPost.Items.AddRange(new object[] {
            "三级",
            "二级",
            "一级"});
            this.cbbReadPost.Location = new System.Drawing.Point(390, 41);
            this.cbbReadPost.Name = "cbbReadPost";
            this.cbbReadPost.Size = new System.Drawing.Size(132, 20);
            this.cbbReadPost.TabIndex = 23;
            // 
            // lbReadRegisterDate
            // 
            this.lbReadRegisterDate.AutoSize = true;
            this.lbReadRegisterDate.Location = new System.Drawing.Point(53, 260);
            this.lbReadRegisterDate.Name = "lbReadRegisterDate";
            this.lbReadRegisterDate.Size = new System.Drawing.Size(53, 12);
            this.lbReadRegisterDate.TabIndex = 41;
            this.lbReadRegisterDate.Text = "登记日期";
            // 
            // tbReadNumberId
            // 
            this.tbReadNumberId.Location = new System.Drawing.Point(390, 202);
            this.tbReadNumberId.Name = "tbReadNumberId";
            this.tbReadNumberId.Size = new System.Drawing.Size(132, 21);
            this.tbReadNumberId.TabIndex = 33;
            // 
            // lbReadNumberId
            // 
            this.lbReadNumberId.AutoSize = true;
            this.lbReadNumberId.Location = new System.Drawing.Point(322, 206);
            this.lbReadNumberId.Name = "lbReadNumberId";
            this.lbReadNumberId.Size = new System.Drawing.Size(53, 12);
            this.lbReadNumberId.TabIndex = 40;
            this.lbReadNumberId.Text = "身份证号";
            // 
            // tbReadPhone
            // 
            this.tbReadPhone.Location = new System.Drawing.Point(122, 202);
            this.tbReadPhone.Name = "tbReadPhone";
            this.tbReadPhone.Size = new System.Drawing.Size(132, 21);
            this.tbReadPhone.TabIndex = 31;
            // 
            // lbReadPhone
            // 
            this.lbReadPhone.AutoSize = true;
            this.lbReadPhone.Location = new System.Drawing.Point(53, 206);
            this.lbReadPhone.Name = "lbReadPhone";
            this.lbReadPhone.Size = new System.Drawing.Size(53, 12);
            this.lbReadPhone.TabIndex = 39;
            this.lbReadPhone.Text = "联系电话";
            // 
            // tbReadClass
            // 
            this.tbReadClass.Location = new System.Drawing.Point(390, 149);
            this.tbReadClass.Name = "tbReadClass";
            this.tbReadClass.Size = new System.Drawing.Size(132, 21);
            this.tbReadClass.TabIndex = 29;
            // 
            // lbReadClass
            // 
            this.lbReadClass.AutoSize = true;
            this.lbReadClass.Location = new System.Drawing.Point(346, 153);
            this.lbReadClass.Name = "lbReadClass";
            this.lbReadClass.Size = new System.Drawing.Size(29, 12);
            this.lbReadClass.TabIndex = 35;
            this.lbReadClass.Text = "班级";
            // 
            // lbReadDepartment
            // 
            this.lbReadDepartment.AutoSize = true;
            this.lbReadDepartment.Location = new System.Drawing.Point(77, 153);
            this.lbReadDepartment.Name = "lbReadDepartment";
            this.lbReadDepartment.Size = new System.Drawing.Size(29, 12);
            this.lbReadDepartment.TabIndex = 32;
            this.lbReadDepartment.Text = "系别";
            // 
            // lbReadName
            // 
            this.lbReadName.AutoSize = true;
            this.lbReadName.Location = new System.Drawing.Point(77, 99);
            this.lbReadName.Name = "lbReadName";
            this.lbReadName.Size = new System.Drawing.Size(29, 12);
            this.lbReadName.TabIndex = 30;
            this.lbReadName.Text = "姓名";
            // 
            // lbReadsex
            // 
            this.lbReadsex.AutoSize = true;
            this.lbReadsex.Location = new System.Drawing.Point(346, 99);
            this.lbReadsex.Name = "lbReadsex";
            this.lbReadsex.Size = new System.Drawing.Size(29, 12);
            this.lbReadsex.TabIndex = 26;
            this.lbReadsex.Text = "性别";
            // 
            // lbReadPost
            // 
            this.lbReadPost.AutoSize = true;
            this.lbReadPost.Location = new System.Drawing.Point(346, 45);
            this.lbReadPost.Name = "lbReadPost";
            this.lbReadPost.Size = new System.Drawing.Size(29, 12);
            this.lbReadPost.TabIndex = 24;
            this.lbReadPost.Text = "职务";
            // 
            // lbReadId
            // 
            this.lbReadId.AutoSize = true;
            this.lbReadId.Location = new System.Drawing.Point(47, 45);
            this.lbReadId.Name = "lbReadId";
            this.lbReadId.Size = new System.Drawing.Size(59, 12);
            this.lbReadId.TabIndex = 21;
            this.lbReadId.Text = "学号/工号";
            // 
            // tbReadMark
            // 
            this.tbReadMark.Location = new System.Drawing.Point(122, 314);
            this.tbReadMark.Multiline = true;
            this.tbReadMark.Name = "tbReadMark";
            this.tbReadMark.Size = new System.Drawing.Size(400, 55);
            this.tbReadMark.TabIndex = 55;
            // 
            // lbBookMark
            // 
            this.lbBookMark.AutoSize = true;
            this.lbBookMark.Location = new System.Drawing.Point(77, 335);
            this.lbBookMark.Name = "lbBookMark";
            this.lbBookMark.Size = new System.Drawing.Size(29, 12);
            this.lbBookMark.TabIndex = 56;
            this.lbBookMark.Text = "备注";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(122, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 10);
            this.label3.TabIndex = 57;
            this.label3.Text = "提示:学号/工号是唯一的,不能修改";
            // 
            // tbPassWord
            // 
            this.tbPassWord.Location = new System.Drawing.Point(390, 256);
            this.tbPassWord.MaxLength = 6;
            this.tbPassWord.Name = "tbPassWord";
            this.tbPassWord.PasswordChar = '*';
            this.tbPassWord.Size = new System.Drawing.Size(132, 21);
            this.tbPassWord.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(346, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 58;
            this.label9.Text = "密码";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 378);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(13, 398);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 52);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作";
            // 
            // frmUpdateRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.tbPassWord);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbReadMark);
            this.Controls.Add(this.lbBookMark);
            this.Controls.Add(this.cbbReadDepartment);
            this.Controls.Add(this.dtpReadRegister);
            this.Controls.Add(this.btnAddReadClose);
            this.Controls.Add(this.btnAddReadOK);
            this.Controls.Add(this.cbbReadSex);
            this.Controls.Add(this.tbReadName);
            this.Controls.Add(this.tbReadId);
            this.Controls.Add(this.cbbReadPost);
            this.Controls.Add(this.lbReadRegisterDate);
            this.Controls.Add(this.tbReadNumberId);
            this.Controls.Add(this.lbReadNumberId);
            this.Controls.Add(this.tbReadPhone);
            this.Controls.Add(this.lbReadPhone);
            this.Controls.Add(this.tbReadClass);
            this.Controls.Add(this.lbReadClass);
            this.Controls.Add(this.lbReadDepartment);
            this.Controls.Add(this.lbReadName);
            this.Controls.Add(this.lbReadsex);
            this.Controls.Add(this.lbReadPost);
            this.Controls.Add(this.lbReadId);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmUpdateRead";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "读者管理(修改)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbReadDepartment;
        private System.Windows.Forms.DateTimePicker dtpReadRegister;
        private System.Windows.Forms.Button btnAddReadClose;
        private System.Windows.Forms.Button btnAddReadOK;
        private System.Windows.Forms.ComboBox cbbReadSex;
        private System.Windows.Forms.TextBox tbReadName;
        private System.Windows.Forms.TextBox tbReadId;
        private System.Windows.Forms.ComboBox cbbReadPost;
        private System.Windows.Forms.Label lbReadRegisterDate;
        private System.Windows.Forms.TextBox tbReadNumberId;
        private System.Windows.Forms.Label lbReadNumberId;
        private System.Windows.Forms.TextBox tbReadPhone;
        private System.Windows.Forms.Label lbReadPhone;
        private System.Windows.Forms.TextBox tbReadClass;
        private System.Windows.Forms.Label lbReadClass;
        private System.Windows.Forms.Label lbReadDepartment;
        private System.Windows.Forms.Label lbReadName;
        private System.Windows.Forms.Label lbReadsex;
        private System.Windows.Forms.Label lbReadPost;
        private System.Windows.Forms.Label lbReadId;
        private System.Windows.Forms.TextBox tbReadMark;
        private System.Windows.Forms.Label lbBookMark;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPassWord;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}