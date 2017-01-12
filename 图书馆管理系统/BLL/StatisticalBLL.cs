using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DAL;
using System.Data;

namespace BLL
{
    public class StatisticalBLL
    {
        /// <summary>
        /// 统计信息方法
        /// </summary>
        /// <param name="i">
        ///1按图书名称
        ///2按图书编号
        ///3按图书类别
        ///4按图书出版社  
        /// </param>
        /// <param name="rank">排行显示的个数</param>
        /// <returns></returns>
        public static object sysStatisticalBook(int i, int rank)
        {
            //绑定数据
            SqlConnection con = new SqlConnection(SqlHelper.ConnectionStringLocalTransaction);
            con.Open();
            string str = "proc_Statistics";
            SqlCommand com = new SqlCommand(str, con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@num", SqlDbType.Int);
            com.Parameters["@num"].Value = i;
            com.Parameters.Add("@rankingnum", SqlDbType.Int);
            com.Parameters["@rankingnum"].Value = rank;
            con.Close();
            return com;
        }
    }
}
