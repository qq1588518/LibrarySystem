using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class SetUp
    {
        //读者级别
        private int cbReadLevel;
        private int nudReadDateNum;
        private int cbReadMaxLevel;
        private int nudBookNum;

        public int CbReadLevel
        {
            get { return cbReadLevel; }
            set { cbReadLevel = value; }
        }

        public int NudReadDateNum
        {
            get { return nudReadDateNum; }
            set { nudReadDateNum = value; }
        }

        public int CbReadMaxLevel
        {
            get { return cbReadMaxLevel; }
            set { cbReadMaxLevel = value; }
        }

        public int NudBookNum
        {
            get { return nudBookNum; }
            set { nudBookNum = value; }
        }


        //罚款单价
        private decimal tbFineDate;
        private decimal tbFineBook;
        private int tbFineLost;

        public decimal TbFineDate
        {
            get { return tbFineDate; }
            set { tbFineDate = value; }
        }

        public decimal TbFineBook
        {
            get { return tbFineBook; }
            set { tbFineBook = value; }
        }        

        public int TbFineLost
        {
            get { return tbFineLost; }
            set { tbFineLost = value; }
        }
    }
}
