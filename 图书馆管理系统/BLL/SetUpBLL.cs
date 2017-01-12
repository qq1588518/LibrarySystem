using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data.SqlClient;
using System.Data;


namespace BLL
{
    public class SetUpBLL
    {
        /// <summary>
        /// 查询读者级别显示
        /// </summary>
        /// <returns></returns>
        public static object sysSelectReadLevel()
        {
            SqlConnection con = new SqlConnection(SqlHelper.ConnectionStringLocalTransaction);
            con.Open();
            DataSet ds = new DataSet();
            string str = "SELECT * FROM ReadStandard";//存储过程的名称           
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            con.Close();
            da.Fill(ds);
            return ds.Tables[0]; //返回一个表出去
        }


        /// <summary>
        /// 显示各项结果
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static SqlDataReader sysShowRead(int value)
        {
            string str = "select * from ReadStandard where 读者级别=@读者级别	";
            return SqlHelper.ExecuteReader(SqlHelper.ConnectionStringLocalTransaction, CommandType.Text, str, new[]
            {
                new SqlParameter("@读者级别",value)
            });
        }


        /// <summary>
        /// 设置读者级别 
        /// </summary>
        /// <param name="i">1代表修改</param>
        /// <param name="su"></param>
        /// <returns></returns>
        public static string sysSetUp(int i, Model.SetUp su)
        {
            string str = "prco_ReadStandardSave";
            SqlParameter[] Parameter = 
            {
                new SqlParameter("@num",SqlDbType.Int),
                new SqlParameter("@读者级别",SqlDbType.Int),
                new SqlParameter("@可借天数",SqlDbType.Int),
                new SqlParameter("@可借最高级别",SqlDbType.Int),
                new SqlParameter("@可借本数",SqlDbType.Int),
                new SqlParameter("@backvalue",SqlDbType.NVarChar,20)
            };

            Parameter[0].Value = i;
            Parameter[1].Value = su.CbReadLevel;
            Parameter[2].Value = su.NudReadDateNum;
            Parameter[3].Value = su.CbReadMaxLevel;
            Parameter[4].Value = su.NudBookNum;
            Parameter[5].Direction = ParameterDirection.Output;

            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStringLocalTransaction, CommandType.StoredProcedure, str, Parameter);

            return Convert.ToString(Parameter[5].Value.ToString());
        }


        /// <summary>
        /// 设置罚款单价
        /// </summary>
        /// <param name="i">1代表修改</param>
        /// <param name="su"></param>
        /// <returns></returns>
        public static string sysFine(int i, Model.SetUp su)
        {
            string str = "proc_FineStandardSave";
            SqlParameter[] Parameter =
            {
                new SqlParameter("@num",SqlDbType.Int),
                new SqlParameter("@逾期单价",SqlDbType.Decimal),
                new SqlParameter("@损坏单价",SqlDbType.Decimal),
                new SqlParameter("@丢失单价",SqlDbType.TinyInt),
                new SqlParameter("@backvalue",SqlDbType.NVarChar,20)
            };
            Parameter[0].Value = i;
            Parameter[1].Value = su.TbFineDate;
            Parameter[2].Value = su.TbFineBook;
            Parameter[3].Value = su.TbFineLost;
            Parameter[4].Direction = ParameterDirection.Output;

            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStringLocalTransaction, CommandType.StoredProcedure, str, Parameter);

            return Convert.ToString(Parameter[4].Value.ToString());
        }
    }
}
