using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class BookIdBLL
    {
        /// <summary>
        /// 图书编号信息方法
        /// </summary>
        /// <param name="i">1代表插入数据 2代表修改数据 3代表删除数据 4确认删除数据哈哈</param>
        /// <param name="bi"></param>
        /// <returns></returns>
        public static string sysBookID(int i, Model.BookId bi)
        {
            string str = "proc_BookIDSave";

            SqlParameter[] Parameter = 
            {
                new SqlParameter("@num",SqlDbType.Int),
                new SqlParameter("@ISBN",SqlDbType.NVarChar),
                new SqlParameter("@BookID",SqlDbType.NVarChar),
                new SqlParameter("@损坏程度",SqlDbType.NVarChar),
                new SqlParameter("@备注",SqlDbType.NVarChar),
                new SqlParameter("@注销日期",SqlDbType.Date),
                new SqlParameter("@backvalue",SqlDbType.NVarChar,150),
            };

            Parameter[0].Value = i;
            Parameter[1].Value = bi.TbISBN;
            Parameter[2].Value = bi.TbBookID;
            Parameter[3].Value = bi.CbDamage;
            Parameter[4].Value = bi.TbBookIdMemo;
            Parameter[5].Value = bi.DtpLogoutDate;
            Parameter[6].Direction = ParameterDirection.Output;

            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStringLocalTransaction, CommandType.StoredProcedure, str, Parameter);

            return Convert.ToString(Parameter[6].Value.ToString());
        }

    }
}
