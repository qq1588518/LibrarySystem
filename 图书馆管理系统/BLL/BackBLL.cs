using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DAL;
using System.Data;


namespace BLL
{
    public class BackBLL
    {
        /// <summary>
        /// 图书归还方法
        /// </summary>
        /// <param name="i">1代表插入数据</param>
        /// <returns></returns>
        public static string sysBack(int i, Model.Back bc)
        {
            string str = "proc_BackInfoSave";
            SqlParameter[] Parameter =
            {
                new SqlParameter("@num",SqlDbType.Int),
                new SqlParameter("@BookID",SqlDbType.NVarChar),
                new SqlParameter("@是否丢失",SqlDbType.NVarChar),
                new SqlParameter("@损坏程度",SqlDbType.NVarChar),
                new SqlParameter("@backvalue",SqlDbType.NVarChar,300),
            };
            Parameter[0].Value = i;
            Parameter[1].Value = bc.TbBackBookId;
            Parameter[2].Value = bc.CbBackLost;
            Parameter[3].Value = bc.CbBackDamage;
            Parameter[4].Direction = ParameterDirection.Output;

            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStringLocalTransaction, CommandType.StoredProcedure, str, Parameter);

            return Convert.ToString(Parameter[4].Value.ToString());

        }
    }
}