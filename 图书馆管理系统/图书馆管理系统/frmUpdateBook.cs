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
    public partial class frmUpdateBook : Form
    {
        public delegate void testdelegate(object sender);//定义委托类型
        public event testdelegate testevent;//定义委托事件

        public frmUpdateBook(Model.BookInfo bi)
        {
            InitializeComponent();

        #region 显示要修改的信息

            cbSortId.Text = bi.CbSortId;
            SqlDataReader dr= BLL.SortBLL.sysShowSortMemo(bi.CbSortId);
            while(dr.Read())
            {
                tbSortExplanation.Text = dr["类别说明"].ToString();
            }
            tbBookName.Text = bi.TbBookName;
            tbBookISBN.Text = bi.TbBookISBN;
            tbBookAuthor.Text = bi.TbBookAuthor;
            tbBookPress.Text = bi.TbBookPress;
            tbBookPrice.Text = bi.TbBookPrice;
            tbBookPage.Text = bi.TbBookPage.ToString();
            dtpPDate.Value = DateTime.Parse(bi.DtpPDate.ToString());
            //判断选中的等级               
            if (bi.CbBookGrade == 1)
                cbBookGrade.Text = "一级";
            if (bi.CbBookGrade == 2)
                cbBookGrade.Text = "二级";
            if (bi.CbBookGrade == 3)
                cbBookGrade.Text = "三级";
            tbRQuantity.Text = bi.TbRQuantity.ToString();
            dtpPutDate.Value = bi.DtpPutDate;
            tbSQuantity.Text = bi.TbSQuantity.ToString();
            tbBookMark.Text = bi.TbBookMark;  

        #endregion                                 
        }

        //点击显示类别
        private void cbSortId_DropDown(object sender, EventArgs e)
        {
            object a = BLL.BookInfoBLL.sysSelectSort();
            cbSortId.DataSource = a;
            cbSortId.DisplayMember = "类别编号";

            //第一个[]表示显示的行,第二个[]表示显示的列或者直接像第二个一样写数据库里面的字段名
            //tbBookName.Text = ds.Tables[0].Rows[0][0].ToString(); 
            //tbBookMark.Text = ds.Tables[0].Rows[1]["类别编号"].ToString();
        }

        //显示类别说明
        private void cbSortId_SelectedIndexChanged(object sender, EventArgs e)
        {
           //把当前的类别编号传到业务层做处理
          SqlDataReader dr =BLL.SortBLL.sysShowSortMemo(cbSortId.Text);
          while (dr.Read())
          {
              tbSortExplanation.Text = dr[1].ToString();
          }
        }
       
        //保存
        private void btnUpdateBookOK_Click(object sender, EventArgs e)
        {
            try
            {
                #region 保存传值
                Model.BookInfo bi = new Model.BookInfo();
                bi.CbSortId = cbSortId.Text;
                bi.TbBookISBN = tbBookISBN.Text;
                bi.TbBookName = tbBookName.Text;
                bi.TbBookPress = tbBookPress.Text;
                bi.TbBookAuthor = tbBookAuthor.Text;
                bi.TbBookPrice = tbBookPrice.Text;
                bi.TbBookPage = Convert.ToInt32(tbBookPage.Text);
                bi.DtpPDate = dtpPDate.Value;
                //判断选中的等级               
                if (cbBookGrade.Text == "一级")
                    bi.CbBookGrade = 1;
                if (cbBookGrade.Text == "二级")
                    bi.CbBookGrade = 2;
                if (cbBookGrade.Text == "三级")
                    bi.CbBookGrade = 3;
                bi.TbRQuantity = Convert.ToInt32(tbRQuantity.Text);
                bi.DtpPutDate = dtpPutDate.Value;
                bi.TbSQuantity = Convert.ToInt32(tbSQuantity.Text);
                bi.TbBookMark = tbBookMark.Text;
                #endregion
                string a = BLL.BookInfoBLL.sysBookInfo(2, bi);
                if (a == "图书信息修改成功!")
                {
                    MessageBox.Show(a, "提示");
                    this.Close();
                    //委托事件
                    testevent(null);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //取消
        private void btnUpdateBookClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //焦点落在剩余数量上时 提示信息
        private void tbSQuantity_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("如果你执意要修改这里,我也不强求,只是你要主动承担后果","提示");
        }
    }
}
