using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 初始化登录用户名,密码的（Login）类
    /// 登录方法（存取数据）
    /// </summary>
    public class Login
    {
        private string username;
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
    }
}
