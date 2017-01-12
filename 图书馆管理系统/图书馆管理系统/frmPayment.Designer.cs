namespace 图书馆管理系统
{
    partial class frmPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment));
            this.label1 = new System.Windows.Forms.Label();
            this.tbPaymentReadName = new System.Windows.Forms.TextBox();
            this.tbPaymentReadId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPaymentBookId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPaymentBookName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPaymentMemo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPaymentSum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // tbPaymentReadName
            // 
            this.tbPaymentReadName.Location = new System.Drawing.Point(309, 36);
            this.tbPaymentReadName.Name = "tbPaymentReadName";
            this.tbPaymentReadName.ReadOnly = true;
            this.tbPaymentReadName.Size = new System.Drawing.Size(100, 21);
            this.tbPaymentReadName.TabIndex = 1;
            // 
            // tbPaymentReadId
            // 
            this.tbPaymentReadId.Location = new System.Drawing.Point(123, 36);
            this.tbPaymentReadId.Name = "tbPaymentReadId";
            this.tbPaymentReadId.ReadOnly = true;
            this.tbPaymentReadId.Size = new System.Drawing.Size(100, 21);
            this.tbPaymentReadId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "学号";
            // 
            // tbPaymentBookId
            // 
            this.tbPaymentBookId.Location = new System.Drawing.Point(123, 84);
            this.tbPaymentBookId.Name = "tbPaymentBookId";
            this.tbPaymentBookId.ReadOnly = true;
            this.tbPaymentBookId.Size = new System.Drawing.Size(100, 21);
            this.tbPaymentBookId.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "图书编号";
            // 
            // tbPaymentBookName
            // 
            this.tbPaymentBookName.Location = new System.Drawing.Point(309, 84);
            this.tbPaymentBookName.Name = "tbPaymentBookName";
            this.tbPaymentBookName.ReadOnly = true;
            this.tbPaymentBookName.Size = new System.Drawing.Size(100, 21);
            this.tbPaymentBookName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "图书名称";
            // 
            // tbPaymentMemo
            // 
            this.tbPaymentMemo.Location = new System.Drawing.Point(123, 136);
            this.tbPaymentMemo.Name = "tbPaymentMemo";
            this.tbPaymentMemo.ReadOnly = true;
            this.tbPaymentMemo.Size = new System.Drawing.Size(100, 21);
            this.tbPaymentMemo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "备注";
            // 
            // tbPaymentSum
            // 
            this.tbPaymentSum.Location = new System.Drawing.Point(309, 136);
            this.tbPaymentSum.Name = "tbPaymentSum";
            this.tbPaymentSum.ReadOnly = true;
            this.tbPaymentSum.Size = new System.Drawing.Size(100, 21);
            this.tbPaymentSum.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "罚款金额";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(164, 212);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "确定缴费";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(263, 212);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "以后再说";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 173);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "罚款信息";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(13, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 64);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作";
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 262);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbPaymentSum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPaymentMemo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPaymentBookName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPaymentBookId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPaymentReadId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPaymentReadName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "缴费";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPaymentReadName;
        private System.Windows.Forms.TextBox tbPaymentReadId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPaymentBookId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPaymentBookName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPaymentMemo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPaymentSum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}