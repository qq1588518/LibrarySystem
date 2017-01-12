namespace 图书馆管理系统
{
    partial class frmUpdateSort
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateSort));
            this.lbUpdateTsSortMemo = new System.Windows.Forms.Label();
            this.btnUpdateSotr = new System.Windows.Forms.Button();
            this.tbUpdateSortMemo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUpdateSortId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbUpdateTsSortSortId = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lbUpdateTsSortMemo
            // 
            this.lbUpdateTsSortMemo.AutoSize = true;
            this.lbUpdateTsSortMemo.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbUpdateTsSortMemo.ForeColor = System.Drawing.Color.Red;
            this.lbUpdateTsSortMemo.Location = new System.Drawing.Point(288, 67);
            this.lbUpdateTsSortMemo.Name = "lbUpdateTsSortMemo";
            this.lbUpdateTsSortMemo.Size = new System.Drawing.Size(115, 10);
            this.lbUpdateTsSortMemo.TabIndex = 22;
            this.lbUpdateTsSortMemo.Text = "提示：该类别说明已存在";
            this.lbUpdateTsSortMemo.Visible = false;
            // 
            // btnUpdateSotr
            // 
            this.btnUpdateSotr.Location = new System.Drawing.Point(183, 121);
            this.btnUpdateSotr.Name = "btnUpdateSotr";
            this.btnUpdateSotr.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateSotr.TabIndex = 17;
            this.btnUpdateSotr.Text = "保存或添加";
            this.btnUpdateSotr.UseVisualStyleBackColor = true;
            this.btnUpdateSotr.Click += new System.EventHandler(this.btnUpdateSotr_Click);
            // 
            // tbUpdateSortMemo
            // 
            this.tbUpdateSortMemo.Location = new System.Drawing.Point(288, 41);
            this.tbUpdateSortMemo.Name = "tbUpdateSortMemo";
            this.tbUpdateSortMemo.Size = new System.Drawing.Size(121, 21);
            this.tbUpdateSortMemo.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "类别说明";
            // 
            // tbUpdateSortId
            // 
            this.tbUpdateSortId.Location = new System.Drawing.Point(83, 41);
            this.tbUpdateSortId.Name = "tbUpdateSortId";
            this.tbUpdateSortId.Size = new System.Drawing.Size(121, 21);
            this.tbUpdateSortId.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "类别编号";
            // 
            // lbUpdateTsSortSortId
            // 
            this.lbUpdateTsSortSortId.AutoSize = true;
            this.lbUpdateTsSortSortId.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbUpdateTsSortSortId.ForeColor = System.Drawing.Color.Red;
            this.lbUpdateTsSortSortId.Location = new System.Drawing.Point(82, 67);
            this.lbUpdateTsSortSortId.Name = "lbUpdateTsSortSortId";
            this.lbUpdateTsSortSortId.Size = new System.Drawing.Size(115, 10);
            this.lbUpdateTsSortSortId.TabIndex = 23;
            this.lbUpdateTsSortSortId.Text = "提示：该类别说明已存在";
            this.lbUpdateTsSortSortId.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(13, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 91);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(13, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 46);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作";
            // 
            // frmUpdateSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 162);
            this.Controls.Add(this.lbUpdateTsSortSortId);
            this.Controls.Add(this.lbUpdateTsSortMemo);
            this.Controls.Add(this.tbUpdateSortMemo);
            this.Controls.Add(this.btnUpdateSotr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUpdateSortId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmUpdateSort";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "类别管理";
            this.Load += new System.EventHandler(this.frmUpdateSort_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUpdateTsSortMemo;
        private System.Windows.Forms.Button btnUpdateSotr;
        private System.Windows.Forms.TextBox tbUpdateSortMemo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUpdateSortId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbUpdateTsSortSortId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}