using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using System.Data.SqlClient;
using DAL;

namespace 图书馆管理系统
{
    public partial class frmUpdateBookID : Form
    {
        public delegate void Bookiddelegate(object sender); //声明委托
        public event Bookiddelegate Bookidevent;//声明委托事件

        public frmUpdateBookID(Model.BookId bi)  
        {
            InitializeComponent();

        #region 显示要修改的值 
            this.tbBookID.Text = bi.TbBookID;
            this.tbISBN.Text = bi.TbISBN;
            this.cbDamage.Text = bi.CbDamage;
            this.tbBookIdMemo.Text = bi.TbBookIdMemo;
        #endregion
        }

        //修改保存
        private void btOk_Click(object sender, EventArgs e)
        {
            try
            {
                #region 修改传值
                Model.BookId bi = new Model.BookId();
                bi.TbBookID = this.tbBookID.Text;
                bi.TbISBN = this.tbISBN.Text;
                bi.CbDamage = this.cbDamage.Text;
                bi.TbBookIdMemo = this.tbBookIdMemo.Text;
                #endregion
                string a = BLL.BookIdBLL.sysBookID(2, bi);
                if (a == "修改成功!")
                {
                    MessageBox.Show(a, "提示");
                    this.Close();//关闭当前窗体
                    Bookidevent(null);
                }
                else
                {
                    MessageBox.Show(a, "提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //返回
        private void btAClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
