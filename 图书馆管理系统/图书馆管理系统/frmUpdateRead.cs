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
    public partial class frmUpdateRead : Form
    {
        public delegate void Readdelegate(object sender);//声明委托
        public event Readdelegate Readevent;//声明委托事件

        public frmUpdateRead(Model.ReadInfo ri)
        {
            InitializeComponent();

        #region 显示要修改的信息
        
            this.tbReadId.Text=ri.TbReadId;
            this.tbReadName.Text=ri.TbReadName; 
            this.cbbReadSex.Text= ri.CbbReadSex;
            if (ri.CbbReadPost == 3)
            {
                this.cbbReadPost.Text = "三级";
            }
            else if (ri.CbbReadPost == 2)
            {
                this.cbbReadPost.Text = "二级";
            }
            else if (ri.CbbReadPost == 1)
            {
                this.cbbReadPost.Text = "一级";
            }
            this.cbbReadDepartment.Text= ri.CbbReadDepartment; 
            this.tbReadClass.Text=ri.TbReadClass; 
            this.tbReadPhone.Text=ri.TbReadPhone; 
            this.tbReadNumberId.Text=ri.TbReadNumberId; 
            this.dtpReadRegister.Value=ri.DtpReadRegister;
            this.tbPassWord.Text = ri.TbPassWord;
            this.tbReadMark.Text = ri.TbReadMark;
            this.tbPassWord.Text = ri.TbPassWord;

        #endregion
        }

        //保存
        private void btnAddReadOK_Click(object sender, EventArgs e)
        {
            try
            {
                #region 保存传值
                Model.ReadInfo ri = new Model.ReadInfo();
                ri.TbReadId = this.tbReadId.Text;
                ri.TbReadName = this.tbReadName.Text;
                ri.CbbReadSex = this.cbbReadSex.Text;
                if (cbbReadPost.Text == "三级")
                {
                    ri.CbbReadPost = 3;
                }
                else if (cbbReadPost.Text == "二级")
                {
                    ri.CbbReadPost = 2;
                }
                else if (cbbReadPost.Text == "一级")
                {
                    ri.CbbReadPost = 1;
                }
                ri.CbbReadDepartment = this.cbbReadDepartment.Text;
                ri.TbReadClass = this.tbReadClass.Text;
                ri.TbReadPhone = this.tbReadPhone.Text;
                ri.TbReadNumberId = this.tbReadNumberId.Text;
                ri.DtpReadRegister = DateTime.Parse(this.dtpReadRegister.Text.ToString());
                ri.TbPassWord = this.tbPassWord.Text;
                ri.TbReadMark = this.tbReadMark.Text;
                ri.TbPassWord = this.tbPassWord.Text;
                #endregion
                string a = BLL.ReadInfoBLL.sysReadInfo(2, ri);
                if (a == "修改成功!")
                {
                    MessageBox.Show(a, "提示");
                    this.Close();
                    //委托事件
                    Readevent(null);
                }
                else 
                {
                    MessageBox.Show("修改失败!", "提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //取消
        private void btnAddReadClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
