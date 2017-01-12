using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Search
    {
        private string tbSearchBookInfo;
        private string tbSearchBookId;
        private string tbSearchReadInfo;
        private string tbSearchBorrow;
        private string tbSearchBack;

        public string TbSearchBack
        {
            get { return tbSearchBack; }
            set { tbSearchBack = value; }
        }

        public string TbSearchBorrow
        {
            get { return tbSearchBorrow; }
            set { tbSearchBorrow = value; }
        }

        public string TbSearchBookId
        {
            get { return tbSearchBookId; }
            set { tbSearchBookId = value; }
        }

        public string TbSearchReadInfo
        {
            get { return tbSearchReadInfo; }
            set { tbSearchReadInfo = value; }
        }

        public string TbSearchBookInfo
        {
            get { return tbSearchBookInfo; }
            set { tbSearchBookInfo = value; }
        }
    }
}
