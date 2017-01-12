namespace 图书馆管理系统
{
    partial class frmPrintReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintReport));
            this.reportViewerBookPenalty = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewerBookDamage = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewerReadLogout = new Microsoft.Reporting.WinForms.ReportViewer();
            this.libraryDataSet = new 图书馆管理系统.LibraryDataSet();
            this.viewReadLogoutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_ReadLogoutTableAdapter = new 图书馆管理系统.LibraryDataSetTableAdapters.View_ReadLogoutTableAdapter();
            this.viewReportsReadFineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_ReportsReadFineTableAdapter = new 图书馆管理系统.LibraryDataSetTableAdapters.View_ReportsReadFineTableAdapter();
            this.viewBookDamageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_BookDamageTableAdapter = new 图书馆管理系统.LibraryDataSetTableAdapters.View_BookDamageTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewReadLogoutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewReportsReadFineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewBookDamageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerBookPenalty
            // 
            this.reportViewerBookPenalty.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetReportsReadFine";
            reportDataSource1.Value = this.viewReportsReadFineBindingSource;
            this.reportViewerBookPenalty.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerBookPenalty.LocalReport.ReportEmbeddedResource = "图书馆管理系统.ReportBookPenalty.rdlc";
            this.reportViewerBookPenalty.Location = new System.Drawing.Point(0, 0);
            this.reportViewerBookPenalty.Name = "reportViewerBookPenalty";
            this.reportViewerBookPenalty.ShowZoomControl = false;
            this.reportViewerBookPenalty.Size = new System.Drawing.Size(734, 812);
            this.reportViewerBookPenalty.TabIndex = 0;
            this.reportViewerBookPenalty.Visible = false;
            this.reportViewerBookPenalty.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // reportViewerBookDamage
            // 
            this.reportViewerBookDamage.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSetBookDamage";
            reportDataSource2.Value = this.viewBookDamageBindingSource;
            this.reportViewerBookDamage.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerBookDamage.LocalReport.ReportEmbeddedResource = "图书馆管理系统.ReportBookDamage.rdlc";
            this.reportViewerBookDamage.Location = new System.Drawing.Point(0, 0);
            this.reportViewerBookDamage.Name = "reportViewerBookDamage";
            this.reportViewerBookDamage.ShowZoomControl = false;
            this.reportViewerBookDamage.Size = new System.Drawing.Size(734, 812);
            this.reportViewerBookDamage.TabIndex = 1;
            this.reportViewerBookDamage.Visible = false;
            this.reportViewerBookDamage.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // reportViewerReadLogout
            // 
            this.reportViewerReadLogout.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSetReadLogout";
            reportDataSource3.Value = this.viewReadLogoutBindingSource;
            this.reportViewerReadLogout.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewerReadLogout.LocalReport.ReportEmbeddedResource = "图书馆管理系统.ReportReadLogout.rdlc";
            this.reportViewerReadLogout.Location = new System.Drawing.Point(0, 0);
            this.reportViewerReadLogout.Name = "reportViewerReadLogout";
            this.reportViewerReadLogout.ShowZoomControl = false;
            this.reportViewerReadLogout.Size = new System.Drawing.Size(734, 812);
            this.reportViewerReadLogout.TabIndex = 2;
            this.reportViewerReadLogout.Visible = false;
            this.reportViewerReadLogout.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewReadLogoutBindingSource
            // 
            this.viewReadLogoutBindingSource.DataMember = "View_ReadLogout";
            this.viewReadLogoutBindingSource.DataSource = this.libraryDataSet;
            // 
            // view_ReadLogoutTableAdapter
            // 
            this.view_ReadLogoutTableAdapter.ClearBeforeFill = true;
            // 
            // viewReportsReadFineBindingSource
            // 
            this.viewReportsReadFineBindingSource.DataMember = "View_ReportsReadFine";
            this.viewReportsReadFineBindingSource.DataSource = this.libraryDataSet;
            // 
            // view_ReportsReadFineTableAdapter
            // 
            this.view_ReportsReadFineTableAdapter.ClearBeforeFill = true;
            // 
            // viewBookDamageBindingSource
            // 
            this.viewBookDamageBindingSource.DataMember = "View_BookDamage";
            this.viewBookDamageBindingSource.DataSource = this.libraryDataSet;
            // 
            // view_BookDamageTableAdapter
            // 
            this.view_BookDamageTableAdapter.ClearBeforeFill = true;
            // 
            // frmPrintReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 812);
            this.Controls.Add(this.reportViewerReadLogout);
            this.Controls.Add(this.reportViewerBookDamage);
            this.Controls.Add(this.reportViewerBookPenalty);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrintReport";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "打印";
            this.Load += new System.EventHandler(this.frmPrintReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewReadLogoutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewReportsReadFineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewBookDamageBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerBookPenalty;
        private LibraryDataSet libraryDataSet;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerBookDamage;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerReadLogout;
        private System.Windows.Forms.BindingSource viewReadLogoutBindingSource;
        private LibraryDataSetTableAdapters.View_ReadLogoutTableAdapter view_ReadLogoutTableAdapter;
        private System.Windows.Forms.BindingSource viewReportsReadFineBindingSource;
        private LibraryDataSetTableAdapters.View_ReportsReadFineTableAdapter view_ReportsReadFineTableAdapter;
        private System.Windows.Forms.BindingSource viewBookDamageBindingSource;
        private LibraryDataSetTableAdapters.View_BookDamageTableAdapter view_BookDamageTableAdapter;




    }
}