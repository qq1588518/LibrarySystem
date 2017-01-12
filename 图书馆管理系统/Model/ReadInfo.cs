using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 初始化读者信息（ReadInfo）类
    /// 读者信息方法（存取数据）
    /// </summary>
    public class ReadInfo
    {
        private string tbReadId;
        private int cbbReadPost;
        private string tbReadName;
        private string cbbReadSex;
        private string cbbReadDepartment;
        private string tbReadClass;
        private string tbReadPhone;
        private DateTime dtpReadRegister;
        private string tbReadNumberId;
        private string tbReadMark;
        private string tbPassWord;

        public string TbPassWord
        {
            get { return tbPassWord; }
            set { tbPassWord = value; }
        }

        public string TbReadMark
        {
            get { return tbReadMark; }
            set { tbReadMark = value; }
        }

        public string TbReadId
        {
            get { return tbReadId; }
            set { tbReadId = value; }
        }

        public int CbbReadPost
        {
            get { return cbbReadPost; }
            set { cbbReadPost = value; }
        }

        public string TbReadName
        {
            get { return tbReadName; }
            set { tbReadName = value; }
        }

        public string CbbReadSex
        {
            get { return cbbReadSex; }
            set { cbbReadSex = value; }
        }
        
        public string CbbReadDepartment
        {
            get { return cbbReadDepartment; }
            set { cbbReadDepartment = value; }
        }

        public string TbReadClass
        {
            get { return tbReadClass; }
            set { tbReadClass = value; }
        }

        public string TbReadPhone
        {
            get { return tbReadPhone; }
            set { tbReadPhone = value; }
        }

        public string TbReadNumberId
        {
            get { return tbReadNumberId; }
            set { tbReadNumberId = value; }
        }
        
        public DateTime DtpReadRegister
        {
            get { return dtpReadRegister; }
            set { dtpReadRegister = value; }
        }
    }
}
