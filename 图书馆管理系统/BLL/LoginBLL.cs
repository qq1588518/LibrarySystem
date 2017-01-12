using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DAL;
using System.Data;
using Model;

namespace BLL
{
    //登录验证
    public class LoginBLL
    {
        public static string sysLogin(Model.Login l) //返回一个String型的数据出去
        {
            string str = "proc_Login";//存储过程名称
            SqlParameter[] Parameter =
            {
                new SqlParameter("@username",SqlDbType.NVarChar),
                new SqlParameter("@password",SqlDbType.NVarChar),
                new SqlParameter("@BackValue",SqlDbType.NVarChar,50)
            };
            Parameter[0].Value = l.Username;
            Parameter[1].Value = l.Password;
            Parameter[2].Direction = ParameterDirection.Output; //获取数据库的返回值

            SqlHelper.ExecuteScalar(SqlHelper.ConnectionStringLocalTransaction, CommandType.StoredProcedure, str, Parameter);
            //获取返回值
            return Convert.ToString(Parameter[2].Value.ToString());
        }
    }
}
