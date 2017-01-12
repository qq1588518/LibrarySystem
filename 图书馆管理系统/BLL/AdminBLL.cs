using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
    public class AdminBLL
    {
        /// <summary>
        /// 添加管理员方法
        /// </summary>
        /// <param name="i">1代表插入数据</param>
        /// <returns></returns>
        public static string sysAdmin(int i, Model.Admin ai)
        {
            string str = "proc_AdminSave";
            SqlParameter[] Parameter =
            {
                new SqlParameter("@num",SqlDbType.TinyInt),
                new SqlParameter("@学号工号",SqlDbType.NVarChar),
                new SqlParameter("@权限级别",SqlDbType.TinyInt),
                new SqlParameter("@密码",SqlDbType.NVarChar),
                new SqlParameter("@是否停用",SqlDbType.NVarChar),
                new SqlParameter("@BackValue",SqlDbType.NVarChar,20)
            };

            Parameter[0].Value = i;
            Parameter[1].Value = ai.TbAdminID;
            Parameter[2].Value = ai.AdminType;
            Parameter[3].Value = ai.TbAdminPassWordOK;
            Parameter[4].Value = ai.CbDisable;
            Parameter[5].Direction = ParameterDirection.Output;

            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStringLocalTransaction, CommandType.StoredProcedure, str, Parameter);

            return Convert.ToString(Parameter[5].Value.ToString());
        }
    }
}
