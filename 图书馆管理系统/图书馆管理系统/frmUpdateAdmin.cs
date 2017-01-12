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
    public partial class frmUpdateAdmin : Form
    {
        public delegate void AdminDelegate(object value);
        public event AdminDelegate AdminEvent;

        public frmUpdateAdmin(Model.Admin ai)
        {
            InitializeComponent();

            #region 修改传值
            
            this.tbAdminID.Text = ai.TbAdminID;
            this.tbAdminPassWordOK.Text = ai.TbAdminPassWordOK;
            this.tbPassWord.Text = ai.TbAdminPassWordOK;
            if (ai.AdminType == 1)
               this.rbAdmin.Checked = true;
            if (ai.AdminType == 2)
                this.rbSuperAdmin.Checked = true;
            if (ai.CbDisable == "是")
                this.cbDisable.Checked = true;
            if (ai.CbDisable == "否")
                this.cbDisable.Checked = false;

            #endregion
        }

        //保存
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.tbPassWord.Text == this.tbAdminPassWordOK.Text)
            {
                Model.Admin ai = new Model.Admin();
                ai.TbAdminID = this.tbAdminID.Text;
                if (rbAdmin.Checked == true)
                    ai.AdminType = 1;
                if (rbSuperAdmin.Checked == true)
                    ai.AdminType = 2;
                ai.TbAdminPassWordOK = this.tbAdminPassWordOK.Text;
                if (cbDisable.Checked == true)
                    ai.CbDisable = "是";
                if (cbDisable.Checked == false)
                    ai.CbDisable = "否";

                string a=  BLL.AdminBLL.sysAdmin(2,ai);
                MessageBox.Show(a, "提示");
                //委托
                AdminEvent(null);
                this.Close();
            }
            else 
            {
                MessageBox.Show("密码不一致!", "提示");
            }
        }

        //返回
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
