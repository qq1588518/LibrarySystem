using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 图书入库（BookID）类
    /// 图书入库方法（存取数据）
    /// </summary>
    public class BookId
    {
        private string tbBookID;
        private string tbISBN;
        private string cbDamage;
        private string tbBookIdMemo;
        private DateTime dtpLogoutDate;

        public DateTime DtpLogoutDate
        {
            get { return dtpLogoutDate; }
            set { dtpLogoutDate = value; }
        }

        public string TbBookIdMemo
        {
            get { return tbBookIdMemo; }
            set { tbBookIdMemo = value; }
        }

        public string CbDamage
        {
            get { return cbDamage; }
            set { cbDamage = value; }
        }

        public string TbBookID
        {
            get { return tbBookID; }
            set { tbBookID = value; }
        }

        public string TbISBN
        {
            get { return tbISBN; }
            set { tbISBN = value; }
        }

    }
}
