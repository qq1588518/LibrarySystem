using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 图书信息（BookInfo）类
    /// 图书信息方法（存取数据）
    /// </summary>
    public class BookInfo
    {
        private string cbSortId;
        private string tbSortExplanation;       
        private string tbBookName;
        private string tbBookISBN;
        private string tbBookAuthor;
        private string tbBookPress;
        private string tbBookPrice;
        private DateTime dtpPDate;
        private int cbBookGrade;
        private string tbBookMark;
        private int tbBookPage;
        private DateTime dtpPutDate;
        private int tbSQuantity;
        private int tbRQuantity;

        public int TbRQuantity
        {
            get { return tbRQuantity; }
            set { tbRQuantity = value; }
        }

        public int TbSQuantity
        {
            get { return tbSQuantity; }
            set { tbSQuantity = value; }
        }

        public DateTime DtpPutDate
        {
            get { return dtpPutDate; }
            set { dtpPutDate = value; }
        }

        public int TbBookPage
        {
            get { return tbBookPage; }
            set { tbBookPage = value; }
        }

        public string TbSortExplanation
        {
            get { return tbSortExplanation; }
            set { tbSortExplanation = value; }
        }        

        public string CbSortId
        {
            get { return cbSortId; }
            set { cbSortId = value; }
        }

        public string TbBookName
        {
            get { return tbBookName; }
            set { tbBookName = value; }
        }

        public string TbBookISBN
        {
            get { return tbBookISBN; }
            set { tbBookISBN = value; }
        }

        public string TbBookAuthor
        {
            get { return tbBookAuthor; }
            set { tbBookAuthor = value; }
        }

        public string TbBookPress
        {
            get { return tbBookPress; }
            set { tbBookPress = value; }
        }

        public string TbBookPrice
        {
            get { return tbBookPrice; }
            set { tbBookPrice = value; }
        }

        public DateTime DtpPDate
        {
            get { return dtpPDate; }
            set { dtpPDate = value; }
        }

        public int CbBookGrade
        {
            get { return cbBookGrade; }
            set { cbBookGrade = value; }
        }

        public string TbBookMark
        {
            get { return tbBookMark; }
            set { tbBookMark = value; }
        }
    }


}
