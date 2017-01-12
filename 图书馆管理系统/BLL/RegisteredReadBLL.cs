using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DAL;
using Model;

namespace BLL
{
    public class RegisteredReadBLL
    {
        /// <summary>
        /// 注册方法
        /// </summary>
        /// <param name="r">实例化对象</param>
        /// <returns></returns>
        public static string sysRegisteredRead(Model.RegisteredRead r)
        {
            string str = "proc_RegisteredReadSave";
            SqlParameter[] Parameter =
            {
                new SqlParameter("@学号工号",SqlDbType.NVarChar),
                new SqlParameter("@姓名",SqlDbType.NVarChar),
                new SqlParameter("@性别",SqlDbType.NVarChar),
                new SqlParameter("@读者级别",SqlDbType.TinyInt),
                new SqlParameter("@系别",SqlDbType.NVarChar),
                new SqlParameter("@班级",SqlDbType.NVarChar),
                new SqlParameter("@联系电话",SqlDbType.NVarChar),
                new SqlParameter("@身份证号",SqlDbType.NVarChar),
                new SqlParameter("@登记日期",SqlDbType.Date),
                new SqlParameter("@密码",SqlDbType.NVarChar),
                new SqlParameter("@备注",SqlDbType.NVarChar),                
                new SqlParameter("@BackValue",SqlDbType.NVarChar,100)//添加一个返回参数,//传出参数必须指定大小
            };

            Parameter[0].Value = r.TbReadId;
            Parameter[1].Value = r.TbName;
            Parameter[2].Value = r.CbSex;
            Parameter[3].Value = r.CbReadLevel;
            Parameter[4].Value = r.CbDepartment;
            Parameter[5].Value = r.TbClass;
            Parameter[6].Value = r.TbPhone;
            Parameter[7].Value = r.TbIDNumber;
            Parameter[8].Value = r.DtpRegistration;
            Parameter[9].Value = r.TbPassWordOK;
            Parameter[10].Value = r.TbMemo;
            Parameter[11].Direction = ParameterDirection.Output;

            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStringLocalTransaction, CommandType.StoredProcedure, str, Parameter);

            //获取返回值 返回出去
            return Convert.ToString(Parameter[11].Value.ToString());
        }

    }
}
