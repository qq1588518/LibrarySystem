namespace 图书馆管理系统
{
    partial class frmUpdateBookID
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateBookID));
            this.tbBookIdMemo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDamage = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btAClose = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.tbBookID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbISBN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // tbBookIdMemo
            // 
            this.tbBookIdMemo.Location = new System.Drawing.Point(303, 107);
            this.tbBookIdMemo.Name = "tbBookIdMemo";
            this.tbBookIdMemo.Size = new System.Drawing.Size(121, 21);
            this.tbBookIdMemo.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 59;
            this.label3.Text = "备注";
            // 
            // cbDamage
            // 
            this.cbDamage.FormattingEnabled = true;
            this.cbDamage.Items.AddRange(new object[] {
            "正常",
            "一级",
            "二级",
            "三级"});
            this.cbDamage.Location = new System.Drawing.Point(125, 107);
            this.cbDamage.Name = "cbDamage";
            this.cbDamage.Size = new System.Drawing.Size(121, 20);
            this.cbDamage.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 57;
            this.label4.Text = "损坏程度";
            // 
            // btAClose
            // 
            this.btAClose.Location = new System.Drawing.Point(263, 205);
            this.btAClose.Name = "btAClose";
            this.btAClose.Size = new System.Drawing.Size(75, 23);
            this.btAClose.TabIndex = 55;
            this.btAClose.Text = "返回";
            this.btAClose.UseVisualStyleBackColor = true;
            this.btAClose.Click += new System.EventHandler(this.btAClose_Click);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(160, 205);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 54;
            this.btOk.Text = "保存";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // tbBookID
            // 
            this.tbBookID.Enabled = false;
            this.tbBookID.Location = new System.Drawing.Point(125, 58);
            this.tbBookID.Name = "tbBookID";
            this.tbBookID.Size = new System.Drawing.Size(121, 21);
            this.tbBookID.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 52;
            this.label2.Text = "图书编号";
            // 
            // tbISBN
            // 
            this.tbISBN.Enabled = false;
            this.tbISBN.Location = new System.Drawing.Point(303, 58);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.Size = new System.Drawing.Size(121, 21);
            this.tbISBN.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 50;
            this.label1.Text = "ISBN";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(13, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 157);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(13, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 52);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作";
            // 
            // frmUpdateBookID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 262);
            this.Controls.Add(this.tbBookIdMemo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbDamage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btAClose);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.tbBookID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbISBN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmUpdateBookID";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "编号入库(修改)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBookIdMemo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDamage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btAClose;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.TextBox tbBookID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbISBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;


    }
}