using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DAL;
using Model;
using System.Data;


namespace BLL
{
    public class BookInfoBLL
    {
        /// <summary>
        /// 查询类别显示
        /// </summary>
        /// <returns></returns>
        public static object sysSelectSort()
        {
            SqlConnection con = new SqlConnection(SqlHelper.ConnectionStringLocalTransaction);
            con.Open();
            DataSet ds = new DataSet();
            string str = "SelectSort";//存储过程的名称 （查询类别编号）
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            da.Fill(ds);
            return ds.Tables[0]; //返回一个表出去

            //第一个[]表示显示的行,第二个[]表示显示的列或者直接像第二个一样写数据库里面的字段名
            //tbBookName.Text = ds.Tables[0].Rows[0][0].ToString(); 
            //tbBookMark.Text = ds.Tables[0].Rows[1]["类别编号"].ToString();
        }


        /// <summary>
        /// 图书信息方法
        /// </summary>
        /// <param name="i">1代表插入数据 2代表修改数据 3代表删除数据</param>
        /// <param name="a">实例化对象</param>
        /// <returns></returns>
        public static string sysBookInfo(int i, Model.BookInfo a)
        {
            string str = "proc_BookInfoSave";
            SqlParameter[] Parameter =
            {
                new SqlParameter("@num",SqlDbType.Int),
                new SqlParameter("@类别编号",SqlDbType.NVarChar),
                new SqlParameter("@图书名称",SqlDbType.NVarChar),
                new SqlParameter("@ISBN",SqlDbType.NVarChar),
                new SqlParameter("@图书作者",SqlDbType.NVarChar),
                new SqlParameter("@出版社",SqlDbType.NVarChar),
                new SqlParameter("@价格",SqlDbType.Decimal),
                new SqlParameter("@页数",SqlDbType.Int),
                new SqlParameter("@出版日期",SqlDbType.DateTime),
                new SqlParameter("@图书等级编号",SqlDbType.TinyInt),
                new SqlParameter("@图书简介",SqlDbType.NVarChar),
                new SqlParameter("@入库日期",SqlDbType.DateTime),
                new SqlParameter("@入库数量",SqlDbType.Int),
                new SqlParameter("@在馆数量",SqlDbType.Int),
                new SqlParameter("@BackValue",SqlDbType.NVarChar,50),
            };
            Parameter[0].Value = i;
            Parameter[1].Value = a.CbSortId;
            Parameter[2].Value = a.TbBookName;
            Parameter[3].Value = a.TbBookISBN;
            Parameter[4].Value = a.TbBookAuthor;
            Parameter[5].Value = a.TbBookPress;
            Parameter[6].Value = a.TbBookPrice;
            Parameter[7].Value = a.TbBookPage;
            Parameter[8].Value = a.DtpPDate;
            Parameter[9].Value = a.CbBookGrade;
            Parameter[10].Value = a.TbBookMark;
            Parameter[11].Value = a.DtpPutDate;
            Parameter[12].Value = a.TbRQuantity;
            Parameter[13].Value = a.TbSQuantity;
            Parameter[14].Direction = ParameterDirection.Output;

            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStringLocalTransaction, CommandType.StoredProcedure, str, Parameter);

            return Convert.ToString(Parameter[14].Value.ToString());

        }


        /// <summary>
        /// 显示图书信息 分页显示
        /// </summary>
        /// <param name="p">
        /// 1代表图书信息的分页 
        /// 2代表图书编号的分页 
        /// 3代表读者信息的分页 
        /// 4代表显示读者借阅信息视图
        /// 6代表显示读者信息视图
        /// 7代表显示图书编号信息视图
        /// 8代表显示ISBN信息视图
        /// </param>
        /// <param name="numpage">代表页码</param>
        /// <returns></returns>
        public static object sysPaging(int p, int numpage)
        {
            string str = "Paging";
            SqlConnection con = new SqlConnection(SqlHelper.ConnectionStringLocalTransaction);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@num", SqlDbType.Int);
            cmd.Parameters.Add("@a", SqlDbType.Int);
            cmd.Parameters["@num"].Value = numpage;
            cmd.Parameters["@a"].Value = p;
            da.SelectCommand = cmd;
            con.Close();
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }


        /// <summary>
        /// 删除ISBN图书
        /// </summary>
        /// <param name="i"></param>
        /// <param name="?"></param>
        /// <returns></returns>
        public static string sysDelete(int i,string s)
        {
            string str = "proc_DelectSave";
            SqlParameter[] Parameter =
            {
                new SqlParameter("@num",SqlDbType.Int),
                new SqlParameter("@var",SqlDbType.NVarChar),
                new SqlParameter("@backvalue",SqlDbType.NVarChar,50),
            };
            Parameter[0].Value = i;
            Parameter[1].Value = s;
            Parameter[2].Direction = ParameterDirection.Output;

            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStringLocalTransaction, CommandType.StoredProcedure, str, Parameter);

            return Convert.ToString(Parameter[2].Value.ToString());

        }
    }
}
