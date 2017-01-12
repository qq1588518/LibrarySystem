using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 缴费模型
    /// </summary>
    public class Payment
    {
        private string tbPaymentReadId;
        private string tbPaymentReadName;
        private string tbPaymentBookId;
        private string tbPaymentBookName;
        private string tbPaymentMemo;
        private string tbPaymentSum;

        private int serialnumber;//借书序号

        public int Serialnumber
        {
            get { return serialnumber; }
            set { serialnumber = value; }
        }

        public string TbPaymentReadId
        {
            get { return tbPaymentReadId; }
            set { tbPaymentReadId = value; }
        }

        public string TbPaymentReadName
        {
            get { return tbPaymentReadName; }
            set { tbPaymentReadName = value; }
        }

        public string TbPaymentBookId
        {
            get { return tbPaymentBookId; }
            set { tbPaymentBookId = value; }
        }

        public string TbPaymentBookName
        {
            get { return tbPaymentBookName; }
            set { tbPaymentBookName = value; }
        }

        public string TbPaymentMemo
        {
            get { return tbPaymentMemo; }
            set { tbPaymentMemo = value; }
        }

        public string TbPaymentSum
        {
            get { return tbPaymentSum; }
            set { tbPaymentSum = value; }
        }
    }
}
