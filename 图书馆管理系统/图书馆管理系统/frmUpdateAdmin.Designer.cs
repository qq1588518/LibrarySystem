namespace 图书馆管理系统
{
    partial class frmUpdateAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateAdmin));
            this.rbSuperAdmin = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.cbDisable = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.tbAdminPassWordOK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPassWord = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAdminID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbSuperAdmin
            // 
            this.rbSuperAdmin.AutoSize = true;
            this.rbSuperAdmin.Location = new System.Drawing.Point(120, 47);
            this.rbSuperAdmin.Name = "rbSuperAdmin";
            this.rbSuperAdmin.Size = new System.Drawing.Size(83, 16);
            this.rbSuperAdmin.TabIndex = 49;
            this.rbSuperAdmin.TabStop = true;
            this.rbSuperAdmin.Text = "超级管理员";
            this.rbSuperAdmin.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(334, 114);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 59;
            this.btnClose.Text = "返回";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(334, 80);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 51;
            this.btnOk.Text = "保存";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cbDisable
            // 
            this.cbDisable.AutoSize = true;
            this.cbDisable.Location = new System.Drawing.Point(335, 53);
            this.cbDisable.Name = "cbDisable";
            this.cbDisable.Size = new System.Drawing.Size(72, 16);
            this.cbDisable.TabIndex = 60;
            this.cbDisable.Text = "是否停用";
            this.cbDisable.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAdmin);
            this.groupBox1.Controls.Add(this.tbAdminPassWordOK);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbPassWord);
            this.groupBox1.Controls.Add(this.rbSuperAdmin);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbAdminID);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 140);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户信息";
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Location = new System.Drawing.Point(209, 47);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(83, 16);
            this.rbAdmin.TabIndex = 66;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "普通管理员";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // tbAdminPassWordOK
            // 
            this.tbAdminPassWordOK.Location = new System.Drawing.Point(120, 104);
            this.tbAdminPassWordOK.MaxLength = 6;
            this.tbAdminPassWordOK.Name = "tbAdminPassWordOK";
            this.tbAdminPassWordOK.PasswordChar = '*';
            this.tbAdminPassWordOK.Size = new System.Drawing.Size(121, 21);
            this.tbAdminPassWordOK.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 69;
            this.label1.Text = "重复密码";
            // 
            // tbPassWord
            // 
            this.tbPassWord.Location = new System.Drawing.Point(120, 71);
            this.tbPassWord.MaxLength = 6;
            this.tbPassWord.Name = "tbPassWord";
            this.tbPassWord.PasswordChar = '*';
            this.tbPassWord.Size = new System.Drawing.Size(121, 21);
            this.tbPassWord.TabIndex = 68;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 67;
            this.label9.Text = "用户密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 66;
            this.label2.Text = "学号/工号";
            // 
            // tbAdminID
            // 
            this.tbAdminID.Enabled = false;
            this.tbAdminID.Location = new System.Drawing.Point(120, 20);
            this.tbAdminID.Name = "tbAdminID";
            this.tbAdminID.Size = new System.Drawing.Size(121, 21);
            this.tbAdminID.TabIndex = 65;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(319, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(103, 140);
            this.groupBox2.TabIndex = 66;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作";
            // 
            // frmUpdateAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 162);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbDisable);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmUpdateAdmin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改管理员";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbSuperAdmin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.CheckBox cbDisable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbAdminPassWordOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPassWord;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAdminID;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}