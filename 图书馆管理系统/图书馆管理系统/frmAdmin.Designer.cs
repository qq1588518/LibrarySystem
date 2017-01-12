namespace 图书馆管理系统
{
    partial class frmAdmin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbAdminID = new System.Windows.Forms.TextBox();
            this.tbPassWord = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bindingNavigatorAdmin = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorUpdateAdmin = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteAdmin = new System.Windows.Forms.ToolStripButton();
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSuperAdmin = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.tbAdminPassWordOK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdminClose = new System.Windows.Forms.Button();
            this.btnAdminOK = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorAdmin)).BeginInit();
            this.bindingNavigatorAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbAdminID
            // 
            this.tbAdminID.Location = new System.Drawing.Point(129, 23);
            this.tbAdminID.Name = "tbAdminID";
            this.tbAdminID.Size = new System.Drawing.Size(171, 21);
            this.tbAdminID.TabIndex = 41;
            // 
            // tbPassWord
            // 
            this.tbPassWord.Location = new System.Drawing.Point(129, 69);
            this.tbPassWord.MaxLength = 6;
            this.tbPassWord.Name = "tbPassWord";
            this.tbPassWord.PasswordChar = '*';
            this.tbPassWord.Size = new System.Drawing.Size(171, 21);
            this.tbPassWord.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 43;
            this.label9.Text = "用户密码";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bindingNavigatorAdmin);
            this.groupBox2.Controls.Add(this.dgvAdmin);
            this.groupBox2.Location = new System.Drawing.Point(12, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 260);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "所有管理员";
            // 
            // bindingNavigatorAdmin
            // 
            this.bindingNavigatorAdmin.AddNewItem = null;
            this.bindingNavigatorAdmin.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorAdmin.DeleteItem = null;
            this.bindingNavigatorAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorUpdateAdmin,
            this.bindingNavigatorDeleteAdmin});
            this.bindingNavigatorAdmin.Location = new System.Drawing.Point(3, 17);
            this.bindingNavigatorAdmin.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorAdmin.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorAdmin.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorAdmin.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorAdmin.Name = "bindingNavigatorAdmin";
            this.bindingNavigatorAdmin.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorAdmin.Size = new System.Drawing.Size(454, 25);
            this.bindingNavigatorAdmin.TabIndex = 1;
            this.bindingNavigatorAdmin.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorUpdateAdmin
            // 
            this.bindingNavigatorUpdateAdmin.Image = global::图书馆管理系统.Properties.Resources.修改;
            this.bindingNavigatorUpdateAdmin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorUpdateAdmin.Name = "bindingNavigatorUpdateAdmin";
            this.bindingNavigatorUpdateAdmin.Size = new System.Drawing.Size(52, 22);
            this.bindingNavigatorUpdateAdmin.Text = "修改";
            this.bindingNavigatorUpdateAdmin.Click += new System.EventHandler(this.bindingNavigatorUpdateAdmin_Click);
            // 
            // bindingNavigatorDeleteAdmin
            // 
            this.bindingNavigatorDeleteAdmin.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteAdmin.Image")));
            this.bindingNavigatorDeleteAdmin.Name = "bindingNavigatorDeleteAdmin";
            this.bindingNavigatorDeleteAdmin.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteAdmin.Size = new System.Drawing.Size(52, 22);
            this.bindingNavigatorDeleteAdmin.Text = "删除";
            this.bindingNavigatorDeleteAdmin.Click += new System.EventHandler(this.bindingNavigatorDeleteAdmin_Click);
            // 
            // dgvAdmin
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAdmin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAdmin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAdmin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdmin.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvAdmin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAdmin.Location = new System.Drawing.Point(3, 47);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdmin.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvAdmin.RowTemplate.Height = 23;
            this.dgvAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdmin.Size = new System.Drawing.Size(454, 210);
            this.dgvAdmin.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSuperAdmin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAdmin);
            this.groupBox1.Controls.Add(this.rbAdmin);
            this.groupBox1.Controls.Add(this.tbAdminPassWordOK);
            this.groupBox1.Controls.Add(this.tbAdminID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbPassWord);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 140);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "类别信息";
            // 
            // rbSuperAdmin
            // 
            this.rbSuperAdmin.AutoSize = true;
            this.rbSuperAdmin.Location = new System.Drawing.Point(129, 47);
            this.rbSuperAdmin.Name = "rbSuperAdmin";
            this.rbSuperAdmin.Size = new System.Drawing.Size(83, 16);
            this.rbSuperAdmin.TabIndex = 49;
            this.rbSuperAdmin.TabStop = true;
            this.rbSuperAdmin.Text = "超级管理员";
            this.rbSuperAdmin.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 47;
            this.label2.Text = "学号/工号";
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.White;
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmin.Image")));
            this.btnAdmin.Location = new System.Drawing.Point(281, 24);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(18, 19);
            this.btnAdmin.TabIndex = 42;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Location = new System.Drawing.Point(217, 47);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(83, 16);
            this.rbAdmin.TabIndex = 50;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "普通管理员";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // tbAdminPassWordOK
            // 
            this.tbAdminPassWordOK.Location = new System.Drawing.Point(129, 108);
            this.tbAdminPassWordOK.MaxLength = 6;
            this.tbAdminPassWordOK.Name = "tbAdminPassWordOK";
            this.tbAdminPassWordOK.PasswordChar = '*';
            this.tbAdminPassWordOK.Size = new System.Drawing.Size(171, 21);
            this.tbAdminPassWordOK.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 45;
            this.label1.Text = "重复密码";
            // 
            // btnAdminClose
            // 
            this.btnAdminClose.Location = new System.Drawing.Point(376, 92);
            this.btnAdminClose.Name = "btnAdminClose";
            this.btnAdminClose.Size = new System.Drawing.Size(73, 37);
            this.btnAdminClose.TabIndex = 52;
            this.btnAdminClose.Text = "返回";
            this.btnAdminClose.UseVisualStyleBackColor = true;
            this.btnAdminClose.Click += new System.EventHandler(this.btnAdminClose_Click);
            // 
            // btnAdminOK
            // 
            this.btnAdminOK.Location = new System.Drawing.Point(376, 33);
            this.btnAdminOK.Name = "btnAdminOK";
            this.btnAdminOK.Size = new System.Drawing.Size(73, 37);
            this.btnAdminOK.TabIndex = 51;
            this.btnAdminOK.Text = "添加";
            this.btnAdminOK.UseVisualStyleBackColor = true;
            this.btnAdminOK.Click += new System.EventHandler(this.btnAdminOK_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(355, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(114, 140);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "操作";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 412);
            this.Controls.Add(this.btnAdminClose);
            this.Controls.Add(this.btnAdminOK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdmin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "用户管理";
            this.Load += new System.EventHandler(this.frmAddAdmin_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorAdmin)).EndInit();
            this.bindingNavigatorAdmin.ResumeLayout(false);
            this.bindingNavigatorAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.TextBox tbAdminID;
        private System.Windows.Forms.TextBox tbPassWord;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingNavigator bindingNavigatorAdmin;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorUpdateAdmin;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteAdmin;
        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAdminPassWordOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbSuperAdmin;
        private System.Windows.Forms.Button btnAdminClose;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.Button btnAdminOK;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}