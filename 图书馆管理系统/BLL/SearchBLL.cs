using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DAL;
using System.Data;



namespace BLL
{
    public class SearchBLL
    {
        /// <summary>
        /// 搜索
        /// </summary>
        /// <param name="i">1代表图书搜索，2代表读者搜索，3代表借阅搜索</param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static object sysSearchBook(int i, string value)
        {
            string str = "proc_SearchtBookSave";
            SqlConnection con = new SqlConnection(SqlHelper.ConnectionStringLocalTransaction);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@num", SqlDbType.Int);
            cmd.Parameters.Add("@Variable", SqlDbType.NVarChar, 50);
            cmd.Parameters["@num"].Value = i;
            cmd.Parameters["@Variable"].Value = value;
            da.SelectCommand = cmd;
            con.Close();
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
    }
}
