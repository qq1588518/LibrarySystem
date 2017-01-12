using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace 图书馆管理系统
{
    //声明委托
    public delegate void testdelegate(object sender);
    
    public partial class frmUpdateSort : Form
    {
       //声明事件
       public event testdelegate testevent;

       /// <summary>
       /// 传入参数
       /// </summary>
       /// <param name="sid">接收一个类别id参数</param>
       /// <param name="smemo">接收一个类别说明参数</param>        
        public frmUpdateSort(string sid,string smemo,string textname, string btntextname)
        {
            InitializeComponent();
            this.tbUpdateSortId.Text = sid;
            this.tbUpdateSortMemo.Text = smemo;
            //传入参数显示不同的标题和按钮
            this.Text += textname;
            this.btnUpdateSotr.Text = btntextname;

        }

        //窗体加载时事件
        private void frmUpdateSort_Load(object sender, EventArgs e)
        {
            if (btnUpdateSotr.Text == "添加")
            {
                tbUpdateSortId.Enabled = true;
            }
            if (btnUpdateSotr.Text == "保存")
            {
                tbUpdateSortId.Enabled = false;
            }
        }

        //保存,添加类别
        private void btnUpdateSotr_Click(object sender, EventArgs e)
        {
            if (btnUpdateSotr.Text == "保存")
            {
                if (tbUpdateSortMemo.Text != "")
                {
                    string a = tbUpdateSortId.Text;
                    string b = tbUpdateSortMemo.Text;
                    int num = BLL.SortBLL.sysUpdateSort(a, b);
                    if (num == 1)
                    {
                        lbUpdateTsSortMemo.Text = "提示:该类别说明已存在";
                        lbUpdateTsSortMemo.Visible = true;
                        tbUpdateSortMemo.Focus();
                    }
                    if (num == 2)
                    {
                        if (MessageBox.Show("修改成功!", "提示") == DialogResult.OK)
                        {
                            //当用户点击确定按钮后 关闭修改窗体                        
                            this.Close();
                            testevent(null);  //委托事件
                        }
                    }
                }
                else
                {
                    lbUpdateTsSortMemo.Text = "提示:类别说明不能为空";
                    lbUpdateTsSortMemo.Visible = true;
                    tbUpdateSortMemo.Focus();
                }
            }

            if (btnUpdateSotr.Text == "添加")
            {
                if (tbUpdateSortId.Text != "")
                {
                    lbUpdateTsSortSortId.Visible = false;
                    if (tbUpdateSortMemo.Text != "")
                    {
                        lbUpdateTsSortMemo.Visible = false;
                        Model.Sort ast = new Model.Sort();
                        ast.TbSortId = tbUpdateSortId.Text;
                        ast.TbSortMemo = tbUpdateSortMemo.Text;
                        int a = BLL.SortBLL.sysAddSort(ast);
                        //取返回值 1代表该类别号已经存在 2代表类别说明已存在 3代表添加类别号成功
                        if (a == 1)
                        {
                            lbUpdateTsSortSortId.Text = "提示：该类别编号已存在";
                            lbUpdateTsSortSortId.Visible = true;
                            tbUpdateSortId.Focus();
                            lbUpdateTsSortMemo.Visible = false;
                        }
                        else if (a == 2)
                        {
                            lbUpdateTsSortMemo.Text = "提示：该类别说明已存在";
                            lbUpdateTsSortMemo.Visible = true;
                            tbUpdateSortMemo.Focus();
                            lbUpdateTsSortSortId.Visible = false;
                        }
                        else if (a == 3)
                        {
                            lbUpdateTsSortSortId.Visible = false;
                            lbUpdateTsSortMemo.Visible = false;
                            if (MessageBox.Show("添加类别成功!", "提示") == DialogResult.OK)
                            {
                                this.Close();//关闭当前窗体
                                testevent(null);
                            }
                        }
                    }
                    else
                    {
                        lbUpdateTsSortMemo.Text = "提示:类别说明不能为空";
                        lbUpdateTsSortMemo.Visible = true;
                    }
                }
                else
                {
                    lbUpdateTsSortSortId.Text = "提示:类别编号不能为空";
                    lbUpdateTsSortSortId.Visible = true;
                }

            }
        }
    }
}
