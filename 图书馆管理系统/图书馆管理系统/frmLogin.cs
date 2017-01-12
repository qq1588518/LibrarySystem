using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using BLL;
using DAL;
using System.Data.SqlClient;

namespace 图书馆管理系统
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public string user;//获取用户名

        //注册用户事件
        private void linkRegistered_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //显示注册窗体
            frmRegisteredRead fru = new frmRegisteredRead();
            fru.ShowDialog();
        }

        //退出事件
        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
       
        //登录事件
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            Model.Login lg = new Model.Login();
            lg.Username = tbUsername.Text.Trim();
            lg.Password = tbPassword.Text.Trim();
            //实例化BLL（业务层）类库的Login类并传入参数
            string a = BLL.LoginBLL.sysLogin(lg);
            //获取用户名
            SqlDataReader dr = SqlHelper.ExecuteReader(SqlHelper.ConnectionStringLocalTransaction, CommandType.Text, "select * from View_Admin where 学号工号='" + lg.Username + "' and 密码='" + lg.Password + "'");
            while (dr.Read())
            {
                user = dr["姓名"].ToString();
            }
//--------------------------------超级管理员----------------------------------------
            if (a == "超级管理员登录成功" && cbType.Text == "管理员")
            {
               // MessageBox.Show(a, "提示", MessageBoxButtons.OK);
                this.Hide();
                frmMain fm = new frmMain(2, user);
                fm.ShowDialog();
            }
            else if (a == "超级管理员登录成功" && cbType.Text == "读者")
            {
               // MessageBox.Show("读者登录成功", "提示", MessageBoxButtons.OK);
                this.Hide();
            }

//--------------------------------普通管理员----------------------------------------
            else if (a == "普通管理员登录成功" && cbType.Text == "管理员")
            {
               // MessageBox.Show(a, "提示", MessageBoxButtons.OK);
                this.Hide();
                frmMain fm = new frmMain(1, user);
                fm.ShowDialog();
            }
            else if (a == "普通管理员登录成功" && cbType.Text == "读者")
            {
                MessageBox.Show("读者登录成功", "提示", MessageBoxButtons.OK);
                this.Hide();
            }

//--------------------------------读者----------------------------------------------
            else if (a == "读者登录成功" && cbType.Text == "读者")
            {
                //MessageBox.Show(a, "提示", MessageBoxButtons.OK);
                this.Hide();
            }
//--------------------------------失败----------------------------------------------
            else
            {
                MessageBox.Show("登录失败", "提示");
            }
        }
    }
}
