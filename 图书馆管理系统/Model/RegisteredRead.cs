using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 初始化注册的（RegisteredUser）类
    /// 注册方法（存取数据）
    /// </summary>
    public class RegisteredRead
    {
        private string tbReadId;
        private int cbReadLevel;
        private string tbPassWordOK;
        private string tbName;
        private string cbSex;
        private string cbDepartment;
        private string tbClass;
        private string tbPhone;
        private string tbIDNumber;
        private DateTime dtpRegistration;
        private string tbMemo;

        public string TbMemo
        {
            get { return tbMemo; }
            set { tbMemo = value; }
        }

        public DateTime DtpRegistration
        {
            get { return dtpRegistration; }
            set { dtpRegistration = value; }
        }

        public string TbReadId
        {
            get { return tbReadId; }
            set { tbReadId = value; }
        }

        public int CbReadLevel
        {
            get { return cbReadLevel; }
            set { cbReadLevel = value; }
        }       

        public string TbPassWordOK
        {
            get { return tbPassWordOK; }
            set { tbPassWordOK = value; }
        }       

        public string TbName
        {
            get { return tbName; }
            set { tbName = value; }
        }        

        public string CbSex
        {
            get { return cbSex; }
            set { cbSex = value; }
        }        

        public string CbDepartment
        {
            get { return cbDepartment; }
            set { cbDepartment = value; }
        }        

        public string TbClass
        {
            get { return tbClass; }
            set { tbClass = value; }
        }        

        public string TbPhone
        {
            get { return tbPhone; }
            set { tbPhone = value; }
        }        

        public string TbIDNumber
        {
            get { return tbIDNumber; }
            set { tbIDNumber = value; }
        }
    }
}
