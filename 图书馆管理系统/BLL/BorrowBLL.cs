using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class BorrowBLL
    {
        /// <summary>
        /// 借阅信息方法
        /// </summary>
        /// <param name="i">
        /// 1代表借阅图书错（插入数据）
        /// 2代表续借（修改数据）
        /// </param>
        /// <param name="bi">实例化对象</param>
        /// <returns></returns>
        public static string sysBorrow(int i, Model.BorrowInfo bi)
        {
            string str = "proc_BorrowInfoSave";
            SqlParameter[] Parameter =
            {
                new SqlParameter("@num",SqlDbType.Int),
                new SqlParameter("@学号",SqlDbType.NVarChar),
                new SqlParameter("@BookID",SqlDbType.NVarChar),
                new SqlParameter("@backvalue",SqlDbType.NVarChar,30),
            };
            Parameter[0].Value = i;
            Parameter[1].Value = bi.TbBorrowReadId;
            Parameter[2].Value = bi.TbBorrowBookId;
            Parameter[3].Direction = ParameterDirection.Output;

            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStringLocalTransaction, CommandType.StoredProcedure, str, Parameter);

            return Convert.ToString(Parameter[3].Value.ToString());
        }
    }
}
