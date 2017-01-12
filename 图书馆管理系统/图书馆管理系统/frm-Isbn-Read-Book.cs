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
    public partial class frmIsbnReadBook : Form
    {
        //声明ISBN委托 学号委托 图书委托 图书借出编号委托事件
        public delegate void IDdelegate(string value);
        public event IDdelegate IDevent;

        public delegate void ISBNdelegate(string value);
        public event ISBNdelegate ISBNevent;

        public delegate void Readdelegate(string value);
        public event Readdelegate Readevent;

        public delegate void Bookdelegate(string value);
        public event Bookdelegate Bookevent;

        public delegate void BookIDdelegate(string value, string Damagevalue);
        public event BookIDdelegate BookIDevent;


        //声明一个封装ISBN信息 读者信息 图书信息 图书借出编号信息数据源对象
        public BindingSource bsID = new BindingSource();
        public BindingSource bsISBN = new BindingSource();
        public BindingSource bsRead = new BindingSource();
        public BindingSource bsBook = new BindingSource();
        public BindingSource bsBookID = new BindingSource();

        /// <param name="title">设置显示的标题</param>
        public frmIsbnReadBook(string title)
        {
            InitializeComponent();
            this.Text = title + this.Text;
        }

        //加载时显示所有读者信息
        private void frmRead_Load(object sender, EventArgs e)
        {
            if (this.Text == "注销列表选择")
            {
                bsID.DataSource = BLL.BookInfoBLL.sysPaging(9, 0);
                dataGridViewRead.DataSource = bsID;
                SqlHelper.AutoSizeColumn(dataGridViewRead);
            }
            else if (this.Text == "ISBN列表选择")
            {
                bsISBN.DataSource = BLL.BookInfoBLL.sysPaging(8, 0);
                dataGridViewRead.DataSource = bsISBN;
                SqlHelper.AutoSizeColumn(dataGridViewRead);
            }

            else if (this.Text == "读者列表选择")
            {
                bsRead.DataSource = BLL.BookInfoBLL.sysPaging(6, 0);
                dataGridViewRead.DataSource = bsRead;
                SqlHelper.AutoSizeColumn(dataGridViewRead);
            }
            else if (this.Text == "图书列表选择")
            {
                bsBook.DataSource = BLL.BookInfoBLL.sysPaging(7, 0);
                dataGridViewRead.DataSource = bsBook;
                SqlHelper.AutoSizeColumn(dataGridViewRead);
            }
            else if (this.Text == "图书编号列表选择")
            {
                bsBookID.DataSource = BLL.BookInfoBLL.sysPaging(10, 0);
                dataGridViewRead.DataSource = bsBookID;
                SqlHelper.AutoSizeColumn(dataGridViewRead);
            }
        }

        //选中确定
        private void btnReadOK_Click(object sender, EventArgs e)
        {
            if (this.Text == "注销列表选择")
            {
                Model.BookId bi = new Model.BookId();
                bi.TbBookID = dataGridViewRead[0, bsID.Position].Value.ToString().Trim();
                IDevent(bi.TbBookID);
                this.Close();
            }
            if (this.Text == "ISBN列表选择")
            {
                Model.BookId bi = new Model.BookId();
                bi.TbISBN = dataGridViewRead[0, bsISBN.Position].Value.ToString().Trim();
                ISBNevent(bi.TbISBN);
                this.Close();
            }

            if (this.Text == "读者列表选择")
            {
                Model.BorrowInfo br = new Model.BorrowInfo();
                br.TbBorrowReadId = dataGridViewRead[0, bsRead.Position].Value.ToString().Trim();
                Readevent(br.TbBorrowReadId);
                this.Close();
            }
            if (this.Text == "图书列表选择")
            {
                Model.BorrowInfo br = new Model.BorrowInfo();
                br.TbBorrowBookId = dataGridViewRead[0, bsBook.Position].Value.ToString().Trim();
                //委托事件传值
                Bookevent(br.TbBorrowBookId);
                //选择完成后 关闭当前窗体
                this.Close();
            }
            if (this.Text == "图书编号列表选择")
            {
                Model.Back bc = new Model.Back();
                bc.TbBackBookId = dataGridViewRead[0, bsBookID.Position].Value.ToString().Trim();
                bc.CbBackDamage = dataGridViewRead["损坏程度", bsBookID.Position].Value.ToString().Trim();
                BookIDevent(bc.TbBackBookId, bc.CbBackDamage);
                this.Close();
            }

        }

        //取消 
        private void btnReadClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //文本框查询
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
           
            if (this.Text == "读者列表选择")
            {
                string str = "SELECT 学号工号,姓名,备注,读者级别 FROM dbo. View_ReadInfo WHERE 注销日期 IS NULL AND 备注<>'管理员' and 学号工号 LIKE '%" + this.tbSearch.Text + "%' OR 姓名 LIKE '%" + this.tbSearch.Text + "%'";
                cmdView(str);
            }

            else if (this.Text == "图书列表选择")
            {
                string str = "SELECT 图书编号,图书名称,类别说明,是否借出,图书等级编号 FROM dbo.View_BookInfo where (报废时间 is null) and (是否借出='否') and 图书编号 LIKE '%" + this.tbSearch.Text + "%' OR 图书名称 LIKE '%" + this.tbSearch.Text + "%'";
                cmdView(str);
            }
            else if (this.Text == "图书编号列表选择")
            {
                string str = "SELECT 图书编号,姓名,学号工号,图书名称,是否借出,损坏程度 FROM dbo.View_ReadBorrow WHERE 是否借出='是' AND 归还日期 IS NULL and 学号工号 LIKE '%" + this.tbSearch.Text + "%' OR 图书编号 LIKE '%" + this.tbSearch.Text + "%' OR 姓名 LIKE '%" + this.tbSearch.Text + "%'";
                cmdView(str);
            }

            
        }

        //模糊查询链接方法
        public void cmdView(string str)
        {
            SqlConnection con = new SqlConnection(SqlHelper.ConnectionStringLocalTransaction);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewRead.DataSource = ds.Tables[0];
            con.Close();
        }

    }
}
