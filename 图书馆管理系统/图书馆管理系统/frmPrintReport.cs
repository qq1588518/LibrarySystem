using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 图书馆管理系统
{
    public partial class frmPrintReport : Form
    {
        public frmPrintReport(string textvalue)
        {
            InitializeComponent();
            this.Text = textvalue;
        }

        private void frmPrintReport_Load(object sender, EventArgs e)
        {         
            if (this.Text == "图书罚款打印")
            {
                this.reportViewerBookPenalty.Visible = true;
                this.view_ReportsReadFineTableAdapter.Fill(this.libraryDataSet.View_ReportsReadFine);
                this.reportViewerBookPenalty.RefreshReport();
            }
            else if (this.Text == "图书丢失打印")
            {
                this.reportViewerBookDamage.Visible = true;
                this.view_BookDamageTableAdapter.Fill(this.libraryDataSet.View_BookDamage);
                this.reportViewerBookDamage.RefreshReport();
            }
            else if (this.Text == "用户注销打印")
            {
                this.reportViewerReadLogout.Visible = true;
                this.view_ReadLogoutTableAdapter.Fill(this.libraryDataSet.View_ReadLogout);
                this.reportViewerReadLogout.RefreshReport();
            }
        }

    }
}
