using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using System.Data.SqlClient;

namespace 图书馆管理系统
{
    public partial class frmRegisteredRead : Form
    {
        public frmRegisteredRead()
        {
            InitializeComponent();
        }

        //注册取消事件
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //注册确定事件
        private void btOK_Click(object sender, EventArgs e)
        {
            if(tbReadId.Text!="")
                if(cbReadLevel.Text!="")
                    if(tbPassWord.Text!="")
                        if (tbPassWordOK.Text != "")
                            if (tbName.Text != "")
                                if (cbSex.Text != "")
                                    if (cbDepartment.Text != "")
                                        if (tbClass.Text != "")
                                            if (tbPhone.Text != "")
                                                if (tbIDNumber.Text != "")
                                                    {                                                    
                                                        Model.RegisteredRead ru = new RegisteredRead();
                                                        ru.TbReadId = this.tbReadId.Text;
                                                        //判断选中的等级                                                     
                                                        if (this.cbReadLevel.Text == "一级")
                                                        ru.CbReadLevel = 1;
                                                        if (this.cbReadLevel.Text == "二级")
                                                        ru.CbReadLevel = 2;
                                                        if (this.cbReadLevel.Text == "三级")
                                                        ru.CbReadLevel = 3;
                                                        ru.TbPassWordOK = this.tbPassWordOK.Text;
                                                        ru.TbName = this.tbName.Text;
                                                        ru.CbSex = this.cbSex.Text;
                                                        ru.CbDepartment = this.cbDepartment.Text;
                                                        ru.TbClass = this.tbClass.Text;
                                                        ru.TbPhone = this.tbPhone.Text;
                                                        ru.TbIDNumber = this.tbIDNumber.Text;
                                                        ru.DtpRegistration = DateTime.Parse(this.dtpRegistration.Value.ToString());
                                                        ru.TbMemo = this.tbMemo.Text;
                                                        try
                                                        {
                                                            if (tbPassWordOK.Text != tbPassWord.Text)
                                                            {
                                                                lbTsPassWord.Visible = true; //密码不相同时 显示提示信息
                                                                tbPassWordOK.Focus(); //文本框取得焦点
                                                            }
                                                            else
                                                            {
                                                                lbTsPassWord.Visible = false; //重新点击注册按钮时 如果密码正确 隐藏提示
                                                                string a = BLL.RegisteredReadBLL.sysRegisteredRead(ru);
                                                                MessageBox.Show(a, "提示");
                                                                this.Close();
                                                            }
                                                        }
                                                        catch (SqlException ex)
                                                        {
                                                            if (ex.Number == 2627)//主键错误
                                                            {
                                                                MessageBox.Show("你输入的学号或工号已存在!");
                                                            }
                                                            else
                                                            {
                                                                MessageBox.Show(ex.Message);
                                                            }                                                           
                                                        }
                                                       }
                                               else MessageBox.Show("身份证号不能为空!", "提示");
                                           else MessageBox.Show("联系电话不能为空!", "提示");
                                       else MessageBox.Show("班级不能为空!", "提示");
                                   else MessageBox.Show("系别不能为空!", "提示");
                               else MessageBox.Show("性别不能为空!", "提示");
                           else MessageBox.Show("姓名不能为空!", "提示");
                       else MessageBox.Show("确认密码不能为空!", "提示");
                    else MessageBox.Show("密码不能为空!","提示");
                else MessageBox.Show("读者级别不能为空!","提示");
            else MessageBox.Show("学号/工号不能为空!","提示");
        }

    }
}
