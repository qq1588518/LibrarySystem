namespace 图书馆管理系统
{
    partial class frmIsbnReadBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIsbnReadBook));
            this.dataGridViewRead = new System.Windows.Forms.DataGridView();
            this.btnReadClose = new System.Windows.Forms.Button();
            this.btnReadOK = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRead)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRead
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewRead.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRead.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewRead.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewRead.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewRead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRead.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRead.Location = new System.Drawing.Point(18, 75);
            this.dataGridViewRead.Name = "dataGridViewRead";
            this.dataGridViewRead.ReadOnly = true;
            this.dataGridViewRead.RowTemplate.Height = 23;
            this.dataGridViewRead.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRead.Size = new System.Drawing.Size(548, 374);
            this.dataGridViewRead.TabIndex = 0;
            // 
            // btnReadClose
            // 
            this.btnReadClose.Location = new System.Drawing.Point(458, 21);
            this.btnReadClose.Name = "btnReadClose";
            this.btnReadClose.Size = new System.Drawing.Size(75, 23);
            this.btnReadClose.TabIndex = 9;
            this.btnReadClose.Text = "取消";
            this.btnReadClose.UseVisualStyleBackColor = true;
            this.btnReadClose.Click += new System.EventHandler(this.btnReadClose_Click);
            // 
            // btnReadOK
            // 
            this.btnReadOK.Location = new System.Drawing.Point(347, 21);
            this.btnReadOK.Name = "btnReadOK";
            this.btnReadOK.Size = new System.Drawing.Size(75, 23);
            this.btnReadOK.TabIndex = 8;
            this.btnReadOK.Text = "确定";
            this.btnReadOK.UseVisualStyleBackColor = true;
            this.btnReadOK.Click += new System.EventHandler(this.btnReadOK_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(112, 22);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(170, 21);
            this.tbSearch.TabIndex = 10;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "搜索";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 48);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 400);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "结果";
            // 
            // frmIsbnReadBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnReadClose);
            this.Controls.Add(this.btnReadOK);
            this.Controls.Add(this.dataGridViewRead);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIsbnReadBook";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "列表选择";
            this.Load += new System.EventHandler(this.frmRead_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRead;
        private System.Windows.Forms.Button btnReadClose;
        private System.Windows.Forms.Button btnReadOK;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;

    }
}