using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DAL;
using System.Data;

namespace BLL
{
    public class SortBLL
    {
        /// <summary>
        /// 添加类别
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int sysAddSort(Model.Sort s)
        {
            string str = "AddSort";
            SqlParameter[] Parameter =
            {
                new SqlParameter("@SortId",SqlDbType.NVarChar),
                new SqlParameter("@SortMemo",SqlDbType.NVarChar),
                new SqlParameter("@retrun",SqlDbType.NVarChar,10)// 数据类型长度一定要写
            };

            Parameter[0].Value = s.TbSortId;
            Parameter[1].Value = s.TbSortMemo;
            Parameter[2].Direction = ParameterDirection.ReturnValue;

            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStringLocalTransaction, CommandType.StoredProcedure, str, Parameter);
            //取返回值 1代表该类别号已经存在 2代表类别说明已存在 3代表添加类别号成功
            return Convert.ToInt32(Parameter[2].Value.ToString());
        }

        /// <summary>
        /// 删除类别
        /// </summary>
        /// <param name="s">获取的类别ID</param>
        /// <param name="m">获取的类别说明</param>
        /// <returns></returns>
        public static String sysDeleSort(string s) //传入一个参数 因为删除操作只需要id就可以了
        {
            string str = "DelectSort";
            SqlParameter[] Parameter =
            {
                new SqlParameter("@SortId",SqlDbType.NVarChar),
                new SqlParameter("@backvalue",SqlDbType.NVarChar,10)
            };

            Parameter[0].Value = s;
            Parameter[1].Direction = ParameterDirection.Output;

            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStringLocalTransaction, CommandType.StoredProcedure, str, Parameter);
            //取返回值
            return Convert.ToString(Parameter[1].Value.ToString());
        }


        /// <summary>
        /// 修改类别
        /// </summary>
        /// <param name="s">获取的类别ID</param>
        /// <param name="m">获取的类别说明</param>
        /// <returns></returns>
        public static int sysUpdateSort(string s, string m)
        {
            string str = "UpdateSort";
            SqlParameter[] Parameter =
            {
                new SqlParameter("@SortId",SqlDbType.NVarChar),
                new SqlParameter("@SortMemo",SqlDbType.NVarChar),
                new SqlParameter("@retrun",SqlDbType.NVarChar,10)
            };

            Parameter[0].Value = s;
            Parameter[1].Value = m;
            Parameter[2].Direction = ParameterDirection.ReturnValue;

            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStringLocalTransaction, CommandType.StoredProcedure, str, Parameter);
            //取返回值 2代表已删除
            return Convert.ToInt32(Parameter[2].Value.ToString());
        }

        /// <summary>
        /// 类别说明显示
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static SqlDataReader sysShowSortMemo(string s)
        {
            string str = "ShowSoetMemo";
            return SqlHelper.ExecuteReader(SqlHelper.ConnectionStringLocalTransaction, CommandType.StoredProcedure, str, new[]
            {
                new SqlParameter("@类别编号",s),
            });
        }
    }
}
