using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using DAL;
using System.Data.SqlClient;

namespace 图书馆管理系统
{
    public partial class frmAddUpdateBookSort : Form
    {
        //实例化一个数据源对象
        public BindingSource bs = new BindingSource();

        //声明当用户点击列表获取的列数和行数 就是鼠标点击的当前位置
        public string sort;
        public string memo;

        //禁用事件判断
        public bool CellClick = false;
        public bool DClick = false;

        /// <summary>
        /// 窗体初始化入口
        /// </summary>
        public frmAddUpdateBookSort(string textname, string btntextname)
        {
            try
            {
                InitializeComponent();
                this.Text += textname;
                this.btnAddSort.Text = btntextname;
                //让列宽布满显示           
                SqlHelper.AutoSizeColumn(dgvSortInfo);
            }
            catch
            {
                //捕获到自动列宽的错误，这里不做什么操作，直接跳过
            }
        }

        //窗体加载时 列表显示所有的信息
        private void frmAddUpdateBookSort_Load(object sender, EventArgs e)
        {
            ShowSortInfo();
            if (btnAddSort.Text == "添加")
            {
                bindingNavigatorAddItem.Visible = false;//隐藏增加类别图标
                tbSortId.Enabled = true;
                //设置事件禁用
                CellClick = false;
                DClick = true;
            }
            if (btnAddSort.Text == "保存")
            {
                sort = dgvSortInfo[0, bs.Position].Value.ToString().Trim();
                memo = dgvSortInfo[1, bs.Position].Value.ToString().Trim();
                tbSortId.Enabled = false;
                bindingNavigatorAddItem.Visible = true;//显示增加类别图标
                bindingNavigatorUpdateItem.Visible = false; //隐藏修改图标
                tbSortId.Text = sort;
                tbSortMemo.Text = memo;
                //设置事件禁用
                CellClick = true;
                DClick = false;
            }
            if (btnAddSort.Text == "删除")
            {
                sort = dgvSortInfo[0, bs.Position].Value.ToString().Trim();
                memo = dgvSortInfo[1, bs.Position].Value.ToString().Trim();
                tbSortId.Enabled = false;
                tbSortMemo.Enabled = false;
                bindingNavigatorDeleteItem.Visible = false;//隐藏删除图标
                tbSortId.Text = sort;
                tbSortMemo.Text = memo;
                CellClick = true;
                DClick = true;
            }
        }


        //判断用户点击是添加，修改还是删除,然后做出不同的响应
        private void btnAddSort_Click(object sender, EventArgs e)
        {

            if (btnAddSort.Text == "添加")
            {

                if (tbSortId.Text != "")
                {
                    lbTsSortId.Visible = false;
                    if (tbSortMemo.Text != "")
                    {
                        lbTsSortMemo.Visible = false;
                        Model.Sort ast = new Model.Sort();
                        ast.TbSortId = tbSortId.Text;
                        ast.TbSortMemo = tbSortMemo.Text;
                        int a = BLL.SortBLL.sysAddSort(ast);
                        //取返回值 1代表该类别号已经存在 2代表类别说明已存在 3代表添加类别号成功
                        if (a == 1)
                        {
                            lbTsSortId.Text = "提示：该类别编号已存在";
                            lbTsSortId.Visible = true;
                            tbSortId.Focus();
                            lbTsSortMemo.Visible = false;
                        }
                        else if (a == 2)
                        {
                            lbTsSortMemo.Text = "提示：该类别说明已存在";
                            lbTsSortMemo.Visible = true;
                            tbSortMemo.Focus();
                            lbTsSortId.Visible = false;
                        }
                        else if (a == 3)
                        {
                            lbTsSortId.Visible = false;
                            lbTsSortMemo.Visible = false;
                            if (MessageBox.Show("添加类别成功!", "提示") == DialogResult.OK)
                            {
                                //显示提示信息 当用户点击提示按钮后 清除文本框内容
                                tbSortId.Clear();
                                tbSortMemo.Clear();
                                ShowSortInfo();
                            }
                        }
                    }
                    else
                    {
                        lbTsSortMemo.Text = "提示:类别说明不能为空";
                        lbTsSortMemo.Visible = true;
                    }
                }
                else
                {
                    lbTsSortId.Text = "提示:类别编号不能为空";
                    lbTsSortId.Visible = true;
                }
            }


            if (btnAddSort.Text == "保存")
            {
                if (tbSortMemo.Text == "")
                {
                    lbTsSortMemo.Text = "提示:类别说明不能为空";
                    lbTsSortMemo.Visible = true;
                    tbSortMemo.Focus();
                }
                else
                {
                    lbTsSortMemo.Visible = false;
                    string a = tbSortId.Text;
                    string b = tbSortMemo.Text;
                    int num = BLL.SortBLL.sysUpdateSort(a, b);
                    if (num == 1)
                    {
                        lbTsSortMemo.Text = "提示:该类别说明已存在";
                        lbTsSortMemo.Visible = true;
                        tbSortMemo.Focus();
                    }
                    if (num == 2)
                    {
                        if (MessageBox.Show("修改成功!", "提示") == DialogResult.OK)
                        {
                            ShowSortInfo();
                        }
                    }

                }
            }

            if (btnAddSort.Text == "删除")
            {
                string a = tbSortId.Text;
                if (MessageBox.Show("确认要删除类别编号为'" + sort + "'相关的所有图书信息吗?", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {    
                    //执行删除
                    string m=  BLL.SortBLL.sysDeleSort(a);                  
                    if (m == "已存在")
                    {
                        MessageBox.Show("该类别编号下有图书未归还,请先归还后在删除!", "温馨提示");
                    }
                    else
                    {
                        MessageBox.Show("删除成功", "温馨提示");
                        //从列表中移除当前行
                        bs.RemoveCurrent();
                        tbSortId.Clear();
                        tbSortMemo.Clear();
                    }
                }
            }

        }

        //删除类别事件(通用)
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //获取行的信息
            sort = dgvSortInfo[0, bs.Position].Value.ToString().Trim();
            //memo = dgvSortInfo[1, bs.Position].Value.ToString().Trim();
            if (MessageBox.Show("确认要删除类别编号为'" + sort + "'相关的所有图书信息吗?", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {                  
                //执行删除
                string a=BLL.SortBLL.sysDeleSort(sort);
                if (a == "已存在")
                {
                    MessageBox.Show("该类别编号下有图书未归还,请先归还后在删除!", "温馨提示");
                }
                else 
                {
                    MessageBox.Show("删除成功", "温馨提示");
                    //从列表中移除当前行
                    bs.RemoveCurrent();
                }
                
            }
            

        }


        //单击列表记录点击的位置
        private void dgvSortInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //当判断到CellClick是true时执行下面代码  否则不执行
            if (CellClick == true)
            {
                sort = dgvSortInfo[0, bs.Position].Value.ToString().Trim();
                memo = dgvSortInfo[1, bs.Position].Value.ToString().Trim();
                tbSortId.Text = sort;
                tbSortMemo.Text = memo;
                tbSortMemo.Focus();
            }
        }

        //双击列表弹出修改对话框
        private void dgvSortInfo_DoubleClick(object sender, EventArgs e)
        {
            //当判断到DoubleClick是true时执行下面代码  否则不执行
            if (DClick == true)
            {
                //获取行的信息
                sort = dgvSortInfo[0, bs.Position].Value.ToString().Trim();
                memo = dgvSortInfo[1, bs.Position].Value.ToString().Trim();
                frmUpdateSort fus = new frmUpdateSort(sort, memo, "(修改)", "保存");
                fus.testevent += new 图书馆管理系统.testdelegate(fus_testevent);
                fus.ShowDialog();
            }
        }

        //修改类别事件
        private void bindingNavigatorUpdateItem_Click(object sender, EventArgs e)
        {
            //获取行的信息
            sort = dgvSortInfo[0, bs.Position].Value.ToString().Trim();
            memo = dgvSortInfo[1, bs.Position].Value.ToString().Trim();
            frmUpdateSort fus = new frmUpdateSort(sort, memo, "(修改)", "保存");
            fus.testevent += new 图书馆管理系统.testdelegate(fus_testevent);
            fus.ShowDialog();
        }

        //添加类别按钮事件
        private void bindingNavigatorAddItem_Click(object sender, EventArgs e)
        {
            frmUpdateSort fus = new frmUpdateSort(null, null, "(添加)", "添加");
            fus.testevent += new 图书馆管理系统.testdelegate(fus_testevent);
            fus.ShowDialog();
        }


        /// <summary>
        /// 显示类别信息的方法
        /// </summary>
        public void ShowSortInfo()
        {
            SqlConnection con = new SqlConnection(SqlHelper.ConnectionStringLocalTransaction);
            con.Open();
            string str = "select * from B1BookSort";
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            //实例化一个数据源对象
            //将获取到的数据绑定到这个对象
            bs.DataSource = ds.Tables[0];
            //设置控件的数据来源 绑定两个控件关联起来
            bindingNavigator.BindingSource = bs;
            dgvSortInfo.DataSource = bs;
        }


        /// <summary>
        /// 委托--要刷新的操作
        /// </summary>
        /// <param name="sender"></param>
        void fus_testevent(object sender)
        {
            ShowSortInfo();
        }

    }
}
