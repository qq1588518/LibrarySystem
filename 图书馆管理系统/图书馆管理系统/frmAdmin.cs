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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();

        }
        //绑定数据源
        public BindingSource bsAdmin = new BindingSource();

        //窗体加载时
        private void frmAddAdmin_Load(object sender, EventArgs e)
        {
            ShowbsAdmin();
            //默认选中普通管理员
            rbAdmin.Checked = true;
        }

        //刷新显示列表方法
        public void ShowbsAdmin()
        {
            bsAdmin.DataSource = BLL.BookInfoBLL.sysPaging(11, 0);
            bindingNavigatorAdmin.BindingSource = bsAdmin;
            dgvAdmin.DataSource = bsAdmin;
            SqlHelper.AutoSizeColumn(dgvAdmin);
        }

        //选择管理员
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmIsbnReadBook fr = new frmIsbnReadBook("读者");
            fr.Readevent += new frmIsbnReadBook.Readdelegate(fr_Readevent);
            fr.ShowDialog();
        }
        //读者选择学号传递委托
        void fr_Readevent(string value)
        {
            //当前学号文本框值赋值为委托传递过来的值 也就是选择好的id
            this.tbAdminID.Text = value;

        }

        //添加
        private void btnAdminOK_Click(object sender, EventArgs e)
        {
            if (tbPassWord.Text == tbAdminPassWordOK.Text)
            {
                try
                {
                    Model.Admin ai = new Model.Admin();
                    ai.TbAdminID = this.tbAdminID.Text;
                    //判断选择的是什么级别的管理员
                    if (rbSuperAdmin.Checked == true)
                        ai.AdminType = 2;
                    if (rbAdmin.Checked == true)
                        ai.AdminType = 1;
                    ai.TbAdminPassWordOK = this.tbAdminPassWordOK.Text.Trim();
                    ai.CbDisable = "否";
                    string a = BLL.AdminBLL.sysAdmin(1, ai);
                    MessageBox.Show(a, "提示");
                    //刷新
                    ShowbsAdmin();
                    //清除值
                    ClearAdmin();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        MessageBox.Show("该管理员已存在!", "提示");
                    }
                }

            }
            else
            {
                MessageBox.Show("两次密码不一致!", "提示");
            }
        }
        //返回
        private void btnAdminClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //清除值方法
        public void ClearAdmin()
        {
            this.tbAdminID.Clear();
            this.tbAdminPassWordOK.Clear();
            this.tbPassWord.Clear();
        }

        //修改
        private void bindingNavigatorUpdateAdmin_Click(object sender, EventArgs e)
        {
            #region 修改传值

            Model.Admin ai = new Model.Admin();
            ai.TbAdminID = dgvAdmin["学号工号", bsAdmin.Position].Value.ToString();
            ai.TbAdminPassWordOK = dgvAdmin["密码", bsAdmin.Position].Value.ToString();
            ai.AdminType = Convert.ToInt32(dgvAdmin["权限级别", bsAdmin.Position].Value.ToString());
            ai.CbDisable = dgvAdmin["是否停用", bsAdmin.Position].Value.ToString();

            #endregion
            frmUpdateAdmin fua = new frmUpdateAdmin(ai);
            fua.AdminEvent += new frmUpdateAdmin.AdminDelegate(fua_AdminEvent);
            fua.ShowDialog();
        }
        //委托刷新
        void fua_AdminEvent(object value)
        {
            ShowbsAdmin();
        }

        //删除
        private void bindingNavigatorDeleteAdmin_Click(object sender, EventArgs e)
        {
            Model.Admin ai = new Model.Admin();
            ai.TbAdminID = dgvAdmin["学号工号", bsAdmin.Position].Value.ToString();
            ai.TbAdminPassWordOK = "";
            ai.CbDisable = "";
            ai.AdminType = 0;
            if (MessageBox.Show("确定删除'" + ai.TbAdminID + "'该工号管理员一职吗？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string a = BLL.AdminBLL.sysAdmin(3, ai);
                MessageBox.Show(a, "提示");
                ShowbsAdmin();
            }
        }
    }
}
