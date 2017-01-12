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
using DAL;
using System.Threading;

namespace 图书馆管理系统
{
    public partial class frmMain : Form
    {
        public frmMain(int value, string name)
        {
            InitializeComponent();
            //设置搜索框文本颜色
            tstbSearch.ForeColor = Color.Silver;
            tstbBookID.ForeColor = Color.Silver;
            tstbReadInfo.ForeColor = Color.Silver;
            tstbBorrow.ForeColor = Color.Silver;
            tstbBack.ForeColor = Color.Silver;

            //读者登录级别
            AdminLevel = value;
            //用户名
            NameID.Text = name;
            //时间计时器启动
            timerNow.Enabled = true;

            //隐藏图书编号选项卡
            //tabControl1.TabPages[5].Parent = null;
            //this.tabControl1.TabPages.Remove(tabPageBookID);

            //用户名
            this.lbuser.Text = name;
            string str1 = "select count(*) from Bookid";
            object a1 = SqlHelper.ExecuteScalar(SqlHelper.ConnectionStringLocalTransaction, CommandType.Text, str1, null);
            this.lbsumbook.Text = a1.ToString();

            string str2 = "select count(*) from Bookid where 是否借出='是'";
            object a2 = SqlHelper.ExecuteScalar(SqlHelper.ConnectionStringLocalTransaction, CommandType.Text, str2, null);
            this.lbborrowbook.Text = a2.ToString();

            string str3 = "select count(*) from Readinfo";
            object a3 = SqlHelper.ExecuteScalar(SqlHelper.ConnectionStringLocalTransaction, CommandType.Text, str3, null);
            this.lbsumread.Text = a3.ToString();

        }

        #region 定义全局变量

        //声明一个封装数据源对象
        public BindingSource bsBookInfo = new BindingSource();

        //申明一个封装编号入库的数据源对象
        public BindingSource bsBookId = new BindingSource();

        //声明一个封装读者信息的数据源
        public BindingSource bsReadInfo = new BindingSource();

        //声明一个封装借阅信息的数据源
        public BindingSource bsBorrow = new BindingSource();

        //声明一个封装归还信息的数据源
        public BindingSource bsBack = new BindingSource();

        #endregion

        //定义一个数判断用户登录级别显示
        public int AdminLevel;


        #region 欢迎页快捷启动

        //图书
        private void btnBookmanager_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 1;
        }
        //读者
        private void btnReadmanager_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 2;
        }
        //查询
        private void btnSearchmanager_Click(object sender, EventArgs e)
        {
            frmSearch fs = new frmSearch(0);
            fs.ShowDialog();
        }
        //统计
        private void btnStatisticsmanager_Click(object sender, EventArgs e)
        {
            frmStatistical fs = new frmStatistical();
            fs.ShowDialog();
        }
        //借阅
        private void btnBorrowmanager_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 3;
        }
        //缴费
        private void btnBackmanager_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 4;
        }


        #endregion

        //侧边栏样式
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            string text = ((TabControl)sender).TabPages[e.Index].Text;
            SolidBrush brush = new SolidBrush(Color.Black);
            StringFormat sf = new StringFormat(StringFormatFlags.DirectionRightToLeft);
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;
            e.Graphics.DrawString(text, SystemInformation.MenuFont, brush, e.Bounds, sf);
        }
        //侧边栏向左
        private void 侧边栏在左ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl1.Alignment = TabAlignment.Left;
            this.侧边栏在右ToolStripMenuItem.Checked = false;
            this.侧边栏在左ToolStripMenuItem.Checked = true;
        }
        //侧边栏向右
        private void 侧边栏在右ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl1.Alignment = TabAlignment.Right;
            this.侧边栏在左ToolStripMenuItem.Checked = false;
            this.侧边栏在右ToolStripMenuItem.Checked = true;
        }


        //选项卡切换时加载事件
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            try
            {
                //切换选项卡时 分页显示不同
                if (e.TabPage == tabPageBookInfo)
                {
                    bsBookInfoDateSource();
                    SqlHelper.AutoSizeColumn(dgvBookInfo);
                    tstbSearch.ForeColor = Color.Silver;
                }
                else if (e.TabPage == tabPageBookID)
                {
                    bsBookIdDateSource();
                    SqlHelper.AutoSizeColumn(dgvBookID);
                }
                else if (e.TabPage == tabPageReadInfo)
                {
                    bsReadInfoDateSource();
                    SqlHelper.AutoSizeColumn(dgvReadInfo);
                }
                else if (e.TabPage == tabPageBorrow)
                {
                    bsBorrowDateSource();
                    SqlHelper.AutoSizeColumn(dgvBorrow);
                }
                else if (e.TabPage == tabPageBack)
                {
                    bsBackDateSource();
                    SqlHelper.AutoSizeColumn(dgvBack);
                }
                else if (e.TabPage == tabPageShow)
                {
                    string str1 = "select count(*) from Bookid";
                    object a1 = SqlHelper.ExecuteScalar(SqlHelper.ConnectionStringLocalTransaction, CommandType.Text, str1, null);
                    this.lbsumbook.Text = a1.ToString();

                    string str2 = "select count(*) from Bookid where 是否借出='是'";
                    object a2 = SqlHelper.ExecuteScalar(SqlHelper.ConnectionStringLocalTransaction, CommandType.Text, str2, null);
                    this.lbborrowbook.Text = a2.ToString();

                    string str3 = "select count(*) from Readinfo";
                    object a3 = SqlHelper.ExecuteScalar(SqlHelper.ConnectionStringLocalTransaction, CommandType.Text, str3, null);
                    this.lbsumread.Text = a3.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //窗体加载
        private void frmMain_Load(object sender, EventArgs e)
        {
            //窗体加载 图书信息列表显示指定的10条记录
            bsBookInfoDateSource();
            tsbPreviousPage.Enabled = false;

            //判断用户
            if (AdminLevel == 1)
            {
                设置ToolStripMenuItem.Visible = false;
                管理员ToolStripMenuItem.Visible = false;
                this.Text = Text + "(普通管理员)";
            }
            if (AdminLevel == 2)
            {
                this.Text = Text + "(超级管理员)";
            }
        }

        //当前时间
        private void timerNow_Tick(object sender, EventArgs e)
        {
            NowDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }


        #region 点击按钮显示各个菜单的事件

        //注销窗体事件
        private void 注销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin fl = new frmLogin();
            fl.ShowDialog();

        }

        //退出窗体事件
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        //关闭主窗体事件
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        #region 类别管理

        //添加类别事件
        private void 添加类别ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateBookSort faubs = new frmAddUpdateBookSort("(添加)", "添加");
            faubs.ShowDialog();
        }

        //修改类别事件
        private void 修改类别ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateBookSort faubs = new frmAddUpdateBookSort("(修改)", "保存");
            faubs.Show();
        }

        //删除类别
        private void 删除类别ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateBookSort faubs = new frmAddUpdateBookSort("(删除)", "删除");
            faubs.ShowDialog();
        }

        #endregion

        #region 图书管理

        //添加图书
        private void 添加图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 1;
        }
        //修改图书
        private void 修改图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            #region 修改图书传值
            Model.BookInfo bi = new Model.BookInfo();
            bi.CbSortId = dgvBookInfo[0, bsBookInfo.Position].Value.ToString().Trim();
            bi.TbBookName = dgvBookInfo[1, bsBookInfo.Position].Value.ToString().Trim();
            bi.TbBookISBN = dgvBookInfo[2, bsBookInfo.Position].Value.ToString().Trim();
            bi.TbBookAuthor = dgvBookInfo[3, bsBookInfo.Position].Value.ToString().Trim();
            bi.TbBookPress = dgvBookInfo[4, bsBookInfo.Position].Value.ToString().Trim();
            bi.TbBookPrice = dgvBookInfo[5, bsBookInfo.Position].Value.ToString().Trim();
            bi.TbBookPage = Convert.ToInt32(dgvBookInfo[6, bsBookInfo.Position].Value);
            bi.DtpPDate = DateTime.Parse(dgvBookInfo[7, bsBookInfo.Position].Value.ToString());
            bi.CbBookGrade = Convert.ToInt32(dgvBookInfo[8, bsBookInfo.Position].Value);
            bi.TbBookMark = dgvBookInfo[9, bsBookInfo.Position].Value.ToString().Trim();
            bi.DtpPutDate = DateTime.Parse(dgvBookInfo[10, bsBookInfo.Position].Value.ToString());
            bi.TbRQuantity = Convert.ToInt32(dgvBookInfo[11, bsBookInfo.Position].Value.ToString().Trim());
            bi.TbSQuantity = Convert.ToInt32(dgvBookInfo[12, bsBookInfo.Position].Value.ToString().Trim());
            #endregion
            frmUpdateBook fub = new frmUpdateBook(bi);
            fub.testevent += new frmUpdateBook.testdelegate(fub_testevent);
            fub.ShowDialog();
        }
        //删除图书
        private void 删除图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 1;
            Model.BookInfo bi = new Model.BookInfo();
            bi.TbBookISBN = dgvBookInfo["ISBN", bsBookInfo.Position].Value.ToString();
            if (MessageBox.Show("确定要删除ISBN号为:'" + bi.TbBookISBN + "'的该类所有图书吗！？", "温馨提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string a = BLL.BookInfoBLL.sysDelete(1, bi.TbBookISBN);
                if (a == "已删除")
                {
                    MessageBox.Show("删除成功!", "温馨提示");
                    //刷新
                    bsBookInfoDateSource();
                }
                else
                {
                    MessageBox.Show(a, "温馨提示");
                }
            }
        }


        //修改图书编号基本信息
        private void 修改编号ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 5;
            #region 修改编号传值
            Model.BookId bi = new Model.BookId();
            bi.TbBookID = dgvBookID["图书编号", bsBookId.Position].Value.ToString().Trim();
            bi.TbISBN = dgvBookID["ISBN", bsBookId.Position].Value.ToString().Trim();
            bi.CbDamage = dgvBookID["损坏程度", bsBookId.Position].Value.ToString().Trim();
            bi.TbBookIdMemo = dgvBookID["备注", bsBookId.Position].Value.ToString().Trim();
            #endregion
            frmUpdateBookID fubi = new frmUpdateBookID(bi);
            fubi.Bookidevent += new frmUpdateBookID.Bookiddelegate(fubi_Bookidevent);
            fubi.ShowDialog();
        }

        //删除编号
        private void 删除编号ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 5;
            Model.BookId bi = new Model.BookId();
            bi.TbBookID = dgvBookID["图书编号", bsBookId.Position].Value.ToString();
            if (MessageBox.Show("确定要删除图书编号为:'" + bi.TbBookID + "'的图书吗！？", "温馨提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string a = BLL.BookInfoBLL.sysDelete(2, bi.TbBookID);
                if (a == "已删除")
                {
                    MessageBox.Show("删除成功!", "温馨提示");
                    //刷新
                    bsBookIdDateSource();
                }
                else
                {
                    MessageBox.Show(a, "温馨提示");
                }
            }
        }

        #endregion

        #region 读者管理

        //添加读者信息事件
        private void 添加读者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 2;//显示第三个选项卡
        }
        //修改读者信息事件
        private void 修改读者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            #region 修改读者传值
            Model.ReadInfo ri = new Model.ReadInfo();
            ri.TbReadId = dgvReadInfo[0, bsReadInfo.Position].Value.ToString().Trim();
            ri.TbReadName = dgvReadInfo[1, bsReadInfo.Position].Value.ToString().Trim();
            ri.CbbReadSex = dgvReadInfo[2, bsReadInfo.Position].Value.ToString().Trim();
            ri.CbbReadPost = Convert.ToInt32(dgvReadInfo[3, bsReadInfo.Position].Value);
            ri.CbbReadDepartment = dgvReadInfo[4, bsReadInfo.Position].Value.ToString().Trim();
            ri.TbReadClass = dgvReadInfo[5, bsReadInfo.Position].Value.ToString().Trim();
            ri.TbReadPhone = dgvReadInfo[6, bsReadInfo.Position].Value.ToString().Trim();
            ri.TbReadNumberId = dgvReadInfo[7, bsReadInfo.Position].Value.ToString().Trim();
            ri.DtpReadRegister = DateTime.Parse(dgvReadInfo[8, bsReadInfo.Position].Value.ToString());
            ri.TbReadMark = dgvReadInfo[9, bsReadInfo.Position].Value.ToString().Trim();
            ri.TbPassWord = dgvReadInfo["密码", bsReadInfo.Position].Value.ToString().Trim();
            #endregion
            frmUpdateRead fur = new frmUpdateRead(ri);
            fur.Readevent += new frmUpdateRead.Readdelegate(fur_Readevent);
            fur.ShowDialog();
        }
        //删除读者
        private void 删除读者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 2;
            Model.ReadInfo ri = new Model.ReadInfo();
            ri.TbReadId = dgvReadInfo["学号工号", bsReadInfo.Position].Value.ToString();
            if (MessageBox.Show("确定要删除学号/工号为:'" + ri.TbReadId + "'的所有借阅信息吗！？", "温馨提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string a = BLL.BookInfoBLL.sysDelete(3, ri.TbReadId);
                if (a == "已删除")
                {
                    MessageBox.Show("删除成功!", "温馨提示");
                    //刷新
                    bsReadInfoDateSource();
                }
                else
                {
                    MessageBox.Show(a, "温馨提示");
                }
            }
        }

        #endregion

        #region 查询管理

        //图书查询
        private void 图书查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearch fs = new frmSearch(0);
            fs.ShowDialog();
        }
        //读者查询
        private void 读者查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearch fs = new frmSearch(1);
            fs.ShowDialog();
        }

        //借阅查询
        private void 借阅查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearch fs = new frmSearch(2);
            fs.ShowDialog();
        }

        #endregion


        #region 打印报表事件

        private void 图书罚款表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrintReport fpr = new frmPrintReport("图书罚款打印");
            fpr.ShowDialog();
        }

        private void 图书损坏表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrintReport fpr = new frmPrintReport("图书丢失打印");
            fpr.ShowDialog();
        }

        private void 用户注销表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrintReport fpr = new frmPrintReport("用户注销打印");
            fpr.ShowDialog();
        }

        #endregion

        //管理员(添加,修改,删除)
        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin fa = new frmAdmin();
            fa.ShowDialog();
        }

        #region 设置

        //设置读者级别显示
        private void 读者级别ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSetUp su = new frmSetUp(0);
            su.ShowDialog();
        }

        //设置罚款单价
        private void 罚款单价ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSetUp su = new frmSetUp(1);
            su.ShowDialog();
        }

        #endregion

        #region 管理员

        //统计
        private void 统计ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmStatistical fs = new frmStatistical();
            fs.ShowDialog();
        }

        #endregion


        #endregion


        #region 图书信息

        /// <summary>
        /// 图书信息的上一页下一页的页码 默认为1
        /// </summary>
        public int i = 1;

        /// <summary>
        /// 绑定图书信息数据源方法
        /// </summary>
        public void bsBookInfoDateSource()
        {
            //这里把分页查询的数据 封装起来赋值给列表显示 以便调用 减少冗余
            bsBookInfo.DataSource = BLL.BookInfoBLL.sysPaging(1, i);
            dgvBookInfo.DataSource = bsBookInfo;
        }

        //确定添加图书信息
        private void btnAddBookOK_Click(object sender, EventArgs e)
        {
            try
            {
                //把图书信息的值存放在Model类库的AddBookInfo类下
                Model.BookInfo abf = new Model.BookInfo();
                abf.CbSortId = cbSortId.Text;
                abf.TbBookName = tbBookName.Text;
                abf.TbBookISBN = tbBookISBN.Text;
                abf.TbBookAuthor = tbBookAuthor.Text;
                abf.TbBookPress = tbBookPress.Text;
                abf.TbBookPrice = tbBookPrice.Text;
                abf.DtpPDate = dtpPDate.Value;
                //判断选中的等级               
                if (cbBookGrade.Text == "一级")
                    abf.CbBookGrade = 1;
                if (cbBookGrade.Text == "二级")
                    abf.CbBookGrade = 2;
                if (cbBookGrade.Text == "三级")
                    abf.CbBookGrade = 3;
                abf.TbBookMark = tbBookMark.Text;
                abf.TbBookPage = Convert.ToInt32(tbBookPage.Text);
                abf.DtpPutDate = dtpPutDate.Value;
                abf.TbRQuantity = Convert.ToInt32(tbRQuantity.Text);
                abf.TbSQuantity = Convert.ToInt32(tbSQuantity.Text); //入库数量==剩余数量
                //判断返回值
                string a = BLL.BookInfoBLL.sysBookInfo(1, abf);
                if (a == "入库成功!")
                {
                    MessageBox.Show(a, "温馨提示");
                    //刷新显示
                    bsBookInfoDateSource();
                    ClearBookInfo();
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)//主键重复
                {
                    MessageBox.Show("你输入ISBN号已存在!", "温馨提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "温馨提示");
            }
        }

        //点击类别编号文本框事件
        private void cbSortId_DropDown(object sender, EventArgs e)
        {
            //实例化 
            object a = BLL.BookInfoBLL.sysSelectSort();
            cbSortId.DataSource = a;
            cbSortId.DisplayMember = "类别编号";
        }

        //显示类别说明
        private void cbSortId_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader dr = BLL.SortBLL.sysShowSortMemo(cbSortId.Text);
            while (dr.Read())
            {
                tbSortExplanation.Text = dr["类别说明"].ToString();
            }
        }

        //初始化剩余数量
        private void tbRQuantity_Leave(object sender, EventArgs e)
        {
            tbSQuantity.Text = tbRQuantity.Text;
        }

        //取消
        private void btnAddBookClose_Click(object sender, EventArgs e)
        {
            ClearBookInfo();
        }

        //图书信息上一页
        private void tsbPreviousPage_Click(object sender, EventArgs e)
        {
            i -= 1;
            if (i != 0)
            {
                bsBookInfoDateSource();
                tsbNextPage.Enabled = true; //启用下一页
            }
            if (i == 1)
            {
                //当页数为为时 禁用按钮
                tsbPreviousPage.Enabled = false;
            }
        }

        //图书信息下一页
        private void tsbNextPage_Click(object sender, EventArgs e)
        {
            try
            {
                i += 1;
                if (i > 1)
                {
                    bsBookInfoDateSource();
                    tsbPreviousPage.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("亲！没有记录了哦", "温馨提示");
                tsbNextPage.Enabled = false; //禁用下一页
            }
        }

        //图书修改
        private void tsbUpdateBook_Click_1(object sender, EventArgs e)
        {
            #region //修改传值
            Model.BookInfo bi = new Model.BookInfo();
            bi.CbSortId = dgvBookInfo[0, bsBookInfo.Position].Value.ToString().Trim();
            bi.TbBookName = dgvBookInfo[1, bsBookInfo.Position].Value.ToString().Trim();
            bi.TbBookISBN = dgvBookInfo[2, bsBookInfo.Position].Value.ToString().Trim();
            bi.TbBookAuthor = dgvBookInfo[3, bsBookInfo.Position].Value.ToString().Trim();
            bi.TbBookPress = dgvBookInfo[4, bsBookInfo.Position].Value.ToString().Trim();
            bi.TbBookPrice = dgvBookInfo[5, bsBookInfo.Position].Value.ToString().Trim();
            bi.TbBookPage = Convert.ToInt32(dgvBookInfo[6, bsBookInfo.Position].Value);
            bi.DtpPDate = DateTime.Parse(dgvBookInfo[7, bsBookInfo.Position].Value.ToString());
            bi.CbBookGrade = Convert.ToInt32(dgvBookInfo[8, bsBookInfo.Position].Value);
            bi.TbBookMark = dgvBookInfo[9, bsBookInfo.Position].Value.ToString().Trim();
            bi.DtpPutDate = DateTime.Parse(dgvBookInfo[10, bsBookInfo.Position].Value.ToString());
            bi.TbRQuantity = Convert.ToInt32(dgvBookInfo[11, bsBookInfo.Position].Value.ToString().Trim());
            bi.TbSQuantity = Convert.ToInt32(dgvBookInfo[12, bsBookInfo.Position].Value.ToString().Trim());
            #endregion
            //实例化 修改窗体 传入参数
            frmUpdateBook fub = new frmUpdateBook(bi);
            fub.testevent += new frmUpdateBook.testdelegate(fub_testevent);
            fub.ShowDialog();
        }

        //图书注销
        private void tsbLogoutBook_Click(object sender, EventArgs e)
        {
            try
            {
                #region 注销传值
                Model.BookInfo bi = new Model.BookInfo();
                bi.CbSortId = dgvBookInfo[0, bsBookInfo.Position].Value.ToString().Trim();
                bi.TbBookName = dgvBookInfo[1, bsBookInfo.Position].Value.ToString().Trim();
                bi.TbBookISBN = dgvBookInfo[2, bsBookInfo.Position].Value.ToString().Trim();
                bi.TbBookAuthor = dgvBookInfo[3, bsBookInfo.Position].Value.ToString().Trim();
                bi.TbBookPress = dgvBookInfo[4, bsBookInfo.Position].Value.ToString().Trim();
                bi.TbBookPrice = dgvBookInfo[5, bsBookInfo.Position].Value.ToString().Trim();
                bi.TbBookPage = Convert.ToInt32(dgvBookInfo[6, bsBookInfo.Position].Value);
                bi.DtpPDate = DateTime.Parse(dgvBookInfo[7, bsBookInfo.Position].Value.ToString());
                bi.CbBookGrade = Convert.ToInt32(dgvBookInfo[8, bsBookInfo.Position].Value);
                bi.TbBookMark = dgvBookInfo[9, bsBookInfo.Position].Value.ToString().Trim();
                bi.DtpPutDate = DateTime.Parse(dgvBookInfo[10, bsBookInfo.Position].Value.ToString());
                bi.TbRQuantity = Convert.ToInt32(dgvBookInfo[11, bsBookInfo.Position].Value.ToString().Trim());
                bi.TbSQuantity = Convert.ToInt32(dgvBookInfo[12, bsBookInfo.Position].Value.ToString().Trim());
                #endregion
                if (MessageBox.Show("确定要注销ISBN号为:'" + bi.TbBookISBN + "'的该类图书信息吗?", "温馨提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string a = BLL.BookInfoBLL.sysBookInfo(3, bi);
                    if (a == "注销成功!")
                    {
                        MessageBox.Show(a, "温馨提示");
                        bsBookInfoDateSource();
                    }
                    else if (a == "还有书没还")
                    {
                        MessageBox.Show("该ISBN号下有借出的图书,请先归还再注销", "温馨提示");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //图书刷新
        private void tspRefresh_Click(object sender, EventArgs e)
        {
            bsBookInfoDateSource();
        }
        #region 搜索

        //图书搜索焦点进入
        private void tstbSearch_Enter(object sender, EventArgs e)
        {
            if (this.tstbSearch.Text == "憋说话,搜我！")
            {
                this.tstbSearch.Text = "";
            }
        }
        //图书搜索焦点离开
        private void tstbSearch_Leave(object sender, EventArgs e)
        {
            if (this.tstbSearch.Text == "")
            {
                this.tstbSearch.Text = "憋说话,搜我！";
            }
        }
        //回车搜索
        private void tstbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                //实例化传值
                Model.Search sr = new Model.Search();
                sr.TbSearchBookInfo = this.tstbSearch.Text;
                //列表显示
                bsBookInfo.DataSource = BLL.SearchBLL.sysSearchBook(1, sr.TbSearchBookInfo);
                dgvBookInfo.DataSource = bsBookInfo;
            }
        }
        //判断是否文本框为空
        private void tstbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tstbSearch.Text == "")
            {
                //调用刷新事件
                tspRefresh_Click(null, EventArgs.Empty);
            }
        }

        #endregion


        /// <summary>
        /// 清除图书信息方法
        /// </summary>
        private void ClearBookInfo()
        {
            cbSortId.Text = "";
            tbSortExplanation.Clear();
            tbBookName.Clear();
            tbBookISBN.Clear();
            tbBookAuthor.Clear();
            tbBookMark.Clear();
            tbBookPage.Clear();
            tbBookPress.Clear();
            tbBookPrice.Clear();
            tbRQuantity.Clear();
            cbBookGrade.Text = "";
            tbSQuantity.Clear();
        }

        //图书修改传递委托
        void fub_testevent(object sender)
        {
            bsBookInfoDateSource();
        }

        #endregion


        #region 编号信息

        /// <summary>
        /// 编号信息的上一页下一页的页码 默认为1
        /// </summary>
        public int o = 1;

        /// <summary>
        /// 绑定编号信息数据源方法
        /// </summary>
        public void bsBookIdDateSource()
        {
            bsBookId.DataSource = BLL.BookInfoBLL.sysPaging(2, o);
            dgvBookID.DataSource = bsBookId;
        }

        //显示ISBN列表
        private void btnISBN_Click(object sender, EventArgs e)
        {
            frmIsbnReadBook fi = new frmIsbnReadBook("ISBN");
            fi.ISBNevent += new frmIsbnReadBook.ISBNdelegate(fi_ISBNevent);
            fi.ShowDialog();

        }

        //选择ISBN传递委托
        void fi_ISBNevent(string value)
        {
            this.tbISBN.Text = value;
        }

        //确定入库
        private void btnBookId_Click(object sender, EventArgs e)
        {
            try
            {
                Model.BookId bi = new Model.BookId();
                bi.TbBookID = tbBookID.Text;
                bi.TbISBN = tbISBN.Text;
                bi.CbDamage = cbDamage.Text;
                bi.TbBookIdMemo = tbBookIdMemo.Text;
                string a = BLL.BookIdBLL.sysBookID(1, bi);
                if (a == "编号成功!")
                {
                    MessageBox.Show(a, "温馨提示");
                    this.tbBookID.Clear();
                    this.tbISBN.Clear();
                    this.cbDamage.Text = "";
                    this.tbBookIdMemo.Clear();
                    bsBookIdDateSource();
                }
                else
                {
                    MessageBox.Show(a, "温馨提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "温馨提示");
            }
        }

        //取消按钮 清除文本框内容
        private void btnBooKIdClose_Click(object sender, EventArgs e)
        {
            this.tbBookID.Clear();
            this.tbISBN.Clear();
        }

        //编号信息上一页
        private void tsbBookidPreviousPage_Click(object sender, EventArgs e)
        {
            try
            {
                o -= 1;
                if (o != 0)
                {
                    bsBookIdDateSource();
                    tsbBookidNextPage.Enabled = true; //启用下一页
                }
            }
            catch
            {}
            
        }

        //编号信息下一页
        private void tsbBookidNextPage_Click(object sender, EventArgs e)
        {
            o += 1;
            if (o > 1)
            {
                bsBookIdDateSource();
                tsbBookidPreviousPage.Enabled = true;
            }
        }

        //编号修改
        private void tsbUpdateBookID_Click(object sender, EventArgs e)
        {
            #region 修改传值
            Model.BookId bi = new Model.BookId();
            bi.TbBookID = dgvBookID["图书编号", bsBookId.Position].Value.ToString().Trim();
            bi.TbISBN = dgvBookID["ISBN", bsBookId.Position].Value.ToString().Trim();
            bi.CbDamage = dgvBookID["损坏程度", bsBookId.Position].Value.ToString().Trim();
            bi.TbBookIdMemo = dgvBookID["备注", bsBookId.Position].Value.ToString().Trim();
            #endregion
            frmUpdateBookID fubi = new frmUpdateBookID(bi);
            fubi.Bookidevent += new frmUpdateBookID.Bookiddelegate(fubi_Bookidevent);
            fubi.ShowDialog();
        }

        //编号注销
        private void tsbLogoutBookID_Click(object sender, EventArgs e)
        {
            Model.BookId bi = new Model.BookId();
            bi.TbBookID = dgvBookID["图书编号", bsBookId.Position].Value.ToString().Trim();
            bi.TbISBN = "";
            bi.CbDamage = "";
            bi.TbBookIdMemo = "";
            bi.DtpLogoutDate = DateTime.Now;
            string a = BLL.BookIdBLL.sysBookID(3, bi);
            if (MessageBox.Show("确定要注销图书编号为:'" + bi.TbBookID + "'的图书信息吗?", "温馨提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (a == "已注销")
                {
                    MessageBox.Show("如果你能看见“已注销”这三个字,说明真的是注销了...", "温馨提示");
                }
                else if (a == "已存在")
                {
                    MessageBox.Show("该书已经被借出,请先归还再注销", "温馨提示");
                    //if (MessageBox.Show("告诉你一个秘密\n你要注销的这本书已经被\n借出去了\n劝你先收回再注销\n不然亏大了\n当然如果你想要执意要注销它\n并且展示我校实力\n那就点击下面那个“YES”选项\n膨胀吧,word哥", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    //{
                    //    BLL.BookIdBLL.sysBookID(4, bi);
                    //    MessageBox.Show("注销成功!", "提示");
                    //}
                }
                //刷新
                bsBookIdDateSource();
            }
        }

        //编号刷新
        private void tsbBookIDRefresh_Click(object sender, EventArgs e)
        {
            bsBookIdDateSource();
            SqlHelper.AutoSizeColumn(dgvBookID);
        }

        #region 搜索

        //编号搜索焦点进入
        private void tstbBookID_Enter(object sender, EventArgs e)
        {
            if (this.tstbBookID.Text == "憋说话,搜我！")
            {
                this.tstbBookID.Text = "";
            }
        }
        //编号搜索焦点离开
        private void tstbBookID_Leave(object sender, EventArgs e)
        {
            if (this.tstbBookID.Text == "")
            {
                this.tstbBookID.Text = "憋说话,搜我！";
            }
        }
        //回车搜索
        private void tstbBookID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                //实例化传值
                Model.Search sr = new Model.Search();
                sr.TbSearchBookId = this.tstbBookID.Text;
                //列表显示
                bsBookId.DataSource = BLL.SearchBLL.sysSearchBook(2, sr.TbSearchBookId);
                dgvBookID.DataSource = bsBookId;
            }
        }
        //判断是否文本框为空
        private void tstbBookID_TextChanged(object sender, EventArgs e)
        {
            if (tstbBookID.Text == "")
            {
                //调用刷新事件
                tsbBookIDRefresh_Click(null, EventArgs.Empty);
            }
        }

        #endregion


        //编号修改传递委托
        void fubi_Bookidevent(object sender)
        {
            bsBookIdDateSource();
        }

        #endregion


        #region 读者信息

        /// <summary>
        /// 读者信息的上一页下一页的页码 默认为1
        /// </summary>
        public int r = 1;

        /// <summary>
        /// 绑定读者信息数据源方法
        /// </summary>
        public void bsReadInfoDateSource()
        {
            //这里把分页查询的数据 封装起来赋值给列表显示 以便调用 减少冗余
            bsReadInfo.DataSource = BLL.BookInfoBLL.sysPaging(3, r);
            dgvReadInfo.DataSource = bsReadInfo;
        }

        //确定添加读者信息
        private void btnAddReadOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbReadId.Text != "")
                {
                    Model.ReadInfo ri = new Model.ReadInfo();
                    ri.TbReadId = tbReadId.Text.Trim();
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
                    ri.TbReadName = tbReadName.Text.Trim();
                    ri.CbbReadSex = cbbReadSex.Text;
                    ri.CbbReadDepartment = cbbReadDepartment.Text;
                    ri.TbReadClass = tbReadClass.Text;
                    ri.TbReadPhone = tbReadPhone.Text;
                    ri.TbReadNumberId = tbReadNumberId.Text;
                    ri.DtpReadRegister = dtpReadRegister.Value;
                    ri.TbReadMark = tbReadMark.Text;
                    ri.TbPassWord = tbPassWord.Text;
                    //实例化业务层的ReadInfoBLL类的sysAddRead方法               
                    string a = BLL.ReadInfoBLL.sysReadInfo(1, ri);
                    if (a == "添加成功!")
                    {
                        MessageBox.Show(a, "温馨提示");
                        ReadClear();
                        bsReadInfoDateSource();
                    }
                    else
                    {
                        MessageBox.Show("添加读者信息失败！", "温馨提示");
                    }
                }
                else MessageBox.Show("学号不能为空!", "温馨提示");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("亲,该学号或工号已存在", "温馨提示");
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
            ReadClear();
        }

        //上一页
        private void tsbReadPreviousPage_Click(object sender, EventArgs e)
        {
            r -= 1;
            if (r != 0)
            {
                bsReadInfoDateSource();
                tsbReadNextPage.Enabled = true; //启用下一页
            }
            if (r == 1)
            {
                //当页数为为时 禁用按钮
                tsbReadPreviousPage.Enabled = false;
            }
        }

        //下一页
        private void tsbReadNextPage_Click(object sender, EventArgs e)
        {
            try
            {
                r += 1;
                if (r > 1)
                {
                    bsReadInfoDateSource();
                    tsbReadPreviousPage.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("亲！没有记录了哦", "温馨提示");
                tsbReadNextPage.Enabled = false; //禁用下一页
            }
        }

        //读者修改
        private void tsbReadUpadte_Click(object sender, EventArgs e)
        {
            #region 修改读者传值
            Model.ReadInfo ri = new Model.ReadInfo();
            ri.TbReadId = dgvReadInfo[0, bsReadInfo.Position].Value.ToString().Trim();
            ri.TbReadName = dgvReadInfo[1, bsReadInfo.Position].Value.ToString().Trim();
            ri.CbbReadSex = dgvReadInfo[2, bsReadInfo.Position].Value.ToString().Trim();
            ri.CbbReadPost = Convert.ToInt32(dgvReadInfo[3, bsReadInfo.Position].Value);
            ri.CbbReadDepartment = dgvReadInfo[4, bsReadInfo.Position].Value.ToString().Trim();
            ri.TbReadClass = dgvReadInfo[5, bsReadInfo.Position].Value.ToString().Trim();
            ri.TbReadPhone = dgvReadInfo[6, bsReadInfo.Position].Value.ToString().Trim();
            ri.TbReadNumberId = dgvReadInfo[7, bsReadInfo.Position].Value.ToString().Trim();
            ri.DtpReadRegister = DateTime.Parse(dgvReadInfo[8, bsReadInfo.Position].Value.ToString());
            ri.TbReadMark = dgvReadInfo[9, bsReadInfo.Position].Value.ToString().Trim();
            ri.TbPassWord = dgvReadInfo["密码", bsReadInfo.Position].Value.ToString().Trim();
            #endregion
            frmUpdateRead fur = new frmUpdateRead(ri);
            fur.Readevent += new frmUpdateRead.Readdelegate(fur_Readevent);
            fur.ShowDialog();
        }

        //读者注销
        private void tsbLogoutRead_Click(object sender, EventArgs e)
        {
            try
            {
                #region 读者注销传值
                Model.ReadInfo ri = new Model.ReadInfo();
                ri.TbReadId = dgvReadInfo["学号工号", bsReadInfo.Position].Value.ToString().Trim();
                ri.TbReadName = dgvReadInfo[1, bsReadInfo.Position].Value.ToString().Trim();
                ri.CbbReadSex = dgvReadInfo[2, bsReadInfo.Position].Value.ToString().Trim();
                ri.CbbReadPost = Convert.ToInt32(dgvReadInfo[3, bsReadInfo.Position].Value);
                ri.CbbReadDepartment = dgvReadInfo[4, bsReadInfo.Position].Value.ToString().Trim();
                ri.TbReadClass = dgvReadInfo[5, bsReadInfo.Position].Value.ToString().Trim();
                ri.TbReadPhone = dgvReadInfo[6, bsReadInfo.Position].Value.ToString().Trim();
                ri.TbReadNumberId = dgvReadInfo[7, bsReadInfo.Position].Value.ToString().Trim();
                ri.DtpReadRegister = DateTime.Parse(dgvReadInfo[8, bsReadInfo.Position].Value.ToString());
                ri.TbReadMark = dgvReadInfo[9, bsReadInfo.Position].Value.ToString().Trim();
                ri.TbPassWord = dgvReadInfo["密码", bsReadInfo.Position].Value.ToString().Trim();
                #endregion
                if (MessageBox.Show("确定要注销学号/工号为:'" + ri.TbReadId + "'的读者吗?", "温馨提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string a = BLL.ReadInfoBLL.sysReadInfo(3, ri);
                    if (a == "注销成功!")
                    {
                        MessageBox.Show("如果你能看见“已注销”三个字，就说明真的注销了...", "温馨提示");
                        bsReadInfoDateSource();
                    }
                    else
                    {
                        MessageBox.Show(a, "温馨提示");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //刷新
        private void tsbReadRefresh_Click(object sender, EventArgs e)
        {
            bsReadInfoDateSource();
        }

        #region 搜索

        private void tstbReadInfo_Enter(object sender, EventArgs e)
        {
            if (this.tstbReadInfo.Text == "憋说话,搜我！")
            {
                this.tstbReadInfo.Text = "";
            }
        }

        private void tstbReadInfo_Leave(object sender, EventArgs e)
        {
            if (this.tstbReadInfo.Text == "")
            {
                this.tstbReadInfo.Text = "憋说话,搜我！";
            }
        }

        private void tstbReadInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                //实例化传值
                Model.Search sr = new Model.Search();
                sr.TbSearchReadInfo = this.tstbReadInfo.Text;
                //列表显示
                bsReadInfo.DataSource = BLL.SearchBLL.sysSearchBook(3, sr.TbSearchReadInfo);
                dgvReadInfo.DataSource = bsReadInfo;
            }
        }

        private void tstbReadInfo_TextChanged(object sender, EventArgs e)
        {
            if (tstbReadInfo.Text == "")
            {
                //调用刷新事件
                tsbReadRefresh_Click(null, EventArgs.Empty);
            }
        }

        #endregion

        //清除文本框值的方法
        public void ReadClear()
        {
            this.tbReadId.Clear();
            this.cbbReadPost.Text = "";
            this.tbReadName.Clear();
            this.cbbReadSex.Text = "";
            this.cbbReadDepartment.Text = "";
            this.tbReadClass.Clear();
            this.tbReadPhone.Clear();
            this.tbReadNumberId.Clear();
            this.tbReadMark.Clear();
        }

        //读者修改传递委托
        void fur_Readevent(object sender)
        {
            bsReadInfoDateSource();
        }

        #endregion


        #region 借阅信息

        /// <summary>
        /// 借阅信息的上一页下一页的页码 默认为1
        /// </summary>
        public int b = 1;

        /// <summary>
        /// 绑定借阅信息数据源方法
        /// </summary>
        public void bsBorrowDateSource()
        {
            //这里把分页查询的数据 封装起来赋值给列表显示 以便调用 减少冗余
            bsBorrow.DataSource = BLL.BookInfoBLL.sysPaging(4, b);
            dgvBorrow.DataSource = bsBorrow;
        }

        //显示读者信息列表
        private void btnRead_Click(object sender, EventArgs e)
        {
            frmIsbnReadBook fr = new frmIsbnReadBook("读者");
            fr.Readevent += new frmIsbnReadBook.Readdelegate(fr_Readevent);
            fr.ShowDialog();
        }

        //显示图书信息列表
        private void btnBook_Click(object sender, EventArgs e)
        {
            frmIsbnReadBook fr = new frmIsbnReadBook("图书");
            fr.Bookevent += new frmIsbnReadBook.Bookdelegate(fr_Bookevent);
            fr.ShowDialog();
        }

        //读者选择学号传递委托
        void fr_Readevent(string value)
        {
            //当前学号文本框值赋值为委托传递过来的值 也就是选择好的id
            this.tbBorrowReadId.Text = value;

        }

        //读者选择图书传递委托
        void fr_Bookevent(string value)
        {
            //当前图书编号文本框值赋值为委托传递过来的值 也就是选择好的图书id
            this.tbBorrowBookId.Text = value;
        }

        //借阅
        private void btnBorrowOK_Click(object sender, EventArgs e)
        {
            try
            {
                Model.BorrowInfo br = new Model.BorrowInfo();
                br.TbBorrowReadId = this.tbBorrowReadId.Text;
                br.TbBorrowBookId = this.tbBorrowBookId.Text;
                string a = BLL.BorrowBLL.sysBorrow(1, br);
                if (MessageBox.Show(a, "温馨提示", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    // 清空文本框值
                    this.tbBorrowReadId.Clear();
                    this.tbBorrowBookId.Clear();
                    //刷新列表
                    bsBorrowDateSource();
                }
            }
            //catch (SqlException ex)
            //{
            //    if (ex.Number == 3609)//事务在触发器中结束 触发器返回错误码3609
            //    {
            //        MessageBox.Show("注意,由于该读者级别问题，不能借此书","温馨提示");
            //    }
            //}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //取消
        private void btnBorrowClose_Click(object sender, EventArgs e)
        {
            this.tbBorrowReadId.Clear();
            this.tbBorrowBookId.Clear();
        }

        //上一页
        private void tsbBorrowPreviousPage_Click(object sender, EventArgs e)
        {
            b -= 1;
            if (b != 0)
            {
                bsBorrowDateSource();
                tsbBorrowNextPage.Enabled = true; //启用下一页
            }
            if (b == 1)
            {
                //当页数为为时 禁用按钮
                tsbBorrowPreviousPage.Enabled = false;
            }
        }

        //下一页
        private void tsbBorrowNextPage_Click(object sender, EventArgs e)
        {
            try
            {
                b += 1;
                if (b > 1)
                {
                    bsBorrowDateSource();
                    tsbBorrowPreviousPage.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("亲！没有记录了哦", "温馨提示");
                tsbBorrowNextPage.Enabled = false; //禁用下一页
            }
        }

        //续借
        private void tsbBorrowRenew_Click(object sender, EventArgs e)
        {
            try
            {
                Model.BorrowInfo bi = new Model.BorrowInfo();
                bi.TbBorrowBookId = dgvBorrow["图书编号", bsBorrow.Position].Value.ToString();
                bi.TbBorrowReadId = dgvBorrow["学号工号", bsBorrow.Position].Value.ToString();
                if (MessageBox.Show("确定要续借编号为：'" + bi.TbBorrowBookId + "'的图书吗!?", "温馨提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string a = BLL.BorrowBLL.sysBorrow(2, bi);
                    if (MessageBox.Show(a, "温馨提示", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        // 清空文本框值
                        this.tbBorrowReadId.Clear();
                        this.tbBorrowBookId.Clear();
                        //刷新列表
                        bsBorrowDateSource();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //归还图书
        private void tsbBorrowReturn_Click(object sender, EventArgs e)
        {
            try
            {
                #region 归还传值
                Model.Back bc = new Model.Back();
                bc.TbBackBookId = dgvBorrow["图书编号", bsBorrow.Position].Value.ToString().Trim();
                bc.CbBackDamage = dgvBorrow["损坏程度", bsBorrow.Position].Value.ToString().Trim();
                #endregion
                //显示归还页面
                tabControl1.SelectedIndex = 4;
                //把值传到文本框
                tbBackBookId.Text = bc.TbBackBookId;
                cbBackLost.Text = "否";
                cbBackDamage.Text = bc.CbBackDamage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //刷新
        private void tsbBorrowRefresh_Click(object sender, EventArgs e)
        {
            bsBorrowDateSource();
        }

        #region 搜索

        private void tstbBorrow_Enter(object sender, EventArgs e)
        {
            if (this.tstbBorrow.Text == "憋说话,搜我！")
            {
                this.tstbBorrow.Text = "";
            }
        }
        private void tstbBorrow_Leave(object sender, EventArgs e)
        {
            if (this.tstbBorrow.Text == "")
            {
                this.tstbBorrow.Text = "憋说话,搜我！";
            }
        }
        private void tstbBorrow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                //实例化传值
                Model.Search sr = new Model.Search();
                sr.TbSearchBorrow = this.tstbBorrow.Text;
                //列表显示
                dgvBorrow.DataSource = BLL.SearchBLL.sysSearchBook(4, sr.TbSearchBorrow);
            }
        }
        private void tstbBorrow_TextChanged(object sender, EventArgs e)
        {
            if (tstbBorrow.Text == "")
            {
                //调用刷新事件
                tsbBorrowRefresh_Click(null, EventArgs.Empty);
            }
        }

        #endregion


        #endregion


        #region 归还信息

        /// <summary>
        /// 归还信息的上一页下一页的页码 默认为1
        /// </summary>
        public int k = 1;

        /// <summary>
        /// 绑定归还图书信息数据源方法
        /// </summary>
        public void bsBackDateSource()
        {
            //这里把分页查询的数据 封装起来赋值给列表显示 以便调用 减少冗余
            bsBack.DataSource = BLL.BookInfoBLL.sysPaging(5, k);
            dgvBack.DataSource = bsBack;
        }

        //显示归还图书信息
        private void btnBackBookid_Click(object sender, EventArgs e)
        {
            frmIsbnReadBook firb = new frmIsbnReadBook("图书编号");
            firb.BookIDevent += new frmIsbnReadBook.BookIDdelegate(firb_BookIDevent);
            firb.ShowDialog();
        }

        //归坏选择图书编号传递委托
        void firb_BookIDevent(string value, string Damagevalue)
        {
            this.tbBackBookId.Text = value;
            this.cbBackDamage.Text = Damagevalue;
            this.cbBackLost.Text = "否";
        }

        //归还
        private void btnBackOK_Click(object sender, EventArgs e)
        {
            try
            {
                Model.Back bc = new Model.Back();
                bc.TbBackBookId = this.tbBackBookId.Text;
                bc.CbBackLost = this.cbBackLost.Text;
                bc.CbBackDamage = this.cbBackDamage.Text;
                string a = BLL.BackBLL.sysBack(1, bc);
                MessageBox.Show(a.ToString(), "温馨提示", MessageBoxButtons.OKCancel);

                //清除值
                this.tbBackBookId.Clear();
                this.cbBackLost.Text = "";
                this.cbBackDamage.Text = "";
                this.tbBackMemo.Clear();
                //刷新
                bsBackDateSource();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //上一页
        private void tsbBackPreviousPage_Click(object sender, EventArgs e)
        {
            k -= 1;
            if (k != 0)
            {
                bsBackDateSource();
                tsbBackNextPage.Enabled = true; //启用下一页
            }
            if (k == 1)
            {
                //当页数为为时 禁用按钮
                tsbBackPreviousPage.Enabled = false;
            }
        }

        //下一页
        private void tsbBackNextPage_Click(object sender, EventArgs e)
        {
            try
            {
                k += 1;
                if (k > 1)
                {
                    bsBackDateSource();
                    tsbBackPreviousPage.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("亲！没有记录了哦", "温馨提示");
                tsbBackNextPage.Enabled = false; //禁用下一页
            }
        }

        //刷新
        private void tsbBackRefresh_Click(object sender, EventArgs e)
        {
            bsBackDateSource();
        }

        //罚款缴费
        private void tsbBackFine_Click(object sender, EventArgs e)
        {
            try
            {
                this.tabControl1.SelectedIndex = 4;
                Model.Payment pt = new Model.Payment();
                pt.TbPaymentBookId = dgvBack["图书编号", bsBack.Position].Value.ToString();
                pt.TbPaymentBookName = dgvBack["图书名称", bsBack.Position].Value.ToString();
                pt.TbPaymentReadId = dgvBack["学号工号", bsBack.Position].Value.ToString();
                pt.TbPaymentReadName = dgvBack["姓名", bsBack.Position].Value.ToString();
                pt.TbPaymentMemo = dgvBack["备注", bsBack.Position].Value.ToString();
                pt.TbPaymentSum = dgvBack["罚款金额", bsBack.Position].Value.ToString();
                pt.Serialnumber = Convert.ToInt32(dgvBack["罚金序号", bsBack.Position].Value.ToString());



                frmPayment fp = new frmPayment(pt);
                fp.Updateevent += new frmPayment.UpdateDelegate(fp_Updateevent);
                fp.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("亲,该图书不用罚款！！！", "温馨温馨提示");
            }
        }
        //罚款委托刷新
        void fp_Updateevent(EventArgs e)
        {
            bsBackDateSource();
        }

        #region 搜索

        private void tstbBack_Enter(object sender, EventArgs e)
        {
            if (this.tstbBack.Text == "憋说话,搜我！")
            {
                this.tstbBack.Text = "";
            }
        }
        private void tstbBack_Leave(object sender, EventArgs e)
        {
            if (this.tstbBack.Text == "")
            {
                this.tstbBack.Text = "憋说话,搜我！";
            }
        }
        private void tstbBack_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                //实例化传值
                Model.Search sr = new Model.Search();
                sr.TbSearchBack = this.tstbBack.Text;
                //列表显示
                dgvBack.DataSource = BLL.SearchBLL.sysSearchBook(5, sr.TbSearchBack);
            }
        }
        private void tstbBack_TextChanged(object sender, EventArgs e)
        {
            if (tstbBack.Text == "")
            {
                //调用刷新事件
                tsbBackRefresh_Click(null, EventArgs.Empty);
            }
        }

        #endregion

        #endregion


    }
}
