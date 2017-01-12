using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Model;
using DAL;

namespace BLL
{
    public class ReadInfoBLL
    {
        /// <summary>
        /// 读者信息方法
        /// </summary>
        /// <param name="i">1代表插入数据 2代表更新数据,3代表删除数据</param>
        /// <param name="r">实例化对象</param>
        /// <returns></returns>
        public static string sysReadInfo(int i, Model.ReadInfo r)
        {
            string str = "proc_ReadInfoSave";

            SqlParameter[] Parameter =
            {
                new SqlParameter("@num",SqlDbType.Int),
                new SqlParameter("@学号",SqlDbType.NVarChar),
                new SqlParameter("@姓名",SqlDbType.NVarChar),
                new SqlParameter("@性别",SqlDbType.NVarChar),
                new SqlParameter("@读者级别",SqlDbType.NVarChar),
                new SqlParameter("@系别",SqlDbType.NVarChar),
                new SqlParameter("@班级",SqlDbType.NVarChar),
                new SqlParameter("@联系电话",SqlDbType.NVarChar),
                new SqlParameter("@身份证号",SqlDbType.NVarChar),
                new SqlParameter("@登记日期",SqlDbType.Date),
                new SqlParameter("@密码",SqlDbType.NVarChar),
                new SqlParameter("@备注",SqlDbType.NVarChar),                
                new SqlParameter("@BackValue",SqlDbType.NVarChar,50)
            };

            Parameter[0].Value = i;
            Parameter[1].Value = r.TbReadId;
            Parameter[2].Value = r.TbReadName;
            Parameter[3].Value = r.CbbReadSex;
            Parameter[4].Value = r.CbbReadPost;
            Parameter[5].Value = r.CbbReadDepartment;
            Parameter[6].Value = r.TbReadClass;
            Parameter[7].Value = r.TbReadPhone;
            Parameter[8].Value = r.TbReadNumberId;
            Parameter[9].Value = r.DtpReadRegister;
            Parameter[10].Value = r.TbPassWord;
            Parameter[11].Value = r.TbReadMark;
            Parameter[12].Direction = ParameterDirection.Output;

            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStringLocalTransaction, CommandType.StoredProcedure, str, Parameter);

            return Convert.ToString(Parameter[12].Value.ToString());
        }

    }
}
