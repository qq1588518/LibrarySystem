using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DAL;
using System.Data.SqlClient;



namespace 图书馆管理系统
{
    public partial class frmStatistical : Form
    {
        public frmStatistical()
        {
            InitializeComponent();
        }

        public int a;//排名位数

        private void frmSearchMain_Load(object sender, EventArgs e)
        {
            treeViewtStatistical.ExpandAll();                           //树状图默认全部展开
            nudRankNum.Value = 5;                                       //排名位数默认
            chartSum.Series[0].IsVisibleInLegend = false;               //默认不显示图例显示项

            chartSum.Titles.Add("图书借阅统计排行榜");                   //图表标题
            chartSum.ChartAreas[0].AxisY.Title = "数量";                //Y 轴标题  
            chartSum.ChartAreas[0].AxisX.Title = "图书名称";            //X 轴标题  
            chartSum.BackColor = Color.Azure;                          //图片背景色          
            chartSum.ChartAreas[0].Axes[0].MajorGrid.Enabled = false;  //表示取消x轴的网格线
            chartSum.ChartAreas[0].Axes[1].MajorGrid.Enabled = false;  //表示取消y轴的网格线
            //chartSum.Series[0].Palette = ChartColorPalette.SemiTransparent; //柱状图颜色


            //轴刻度间隔大小
            chartSum.ChartAreas[0].AxisX.Interval =1;
            chartSum.ChartAreas[0].AxisY.Interval =10;

            //设置坐标轴粗细 和 颜色  
            chartSum.ChartAreas[0].AxisX.LineColor = Color.Blue;
            chartSum.ChartAreas[0].AxisY.LineColor = Color.Blue;
            chartSum.ChartAreas[0].AxisX.LineWidth = 3;
            chartSum.ChartAreas[0].AxisY.LineWidth = 3;
            

            //默认加载显示
            tbStatistical.Text = "按图书名称";
            chartSum.ChartAreas[0].AxisX.Title = "图书名称"; //X 轴标题                
            chartSum.DataSource = BLL.StatisticalBLL.sysStatisticalBook(1,Convert.ToInt32(nudRankNum.Value));
            chartSum.Series[0].XValueMember = "图书名称";
            chartSum.Series[0].YValueMembers = "数量";
        }

        //统计按钮
        private void btnStatistical_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(nudRankNum.Value); //获取当前排名位数
            chartSum.Series[0].ChartType = SeriesChartType.Column; //默认图表类型
            chartSum.Series[0].IsVisibleInLegend = false;//默认不显示图例显示项
            chartSum.Series[0].Label = "";
            chartSum.Series[0].LegendText = "";
            lbNum.Visible = true;
            nudRankNum.Visible = true;

            if (tbStatistical.Text == "按图书名称")
            {
                chartSum.ChartAreas[0].AxisX.Title = "图书名称"; //X 轴标题                 
                chartSum.DataSource = BLL.StatisticalBLL.sysStatisticalBook(1, a);
                chartSum.Series[0].XValueMember = "图书名称";
                chartSum.Series[0].YValueMembers = "数量";
                //chartSum.DataBind();
            }
            else if (tbStatistical.Text == "按图书编号")
            {
                chartSum.ChartAreas[0].AxisX.Title = "按图书编号";
                chartSum.DataSource = BLL.StatisticalBLL.sysStatisticalBook(2, a);
                chartSum.Series[0].XValueMember = "图书编号";
                chartSum.Series[0].YValueMembers = "数量";
            }
            else if (tbStatistical.Text == "按图书类别")
            {
                chartSum.ChartAreas[0].AxisX.Title = "按图书类别";
                chartSum.DataSource = BLL.StatisticalBLL.sysStatisticalBook(3, a);
                chartSum.Series[0].XValueMember = "图书类别";
                chartSum.Series[0].YValueMembers = "数量";
                chartSum.Series[0].Palette = ChartColorPalette.SemiTransparent; //柱状图颜色
            }
            else if (tbStatistical.Text == "按图书出版社")
            {
                chartSum.ChartAreas[0].AxisX.Title = "按图书出版社";
                chartSum.DataSource = BLL.StatisticalBLL.sysStatisticalBook(4, a);
                chartSum.Series[0].XValueMember = "图书出版社";
                chartSum.Series[0].YValueMembers = "数量";
            }
            else if (tbStatistical.Text == "按绵职院系别")
            {
                lbNum.Visible = false;
                nudRankNum.Visible = false;
                chartSum.ChartAreas[0].AxisX.Title = "按绵职院系别";
                chartSum.Series[0].ChartType = SeriesChartType.Pie;
                chartSum.DataSource = BLL.StatisticalBLL.sysStatisticalBook(5, 8); //8代表各系
                chartSum.Series[0].XValueMember = "系别";
                chartSum.Series[0].YValueMembers = "数量";
                chartSum.Series[0].Label = "#PERCENT"; //设置百分比
                chartSum.Series[0].LegendText = "#VALX"; //设置图例项文本
                chartSum.Series[0].IsVisibleInLegend = true;//显示图例显示项 也就是表示哪个颜色代表哪类图书
            }
            else if (tbStatistical.Text == "按图书状态")
            {
                lbNum.Visible = false;
                nudRankNum.Visible = false;
                chartSum.ChartAreas[0].AxisX.Title = "按图书状态";
                chartSum.DataSource = BLL.StatisticalBLL.sysStatisticalBook(6, 3); //3代表3种图书状态
                chartSum.Series[0].XValueMember = "图书状态";
                chartSum.Series[0].YValueMembers = "数量";

            }
            else if (tbStatistical.Text == "按读者状态")
            {
                lbNum.Visible = false;
                nudRankNum.Visible = false;
                chartSum.ChartAreas[0].AxisX.Title = "按读者状态";
                chartSum.DataSource = BLL.StatisticalBLL.sysStatisticalBook(7, 3);//3代表3种图书状态
                chartSum.Series[0].XValueMember = "读者状态";
                chartSum.Series[0].YValueMembers = "数量";

            }
            else if (tbStatistical.Text == "借书人数统计")
            {
                lbNum.Text = "年份：";
                chartSum.ChartAreas[0].AxisX.Title = "借书人数统计";
                chartSum.Series[0].ChartType = SeriesChartType.Line; //默认图表类型
                chartSum.DataSource = BLL.StatisticalBLL.sysStatisticalBook(8, a);
                chartSum.Series[0].XValueMember = "月份";
                chartSum.Series[0].YValueMembers = "数量";
            }
            else if (tbStatistical.Text == "购置图书数量统计")
            {
                lbNum.Text = "过去多少年：";
                chartSum.ChartAreas[0].AxisX.Title = "按年统计";
                chartSum.DataSource = BLL.StatisticalBLL.sysStatisticalBook(9, a);
                chartSum.Series[0].XValueMember = "月份";
                chartSum.Series[0].YValueMembers = "数量";
            }
        }

        //单击树 赋值文本
        private void treeViewtStatistical_AfterSelect(object sender, TreeViewEventArgs e)
        {
            nudRankNum.Visible = true;
            lbNum.Visible = true;
            lbNum.Text = "排名位数：";

            this.tbStatistical.Text = this.treeViewtStatistical.SelectedNode.Text;

            if (this.tbStatistical.Text == "按绵职院系别" || this.tbStatistical.Text == "按图书状态" || this.tbStatistical.Text == "按读者状态")
            {
                this.nudRankNum.Visible = false;
                this.lbNum.Visible = false;
            }
            if (this.tbStatistical.Text == "借书人数统计")
            {
                lbNum.Text = "年份：";
                this.nudRankNum.Visible = true;
                this.nudRankNum.Value = 2016;
            }
            if (this.tbStatistical.Text == "购置图书数量统计")
            {
                lbNum.Text = "过去多少年：";
                this.nudRankNum.Value = 5;
            }
        }

        //退出
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //退出
        private void 返回ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
