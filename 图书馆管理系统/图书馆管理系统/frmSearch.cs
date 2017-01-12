using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
using System.Data.SqlClient;

namespace 图书馆管理系统
{
    public partial class frmSearch : Form
    {
        public frmSearch(int selected)
        {
            InitializeComponent();
            this.tabControl1.SelectedIndex = selected;//显示第几个页面
        }

        //封装图书信息的数据源
        public BindingSource bsBookInfo = new BindingSource();
        //封装读者信息的数据源
        public BindingSource bsReadInfo = new BindingSource();
        //封装借阅信息的数据源
        public BindingSource bsBorrowInfo = new BindingSource();

        //图书信息查询
        private void btnSearchBookInfo_Click(object sender, EventArgs e)
        {
            #region 判断查询

            //声明一个查询语句
            string sqlstr = "";
            //如果单选按钮选中 且文本框的值不为空
            if (cbSearchSortID.Checked)
            {
                if (tbSearchSortID.Text != "")
                {
                    sqlstr = sqlstr + "and 类别编号='" + tbSearchSortID.Text + "'";
                }
            }
            if (cbSearchISBN.Checked)
            {
                if (tbSearchISBN.Text != "")
                {
                    sqlstr = sqlstr + "and ISBN='" + tbSearchISBN.Text + "'";
                }
            }
            if (cbSearchBookID.Checked)
            {
                if (tbSearchBookID.Text != "")
                {
                    sqlstr = sqlstr + "and 图书编号='" + tbSearchBookID.Text + "'";
                }
            }
            if (cbSearchBookName.Checked)
            {
                if (tbSearchBookName.Text != "")
                {
                    sqlstr = sqlstr + "and 图书名称='" + tbSearchBookName.Text + "'";
                }
            }
            if (cbSearchBookAuthor.Checked)
            {
                if (tbSearchBookAuthor.Text != "")
                {
                    sqlstr = sqlstr + "and 图书作者='" + tbSearchBookAuthor.Text + "'";
                }
            }
            if (cbSearchBookPress.Checked)
            {
                if (tbSearchBookPress.Text != "")
                {
                    sqlstr = sqlstr + "and 出版社='" + tbSearchBookPress.Text + "'";
                }
            }
            if (cbSearchPutDate.Checked)
            {
                sqlstr = sqlstr + "and 入库日期 between'" + dtpSearchPutDateA.Value.ToString() + "' and '" + dtpSearchPutDateB.Value.ToString() + "'";
            }

            #endregion

            //执行查询的语句不为空
            if (sqlstr != "")
            {                
                try
                {   
                    //去除字符串前面的and
                    sqlstr = sqlstr.Remove(0, 4);
                    string sql = "select * from View_SearchBookInfo where " + sqlstr + "";
                    SqlConnection con = new SqlConnection(SqlHelper.ConnectionStringLocalTransaction);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    if (cmd.ExecuteScalar() == null)
                    {
                        dgvSearchBookInfo.DataSource = null;
                        MessageBox.Show("未查到相关信息！", "提示");
                        return;
                    }
                    else
                    {
                        //把查询出来的结果显示到列表中去
                        SqlDataAdapter da = new SqlDataAdapter(sql, con);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        bsBookInfo.DataSource=ds.Tables[0];
                        bindingBookInfo.BindingSource = bsBookInfo;
                        dgvSearchBookInfo.DataSource = bsBookInfo;
                        
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "提示");
                }
            }
        }

        /// <summary>
        /// 读者级别数字存储器
        /// </summary>
        int ReadLevel;

        //读者信息查询
        private void btnSearchReadInfo_Click(object sender, EventArgs e)
        {
            //-------------------------------读者级别判断

            if (tbSearchReadLevel.Text == "三级")
            {
                ReadLevel = 3;
            }
            else if (tbSearchReadLevel.Text == "二级")
            {
                ReadLevel = 2;
            }
            else if (tbSearchReadLevel.Text == "一级")
            {
                ReadLevel = 1;
            }
            //----------------------------------------

            #region 判断查询
            
            //声明一个查询语句
            string sqlstr = "";
            //如果单选按钮选中 且文本框的值不为空
            if (cbSearchReadID.Checked)
            {
                if (tbSearchReadID.Text != "")
                {
                    sqlstr = sqlstr + "and 学号工号='" + tbSearchReadID.Text + "'";
                }
            }
            if (cbSearchReadName.Checked)
            {
                if (tbSearchReadName.Text != "")
                {
                    sqlstr = sqlstr + "and 姓名='" + tbSearchReadName.Text + "'";
                }
            }
            if (cbSearchReadSex.Checked)
            {
                if (tbSearchReadSex.Text != "")
                {
                    sqlstr = sqlstr + "and 性别='" + tbSearchReadSex.Text + "'";
                }
            }

            if (cbSearchReadLevel.Checked)
            {
                if (tbSearchReadLevel.Text != "")
                {
                    sqlstr = sqlstr + "and 读者级别='" + ReadLevel + "'";
                }
            }
            if (cbSearchReadDepartment.Checked)
            {
                if (tbSearchReadDepartment.Text != "")
                {
                    sqlstr = sqlstr + "and 系别='" + tbSearchReadDepartment.Text + "'";
                }
            }
            if (cbSearchReadClass.Checked)
            {
                if (tbSearchReadClass.Text != "")
                {
                    sqlstr = sqlstr + "and 班级'" + tbSearchReadClass.Text + "'";
                }
            }
            if (cbSearchReadRegisterDate.Checked)
            {
                sqlstr = sqlstr + "and 登记日期 between'" + dtpSearchReadRegisterDateA.Value.ToString() + "' and '" + dtpSearchReadRegisterDateB.Value.ToString() + "'";
            }
            if (cbSearchReadPhone.Checked)
            {
                if (tbSearchReadPhone.Text != "")
                {
                    sqlstr = sqlstr + "and 联系电话='" + tbSearchReadPhone.Text + "'";
                }
            }
            if (cbSearchReadNumberID.Checked)
            {
                if (tbSearchReadNumberID.Text != "")
                {
                    sqlstr = sqlstr + "and 身份证号='" + tbSearchReadNumberID.Text + "'";
                }
            }

            #endregion

            //执行查询的语句不为空
            if (sqlstr != "")
            {
                try
                {
                    //去除字符串前面的and
                    sqlstr = sqlstr.Remove(0, 4);
                    string sql = "select * from View_SearchReadInfo where " + sqlstr + "";
                    SqlConnection con = new SqlConnection(SqlHelper.ConnectionStringLocalTransaction);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    if (cmd.ExecuteScalar() == null)
                    {
                        dgvSearchReadInfo.DataSource = null;
                        MessageBox.Show("未查到相关信息！", "提示");
                        return;
                    }
                    else
                    {
                        //把查询出来的结果显示到列表中去
                        SqlDataAdapter da = new SqlDataAdapter(sql, con);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        bsReadInfo.DataSource = ds.Tables[0];
                        bindingReadInfo.BindingSource = bsReadInfo;
                        dgvSearchReadInfo.DataSource = bsReadInfo;
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "提示");
                }
            }
        }

        //借阅信息查询
        private void btnSearchBorrowInfo_Click(object sender, EventArgs e)
        {
            #region 判断查询
            
            //声明一个查询语句
            string sqlstr = "";
            //如果单选按钮选中 且文本框的值不为空
            if (cbSearchBorrowBookID.Checked)
            {
                if (tbSearchBorrowBookID.Text != "")
                {
                    sqlstr = sqlstr + "and 图书编号='" + tbSearchBorrowBookID.Text + "'";
                }
            }
            if (cbSearchBorrowReadID.Checked)
            {
                if (tbSearchBorrowReadID.Text != "")
                {
                    sqlstr = sqlstr + "and 学号工号='" + tbSearchBorrowReadID.Text + "'";
                }
            }
            if (cbSearchBorrowData.Checked)
            {
                sqlstr = sqlstr + "and 借阅日期 between'" + dtpSearchBorrowDataA.Value.ToString() + "' and '" + dtpSearchBorrowDataB.Value.ToString() + "'";
            }


            #endregion

            //执行查询的语句不为空
            if (sqlstr != "")
            {
                try
                {
                    //去除字符串前面的and
                    sqlstr = sqlstr.Remove(0, 4);
                    string sql = "select * from View_SearchBorrowInfo where " + sqlstr + "";
                    SqlConnection con = new SqlConnection(SqlHelper.ConnectionStringLocalTransaction);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    if (cmd.ExecuteScalar() == null)
                    {
                        dgvSearchBorrowInfo.DataSource = null;
                        MessageBox.Show("未查到相关信息！", "提示");
                        return;
                    }
                    else
                    {
                        //把查询出来的结果显示到列表中去
                        SqlDataAdapter da = new SqlDataAdapter(sql, con);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        bsBorrowInfo.DataSource = ds.Tables[0];
                        bindingBorrowInfo.BindingSource = bsBorrowInfo;
                        dgvSearchBorrowInfo.DataSource = bsBorrowInfo;
                        SqlHelper.AutoSizeColumn(dgvSearchBorrowInfo);
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "提示");
                }
            }
        }

        //返回
        private void 返回ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //类别编号
        private void tbSearchSortID_DropDown(object sender, EventArgs e)
        {
            object a = BLL.BookInfoBLL.sysSelectSort();
            tbSearchSortID.DataSource = a;
            tbSearchSortID.DisplayMember = "类别编号";
        }
    }
}
