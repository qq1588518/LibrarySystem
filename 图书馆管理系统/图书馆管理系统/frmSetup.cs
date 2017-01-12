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
    public partial class frmSetUp : Form
    {
        public frmSetUp(int value)
        {
            InitializeComponent();
            this.tabControl1.SelectedIndex = value;
        }

        //窗体加载时
        private void frmSetUp_Load(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
              showRead();
              this.btnSetUpApp.Enabled = true;
            }
            else if (tabControl1.SelectedIndex == 1)
            {
               showFine();
               this.btnFineApp.Enabled = true;
            }
        }

        //选项卡切换事件
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if(e.TabPage==tabPage1)
            {
                showRead();
            }
            else if (e.TabPage == tabPage2)
            {
               showFine();                
            }
        }

        //显示读者级别方法
        public void showRead()
        {
            SqlConnection con = new SqlConnection(SqlHelper.ConnectionStringLocalTransaction);
            string str = "select * from ReadStandard";
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cbReadLevel.Text = ds.Tables[0].Rows[0][0].ToString();
            nudReadDateNum.Value = Convert.ToInt32(ds.Tables[0].Rows[0][1].ToString());
            cbReadMaxLevel.Text = ds.Tables[0].Rows[0][2].ToString();
            nudBookNum.Value = Convert.ToInt32(ds.Tables[0].Rows[0][3].ToString());
        }

        //显示罚款单价方法
        public void showFine()
        {
            SqlConnection con = new SqlConnection(SqlHelper.ConnectionStringLocalTransaction);
            string str = "select * from FineStandard";
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            tbFineDate.Text = ds.Tables[0].Rows[0][0].ToString();
            tbFineBook.Text = ds.Tables[0].Rows[0][1].ToString();
            tbFineLost.Text = ds.Tables[0].Rows[0][2].ToString();
        }

//--------------------------------------------------------------------------------------------------        

        //读者级别下拉
        private void cbReadLevel_DropDown(object sender, EventArgs e)
        {
            //激活应用按钮
            this.btnSetUpApp.Enabled = true;

            object a = BLL.SetUpBLL.sysSelectReadLevel();
            cbReadLevel.DataSource = a;
            cbReadLevel.DisplayMember = "读者级别";
        }

        //显示
        private void cbReadLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            //激活应用按钮
            this.btnSetUpApp.Enabled = true;

            try
            {
            SqlDataReader dr= BLL.SetUpBLL.sysShowRead(Convert.ToInt32(cbReadLevel.Text));           
                while (dr.Read())
                {
                    this.nudReadDateNum.Value = Convert.ToInt32(dr["可借天数"].ToString());
                    this.cbReadMaxLevel.Text = dr["可借最高级别"].ToString();
                    this.nudBookNum.Value = Convert.ToInt32(dr["可借本数"].ToString());
                }
            }
            catch
            {              
            }
            
        }

        //最高可借级别下拉
        private void cbReadMaxLevel_DropDown(object sender, EventArgs e)
        {
            //激活应用按钮
            this.btnSetUpApp.Enabled = true;         
        }

        //确定
        private void btnSetUpOK_Click(object sender, EventArgs e)
        {
            try
            {
                Model.SetUp su = new Model.SetUp();
                su.CbReadLevel = Convert.ToInt32(this.cbReadLevel.Text);
                su.NudReadDateNum = Convert.ToInt32(this.nudReadDateNum.Value);
                su.CbReadMaxLevel = Convert.ToInt32(this.cbReadMaxLevel.Text);
                su.NudBookNum = Convert.ToInt32(this.nudBookNum.Value);
                BLL.SetUpBLL.sysSetUp(1, su);
                //关闭窗体
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        //取消
        private void btnSetUpClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //应用
        private void btnSetUpApp_Click(object sender, EventArgs e)
        {
            try
            {
                //禁用
                this.btnSetUpApp.Enabled = false; 
          
                Model.SetUp su = new Model.SetUp(); //实体类 封装数据
                su.CbReadLevel = Convert.ToInt32(this.cbReadLevel.Text);
                su.NudReadDateNum = Convert.ToInt32(this.nudReadDateNum.Value);
                su.CbReadMaxLevel = Convert.ToInt32(this.cbReadMaxLevel.Text);
                su.NudBookNum = Convert.ToInt32(this.nudBookNum.Value);

                string a = BLL.SetUpBLL.sysSetUp(1, su); //业务处理层 返回处理完的值
                MessageBox.Show(a, "提示");                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

//--------------------------------------------------------------------------------------------------

        //罚款确定
        private void btnFineOk_Click(object sender, EventArgs e)
        {
            try
            {
                Model.SetUp su = new Model.SetUp();
                su.TbFineBook = Convert.ToDecimal(this.tbFineBook.Text);
                su.TbFineDate = Convert.ToDecimal(this.tbFineDate.Text);
                su.TbFineLost = Convert.ToInt32(this.tbFineLost.Value);
                BLL.SetUpBLL.sysFine(1, su);
                //关闭窗体
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //罚款取消
        private void btnFineClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //罚款应用
        private void btnFineApp_Click(object sender, EventArgs e)
        {
            try
            {
                this.btnFineApp.Enabled = false;

                Model.SetUp su = new Model.SetUp();
                su.TbFineBook = Convert.ToDecimal(this.tbFineBook.Text);
                su.TbFineDate = Convert.ToDecimal(this.tbFineDate.Text);
                su.TbFineLost = Convert.ToInt32(this.tbFineLost.Value);
                string a = BLL.SetUpBLL.sysFine(1, su);
                MessageBox.Show(a, "提示");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

//--------------------------------------------------------------------------------------------------

        private void nudReadDateNum_ValueChanged(object sender, EventArgs e)
        {
            this.btnSetUpApp.Enabled = true;
        }
        private void nudBookNum_ValueChanged(object sender, EventArgs e)
        {
            this.btnSetUpApp.Enabled = true;
        }
        private void tbFineDate_TextChanged(object sender, EventArgs e)
        {
            this.btnFineApp.Enabled = true;
        }
        private void tbFineBook_TextChanged(object sender, EventArgs e)
        {
            this.btnFineApp.Enabled = true;
        }
        private void tbFineLost_ValueChanged(object sender, EventArgs e)
        {
            this.btnFineApp.Enabled = true;
        }
        private void cbReadMaxLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnSetUpApp.Enabled = true;
        }
    }
}
