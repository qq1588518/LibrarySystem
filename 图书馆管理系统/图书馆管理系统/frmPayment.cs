using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DAL;

namespace 图书馆管理系统
{
    public partial class frmPayment : Form
    {
        public int FineID;//罚金序号

        public delegate void UpdateDelegate(EventArgs e);
        public event UpdateDelegate Updateevent;

        public frmPayment(Model.Payment pt)
        {
            InitializeComponent();

            #region 修改传值
           
            this.tbPaymentBookId.Text = pt.TbPaymentBookId;
            this.tbPaymentBookName.Text = pt.TbPaymentBookName;
            this.tbPaymentMemo.Text = pt.TbPaymentMemo;
            this.tbPaymentReadId.Text = pt.TbPaymentReadId;
            this.tbPaymentReadName.Text = pt.TbPaymentReadName;
            this.tbPaymentSum.Text =pt.TbPaymentSum;

            FineID = pt.Serialnumber;//罚金序号
            #endregion
        }

        //确定缴费
        private void btnOK_Click(object sender, EventArgs e)
        {
            #region 保存传值

            Model.Payment pt = new Model.Payment();
            pt.TbPaymentBookId = this.tbPaymentBookId.Text;
            pt.TbPaymentBookName = this.tbPaymentBookName.Text;
            pt.TbPaymentReadId = this.tbPaymentReadId.Text; 
            pt.TbPaymentReadName = this.tbPaymentReadName.Text;
            pt.TbPaymentMemo =  this.tbPaymentMemo.Text;
            pt.TbPaymentSum = this.tbPaymentSum.Text;


            #endregion

            string str = "Update BookPenalty set 是否交款='是'  where 罚金序号=@罚金序号";
            int a = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStringLocalTransaction, CommandType.Text, str, new SqlParameter("@罚金序号", FineID));

            if (a > 0)
            {
                MessageBox.Show("缴费成功!", "提示");
                Updateevent(null);
                this.Close();
            }


            
        }

        //以后再说
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
